using DDD.Domain.Repositories;

namespace DDDTest.Tests
{
    internal sealed class SensorMock : ISensorRepository
    {
        public float GetData()
        {
            return 1.23456f;
        }
    }
}
