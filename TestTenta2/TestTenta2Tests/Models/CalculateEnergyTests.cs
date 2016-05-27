using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTenta2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestTenta2.Models.Tests
{
    [TestClass()]
    public class CalculateEnergyTests
    {
        [TestMethod()]
        public void CalculateMassTest()
        {
            Assert.Fail();
        }

        [Test]
        public void Calculate_PositiveValue()
        {
            CalculateEnergy calculateEnergy = new CalculateEnergy();

            var expected = calculateEnergy.CalculateMass("5");
            var actual = 4.493775893684088e+17;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Calculate_NegativeValue()
        {
            CalculateEnergy calculateEnergy = new CalculateEnergy();

            var expected = calculateEnergy.CalculateMass("-5");
            var actual = -4.493775893684088e+17;
        }

        [Test]
        public void CalculateString()
        {
            CalculateEnergy calculateEnergy = new CalculateEnergy();

            var expected = calculateEnergy.CalculateMass("5g");
            var actual = 4.493775893684088e+17;

            Assert.AreEqual(expected, actual);
        }
    }
}