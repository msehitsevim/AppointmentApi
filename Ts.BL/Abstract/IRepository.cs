using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Ts.DAL.Entities;

namespace Ts.DAL
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> filter = null);
        IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null);
        IEnumerable<T> GetAll();
        void Insert(T obj);
        void Delete(Expression<Func<T, bool>> filter = null);
        void Update(T obj);
      
    }
}
