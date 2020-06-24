using TravelEurope.Model;
using TravelEurope.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public interface IOcjeneService
    {
        Model.Ocjene Get(Model.Requests.OcjeneSearchRequest request);
        Model.Ocjene Insert(Model.Requests.OcjeneInsertRequest request);
        Model.Ocjene GetById(int id);
        Model.Ocjene Update(int id, OcjeneInsertRequest request);
        Ocjene OcijeniRutu(OcjeneInsertRequest request);
        Model.Ocjene GetMojuOcjenu(int RezervacijaId, int KorisnikId);
    }
}
