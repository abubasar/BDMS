using Microsoft.AspNetCore.Mvc;
using Softcode.Bdms.ApplicationService;
using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using Softcode.Bdms.RequestModel;
using Softcode.Bdms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softcode.Bdms.Web.Api.Controllers
{
    [Route("api/marketing-inquiry")]
    public class MarketingInquiryController : BaseController<MarketingInquiry, MarketingInqueryRequestModel, MarketingInquiryViewModel>
    {
        public MarketingInquiryController(IBaseService<MarketingInquiry, MarketingInqueryRequestModel, MarketingInquiryViewModel> service) : base(service)
        {
        }
    }
}
