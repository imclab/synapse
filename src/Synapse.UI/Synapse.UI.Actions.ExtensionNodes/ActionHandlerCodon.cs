//
// ActionHandlerCodon.cs
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
using Synapse.ServiceStack;
using Mono.Addins;

namespace Synapse.UI.Actions.ExtensionNodes
{	
	public class ActionHandlerCodon : TypeExtensionNode
	{
		[NodeAttribute("type", "Full type name of handler")]
		string m_HandlerType;

		public Type HandlerType {
			get {
				return Addin.GetType(m_HandlerType, true);
			}
		}
		
		public override object CreateInstance ()
		{
			return Activator.CreateInstance(HandlerType, null);
		}
	}
}