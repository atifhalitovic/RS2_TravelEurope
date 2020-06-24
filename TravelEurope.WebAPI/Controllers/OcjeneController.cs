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
    public class OcjeneController : ControllerBase
    {
        private readonly IOcjeneService _service;

        public OcjeneController(IOcjeneService service)
        {
            _service = service;
        }

        [HttpGet]
        public Model.Ocjene Get([FromQuery]Model.Requests.OcjeneSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Ocjene Insert([FromBody]Model.Requests.OcjeneInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPost("OcijeniRutu")]
        public Model.Ocjene OcijeniRutu([FromBody]Model.Requests.OcjeneInsertRequest request)
        {
            return _service.OcijeniRutu(request);
        }


        [HttpPut("{id}")]
        public Model.Ocjene Update(int id, [FromBody]Model.Requests.OcjeneInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Ocjene GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("GetMojuOcjenu")]
        public Model.Ocjene GetMojuOcjenu(int RezervacijaId, int KorisnikId)
        {
            return _service.GetMojuOcjenu(RezervacijaId, KorisnikId);
        }
    }
}