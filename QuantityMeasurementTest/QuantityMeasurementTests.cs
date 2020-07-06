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
            bool compareCheck = length.Compare(yard, feet);
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

        //// <summary>
        //// Test case = 3.1 Given 2 inch and 5 cm when compares should return equals length
        //// </summary
        [Test]
        public void Given2InchAnd5Cm_WhenCompared_ShouldReturnEqualLength()
        {
            Length inch = new Length(Length.Unit.INCH, 2.0);
            Length cm = new Length(Length.Unit.CENTIMETER, 5.0);
            bool compareCheck = length.Compare(inch, cm);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 4.1 Given 2 inch and 2 inch when compares should return 4 inch
        //// </summary
        [Test]
        public void Given2InchAnd2Inch_WhenAddition_ShouldReturn4Inch()
        {
            Length inch1 = new Length(Length.Unit.INCH, 2.0);
            Length inch2 = new Length(Length.Unit.INCH, 2.0);
            double inchAdded = length.Add(inch1, inch2);
            Assert.AreEqual(4.0, inchAdded);
        }

        //// <summary>
        //// Test case = 4.2 Given 1 Feet and 2 inch when Addition should return 14 inch
        //// </summary
        [Test]
        public void Given1FeetAnd2Inch_WhenAddition_ShouldReturn14Inch()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length inch2 = new Length(Length.Unit.INCH, 2.0);
            double addedResult = length.Add(feet1, inch2);
            Assert.AreEqual(14, addedResult);
        }

        //// <summary>
        //// Test case = 4.3 Given 1 Feet and 1 feet when Addition should return 24 inch
        //// </summary
        [Test]
        public void Given1FeetAnd1Feet_WhenAddition_ShouldReturn24Inch()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            double addedResult = length.Add(feet1, feet2);
            Assert.AreEqual(24, addedResult);
        }

        //// <summary>
        //// Test case = 4.4 Given 2 inch and 2.5 cm when Addition should return 3 inch
        //// </summary
        [Test]
        public void Given2InchAnd2nd5Cm_WhenAddition_ShouldReturn3Inch()
        {
            Length inch1 = new Length(Length.Unit.INCH, 2.0);
            Length cm1 = new Length(Length.Unit.CENTIMETER, 2.5);
            double addedResult = length.Add(inch1, cm1);
            Assert.AreEqual(3, addedResult, 0.0);
        }

        //// <summary>
        //// Test case = 5.1 Given 1 Gallon and 3n78 litre when compared should return equal length
        //// </summary
        [Test]
        public void Given1GallonAnd3n78Litres_WhenCompared_ShouldReturnEqualLength()
        {
            Length gallon1 = new Length(Length.Unit.GALLON, 1.0);
            Length litre = new Length(Length.Unit.LITRE, 3.78);
            bool compareCheck = length.Compare(gallon1, litre);
            Assert.IsTrue(compareCheck);
        }
        //// <summary>
        //// Test case = 5.2 Given 1 litre and 1000 ml when compared should return equal length
        //// </summary
        [Test]
        public void Given1LitreAnd1000Ml_WhenCompared_ShouldReturnEqualLength()
        {
            Length litre = new Length(Length.Unit.LITRE, 1.0);
            Length ml = new Length(Length.Unit.MILLIMETER, 1000.0);
            bool compareCheck = length.Compare(litre, ml);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case = 6.1 Given 1 gallon and 3.78 litres when addition should return 8.0 litres
        //// </summary
        [Test]
        public void Given1GallonAnd3n78Litres_WhenAddition_ShouldReturnEqualResult()
        {
            Length gallon = new Length(Length.Unit.GALLON, 1.0);
            Length litre = new Length(Length.Unit.LITRE, 3.78);
            double addedResult = litre.Add(gallon, litre);
            Assert.AreEqual(8.0, addedResult);
        }

        //// <summary>
        //// Test case = 6.2 Given 1 litre and 1000 ml when addition should return 2.0 litres
        //// </summary
        [Test]
        public void Given1LitreAnd1000Ml_WhenAddition_ShouldReturn2Litres()
        {
            Length litre = new Length(Length.Unit.LITRE, 1.0);
            Length ml = new Length(Length.Unit.MILLIMETER, 1000.0);
            double addedResult = litre.Add(litre, ml);
            Assert.AreEqual(2.0, addedResult);
        }
    }
}
