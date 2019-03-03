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
    [Route("api/market-status")]
    public class MarketingStatusController : BaseController<MarketingStatus, MarketingStatusRequestModel, MarketSoftwareViewModel>

    {


        //[Route("search-market-software")]
        //public IActionResult SearchMarketSoftware([FromBody]MarketingSoftwareRequestModel model)
        //{
        //    return base.Search(model);
        //}

        //[Route("save-market-software")]
        //public IActionResult SaveMarketSoftware([FromBody]MarketSoftware model)
        //{
        //    return base.POST(model);
        //}

        //[Route("update-market-software")]
        //public IActionResult UpdateMarketSoftware(string id, [FromBody]MarketSoftware model)
        //{
        //    return base.PUT(model);
        //}

        //[Route("delete-market-software")]
        //public IActionResult DeleteMarketSoftware(string id, [FromBody]MarketSoftware model)
        //{
        //    return base.DELETE(model);
        //}
        public MarketingStatusController(IBaseService<MarketingStatus, MarketingStatusRequestModel, MarketSoftwareViewModel> service) : base(service)
        {
        }
    }
}
