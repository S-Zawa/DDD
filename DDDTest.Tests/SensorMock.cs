using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;

namespace DDDTest.Tests
{
    internal sealed class SensorMock : ISensorRepository
    {
        public MeasureValue GetData()
        {
            return new MeasureValue(1.23456f);
        }
    }
}