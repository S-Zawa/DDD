using DDD.Domain.Repositories;
using DDD.Infrastructure;

namespace DDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        public string _measureValue = "--";
        public string _measureDate = "";

        private IMeasureRepository _measureRepository;

        public string MeasureDate
        {
            get
            {
                return _measureDate;
            }
            set
            {
                SetProperty(ref _measureDate, value);
            }
        }

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

        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;

            var entity = _measureRepository.GetLatest();
            MeasureDate = entity.MeasureDate.DisplayValue;
            MeasureValue = entity.MeasureValue.DisplayValue;
        }

        public LatestViewModel() : this(Factories.CreateMeasureRepository())
        {
        }
    }
}