using System.Linq.Expressions;


namespace Core.Abstracts.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task InsertOneAsync(T entity);
        Task InsertManyAsync(IEnumerable<T> entities);

        Task<T?> FindOneAsync(object entityKey);
        Task<IEnumerable<T>> FindManyAsync(
            Expression<Func<T, bool>>? predicate = null, //Verileri filtrelemek için kullanılır.
           string[]? includes = null //Bağlı tabloları birleştirmek için kullanılır.
            );

        Task UpdateAsync(T entity);
        Task UpdateMany(IEnumerable<T> entities);

        Task DeleteAsync(T entity);
        Task DeleteMany(IEnumerable<T> entities);

        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);

        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);

        Task SaveAsync();

        Task DisposeAsync();
    }
}
