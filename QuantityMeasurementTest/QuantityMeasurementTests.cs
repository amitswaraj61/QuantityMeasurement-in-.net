//-----------------------------------------------------------------------
// <copyright file="QuantityMeasurementTests.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace Tests
{
    using NUnit.Framework;
    using QuantityMeasurement;
    using System;

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
            Assert.AreEqual(inch1, inch2);
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
            bool isEqual = feet1.Equals(feet2);
            Assert.IsFalse(isEqual);
        }
        //// <summary>
        //// Test case = 1.6 Given null and 1 feet should return not equal
        //// </summary>
        [Test]
        public void Givennulland1Feet_WhenOneNull_ShouldReturnNotEqual()
        {
            Feet feet1 = null;
            Feet feet2 = new Feet(1.0);
            bool isEqual = feet2.Equals(feet1);
            Assert.IsFalse(isEqual);
        }
        //// <summary>
        //// Test case = 1.7 Given 1 inch and null should return not equal
        //// </summary>
        [Test]
        public void Given1InchAndNull_WhenOneNull_ShouldReturnNotEqual()
        {
            Inch inch1 = new Inch(1.0);
            Inch inch2 = null;
            bool isEqual = inch1.Equals(inch2);
            Assert.IsFalse(isEqual);
        }
        //// <summary>
        //// Test case = 1.8 Given null inch and 1 inch should return not equal
        //// </summary>
        [Test]
        public void GivenNullInchAnd1inch_WhenOneNull_ShouldReturnNotEqual()
        {
            Inch inch1 = null;
            Inch inch2 = new Inch(1.0);
            bool isEqual = inch2.Equals(inch1);
            Assert.IsFalse(isEqual);
        }
        //// <summary>
        //// Test case = 1.9 Given 1 Feet and reference of feet should return  equal
        //// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSameReference_ShouldReturnTrue()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = feet1;
            bool isEqual = feet1.Equals(feet2);
            Assert.IsTrue(isEqual);
        }
        //// <summary>
        //// Test case = 1.10 Given 1 Feet and 1 with same type should return true
        //// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSameType_ShouldReturnEqual()
        {
            Feet feet1 = new Feet(1.0);
            Feet feet2 = new Feet(1.0);
            Type type1 = feet1.GetType();
            Type type2 = feet2.GetType();
            Assert.AreEqual(type1, type2);
        }
    }
}
  