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

using UnitsNet.NumberExtensions.NumberToForce;
using Xunit;

namespace UnitsNet.Tests
{    
    public class NumberToForceExtensionsTests
    {
        [Fact]
        public void NumberToDecanewtonsTest() =>
            Assert.Equal(Force.FromDecanewtons(2), 2.Decanewtons());

        [Fact]
        public void NumberToDyneTest() =>
            Assert.Equal(Force.FromDyne(2), 2.Dyne());

        [Fact]
        public void NumberToKilogramsForceTest() =>
            Assert.Equal(Force.FromKilogramsForce(2), 2.KilogramsForce());

        [Fact]
        public void NumberToKilonewtonsTest() =>
            Assert.Equal(Force.FromKilonewtons(2), 2.Kilonewtons());

        [Fact]
        public void NumberToKiloPondsTest() =>
            Assert.Equal(Force.FromKiloPonds(2), 2.KiloPonds());

        [Fact]
        public void NumberToKilopoundsForceTest() =>
            Assert.Equal(Force.FromKilopoundsForce(2), 2.KilopoundsForce());

        [Fact]
        public void NumberToMeganewtonsTest() =>
            Assert.Equal(Force.FromMeganewtons(2), 2.Meganewtons());

        [Fact]
        public void NumberToMicronewtonsTest() =>
            Assert.Equal(Force.FromMicronewtons(2), 2.Micronewtons());

        [Fact]
        public void NumberToMillinewtonsTest() =>
            Assert.Equal(Force.FromMillinewtons(2), 2.Millinewtons());

        [Fact]
        public void NumberToNewtonsTest() =>
            Assert.Equal(Force.FromNewtons(2), 2.Newtons());

        [Fact]
        public void NumberToOunceForceTest() =>
            Assert.Equal(Force.FromOunceForce(2), 2.OunceForce());

        [Fact]
        public void NumberToPoundalsTest() =>
            Assert.Equal(Force.FromPoundals(2), 2.Poundals());

        [Fact]
        public void NumberToPoundsForceTest() =>
            Assert.Equal(Force.FromPoundsForce(2), 2.PoundsForce());

        [Fact]
        public void NumberToTonnesForceTest() =>
            Assert.Equal(Force.FromTonnesForce(2), 2.TonnesForce());

    }
}
