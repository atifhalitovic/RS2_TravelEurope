using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IRezervacijeService
    {
        List<Model.Rezervacije> Get(Model.Requests.RezervacijeSearchRequest request);
        Model.Rezervacije Insert(Model.Requests.RezervacijeInsertRequest request);
        Rezervacije Update(int id, RezervacijeInsertRequest request);
        Rezervacije GetById(int id);
        bool Remove(int id);
        List<Rezervacije> GetMyRezervacije();
        List<Rezervacije> GetUserRezervacije(int KorisnikId);
    }
}
