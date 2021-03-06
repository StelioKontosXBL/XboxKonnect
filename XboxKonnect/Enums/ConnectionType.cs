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

namespace SK.XboxKonnect
{
	// TODO Add distinction between wifi/network/bridged connections

	/// <summary>
	/// Enum identifying the console's current network connection type.
	/// </summary>
	public enum ConnectionType
	{
		/// <summary>
		/// No connection.
		/// </summary>
		None = 0,

		/// <summary>
		/// Console is connected on the Local Area Network (wired connection).
		/// </summary>
		LAN = 1,

		/// <summary>
		/// Unused. Console is connected on the local Wireless Area Network (WiFi).
		/// </summary>
		Wireless = 2,

		/// <summary>
		/// Console is connected on a bridged connection to this device.
		/// </summary>
		Bridged = 3,
	}

}
