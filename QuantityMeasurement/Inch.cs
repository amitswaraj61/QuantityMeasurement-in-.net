//-----------------------------------------------------------------------
// <copyright file="Inch.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace QuantityMeasurement
{
 using System;
using System.Collections.Generic;
using System.Text;

    //// <summary>
    //// Create Inch Class
    //// </summary>
    public class Inch
    {
        //// <summary>
        //// declare global variable for double value
        //// </summary>
        private double value;
        //// <summary>
        //// Create Parameterized Constructor
        //// </summary>
        public Inch(double value)
        {
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
                Inch inch = (Inch)obj;
            return inch.value == this.value;
        }
    }
}
