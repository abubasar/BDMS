using Softcode.Bdms.Shared.Enums;
using Softcode.Bdms.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softcode.Bdms.ApplicationService
{
   public interface IDropdownService
    {
        List<SelectModel> GetSelectModels(DropdownType type);
    }
}
