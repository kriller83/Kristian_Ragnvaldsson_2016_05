using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Tenta.Models.Tests
{
    [TestClass()]
    public class GetCurrentSpeedTests
    {
        [TestMethod()]
        public void GetSpeedTest()
        {
            Assert.Fail();
        }

        [Test]
        public void GetSpeedPositiveNumber()
        {
            GetCurrentSpeed getCurrentSpeed = new GetCurrentSpeed();
            var expected = getCurrentSpeed.GetSpeed("6000");
            var actual = 100;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSpeedNegativeNumber()
        {
            GetCurrentSpeed getCurrentSpeed = new GetCurrentSpeed();
            var expected = getCurrentSpeed.GetSpeed("-6000");
            var actual = -100;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetSpeedNoInput()
        {
            GetCurrentSpeed getCurrentSpeed = new GetCurrentSpeed();
            var expected = getCurrentSpeed.GetSpeed("0");
            var actual = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}