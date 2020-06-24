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
    public class RuteSlikeController : ControllerBase
    {
        private readonly IRuteSlikeService _service;

        public RuteSlikeController(IRuteSlikeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.RuteSlike> Get([FromQuery]Model.Requests.RuteSlikeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.RuteSlike Insert([FromBody]Model.Requests.RuteSlikeInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.RuteSlike Update(int id, [FromBody]Model.Requests.RuteSlikeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.RuteSlike GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            return _service.Remove(id);
        }
    }
}