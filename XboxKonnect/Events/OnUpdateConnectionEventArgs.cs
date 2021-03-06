﻿/*
 * Console Auto Discovery and Status Scanner
 * 
 * Coded by Stelio Kontos,
 * aka Daniel McClintock
 * 
 * Created: 10/24/2017
 * Updated: 01/20/2020
 * 
 */

using System;

namespace SK.XboxKonnect
{
	/// <summary>
	/// Event args for events triggered when a connection is updated in the connections dictionary
	/// </summary>
	public class OnUpdateConnectionEventArgs : EventArgs
	{
		/// <summary>
		/// Provides access to an <see cref="Connection"/> instance.
		/// </summary>
		public Connection XboxConnection {
			get;
			private set;
		}

		/// <summary>
		/// Initializes a new instance of <see cref="OnUpdateConnectionEventArgs"/>.
		/// </summary>
		/// <param name="xboxConnection"></param>
		public OnUpdateConnectionEventArgs(Connection xboxConnection)
		{
			this.XboxConnection = xboxConnection;
		}
	}

}
