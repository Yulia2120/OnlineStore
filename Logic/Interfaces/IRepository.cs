namespace Logic.Interfaces
{
    public interface IRepository<T> where T : IIdentity
    {
        Task<T> CreateAsync(T item);

        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(T item);
        Task<T> Find(int? id);

        Task<bool> DeleteAsync(T item);

    }
}
