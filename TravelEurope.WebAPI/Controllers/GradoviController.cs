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
    public class GradoviController : ControllerBase
    {
        private readonly IGradoviService _service;

        public GradoviController(IGradoviService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Gradovi> Get([FromQuery]Model.Requests.GradoviSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Gradovi Insert([FromBody]Model.Requests.GradoviInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Gradovi Update(int id, [FromBody]Model.Requests.GradoviInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Gradovi GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}