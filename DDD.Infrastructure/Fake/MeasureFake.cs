using Dapper;
using DapperQueryBuilder;
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
                cnn.Close();
                return measure;
            }
        }

        public IReadOnlyList<MeasureEntity> GetData()
        {
            using (var connection = DbConnection())
            {
                connection.Open();
                SqlMapper.AddTypeHandler(new DateTimeHandler());

                var sql = $"SELECT * FROM Measure ORDER BY MeasureDate DESC";
                var measures = connection.Query<MeasureEntity>(sql);

                var name = nameof(MeasureEntity.MeasureDate);
                Console.WriteLine(name);
                var query = connection.FluentQueryBuilder()
                    .Select($"MeasureId")
                    .Select($"MeasureDate")
                    .Select($"MeasureValue")
                    .From($"Measure")
                    .OrderBy($"MeasureDate DESC");

                var a = query.Query<MeasureEntity>();
                connection.Close();

                return (IReadOnlyList<MeasureEntity>)measures;
            }
        }
    }
}