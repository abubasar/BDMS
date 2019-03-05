using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using System;

namespace Softcode.Bdms.ViewModel
{
    public class BaseViewModel<T> where T:BaseEntity
    {
       

        public BaseViewModel(BaseEntity entity)
        {
            CreatedBy = entity.CreatedBy;
        }

        
        public string CreatedBy { get; set; }

    }
}
