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
        public enum Unit { FEET ,INCH , YARD}
        /// <summary>
        //// convert value feet to inch declare global
        //// </summary>
        public const double FEET_TO_INCH = 12.0;
        /// <summary>
        //// convert value yard to inch declare global
        //// </summary>
        public const double YARD_TO_INCH = 36.0;
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
        ////  method to compare two objects
        //// </summary>
        public bool compare(Length that)
        {

            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.FEET) || this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.INCH))
            {
                return this.value.CompareTo(that.value) == 0;
            }

            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.INCH))
            {
                return this.value * FEET_TO_INCH.CompareTo(that.value) == 0;
            }
            if (this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.FEET))
            {
                return (this.value / FEET_TO_INCH).CompareTo(that.value) == 0;
            }
            if (this.unit.Equals(Unit.YARD) && that.unit.Equals(Unit.FEET))
            {
                return (this.value * YARD_TO_INCH).CompareTo(that.value*FEET_TO_INCH) == 0;
            }
            if (this.unit.Equals(Unit.YARD) && that.unit.Equals(Unit.INCH))
            {
                return (this.value * YARD_TO_INCH).CompareTo(that.value) == 0;
            }
            if (this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.YARD))
            {
                return (this.value).CompareTo(that.value * YARD_TO_INCH) == 0;
            }
            return false;
        }
    }
}
