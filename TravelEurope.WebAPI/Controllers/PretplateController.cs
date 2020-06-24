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
    public class PretplateController : ControllerBase
    {
        private readonly IPretplateService _service;

        public PretplateController(IPretplateService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Pretplate> Get([FromQuery]Model.Requests.PretplateSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Pretplate Insert([FromBody]Model.Requests.PretplateInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Pretplate Update(int id, [FromBody]Model.Requests.PretplateInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Pretplate GetById(int id)
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