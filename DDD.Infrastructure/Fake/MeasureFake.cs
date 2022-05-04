using Dapper;
using DapperExtensions;
using DapperQueryBuilder;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Fake
{
    public class MeasureFake : FakeBase, IMeasureRepository
    {
        public void RegistData(IEnumerable<Measure> measures)
        {
            using (var con = DbConnection())
            {
                SqlMapper.AddTypeHandler(new DateTimeHandler());
                SqlMapper.AddTypeHandler(new MeasureDateTypeHandler());
                SqlMapper.AddTypeHandler(new MeasureValueObjectHandler());
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        con.Insert(measures, tran);

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                    }
                }
                con.Close();
            }
        }

        public void DeleteData(IEnumerable<Measure> measures)
        {
            using (var con = DbConnection())
            {
                SqlMapper.AddTypeHandler(new DateTimeHandler());
                SqlMapper.AddTypeHandler(new MeasureDateTypeHandler());
                SqlMapper.AddTypeHandler(new MeasureValueObjectHandler());
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        con.Delete(measures, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                    }
                }
                con.Close();
            }
        }

        public Measure GetLatest()
        {
            using (var cnn = DbConnection())
            {
                cnn.Open();

                SqlMapper.AddTypeHandler(new DateTimeHandler());
                var measure = cnn.QueryFirstOrDefault<Measure>("SELECT * FROM Measure ORDER BY MeasureDate DESC LIMIT 1");
                cnn.Close();
                return measure;
            }
        }

        public IReadOnlyList<Measure> GetData()
        {
            using (var connection = DbConnection())
            {
                connection.Open();
                SqlMapper.AddTypeHandler(new DateTimeHandler());
                var query = connection.FluentQueryBuilder()
                    .Select($"MeasureId")
                    .Select($"MeasureDate")
                    .Select($"MeasureValue")
                    .From($"Measure")
                    .OrderBy($"MeasureDate DESC");

                var measures = query.Query<Measure>();
                connection.Close();

                return (IReadOnlyList<Measure>)measures;
            }
        }
    }
}