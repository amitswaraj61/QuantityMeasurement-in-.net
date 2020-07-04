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
        //// <summary>
        //// Test case = 1.3 Given 0 inch and 0 inch should return  equal
        //// </summary>
        [Test]
        public void Given0InchAnd0Inch_ShouldReturnEqual()
        {
            Inch inch1 = new Inch(0.0);
            Inch inch2 = new Inch(0.0);
            Assert.AreEqual(inch1,inch2);
        }
        //// <summary>
        //// Test case = 1.4 Given 0 inch and 1 inch should return  equal
        //// </summary>
        [Test]
        public void Given0InchAnd1Inch_ShouldReturnNotEqual()
        {
            Inch inch1 = new Inch(0.0);
            Inch inch2 = new Inch(1.0);
            Assert.AreNotEqual(inch1, inch2);
        }
        //// <summary>
        //// Test case = 1.5 Given 1 feet and null should return not equal
        //// </summary>
        [Test]
        public void Given1FeetAndNull_WhenOneNull_ShouldReturnNotEqual()
        {
            Feet feet1 = new Feet(1.0);
            Feet feet2 = null;
            bool isEqual = feet1.Compare(feet2);
            Assert.IsFalse(isEqual);
        }
    }
}


