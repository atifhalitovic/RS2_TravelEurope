using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IPretplateService
    {
        List<Model.Pretplate> Get(Model.Requests.PretplateSearchRequest request);
        Model.Pretplate Insert(Model.Requests.PretplateInsertRequest request);
        Pretplate Update(int id, PretplateInsertRequest request);
        Pretplate GetById(int id);
        bool Remove(int id);
    }
}
