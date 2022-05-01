using DDD.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    public class MeasureValueTest
    {
        [TestMethod]
        public void イコールテスト()
        {
            var vo1 = new MeasureValue(1.23456f);
            var vo2 = new MeasureValue(1.23456f);
            Assert.AreEqual(true, vo1.Equals(vo2));
        }

        [TestMethod]
        public void イコールイコールテスト()
        {
            var vo1 = new MeasureValue(1.23456f);
            var vo2 = new MeasureValue(1.23456f);
            Assert.AreEqual(true, vo1 == vo2);
        }
    }
}