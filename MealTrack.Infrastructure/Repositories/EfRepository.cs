using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MealTrack.Domain.Interfaces;

namespace MealTrack.Infrastructure.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public EfRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T Get(int id) => _dbSet.Find(id);

        public IEnumerable<T> GetAll() => _dbSet.ToList();

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}
