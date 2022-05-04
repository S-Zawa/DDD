using DDD.Domain.Entities;
using DDD.Infrastructure.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DDDTest.Tests.Infrastructure
{
    [TestClass]
    public class MeasureFakeTest
    {
        [TestMethod]
        public void GetLatestTest()
        {
            var fake = new MeasureFake();
            var dt1 = DateTime.Now;
            var dt2 = dt1.AddMinutes(-1);
            var measures = new List<Measure>()
            {
                new Measure("3",dt1,3.33),
                new Measure("4",dt2,4.44)
            };
            fake.RegistData(measures);

            var measure = fake.GetLatest();
            Assert.AreEqual(measure.MeasureId, "3");
            Assert.AreEqual(measure.MeasureDate.Value, dt1);
            Assert.AreEqual(measure.MeasureValue.Value, 3.33);

            fake.DeleteData(measures);
        }
    }
}