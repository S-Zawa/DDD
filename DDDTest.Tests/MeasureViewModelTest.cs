﻿using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    internal class MeasureViewModelTest
    {
        [TestMethod]
        public void 計測_シナリオ()
        {
            var viewModel = new MeasureViewModel(new SensorMock());
            Assert.AreEqual(viewModel.MeasureValue, "--");
            viewModel.Measure();
            Assert.AreEqual(viewModel.MeasureValue, "1.23m/s");
        }
    }
}