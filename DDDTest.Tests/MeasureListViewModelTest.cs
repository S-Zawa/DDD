using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    public class MeasureListViewModelTest
    {
        [TestMethod]
        public void 計測リスト_シナリオ()
        {
            var viewModel = new MeasureListViewModel();
            Assert.AreEqual(viewModel.Measures.Count, 2);
            Assert.AreEqual(viewModel.Measures[0].MeasureDate, "2020/01/02 12:40:00");
            Assert.AreEqual(viewModel.Measures[0].MeasureValue, "2.55m/s");
            Assert.AreEqual(viewModel.Measures[1].MeasureDate, "2020/01/01 12:30:00");
            Assert.AreEqual(viewModel.Measures[1].MeasureValue, "2.45m/s");
        }
    }
}