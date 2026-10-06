// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Device.I2c;

namespace Iot.Device.Bmp3xx
{
    /// <summary>
    /// Base class for the Bosch BMP3xx family of barometric pressure and temperature sensors (BMP390, BMP388).
    /// </summary>
    public abstract class Bmp3xxBase : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bmp3xxBase"/> class.
        /// </summary>
        /// <param name="chipId">The chip ID expected in the CHIP_ID register.</param>
        /// <param name="i2cDevice">The <see cref="I2cDevice"/> used to communicate with the sensor.</param>
        protected Bmp3xxBase(byte chipId, I2cDevice i2cDevice)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the resources used by the sensor.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}
