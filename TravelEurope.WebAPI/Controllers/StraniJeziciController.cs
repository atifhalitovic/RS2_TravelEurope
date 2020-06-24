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
    public class StraniJeziciController : ControllerBase
    {
        private readonly IStraniJeziciService _service;

        public StraniJeziciController(IStraniJeziciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.StraniJezici> Get([FromQuery]Model.Requests.StraniJeziciSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}

