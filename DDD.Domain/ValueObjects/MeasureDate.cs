namespace DDD.Domain.ValueObjects
{
    public sealed class MeasureDate : ValueObject<MeasureDate>
    {
        public MeasureDate(DateTime value)
        {
            Value = value;
        }

        public static implicit operator MeasureDate(DateTime value)
        {
            return new MeasureDate(value);
        }

        public DateTime Value { get; }
        public string DisplayValue => Value.ToString("yyyy/MM/dd HH:mm:ss");

        protected override bool EqualsCore(MeasureDate other)
        {
            return this.Value == other.Value;
        }
    }
}