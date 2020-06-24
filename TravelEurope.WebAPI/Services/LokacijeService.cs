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
    public class LokacijeService : ILokacijeService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public LokacijeService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Lokacije> Get(LokacijeSearchRequest request)
        {
            var query = _context.Lokacije.Include(a=>a.Drzava).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }
            if (request.DrzavaId > 0)
            {
                query = query.Where(x => x.DrzavaId == request.DrzavaId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Lokacije>>(list);
        }

        public Model.Lokacije Insert(LokacijeInsertRequest request)
        {
            Database.Lokacije entity = _mapper.Map<Database.Lokacije>(request);
           
            _context.Lokacije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Lokacije>(entity);
        }
        public Model.Lokacije GetById(int id)
        {
            var query = _context.Lokacije.AsQueryable();

            query = query.Where(x => x.LokacijaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Lokacije>(entity);
        }

        public Model.Lokacije Update(int id, LokacijeInsertRequest request)
        {
            Database.Lokacije entity = _context.Lokacije.Where(x => x.LokacijaId == id).FirstOrDefault();

            _context.Lokacije.Attach(entity);
            _context.Lokacije.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Lokacije>(entity);
        }
    }
}
