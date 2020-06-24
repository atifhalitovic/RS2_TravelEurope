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
    public class PorukeService : IPorukeService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public PorukeService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Remove(int id)
        {
            Database.Poruke entity = _context.Poruke.Where(x => x.PorukaId == id).FirstOrDefault();
            if (entity != null)
            {
                _context.Poruke.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public List<Model.Poruke> Get(PorukeSearchRequest request)
        {
            var query = _context.Poruke.Include(a=>a.Posiljalac).Include(b=>b.Primalac).AsQueryable();

            if (request.PosiljalacId > 0)
            {
                query = query.Where(x => x.PosiljalacId == request.PosiljalacId);
            }
            if (request.PrimalacId > 0)
            {
                query = query.Where(x => x.PrimalacId == request.PrimalacId);
            }

            var list = query.ToList();

            List<Model.Poruke> listaRezervacija = _mapper.Map<List<Model.Poruke>>(list);
            return listaRezervacija;
        }

        public Model.Poruke Update(int id, PorukeInsertRequest request)
        {
            Database.Poruke entity = _context.Poruke.Where(x => x.PorukaId == id).FirstOrDefault();

            _context.Poruke.Attach(entity);
            _context.Poruke.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Poruke>(entity);
        }
        public Model.Poruke Insert(PorukeInsertRequest request)
        {
            Database.Poruke entity = _mapper.Map<Database.Poruke>(request);

            _context.Poruke.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Poruke>(entity);
        }
        public Model.Poruke GetById(int id)
        {
            var query = _context.Poruke.Include(a => a.Posiljalac).Include(b => b.Primalac).AsQueryable();

            query = query.Where(x => x.PorukaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Poruke>(entity);
        }

        public List<Model.Poruke> GetUserPoruke(int PorukaId)
        {
            var query = _context.Poruke.AsQueryable();

            query = query.Where(x => x.PorukaId == PorukaId);

            query = query.Include(a => a.Posiljalac);

            var list = query.ToList();

            List<Model.Poruke> listaRezervacija = _mapper.Map<List<Model.Poruke>>(list);

            return listaRezervacija;
        }

        public List<Model.Poruke> GetMyPoruke()
        {
            var query = _context.Poruke.AsQueryable();

            query = query.Where(x => x.PorukaId == 1);// Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId);

            var list = query.ToList();

            List<Model.Poruke> listaRezervacija = _mapper.Map<List<Model.Poruke>>(list);

            return listaRezervacija;
        }
    }
}
