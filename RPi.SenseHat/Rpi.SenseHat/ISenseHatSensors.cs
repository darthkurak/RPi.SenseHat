////////////////////////////////////////////////////////////////////////////
//
//  This file is part of Rpi.SenseHat
//
//  Copyright (c) 2015, Mattias Larsson
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy of 
//  this software and associated documentation files (the "Software"), to deal in 
//  the Software without restriction, including without limitation the rights to use, 
//  copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
//  Software, and to permit persons to whom the Software is furnished to do so, 
//  subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all 
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//  INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
//  PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
//  HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
//  OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
//  SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using RichardsTech.Sensors;

namespace Emmellsoft.IoT.Rpi.SenseHat
{
	/// <summary>
	/// Interface to the Sense HAT sensors.
	/// </summary>
	public interface ISenseHatSensors
	{
		/// <summary>
		/// The current reading of the gyro (in radians/sec).
		/// </summary>
		Vector3? Gyro
		{ get; }

		/// <summary>
		/// The current reading of the acceleration (in g).
		/// </summary>
		Vector3? Acceleration
		{ get; }

		/// <summary>
		/// The current reading of the magnetic field (in �T).
		/// </summary>
		Vector3? MagneticField
		{ get; }

		/// <summary>
		/// The current reading of the [atmospheric] pressure (in hPa).
		/// </summary>
		double? Pressure
		{ get; }

		/// <summary>
		/// The current reading of the temperature (in �C).
		/// </summary>
		double? Temperature
		{ get; }

		/// <summary>
		/// The current reading of the relative humidity (in %RH).
		/// </summary>
		double? Humidity
		{ get; }

		/// <summary>
		/// The IMU sensor (measures Gyro, Acceleration and MagneticField).
		/// </summary>
		ImuSensor ImuSensor
		{ get; }

		/// <summary>
		/// The Pressure sensor (measures Pressure).
		/// </summary>
		PressureSensor PressureSensor
		{ get; }

		/// <summary>
		/// The Humidity sensor (measures Temperature and Humidity).
		/// </summary>
		HumiditySensor HumiditySensor
		{ get; }
	}
}