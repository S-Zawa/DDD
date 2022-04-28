using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace DDDTest.Tests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void 直近値_シナリオ()
        {
            var measureMock = new Mock<IMeasureRepository>();
            var measure = new MeasureEntity("guidA", new DateTime(2017, 1, 1, 13, 0, 0), 1.23456f);
            measureMock.Setup(x => x.GetLatest()).Returns(measure);

            var viewModel = new LatestViewModel(measureMock.Object);

            Assert.AreEqual(viewModel.MeasureDate, "2017/01/01 13:00:00");
            Assert.AreEqual(viewModel.MeasureValue, "1.23m/s");
        }
    }
}