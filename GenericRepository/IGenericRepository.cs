using System.Threading.Tasks;

namespace GenericRepository
{
    public interface IGenericRepository
    {
        public Task<bool> InsertAsync<T>(T entity) where T : class;
    }
}
