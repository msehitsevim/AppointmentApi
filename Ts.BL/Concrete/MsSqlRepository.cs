using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ts.DAL.Entities;

namespace Ts.DAL
{
    
    public class MsSqlRepository<T> : Repository<T> where T : class
    {
        public readonly MsDbContext tryContext;
        
        private readonly DbSet<T> entities;

        public MsSqlRepository(MsDbContext context)
        {
            tryContext = context;
            entities = tryContext.Set<T>();
        }

        public override void Delete(Expression<Func<T, bool>> filter = null)
        {
            
            var silinecek = GetList(filter);
            entities.RemoveRange(silinecek);
            tryContext.SaveChanges();
        }

        public override T Get(Expression<Func<T, bool>> filter = null)
        {

            return entities.SingleOrDefault(filter);
        }

        public override IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public override IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return entities.Where(filter);
        }

        public override void Insert(T obj)
        {
            entities.Add(obj);
            tryContext.SaveChanges();
        }

       

        public override void Update(T obj)
        {
            entities.Update(obj);
            tryContext.SaveChanges();
        }
    }
}
