namespace DDD.WinForm.ViewModels
{
    public class MeasureListViewModelMeasure
    {
        public MeasureListViewModelMeasure(string measureDate, string measureValue)
        {
            MeasureDate = measureDate;
            MeasureValue = measureValue;
        }

        public string MeasureDate { get; }
        public string MeasureValue { get; }
    }
}