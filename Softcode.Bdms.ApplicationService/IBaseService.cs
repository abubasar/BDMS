using Softcode.Bdms.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Softcode.Bdms.ApplicationService
{
   public interface IBaseService<T, Tr, Tv> where T : class where Tr : BaseRequestModel<T> where Tv : class
    {
        IQueryable<T> SearchQueryable(BaseRequestModel<T> request);
        bool Add(T model);
        Tv Detail(string id);
        List<Tv> Search(Tr request);
        

    }
}
