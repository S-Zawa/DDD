using Dapper;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Fake
{
    public class MeasureFake : FakeBase, IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            using (var cnn = DbConnection())
            {
                cnn.Open();

                SqlMapper.AddTypeHandler(new DateTimeHandler());
                var measure = cnn.QueryFirstOrDefault<MeasureEntity>("SELECT * FROM Measure ORDER BY MeasureDate DESC LIMIT 1");
                return measure;
            }
        }
    }
}