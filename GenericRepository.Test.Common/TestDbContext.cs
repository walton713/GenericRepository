using GenericRepository.UnitTests.TestObjects;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.UnitTests;

public class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
{
    public DbSet<Address> Addresses { get; set; }
}
