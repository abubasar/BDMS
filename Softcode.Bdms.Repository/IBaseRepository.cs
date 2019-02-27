using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Softcode.Bdms.Repository
{
 public interface IBaseRepository<T> where T:class
    {
        bool Add(T entity);
        IQueryable<T> Get();
        T GetDetail(string id);
        bool Edit(T entity);
        bool Delete(string id);

    }
}
