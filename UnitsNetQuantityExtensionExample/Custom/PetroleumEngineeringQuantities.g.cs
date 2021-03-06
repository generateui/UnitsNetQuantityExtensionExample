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
using System.Globalization;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;
using System.Collections.Generic;
using UnitsNet;
using UnitsNetQuantityExtensionExample.Custom.Units;
using UnitsNetQuantityExtensionExample.Custom.Quantities;

namespace UnitsNetQuantityExtensionExample.Custom
{
            /// <summary>
            ///     Dynamically parse or construct quantities when types are only known at runtime.
            /// </summary>
    public static partial class PetroleumEngineeringQuantities
    {
        /// <summary>
        /// All QuantityInfo instances mapped by quantity name that are present in UnitsNet by default.
        /// </summary>
        public static readonly IDictionary<string, QuantityInfo> ByName = new Dictionary<string, QuantityInfo>
        {
            { "Depth", Depth.Info },
            { "Jerk", Jerk.Info },
        };

        /// <summary>
        /// Dynamically constructs a quantity of the given <see cref="QuantityInfo"/> with the value in the quantity's base units.
        /// </summary>
        /// <param name="quantityInfo">The <see cref="QuantityInfo"/> of the quantity to create.</param>
        /// <param name="value">The value to construct the quantity with.</param>
        /// <returns>The created quantity.</returns>
        public static IQuantity FromQuantityInfo(QuantityInfo quantityInfo, QuantityValue value)
        {
            switch(quantityInfo.Name)
            {
                case "Depth":
                    return Depth.From(value, Depth.BaseUnit);
                case "Jerk":
                    return Jerk.From(value, Jerk.BaseUnit);
                default:
                    throw new ArgumentException($"{quantityInfo.Name} is not a supported quantity.");
            }
        }

        /// <summary>
        ///     Try to dynamically construct a quantity.
        /// </summary>
        /// <param name="value">Numeric value.</param>
        /// <param name="unit">Unit enum value.</param>
        /// <param name="quantity">The resulting quantity if successful, otherwise <c>default</c>.</param>
        /// <returns><c>True</c> if successful with <paramref name="quantity"/> assigned the value, otherwise <c>false</c>.</returns>
        public static bool TryFrom(QuantityValue value, Enum unit, out IQuantity quantity)
        {
            switch (unit)
            {
                case DepthUnit depthUnit:
                    quantity = Depth.From(value, depthUnit);
                    return true;
                case JerkUnit jerkUnit:
                    quantity = Jerk.From(value, jerkUnit);
                    return true;
                default:
                {
                    quantity = default(IQuantity);
                    return false;
                }
            }
        }

        /// <summary>
        ///     Try to dynamically parse a quantity string representation.
        /// </summary>
        /// <param name="formatProvider">The format provider to use for lookup. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <param name="quantityType">Type of quantity, such as <see cref="Length"/>.</param>
        /// <param name="quantityString">Quantity string representation, such as "1.5 kg". Must be compatible with given quantity type.</param>
        /// <param name="quantity">The resulting quantity if successful, otherwise <c>default</c>.</param>
        /// <returns>The parsed quantity.</returns>
        public static bool TryParse(IFormatProvider formatProvider, Type quantityType, string quantityString, out IQuantity quantity)
        {
            quantity = default(IQuantity);

            var parser = QuantityParser.Default;

            switch(quantityType)
            {
                case Type _ when quantityType == typeof(Depth):
                    return parser.TryParse<Depth, DepthUnit>(quantityString, formatProvider, Depth.From, out quantity);
                case Type _ when quantityType == typeof(Jerk):
                    return parser.TryParse<Jerk, JerkUnit>(quantityString, formatProvider, Jerk.From, out quantity);
                default:
                    return false;
            }
        }
    }
}
