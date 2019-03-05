using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
namespace Softcode.Bdms.Repository
{
    public class BaseRepository<T>:IBaseRepository<T> where T : BaseEntity
    {
       private readonly MarketingDbContext context;
        public BaseRepository(MarketingDbContext context)
        {
            this.context = context;
        }

        public bool Add(T entity)
        {
            DbSet<T> dbSet = this.context.Set<T>();//dbset konta chinai dilo ex
            dbSet.Add(entity);
            int i = context.SaveChanges();//how many rows will be effected

            return i > 0;
        }


        public IQueryable<T> Get()
        {
            //return this.context.Set<T>().AsQueryable();
            DbSet<T> dbSet = this.context.Set<T>();
            return dbSet.AsQueryable();
        }

        public T GetDetail(int id)
        {
            return this.context.Set<T>().Find(id);

        }

        public bool Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            int i = context.SaveChanges();//how many rows will be effected
            return i > 0;
        }

        public bool Delete(int id)
        {
            var entity = GetDetail(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                int i = context.SaveChanges();//how many rows will be effected
                return i > 0;
            }
            return true;
        }
    }
}
