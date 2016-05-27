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
        public void CalculateMass_positiveNumber()
        {
            CalculateEnergy calculateEnergy = new CalculateEnergy();
            var expected = calculateEnergy.CalculateMass("5");
            var actual = 4354545;
            Assert.AreEqual(expected, actual);
        }
    }
}