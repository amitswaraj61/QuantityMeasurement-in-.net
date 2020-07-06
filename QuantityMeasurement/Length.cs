//-----------------------------------------------------------------------
// <copyright file="QuantityMeasurement.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------

namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    //// <summary>
    //// Create Feet Class
    //// </summary>
    public class Length
    {
        //// <summary>
        //// Create Enum constants
        //// </summary>
        public enum Unit { FEET, INCH, YARD , CENTIMETER , GALLON , LITRE , MILLIMETER }


        //// <summary>
        //// declare global variable for double value
        //// </summary>
        public double value;

        //// <summary>
        //// declare global variable for double value
        //// </summary>
        public Unit unit;

        //// <summary>
        //// Create Parameterized Constructor
        //// </summary>
        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public Length()
        {

        }

        //// <summary>
        //// Create switch statements for diffrent unit and return value
        //// </summary>
        private double GetUnitConversion(Unit unit)
        {
            switch (unit)
            {
                case Unit.FEET:
                    return 12.0;
                case Unit.INCH:
                    return 1.0;
                case Unit.YARD:
                    return 36.0;
                case Unit.CENTIMETER:
                    return 0.4;
                case Unit.GALLON:
                    return 3780.0;
                case Unit.LITRE:
                    return 1000.0;
                case Unit.MILLIMETER:
                    return 1.0;
            }
            return 0;
        }

        //// <summary>
        //// Create method to compare two diffrent unit and value
        //// </summary>
        public bool Compare(Length firstUnitValue, Length secondUnitValue)
        {
            double baseValue1 = GetUnitConversion(firstUnitValue.unit);
            double baseValue2 = GetUnitConversion(secondUnitValue.unit);
            return CompareUnits(firstUnitValue, secondUnitValue, baseValue1, baseValue2);
        }


        //// <summary>
        //// Create method to compare unit and return results
        //// </summary>
        private bool CompareUnits(Length firstUnitValue, Length secondUnitValue, double baseValue1, double baseValue2)
        {
            return Math.Round(firstUnitValue.value * baseValue1).CompareTo(Math.Round(secondUnitValue.value * baseValue2)) == 0;
        }

        //// <summary>
        //// override method to equals two objects
        //// </summary>
        override
        public bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Length length = (Length)obj;
            return length.value == value && unit == length.unit; ;
        }
        //// <summary>
        //// Overriding GetHashCode Method.
        /// </summary>
        //// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //// <summary>
        //// Method to add two units
        /// </summary>
        public double Add(Length firstUnit, Length secondUnit)
        {
            double baseValue1 = GetUnitConversion(firstUnit.unit);
            double baseValue2 = GetUnitConversion(secondUnit.unit);
            return Math.Round(firstUnit.value * baseValue1) + Math.Round(secondUnit.value * baseValue2);
        }
    }
}
      