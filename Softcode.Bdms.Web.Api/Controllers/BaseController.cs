using Microsoft.AspNetCore.Mvc;
using Softcode.Bdms.ApplicationService;
using Softcode.Bdms.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softcode.Bdms.Web.Api.Controllers
{
    [ApiController]
    public class BaseController<T,Tr,Tv>:ControllerBase where T:class where Tr:BaseRequestModel<T> where Tv:class
    {
        private readonly IBaseService<T, Tr, Tv> service;
        public BaseController(IBaseService<T, Tr, Tv> service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("search")]
        public IActionResult Search(Tr request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please vi sob field fill up koren");
            }
            var searchResult = service.Search(request);
            return Ok(searchResult);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult POST(T model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Bhai please sob field fill up koren");
            }

            var add = service.Add(model);
            return Ok(add);
        }

    }
}
