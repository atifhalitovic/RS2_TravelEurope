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
    public class LokacijeController : ControllerBase
    {
        private readonly ILokacijeService _service;

        public LokacijeController(ILokacijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Lokacije> Get([FromQuery]Model.Requests.LokacijeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Lokacije Insert([FromBody]Model.Requests.LokacijeInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Lokacije Update(int id, [FromBody]Model.Requests.LokacijeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Lokacije GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}