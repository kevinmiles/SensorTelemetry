﻿// Copyright © 2015-2016 Daniel Porrey
//
// This file is part of the Sensor Telemetry solution.
// 
// Sensor Telemetry is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Sensor Telemetry is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Sensor Telemetry. If not, see http://www.gnu.org/licenses/.
//
using System;

namespace Windows.Devices.Sensors.Interfaces
{
	/// <summary>
	/// Defines a structure for a device reading.
	/// </summary>
	public interface IDeviceSensorReading
	{
		/// <summary>
		/// Gets the date and time the reading was taken
		/// from the device.
		/// </summary>
		DateTimeOffset TimestampUtc { get; }		

		/// <summary>
		/// Gets the temperature in Celsius read 
		/// from the device.
		/// </summary>
		float Temperature { get; }

		/// <summary>
		/// Gets a flag that indicates if the temperature reading
		/// is above the critical temperature threshold.
		/// </summary>
		bool IsCritical { get; }

		/// <summary>
		/// Gets a flag that indicates if the temperature reading
		/// is above the upper temperature threshold.
		/// </summary>
		bool IsAboveUpperThreshold { get; }

		/// <summary>
		/// Gets a flag that indicates if the temperature reading
		/// is below the lower temperature threshold.
		/// </summary>
		bool IsBelowLowerThreshold { get; }
	}
}
