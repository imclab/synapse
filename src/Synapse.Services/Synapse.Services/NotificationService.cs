// NotificationService.cs
//
// Authors:
//   Christian Hergert <chris@dronelabs.com>
//
// Copyright (C) 2008 Christian Hergert
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

using Gdk;
using Gtk;
using Notifications;

using Synapse.Core;
using Synapse.ServiceStack;

namespace Synapse.Services
{
	public delegate void NotificationPositionFunc (Notification n, out Screen screen, out int x, out int y);
	
	public class NotificationService : IService, IRequiredService
	{
		private NotificationPositionFunc m_DefaultPositionFunc;
		
		public NotificationPositionFunc DefaultPositionFunc {
			get {
				return this.m_DefaultPositionFunc;
			}
			set {
				this.m_DefaultPositionFunc = value;
			}
		}
		
		public void Notify (string summary)
		{
			Notify (summary, String.Empty);
		}
		
		public void Notify (string summary, string body)
		{
			Notify (summary, body, String.Empty);
		}
		
		public void Notify (string summary, string body, string iconName)
		{
			Notify (summary, body, iconName, null);
		}
		
		public void Notify (string summary, string body, string iconName, Widget widget)
		{
			Notify (summary, body, iconName, widget, 0, false, m_DefaultPositionFunc);
		}
		
		public void Notify (string summary,
		                    string body,
		                    string iconName,
		                    Widget widget,
		                    int    timeout,
		                    bool   critical,
		                    NotificationPositionFunc func)
		{
			Notification notif;
			int x, y;
			Screen screen;
			
			if (widget != null)
				notif = new Notification (summary, body, iconName, widget);
			else
				notif = new Notification (summary, body, iconName);
			
			if (func != null) {
				func (notif, out screen, out x, out y);
				notif.SetGeometryHints (screen, x, y);
			}
			
			if (critical)
				notif.Urgency = Urgency.Critical;
			
			if (timeout > 0)
				notif.Timeout = timeout;
			
			notif.Show ();
		}
		
		string IService.ServiceName {
			get { return "NotificationService"; }
		}
	}
}