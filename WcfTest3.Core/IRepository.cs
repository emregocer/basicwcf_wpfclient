using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WcfTest3.Core
{
    public interface IRepository<T>
    {
        T Insert(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T GetSingle(int Id);
        T GetFirst(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}
