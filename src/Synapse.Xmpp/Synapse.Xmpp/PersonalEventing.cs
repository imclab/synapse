//
// PersonalEventing.cs: Implements XEP-0163: Personal Eventing via Pubsub
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
using System.Collections.Generic;
using System.Linq;
using jabber;
using jabber.protocol;
using jabber.protocol.iq;
using jabber.protocol.client;
using System.Xml;

namespace Synapse.Xmpp
{
	public delegate void PubsubHandler (JID from, string node, XmlNode items);
	
	public class PersonalEventing : IDiscoverable
	{
		Account m_Account;
		Dictionary<string, PubsubHandler> m_Handlers = new Dictionary<string, PubsubHandler>();
		
		public PersonalEventing(Account account)
		{
			m_Account = account;
			account.Client.OnMessage += OnMessage;
		}
		
		public void RegisterHandler (string node, PubsubHandler handler)
		{
			m_Handlers.Add(node, handler);
		}
		
		private void OnMessage (object sender, Message message)
		{
			if (message.FirstChild.Name == "event" &&
			    message.FirstChild.Attributes["xmlns"].Value == Namespace.PubSubEvent &&
			    message.FirstChild.FirstChild.Name == "items")
			{
				string node = message.FirstChild.FirstChild.Attributes["node"].Value;
				if (m_Handlers.ContainsKey(node)) {
					XmlNode items = message.FirstChild.FirstChild;
					PubsubHandler handler = m_Handlers[node];
					handler(message.From, node, items);
				}
			}
		}
		
		public void Publish (string node, System.Xml.XmlElement items)
		{
			IQ iq = new IQ(m_Account.Client.Document);
			iq.Type = IQType.set;
			PubSub pubsub = new PubSub(m_Account.Client.Document);
			pubsub.SetAttribute("xmlns", "http://jabber.org/protocol/pubsub");
			Publish publish = new Publish(m_Account.Client.Document);
			publish.SetAttribute("node", node);
			publish.AddChild(items);
			pubsub.AddChild(publish);
			iq.AddChild(pubsub);
			m_Account.Send(iq);
		}
		
		public string[] FeatureNames {
			get {
				return new string[0];
			}
		}
	}
}