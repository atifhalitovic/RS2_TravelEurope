using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TravelEurope.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize]
        public List<Model.Korisnici> Get([FromQuery]Model.Requests.KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public Model.Korisnici Insert([FromBody]Model.Requests.KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        public Model.Korisnici Update(int id, [FromBody]Model.Requests.KorisniciUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize]
        [HttpPost("UpdateProfile")]
        public Model.Korisnici UpdateProfile([FromBody]Model.Requests.KorisniciUpdateProfilRequest request)
        {
            return _service.UpdateProfile(request);
        }

        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("MyProfile")]
        [Authorize]
        public Model.Korisnici MyProfile()
        {
            return _service.MyProfile();
        }
    }
}