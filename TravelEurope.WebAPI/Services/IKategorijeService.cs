using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IKategorijeService
    {
        List<Model.Kategorije> Get(Model.Requests.KategorijeSearchRequest request);
        Model.Kategorije Insert(Model.Requests.KategorijeInsertRequest request);
        Kategorije Update(int id, KategorijeInsertRequest request);
        Kategorije GetById(int id);
    }
}
