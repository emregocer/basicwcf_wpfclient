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

        public T GetFirst(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T GetSingle(int Id)
        {
            return _dbSet.SingleOrDefault(t => t.Id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Insert(T Entity)
        {
            return _dbSet.Add(Entity);
        }

        // Do I need update method on repository?
        public void Update(T Entity)
        {
            _dbSet.Attach(Entity);
            var entry = _context.Entry(Entity);
            entry.State = EntityState.Modified;
        }

        // I wouldnt need this if i used unit of work.
        public void SaveChanges()
        {
            _context.SaveChanges();
        }      
    }
}
