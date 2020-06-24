using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelEurope.WebAPI.Services
{
    public class TuristickiVodiciService : ITuristickiVodiciService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public TuristickiVodiciService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.TuristickiVodici> Get(TuristickiVodiciSearchRequest request)
        {
            var query = _context.TuristickiVodici.Include(a => a.StraniJezik).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().Contains(request.Ime.ToLower()));
            }
            if (request.StraniJezikId > 0)
            {
                query = query.Where(x => x.StraniJezikId == request.StraniJezikId);
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.TuristickiVodici>>(list);
        }

        public Model.TuristickiVodici Insert(TuristickiVodiciInsertRequest request)
        {
            Database.TuristickiVodici entity = _mapper.Map<Database.TuristickiVodici>(request);
           
            _context.TuristickiVodici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.TuristickiVodici>(entity);
        }
        public Model.TuristickiVodici GetById(int id)
        {
            var query = _context.TuristickiVodici.AsQueryable();

            query = query.Where(x => x.TuristickiVodicId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.TuristickiVodici>(entity);
        }

        public Model.TuristickiVodici Update(int id, TuristickiVodiciInsertRequest request)
        {
            Database.TuristickiVodici entity = _context.TuristickiVodici.Where(x => x.TuristickiVodicId == id).FirstOrDefault();

            _context.TuristickiVodici.Attach(entity);
            _context.TuristickiVodici.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.TuristickiVodici>(entity);

        }
    }
}
