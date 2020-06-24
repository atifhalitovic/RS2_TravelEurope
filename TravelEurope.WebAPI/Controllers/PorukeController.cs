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
    public class PorukeController : ControllerBase
    {
        private readonly IPorukeService _service;

        public PorukeController(IPorukeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Poruke> Get([FromQuery]Model.Requests.PorukeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Poruke Insert([FromBody]Model.Requests.PorukeInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Poruke Update(int id, [FromBody]Model.Requests.PorukeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Poruke GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            return _service.Remove(id);
        }

        [HttpGet("GetMyPoruke")]
        public List<Model.Poruke> GetMyPoruke()
        {
            return _service.GetMyPoruke();
        }

        [HttpGet("GetUserPoruke/{KorisnikId}")]
        public List<Model.Poruke> GetUserPoruke(int KorisnikId)
        {
            return _service.GetUserPoruke(KorisnikId);
        }
    }
}