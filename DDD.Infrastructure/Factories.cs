using DDD.Domain.Repositories;
using DDD.Infrastructure.Fake;

namespace DDD.Infrastructure
{
    public static class Factories

    {
        public static ISensorRepository CreateSendorRepository()
        {
            return new SensorFake();
        }
        public static IMeasureRepository CreateMeasureRepository()
        {
            return new MeasureFake();
        }
    }
}
