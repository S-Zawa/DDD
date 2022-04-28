namespace DDD.Domain.Entities
{
    public class MeasureEntity
    {
        public string MeasureId { get; }
        public DateTime MeasureDate { get; }
        public float MeasureValue { get; }

        public MeasureEntity(string measureId, DateTime measureDate, float measureValue)
        {
            MeasureId = measureId;
            MeasureDate = measureDate;
            MeasureValue = measureValue;
        }

    }
}