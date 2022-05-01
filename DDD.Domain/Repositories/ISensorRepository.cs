using DDD.Domain.ValueObjects;

namespace DDD.Domain.Repositories
{
    public interface ISensorRepository
    {
        MeasureValue GetData();
    }
}