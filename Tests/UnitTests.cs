﻿using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Pham()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Pham()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Pham()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid_Pham() {
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(0, Program.Subtract("3", "3"));
            Assert.AreEqual(-4, Program.Subtract("1", "5"));
        }

        [Test]
        public void Multiply_Valid_Pham() {
            Assert.AreEqual(6, Program.Multiply("2", "3"));
            Assert.AreEqual(0, Program.Multiply("5", "0"));
            Assert.AreEqual(-8, Program.Multiply("-2", "4"));
        }

        [Test]
        public void Power_Valid_Pham() {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(1, Program.Power("5", "0"));
            Assert.AreEqual(0.25, Program.Power("2", "-2"));
        }
    }
}
