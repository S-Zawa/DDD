using DDD.Domain.Entities;

namespace DDD.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();

        IReadOnlyList<MeasureEntity> GetData();
    }
}