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

using System;

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToSpecificEntropy
{
    /// <summary>
    /// A number to SpecificEntropy Extensions
    /// </summary>
    public static class NumberToSpecificEntropyExtensions
    {
        /// <inheritdoc cref="SpecificEntropy.FromBtusPerPoundFahrenheit(UnitsNet.QuantityValue)" />
        public static SpecificEntropy BtusPerPoundFahrenheit<T>(this T value) =>
            SpecificEntropy.FromBtusPerPoundFahrenheit(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy CaloriesPerGramKelvin<T>(this T value) =>
            SpecificEntropy.FromCaloriesPerGramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramDegreeCelsius<T>(this T value) =>
            SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramKelvin<T>(this T value) =>
            SpecificEntropy.FromJoulesPerKilogramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilocaloriesPerGramKelvin<T>(this T value) =>
            SpecificEntropy.FromKilocaloriesPerGramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramDegreeCelsius<T>(this T value) =>
            SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramKelvin<T>(this T value) =>
            SpecificEntropy.FromKilojoulesPerKilogramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramDegreeCelsius<T>(this T value) =>
            SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramKelvin<T>(this T value) =>
            SpecificEntropy.FromMegajoulesPerKilogramKelvin(Convert.ToDouble(value));

    }
}
