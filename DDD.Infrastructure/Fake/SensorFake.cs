using DDD.Domain.Helpers;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Fake
{
    public sealed class SensorFake : ISensorRepository
    {
        private Random _random = new Random();
        public float GetData() => _random.Next(0, 3) + _random.NextDouble().ToSingle();
    }
}
