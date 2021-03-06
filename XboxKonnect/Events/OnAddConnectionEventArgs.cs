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
	/// Event args for events triggered when a connection is added to the connections dictionary.
	/// </summary>
	public class OnAddConnectionEventArgs : EventArgs
	{
		/// <summary>
		/// Provides access to an <see cref="Connection"/> instance.
		/// </summary>
		public Connection XboxConnection {
			get;
			private set;
		}

		/// <summary>
		/// Initializes a new instance of <see cref="OnAddConnectionEventArgs"/>.
		/// </summary>
		/// <param name="xboxConnection"></param>
		public OnAddConnectionEventArgs(Connection xboxConnection)
		{
			this.XboxConnection = xboxConnection;
		}
	}

}
