using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAccounting.Shared.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(Guid id);
    }
}
