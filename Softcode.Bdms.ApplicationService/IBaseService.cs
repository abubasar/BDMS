using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using Softcode.Bdms.RequestModel;
using Softcode.Bdms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Softcode.Bdms.ApplicationService
{
   public interface IBaseService<T, Tr, Tv> where T : BaseEntity where Tr : BaseRequestModel<T> where Tv : BaseViewModel<T>
    {
        IQueryable<T> SearchQueryable(BaseRequestModel<T> request);
        bool Add(T model);
        bool Edit(T model);
        Tv Detail(int id);
        T GetById(int id);
        List<Tv> Search(Tr request);
        HashSet<DropdownViewModel> GetDropdownList(Tr request);
        bool Delete(int id);
    }
}
