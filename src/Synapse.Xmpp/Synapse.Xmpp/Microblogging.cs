//
// Microblogging.cs
//
// Copyright (C) 2008 Eric Butler
//
// Authors:
//   Eric Butler <eric@extremeboredom.net>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using jabber;
using jabber.protocol.iq;
using Synapse.ServiceStack;

namespace Synapse.Xmpp
{	
	public class Microblogging : IDiscoverable
	{
		Account m_Account;
		
		public Microblogging(Account account)
		{
			m_Account = account;
			account.GetFeature<PersonalEventing>().RegisterHandler("urn:xmpp:tmp:microblog", ReceivedMicroblog);
		}
		
		public void Post (string message)
		{
			XmlDocument doc = m_Account.Client.Document;
			
			XmlElement itemElement = doc.CreateElement("item");
			
			XmlElement entryElement = doc.CreateElement("entry");
			entryElement.SetAttribute("xmlns", "http://www.w3.org/2005/Atom");
			itemElement.AppendChild(entryElement);
			
			XmlElement titleElement = doc.CreateElement("title");
			titleElement.InnerText = message;
			entryElement.AppendChild(titleElement);

			XmlElement publishedElement = doc.CreateElement("published");
			publishedElement.InnerText = DateTime.Now.ToString("yyy-MM-ddTHH:mm:sszz");
			entryElement.AppendChild(publishedElement);
			
			m_Account.GetFeature<PersonalEventing>().Publish("urn:xmpp:tmp:microblog", itemElement);
		}
		
		public string[] FeatureNames {
			get {
				return new string[] { "urn:xmpp:tmp:microblog", "urn:xmpp:tmp:microblog+notify" };
			}
		}

		private void ReceivedMicroblog (JID from, string node, PubSubItem item)
		{
			XmlNode entry = item["entry"];
			if (entry["published"] != null && !String.IsNullOrEmpty(entry["published"].InnerText)) {
				var publishedDate = DateTime.Parse(entry["published"].InnerText);
				if ((DateTime.Now - publishedDate).TotalSeconds <= 60) {
					string title = entry["title"].InnerText;
					m_Account.PostActivityFeedItem(from, "shout", null, title);
				}
			}
		}
	}
}
