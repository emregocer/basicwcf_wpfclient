using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Core;
using WcfTest3.Data;

namespace WcfTest3.DataAccess
{
    public class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Delete(T Entity)
        {
            _dbSet.Remove(Entity);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T GetSingle(int Id)
        {
            return _dbSet.SingleOrDefault(t => t.Id == Id);
        }

        public IList<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Insert(T Entity)
        {
            return _dbSet.Add(Entity);
        }

        public void Update(T Entity)
        {
            var entity = _dbSet.SingleOrDefault(t => t.Id == Entity.Id);
            if (entity == null)
            {
                return;
            }
            _context.Entry(Entity).CurrentValues.SetValues(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public T GetFirst(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }
    }
}
