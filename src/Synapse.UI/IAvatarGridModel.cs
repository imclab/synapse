//
// IAvatarGridModel.cs
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
using Synapse.Core;
using Synapse.Xmpp;

namespace Synapse.UI
{
	public delegate void ItemEventHandler<T> (IAvatarGridModel<T> model, T item);

	public interface IAvatarGridModel<T>
	{
		IEnumerable<T> Items {
			get;
		}

		IEnumerable<string> GetItemGroups(T item);
		
		int GetGroupOrder(string groupName);

		string GetName(T item);
		string GetJID(T item);
		string GetPresence(T item);
		string GetPresenceMessage(T item);		
		object GetImage(T item);

		bool IsVisible(T item);

		bool ModelUpdating { 
			get; 
		}
			
		event ItemEventHandler<T> ItemAdded;
		event ItemEventHandler<T> ItemRemoved;
		event ItemEventHandler<T> ItemChanged;
		event EventHandler ItemsChanged;
		event EventHandler Refreshed;
	}
}
