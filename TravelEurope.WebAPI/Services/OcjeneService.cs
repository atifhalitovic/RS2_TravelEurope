using AutoMapper;
using TravelEurope.Model;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class OcjeneService : IOcjeneService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public OcjeneService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Ocjene Get(OcjeneSearchRequest request)
        {
            var query = _context.Ocjene.AsQueryable();

            var entity = query.Where(a => a.KorisnikId == request.KorisnikId && a.RezervacijaId == request.RezervacijaId).FirstOrDefault();

            return _mapper.Map<Model.Ocjene>(entity);
        }

        public Model.Ocjene GetMojuOcjenu(int RezervacijaId, int KorisnikId)
        {
            var query = _context.Ocjene.AsQueryable();

            query = query.Include(x => x.Rezervacija);

            query = query.Include(x => x.Korisnik);

            var entity = query.Where(a=>a.RezervacijaId == RezervacijaId && a.KorisnikId==KorisnikId).FirstOrDefault();

            return _mapper.Map<Model.Ocjene>(entity);
        }

        public Model.Ocjene GetById(int id)
        {
            var query = _context.Ocjene.AsQueryable();

            query = query.Where(x => x.OcjenaId == id);

            query = query.Include(x => x.Rezervacija);

            query = query.Include(x => x.Korisnik);
            

            var entity = query.FirstOrDefault();


            return _mapper.Map<Model.Ocjene>(entity);
        }

        public Model.Ocjene Insert(OcjeneInsertRequest request)
        {
            Database.Ocjene entity = _mapper.Map<Database.Ocjene>(request);

            entity.KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId;

            _context.Ocjene.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Ocjene>(entity);
        }

        public Model.Ocjene OcijeniRutu(OcjeneInsertRequest request)
        {
            int KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId;

            Database.Ocjene entity = _context.Ocjene.Where(x => x.RezervacijaId == request.RezervacijaId && x.KorisnikId == KorisnikId).FirstOrDefault();
            if(entity != null)
            {
                entity.Ocjena = request.Ocjena;
                entity.Komentar = request.Komentar;
            }
            else
            {
                entity = _mapper.Map<Database.Ocjene>(request);
                entity.KorisnikId = KorisnikId;
                entity.DatumOcjene = DateTime.Now;

                _context.Ocjene.Add(entity);
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Ocjene>(entity);

        }

        public Model.Ocjene Update(int id, OcjeneInsertRequest request)
        { 
            Database.Ocjene entity = _context.Ocjene.Where(x => x.RezervacijaId == id).FirstOrDefault();

            _context.Ocjene.Attach(entity);
            _context.Ocjene.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Ocjene>(entity);

        }
    }
}
