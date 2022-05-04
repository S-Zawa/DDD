using Dapper;
using DDD.Domain.ValueObjects;
using System.Data;

namespace DDD.Infrastructure.Fake
{
    internal abstract class SqliteTypeHandler<T> : SqlMapper.TypeHandler<T>
    {
        // Parameters are converted by Microsoft.Data.Sqlite
        public override void SetValue(IDbDataParameter parameter, T value)
            => parameter.Value = value;
    }

    internal class DateTimeHandler : SqliteTypeHandler<DateTime>
    {
        public override DateTime Parse(object value)
        {
            return DateTime.Parse((string)value);
        }
    }

    internal class MeasureValueObjectHandler : SqliteTypeHandler<MeasureValue>
    {
        public override void SetValue(IDbDataParameter parameter, MeasureValue value)
        {
            parameter.DbType = DbType.Double;
            parameter.Value = value.Value;
        }

        public override MeasureValue Parse(object value)
        {
            return new MeasureValue((float)value);
        }
    }

    public class MeasureDateTypeHandler : SqlMapper.TypeHandler<MeasureDate>
    {
        public override void SetValue(IDbDataParameter parameter, MeasureDate value)
        {
            parameter.DbType = DbType.DateTime;
            parameter.Value = value.Value;
        }

        public override MeasureDate Parse(object value)
        {
            return new MeasureDate((DateTime)value);
        }
    }

    internal class DateTimeOffsetHandler : SqliteTypeHandler<DateTimeOffset>
    {
        public override DateTimeOffset Parse(object value)
            => DateTimeOffset.Parse((string)value);
    }

    internal class GuidHandler : SqliteTypeHandler<Guid>
    {
        public override Guid Parse(object value)
            => Guid.Parse((string)value);
    }

    internal class TimeSpanHandler : SqliteTypeHandler<TimeSpan>
    {
        public override TimeSpan Parse(object value)
            => TimeSpan.Parse((string)value);
    }
}