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
    public class MarketingInqueryRequestModel : BaseRequestModel<MarketingInquiry>
    {
        public override Expression<Func<MarketingInquiry, DropdownViewModel>> Dropdown()
        {
            throw new NotImplementedException();
        }

        public override Expression<Func<MarketingInquiry, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x => x.Email.Contains(Keyword)||x.InquiryContactPerson.Contains(Keyword)||x.Mobile.Contains(Keyword)||x.Telephone.Contains(Keyword)||x.Remarks.Contains(Keyword);
            }

            return this.ExpressionObject;
        }

        public override IQueryable<MarketingInquiry> IncludeParents(IQueryable<MarketingInquiry> queryable)
        {
           return queryable.Include(x => x.MarketSoftware);
        }
    }
}
