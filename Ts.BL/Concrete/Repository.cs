using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ts.DAL
{
    public abstract class Repository<T> : IRepository<T>, IDisposable where T : class
    {

        public abstract void Delete(Expression<Func<T, bool>> filter = null);

        public abstract T Get(Expression<Func<T, bool>> filter = null);

        public abstract IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null);
        public abstract IEnumerable<T> GetAll();
        public abstract void Insert(T obj);

        public abstract void Update(T obj);
     
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
