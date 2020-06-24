using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TravelEurope.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : ControllerBase
    {
        private readonly IUlogeService _service;

        public UlogeController(IUlogeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Uloge> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public Model.Uloge Insert([FromBody]Model.Requests.UlogeInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}