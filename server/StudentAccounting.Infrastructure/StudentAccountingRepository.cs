using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentAccounting.Shared;
using StudentAccounting.Shared.Interfaces;

namespace StudentAccounting.Infrastructure
{
    public class StudentAccountingRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly StudentAccountingDbContext _context;
        private readonly DbSet<T> _entities;

        public StudentAccountingRepository(StudentAccountingDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll() => await _entities.ToListAsync();

        public async Task<T> GetById(Guid id) => await _entities.FindAsync(id);

        public async Task<Guid> Insert(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            _entities.Remove(await _entities.FindAsync(id));
            await _context.SaveChangesAsync();
        }
    }
}
