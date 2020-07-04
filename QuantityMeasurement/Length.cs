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
        public enum Unit { FEET ,INCH}
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
        public Length(Unit unit ,double value)
        {
            this.unit = unit;
            this.value = value;
        }
        //// <summary>
        //// override method to compare two objects
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
    }
}
