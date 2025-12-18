using FluentAssertions;
using GenericRepository.UnitTests.TestObjects;
using Microsoft.Data.Sqlite;

namespace GenericRepository.UnitTests.Insert;

public class InsertBasicObjectTests : DatabaseTests
{
    [Fact]
    public async Task GivenABasicObjectToInsert_WhenInsertAsync_ThenReturnsTrue()
    {
        var address = new Address
        {
            Id = 1,
            Address1 = Faker.Address.StreetAddress(),
            Address2 = Faker.Address.SecondaryAddress(),
            City = Faker.Address.City(),
            State = Faker.Address.State(),
            ZipCode = Faker.Address.ZipCode()
        };

        await using var connection = GetNewConnection();
        var sut = new GenericRepository(GetTestDbContext(connection));

        var result = await sut.InsertAsync(address);
        result.Should().BeTrue();
    }

    [Fact]
    public async Task GivenABasicObjectToInsert_WhenInsertAsync_ThenInsertsObject()
    {
        var address = new Address
        {
            Id = 1,
            Address1 = Faker.Address.StreetAddress(),
            Address2 = Faker.Address.SecondaryAddress(),
            City = Faker.Address.City(),
            State = Faker.Address.State(),
            ZipCode = Faker.Address.ZipCode()
        };

        await using (var connection = GetNewConnection())
        {
            var sut = new GenericRepository(GetTestDbContext(connection));
            await sut.InsertAsync(address);
        }

        await using (var  connection = GetNewConnection())
        {
            var context = GetTestDbContext(connection);
            context.Addresses.Count().Should().Be(1);
            context.Addresses.First().Should().BeEquivalentTo(address);
        }
    }
}
