using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface ITuristRuteService
    {
        List<Model.TuristRute> Get(Model.Requests.TuristRuteSearchRequest request);
        List<Model.TuristRute> GetListSaSlikama(Model.Requests.TuristRuteSearchRequest request);
        Model.TuristRute Insert(Model.Requests.TuristRuteInsertRequest request);
        TuristRute Update(int id, TuristRuteInsertRequest request);
        TuristRute GetById(int id);
        RuteSlike GetThumbnail(int TuristRutaId);
    }
}
