using DDD.Domain.Repositories;

namespace DDD.WinForm.ViewModels
{
    public class MeasureViewModel : ViewModelBase
    {
        private string _measureValue = "--";
        private ISensorRepository _sensorRepository;
        public string MeasureValue
        {
            get
            {
                return _measureValue;
            }
            set
            {
                SetProperty(ref _measureValue, value);
            }
        }

        public void Measure()
        {
            var value = _sensorRepository.GetData();
            MeasureValue = Math.Round(value, 2) + " m/s";
        }
    }
}