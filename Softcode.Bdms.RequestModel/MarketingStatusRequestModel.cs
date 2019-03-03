using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using Softcode.Bdms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Softcode.Bdms.RequestModel
{
    public class MarketingStatusRequestModel : BaseRequestModel<MarketingStatus>
    {
        public override Expression<Func<MarketingStatus, DropdownViewModel>> Dropdown()
        {
            return x => new DropdownViewModel()
            {
                Id = x.StatusId,
                Text = x.StatusName,
                Data = new { x.StatusId, x.StatusName }
            };
        }

        public override Expression<Func<MarketingStatus, bool>> GetExpression()
        {
            throw new NotImplementedException();
        }

        public override IQueryable<MarketingStatus> IncludeParents(IQueryable<MarketingStatus> queryable)
        {
            throw new NotImplementedException();
        }
    }
}
