using DDD.Domain.Repositories;
using DDD.Infrastructure;

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
            var measureValue = _sensorRepository.GetData();
            MeasureValue = measureValue.DisplayValue;
        }

        public MeasureViewModel() : this(Factories.CreateSendorRepository())
        {
        }

        public MeasureViewModel(ISensorRepository sensorRepository)
        {
            _sensorRepository = sensorRepository;
        }
    }
}