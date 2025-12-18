using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class GenericRepository(DbContext context) : IGenericRepository
    {
        public async Task<bool> InsertAsync<T>(T entity) where T : class
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
