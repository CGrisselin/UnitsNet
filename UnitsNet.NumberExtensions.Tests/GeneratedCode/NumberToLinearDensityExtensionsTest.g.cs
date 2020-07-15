﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.NumberExtensions.NumberToLinearDensity;
using Xunit;

namespace UnitsNet.Tests
{    
    public class NumberToLinearDensityExtensionsTests
    {
        [Fact]
        public void NumberToGramsPerCentimeterTest() =>
            Assert.Equal(LinearDensity.FromGramsPerCentimeter(2), 2.GramsPerCentimeter());

        [Fact]
        public void NumberToGramsPerMeterTest() =>
            Assert.Equal(LinearDensity.FromGramsPerMeter(2), 2.GramsPerMeter());

        [Fact]
        public void NumberToGramsPerMillimeterTest() =>
            Assert.Equal(LinearDensity.FromGramsPerMillimeter(2), 2.GramsPerMillimeter());

        [Fact]
        public void NumberToKilogramsPerCentimeterTest() =>
            Assert.Equal(LinearDensity.FromKilogramsPerCentimeter(2), 2.KilogramsPerCentimeter());

        [Fact]
        public void NumberToKilogramsPerMeterTest() =>
            Assert.Equal(LinearDensity.FromKilogramsPerMeter(2), 2.KilogramsPerMeter());

        [Fact]
        public void NumberToKilogramsPerMillimeterTest() =>
            Assert.Equal(LinearDensity.FromKilogramsPerMillimeter(2), 2.KilogramsPerMillimeter());

        [Fact]
        public void NumberToMicrogramsPerCentimeterTest() =>
            Assert.Equal(LinearDensity.FromMicrogramsPerCentimeter(2), 2.MicrogramsPerCentimeter());

        [Fact]
        public void NumberToMicrogramsPerMeterTest() =>
            Assert.Equal(LinearDensity.FromMicrogramsPerMeter(2), 2.MicrogramsPerMeter());

        [Fact]
        public void NumberToMicrogramsPerMillimeterTest() =>
            Assert.Equal(LinearDensity.FromMicrogramsPerMillimeter(2), 2.MicrogramsPerMillimeter());

        [Fact]
        public void NumberToMilligramsPerCentimeterTest() =>
            Assert.Equal(LinearDensity.FromMilligramsPerCentimeter(2), 2.MilligramsPerCentimeter());

        [Fact]
        public void NumberToMilligramsPerMeterTest() =>
            Assert.Equal(LinearDensity.FromMilligramsPerMeter(2), 2.MilligramsPerMeter());

        [Fact]
        public void NumberToMilligramsPerMillimeterTest() =>
            Assert.Equal(LinearDensity.FromMilligramsPerMillimeter(2), 2.MilligramsPerMillimeter());

        [Fact]
        public void NumberToPoundsPerFootTest() =>
            Assert.Equal(LinearDensity.FromPoundsPerFoot(2), 2.PoundsPerFoot());

        [Fact]
        public void NumberToPoundsPerInchTest() =>
            Assert.Equal(LinearDensity.FromPoundsPerInch(2), 2.PoundsPerInch());

    }
}
