using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Softcode.Bdms.Repository
{
 public interface IBaseRepository<T> where T:BaseEntity
    {
        bool Add(T entity);
        IQueryable<T> Get();
        T GetDetail(int id);
        bool Edit(T entity);
        bool Delete(int id);

    }
}
