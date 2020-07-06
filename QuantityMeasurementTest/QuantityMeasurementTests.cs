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
        //// create instance of Length Class
        //// </summary>
        Length length = new Length();

        //// <summary>
        //// Test case = 1.1 Given 0 feet and 0 feet should return equal
        //// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET, 0.0);
            Assert.AreEqual(feet1, feet2);
        }

        //// <summary>
        //// Test case = 1.2 Given 0 feet and 1 feet should return not equal
        //// </summary>
        [Test]
        public void Given0FeetAnd1Feet_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        //// <summary>
        //// Test case = 1.3 Given 0 inch and 0 inch should return  equal
        //// </summary>
        [Test]
        public void Given0InchAnd0Inch_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            Length inch2 = new Length(Length.Unit.INCH, 0.0);
            Assert.AreEqual(inch1, inch2);
        }

        //// <summary>
        //// Test case = 1.4 Given 0 inch and 1 inch should return  equal
        //// </summary>
        [Test]
        public void Given0InchAnd1Inch_ShouldReturnNotEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            Length inch2 = new Length(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        //// <summary>
        //// Test case = 1.5 Given 1 feet and null should return not equal
        //// </summary>
        [Test]
        public void Given1FeetAndNull_WhenOneNull_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length feet2 = null;
            bool isEqual = feet1.Equals(feet2);
            Assert.IsFalse(isEqual);
        }

        //// <summary>
        //// Test case = 1.6 Given null and 1 feet should return not equal
        //// </summary>
        [Test]
        public void Givennulland1Feet_WhenOneNull_ShouldReturnNotEqual()
        {
            Length feet1 = null;
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            bool isEqual = feet2.Equals(feet1);
            Assert.IsFalse(isEqual);
        }

        //// <summary>
        //// Test case = 1.7 Given 1 inch and null should return not equal
        //// </summary>
        [Test]
        public void Given1InchAndNull_WhenOneNull_ShouldReturnNotEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Length inch2 = null;
            bool isEqual = inch1.Equals(inch2);
            Assert.IsFalse(isEqual);
        }

        //// <summary>
        //// Test case = 1.8 Given null inch and 1 inch should return not equal
        //// </summary>
        [Test]
        public void GivenNullInchAnd1inch_WhenOneNull_ShouldReturnNotEqual()
        {
            Length inch1 = null;
            Length inch2 = new Length(Length.Unit.INCH, 1.0);
            bool isEqual = inch2.Equals(inch1);
            Assert.IsFalse(isEqual);
        }

        //// <summary>
        //// Test case = 1.9 Given 1 Feet and reference of feet should return  equal
        //// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSameReference_ShouldReturnTrue()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length feet2 = feet1;
            bool isEqual = feet1.Equals(feet2);
            Assert.IsTrue(isEqual);
        }

        //// <summary>
        //// Test case = 1.10 Given 1 Feet and 1 with same type should return true
        //// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSameType_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            Type type1 = feet1.GetType();
            Type type2 = feet2.GetType();
            Assert.AreEqual(type1, type2);
        }

        //// <summary>
        //// Test case = 1.11 Given 2 Feet and 2 Feet with same type should return true
        //// </summary>
        [Test]
        public void Given2FeetAnd2Feet_WhenEquals_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 2.0);
            Length feet2 = new Length(Length.Unit.FEET, 2.0);
            Assert.AreEqual(feet1, feet2);
        }

        //// <summary>
        //// Test case = 1.12 Given 1 Feet and 1 inch when equals should return not equals
        //// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenEquals_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(feet1, inch1);
        }

        //// <summary>
        //// Test case = 1.13 Given 0 Feet and  inch when compares should return  equals length
        //// </summary>
        [Test]
        public void Given0FeetAnd0Inch_ShouldReturnTrue()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            bool compareCheck = length.Compare(feet1, inch1);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 1.13 Given 1 Feet and   when compares should return  equals length
        //// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenCompared_ShouldReturnTrue()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            bool compareCheck = length.Compare(feet1, feet2);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 1.14 Given 1 inch and inch  when compares should return  equals length
        //// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenCompared_ShouldReturnTrue()
        {
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Length inch2 = new Length(Length.Unit.INCH, 1.0);
            bool compareCheck = length.Compare(inch1, inch2);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 1.15 Given 1 inch and 2inch  when compares should return  not equals length
        //// </summary>
        [Test]
        public void Given1InchAnd2Inch_WhenCompared_ShouldReturnFalse()
        {
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Length inch2 = new Length(Length.Unit.INCH, 2.0);
            bool compareCheck = length.Compare(inch1, inch2);
            Assert.IsFalse(compareCheck);
        }

        //// <summary>
        //// Test case = 1.16 Given 1 inch and 12inch  when compares should return  equals length
        //// </summary
        [Test]
        public void Given1FeetAnd12Inch_WhenCompared_ShouldReturnEqualLength()
        {
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length inch = new Length(Length.Unit.INCH, 12.0);
            bool compareCheck = length.Compare(feet, inch);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 1.17 Given 12 inch and 12Feet when compares should return  equals length
        //// </summary
        [Test]
        public void Given12InchAnd1Feet_WhenCompared_ShouldReturnEqualLength()
        {
            Length inch = new Length(Length.Unit.INCH, 12.0);
            Length feet = new Length(Length.Unit.FEET, 1.0);
            bool compareCheck = length.Compare(inch, feet);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 2.1 Given 1 yard and Feet when compares should return  equals length
        //// </summary
        [Test]
        public void Given1YardAnd3Feet_WhenCompared_ShouldReturnEqualLength()
        {
            Length yard = new Length(Length.Unit.YARD, 1.0);
            Length feet = new Length(Length.Unit.FEET, 3.0);
            bool compareCheck = length.Compare(yard,feet);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 2.2 Given 1 yard and 1 Feet when compares should return  not equals length
        //// </summary
        [Test]
        public void Given1FeetAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length yard = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = length.Compare(feet, yard);
            Assert.IsFalse(compareCheck);
        }

        //// <summary>
        //// Test case = 2.3 Given 1 yard and 36 when compares should return equals length
        //// </summary
        [Test]
        public void Given1YardAnd36Inch_WhenCompared_ShouldReturnEqualLength()
        {
            Length yard = new Length(Length.Unit.YARD, 1.0);
            Length inch = new Length(Length.Unit.INCH, 36.0);
            bool compareCheck = length.Compare(yard, inch);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 2.4 Given 36 inch and 1 yard when compares should return equals length
        //// </summary
        [Test]
        public void Given36InchAnd1yard_WhenCompared_ShouldReturnEqualLength()
        {
            Length inch = new Length(Length.Unit.INCH, 36.0);
            Length yard = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = length.Compare(inch, yard);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 2.5 Given 3 feet and 1 yard when compares should return equals length
        //// </summary
        [Test]
        public void Given3FeetAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            Length yard = new Length(Length.Unit.YARD, 1.0);
            Length feet = new Length(Length.Unit.FEET, 3.0);
            bool compareCheck = length.Compare(yard, feet);
            Assert.IsTrue(compareCheck);
        }
    }
}
