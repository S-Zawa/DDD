using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace DDDTest.Tests.WinForm
{
    [TestClass]
    public class MeasureSaveViewModelTest
    {
        [TestMethod]
        public void 計測登録_シナリオ()
        {
            var viewModelMock = new Mock<MeasureSaveViewModel>();
            viewModelMock.Setup(x => x.GetDateTime()).Returns(new DateTime(2017, 1, 3, 13, 0, 0));
            var viewModel = viewModelMock.Object;

            Assert.AreEqual(viewModel.MeasureDate, new DateTime(2017, 1, 3, 13, 0, 0));
            Assert.AreEqual(viewModel.MeasureValue, "");
            Assert.AreEqual(viewModel.UnitLabel, "m/s");
        }
    }
}