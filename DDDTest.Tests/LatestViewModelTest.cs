using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void 直近値_シナリオ()
        {
            var vm = new LatestViewModel();
            Assert.AreEqual(vm.MeasureDate, "2020/01/02 12:40:00");
            Assert.AreEqual(vm.MeasureValue, "2.55m/s");
        }
    }
}