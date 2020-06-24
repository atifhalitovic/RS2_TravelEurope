using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IPorukeService
    {
        List<Model.Poruke> Get(Model.Requests.PorukeSearchRequest request);
        Model.Poruke Insert(Model.Requests.PorukeInsertRequest request);
        Poruke Update(int id, PorukeInsertRequest request);
        Poruke GetById(int id);
        bool Remove(int id);
        List<Poruke> GetMyPoruke();
        List<Poruke> GetUserPoruke(int KorisnikId);
    }
}
