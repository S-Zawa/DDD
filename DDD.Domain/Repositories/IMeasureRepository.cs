using DDD.Domain.Entities;

namespace DDD.Domain.Repositories
{
    public interface IMeasureRepository
    {
        Measure GetLatest();

        IReadOnlyList<Measure> GetData();
    }
}