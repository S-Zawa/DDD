namespace DDD.Domain.ValueObjects
{
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        public MeasureValue(double value)
        {
            Value = value;
        }

        public double Value { get; }

        public string DisplayValue => $"{Math.Round(Value, 2)}m/s";

        protected override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}