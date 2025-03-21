using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Common
{
    public interface IRepository<T> where T : IEntity
    {
        Task CreateAsync(T item);
        Task<IReadOnlyCollection<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(T item);
    }
}