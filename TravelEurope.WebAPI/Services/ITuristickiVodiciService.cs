using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface ITuristickiVodiciService
    {
        List<Model.TuristickiVodici> Get(Model.Requests.TuristickiVodiciSearchRequest request);
        Model.TuristickiVodici Insert(Model.Requests.TuristickiVodiciInsertRequest request);
        TuristickiVodici Update(int id, TuristickiVodiciInsertRequest request);
        TuristickiVodici GetById(int id);
    }
}
