using DDD.Domain.Entities;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Fake
{
    internal class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            return (new MeasureEntity("guidA", new DateTime(2017, 1, 1, 13, 0, 0), 1.23456f));
        }
    }
}