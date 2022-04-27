using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DDDTest.Tests
{
    [TestClass]
    internal class MeasureViewModelTest
    {
        [TestMethod]
        public void 計測_シナリオ()
        {
            var sensorMock = new Mock<ISensorRepository>();

            var viewModel = new MeasureViewModel(sensorMock.Object);

            Assert.AreEqual(viewModel.MeasureValue, "--");

            sensorMock.Setup(x => x.GetData()).Returns(1.23456f);
            viewModel.Measure();
            Assert.AreEqual(viewModel.MeasureValue, "1.23m/s");
        }
    }
}