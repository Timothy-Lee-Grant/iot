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
        // Register bit fields. Section and table numbers refer to the BMP390 datasheet (BST-BMP390-DS002);
        // the BMP388 datasheet (BST-BMP388-DS001) defines the same fields.

        // PWR_CTRL (0x1B), section 4.3.17, table 42: bit 0 press_en, bit 1 temp_en, bits 5..4 mode.
        private const byte PressureEnableBit = 0x01;
        private const byte TemperatureEnableBit = 0x02;
        private const int PowerModeShift = 4;
        private const byte PowerModeMask = 0b0011_0000;

        // OSR (0x1C), section 4.3.18, table 43: bits 2..0 osr_p, bits 5..3 osr_t.
        private const int PressureOversamplingShift = 0;
        private const byte PressureOversamplingMask = 0b0000_0111;
        private const int TemperatureOversamplingShift = 3;
        private const byte TemperatureOversamplingMask = 0b0011_1000;

        // ODR (0x1D), section 4.3.19, table 44: bits 4..0 odr_sel.
        private const byte OutputDataRateMask = 0b0001_1111;

        // CONFIG (0x1F), section 4.3.21, table 46: bits 3..1 iir_filter.
        private const int FilterShift = 1;
        private const byte FilterMask = 0b0000_1110;

        // EVENT (0x10), section 4.3.8, table 33: bit 0 por_detected, set after a power-on reset or soft reset.
        private const byte PowerOnResetDetectedBit = 0x01;

        // CMD (0x7E), section 4.3.23, table 48: the soft reset command.
        private const byte SoftResetCommand = 0xB6;

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
