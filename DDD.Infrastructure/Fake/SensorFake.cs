using DDD.Domain.Helpers;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;

namespace DDD.Infrastructure.Fake
{
    public sealed class SensorFake : ISensorRepository
    {
        private Random _random = new Random();

        public MeasureValue GetData()
        {
            return new MeasureValue(_random.Next(0, 3) + _random.NextDouble().ToSingle());
        }
    }
}