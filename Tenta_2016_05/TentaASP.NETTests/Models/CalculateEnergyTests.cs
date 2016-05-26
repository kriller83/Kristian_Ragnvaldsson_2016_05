using Microsoft.VisualStudio.TestTools.UnitTesting;
using TentaASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TentaASP.NET.Models.Tests
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
        public void CalculateEnergy_RightValue()
        {
            //Arange
            CalculateEnergy calculateEnergy = new CalculateEnergy();
            //Act
            var expected = calculateEnergy.CalculateMass("5");
            var actual = 4.493775893684088e+17;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateEnergy_NegativeValue()
        {
            //Arrange
            CalculateEnergy calculateEnergy = new CalculateEnergy();
            //Act
            var expected = calculateEnergy.CalculateMass("-5");
            var actual = -4.493775893684088e+17;
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void CalculateEnergy_UsingStringValue()
        {
            //Arrange
            CalculateEnergy calculateEnergy = new CalculateEnergy();
            //Act
            var expected = calculateEnergy.CalculateMass("5g");
            var actual = 4.493775893684088e+17;
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}