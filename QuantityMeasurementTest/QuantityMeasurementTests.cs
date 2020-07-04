//-----------------------------------------------------------------------
// <copyright file="QuantityMeasurementTests.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace Tests
{
using NUnit.Framework;
using QuantityMeasurement;
    
   //// <summary>
    //// Create QuantityMeasurementTestsClass
    //// </summary>
    public class QuantityMeasurementTests
    {
        //// <summary>
        //// Test case = 1.1 Given 0 feet and 0 feet should return equal
        //// </summary>
        [Test]
    public void Given0FeetAnd0Feet_ShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(0.0);
            Assert.AreEqual(feet1, feet2);
        }
        //// <summary>
        //// Test case = 1.2 Given 0 feet and 1 feet should return not equal
        //// </summary>
        [Test]
        public void Given0FeetAnd1Feet_ShouldReturnNotEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(1.0);
            Assert.AreNotEqual(feet1, feet2);
        }
    }
}


