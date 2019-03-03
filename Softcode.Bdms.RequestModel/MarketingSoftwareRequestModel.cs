using Microsoft.EntityFrameworkCore;
using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using Softcode.Bdms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Softcode.Bdms.RequestModel
{
    public class MarketingSoftwareRequestModel : BaseRequestModel<MarketSoftware>
    {
        public string MarketName { get; set; }

        public override Expression<Func<MarketSoftware, DropdownViewModel>> Dropdown()
        {
            return x => new DropdownViewModel()
            {
                Id = x.StatusId,
                Text = x.Status.StatusName,
                Data = new { x.StatusId, x.Status.StatusName }
            };
        }

        public override Expression<Func<MarketSoftware, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(this.Keyword))
            {
                this.ExpressionObject = x => x.Address.Contains(Keyword) || x.MarketName.Contains(Keyword) || x.Mkid.Contains(Keyword)||x.Mobile.Contains(Keyword)||x.Telephone.Contains(Keyword)||x.WebSite.Contains(Keyword)||x.Designation.Contains(Keyword)||x.District.Contains(Keyword);
            }

            if (!string.IsNullOrWhiteSpace(MarketName))
            {
                this.ExpressionObject = x => x.MarketName.Contains(MarketName);
            }

            return this.ExpressionObject;
        }

        public override IQueryable<MarketSoftware> IncludeParents(IQueryable<MarketSoftware> queryable)
        {
            return queryable.Include(x => x.Status);
        }
    }
}
