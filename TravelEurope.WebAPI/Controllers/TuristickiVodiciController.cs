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
    public class TuristickiVodiciController : ControllerBase
    {
        private readonly ITuristickiVodiciService _service;

        public TuristickiVodiciController(ITuristickiVodiciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.TuristickiVodici> Get([FromQuery]Model.Requests.TuristickiVodiciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.TuristickiVodici Insert([FromBody]Model.Requests.TuristickiVodiciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.TuristickiVodici Update(int id, [FromBody]Model.Requests.TuristickiVodiciInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.TuristickiVodici GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}