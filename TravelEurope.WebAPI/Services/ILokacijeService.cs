using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface ILokacijeService
    {
        List<Model.Lokacije> Get(Model.Requests.LokacijeSearchRequest request);
        Model.Lokacije Insert(Model.Requests.LokacijeInsertRequest request);
        Lokacije Update(int id, LokacijeInsertRequest request);
        Lokacije GetById(int id);
    }
}
