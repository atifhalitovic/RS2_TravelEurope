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
    [ApiController]
    [Authorize]
    public class PreporukaController : ControllerBase
    {
        private readonly IPreporukaService _service;

        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public List<Model.TuristRute> GetById(int id)
        {
            return _service.GetById(id);
        }
    }
 }