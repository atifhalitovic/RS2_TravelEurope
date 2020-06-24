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
    public class DrzaveController : ControllerBase
    {
        private readonly IDrzaveService _service;

        public DrzaveController(IDrzaveService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Drzave> Get([FromQuery]Model.Requests.DrzaveSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Drzave Insert([FromBody]Model.Requests.DrzaveInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Drzave Update(int id, [FromBody]Model.Requests.DrzaveInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Drzave GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}