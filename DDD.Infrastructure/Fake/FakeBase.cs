using Microsoft.Data.Sqlite;

namespace DDD.Infrastructure.Fake
{
    public class FakeBase
    {
        public static string DbFile => $"{Environment.CurrentDirectory}\\test.sqlite3";

        public static SqliteConnection DbConnection() => new SqliteConnection($"Data Source={DbFile}");
    }
}