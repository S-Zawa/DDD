using DDD.Domain.Repositories;

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
            MeasureDate = entity.MeasureDate.ToString("yyyy/MM/dd HH:mm:ss");
            MeasureValue = $"{Math.Round(entity.MeasureValue, 2)}m/s";
        }
    }
}