namespace DDD.WinForm.ViewModels
{
    public class MeasureSaveViewModel : ViewModelBase
    {
        private DateTime _measureDate;
        private string _measureValue = "";

        public virtual DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public MeasureSaveViewModel()
        {
            _measureDate = GetDateTime();
        }

        public DateTime MeasureDate
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

        public string UnitLabel => Domain.ValueObjects.MeasureValue.UnitName;
    }
}