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
    public class TuristRuteController : ControllerBase
    {
        private readonly ITuristRuteService _service;

        public TuristRuteController(ITuristRuteService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.TuristRute> Get([FromQuery]Model.Requests.TuristRuteSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.TuristRute Insert([FromBody]Model.Requests.TuristRuteInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.TuristRute Update(int id, [FromBody]Model.Requests.TuristRuteInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("GetListSaSlikama")]
        public List<Model.TuristRute> GetListSaSlikama([FromQuery]Model.Requests.TuristRuteSearchRequest request)
        {
            return _service.GetListSaSlikama(request);
        }

        [HttpGet("GetThumbnail/{id}")]
        public Model.RuteSlike GetThumbnail(int id)
        {
            return _service.GetThumbnail(id);
        }

        [HttpGet("{id}")]
        public Model.TuristRute GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}