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
    public class KategorijeController : ControllerBase
    {
        private readonly IKategorijeService _service;

        public KategorijeController(IKategorijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Kategorije> Get([FromQuery]Model.Requests.KategorijeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Kategorije Insert([FromBody]Model.Requests.KategorijeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Kategorije Update(int id, [FromBody]Model.Requests.KategorijeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Kategorije GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}