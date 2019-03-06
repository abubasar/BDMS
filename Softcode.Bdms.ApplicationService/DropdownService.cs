using System;
using System.Collections.Generic;
using System.Text;
using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using Softcode.Bdms.Repository;
using Softcode.Bdms.Shared.Enums;
using Softcode.Bdms.ViewModel;
using System.Linq;
namespace Softcode.Bdms.ApplicationService
{
    public class DropdownService : IDropdownService
    {
        private readonly IBaseRepository<MarketingStatus> baseRepository;
        public DropdownService(IBaseRepository<MarketingStatus> baseRepositor)
        {
            this.baseRepository = baseRepositor;
        }
        public List<SelectModel> GetSelectModels(DropdownType type)
        {
            List<SelectModel> selecModels = new List<SelectModel>();

            switch (type)
            {
                case DropdownType.MarketingStatus:
                    selecModels= this.baseRepository.Get().ToList().Select(x => new SelectModel() { Text = x.StatusName, Value = x.StatusId }).ToList();
                    break;
                default:
                    break;
            }
            return selecModels;



        }
    }
}
