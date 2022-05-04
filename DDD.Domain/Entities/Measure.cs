using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities
{
    public class Measure
    {
        public string MeasureId { get; }
        public MeasureDate MeasureDate { get; }
        public MeasureValue MeasureValue { get; }

        public Measure(string measureId, DateTime measureDate, double measureValue)
        {
            MeasureId = measureId;
            MeasureDate = new MeasureDate(measureDate);
            MeasureValue = new MeasureValue(measureValue);
        }
    }
}