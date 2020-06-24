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
    public class RezervacijeController : ControllerBase
    {
        private readonly IRezervacijeService _service;

        public RezervacijeController(IRezervacijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Rezervacije> Get([FromQuery]Model.Requests.RezervacijeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Rezervacije Insert([FromBody]Model.Requests.RezervacijeInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Rezervacije Update(int id, [FromBody]Model.Requests.RezervacijeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Rezervacije GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            return _service.Remove(id);
        }

        [HttpGet("GetMyRezervacije")]
        public List<Model.Rezervacije> GetMyRezervacije()
        {
            return _service.GetMyRezervacije();
        }

        [HttpGet("GetUserRezervacije/{KorisnikId}")]
        public List<Model.Rezervacije> GetUserRezervacije(int KorisnikId)
        {
            return _service.GetUserRezervacije(KorisnikId);
        }
    }
}