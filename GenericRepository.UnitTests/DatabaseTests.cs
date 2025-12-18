using Bogus;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.UnitTests;

public abstract class DatabaseTests : IDisposable
{
    private readonly SqliteConnection _connection;

    protected readonly Faker Faker;

    protected DatabaseTests()
    {
        Faker = new Faker();
        _connection = GetNewConnection();
        _connection.Open();
    }

    protected static TestDbContext GetTestDbContext(SqliteConnection connection)
    {
        var context = new TestDbContext(GetOptions(connection));
        context.Database.EnsureCreated();
        return context;
    }

    protected static SqliteConnection GetNewConnection()
    {
        var connection = new SqliteConnection("DataSource=Memory;Mode=Memory;Cache=Shared");
        connection.Open();
        return connection;
    }

    private static DbContextOptions<TestDbContext> GetOptions(SqliteConnection connection) =>
        new DbContextOptionsBuilder<TestDbContext>()
            .UseSqlite(connection)
            .Options;

    public void Dispose()
    {
        _connection.Dispose();
    }
}
