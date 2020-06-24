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
    public class RezervacijeService : IRezervacijeService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public RezervacijeService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Remove(int id)
        {
            Database.Rezervacije entity = _context.Rezervacije.Where(x => x.RezervacijaId == id).FirstOrDefault();

            Database.Ocjene entity2 = _context.Ocjene.Where(a => a.RezervacijaId == id).FirstOrDefault();
            if (entity2 != null)
            {
                _context.Ocjene.Remove(entity2);
            }

            if (entity != null)
            {
                _context.Rezervacije.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Model.Rezervacije> Get(RezervacijeSearchRequest request)
        {
            var query = _context.Rezervacije.Include(a=>a.Korisnik).Include(b=>b.TuristRuta).ThenInclude(c=>c.Kategorija).AsQueryable();

            if (request.TuristRutaId > 0)
            {
                query = query.Where(x => x.TuristRutaId == request.TuristRutaId);
            }
            if (request.KorisnikId > 0)
            {
                query = query.Where(x => x.KorisnikId == request.KorisnikId);
            }
            if (request.DatumRezervacijeOd.HasValue)
            {
                query = query.Where(x => x.DatumRezervacije.Date >= request.DatumRezervacijeOd.Value.Date);
            }
            if (request.DatumRezervacijeDo.HasValue)
            {
                query = query.Where(x => x.DatumRezervacije.Date <= request.DatumRezervacijeDo.Value.Date);
            }

            var list = query.ToList();

            List<Model.Rezervacije> listaRezervacija = _mapper.Map<List<Model.Rezervacije>>(list);
            return listaRezervacija;
        }

        public Model.Rezervacije Update(int id, RezervacijeInsertRequest request)
        {
            Database.Rezervacije entity = _context.Rezervacije.Where(x => x.RezervacijaId == id).FirstOrDefault();

            _context.Rezervacije.Attach(entity);
            _context.Rezervacije.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacije>(entity);
        }
        public Model.Rezervacije Insert(RezervacijeInsertRequest request)
        {
            Database.Rezervacije entity = _mapper.Map<Database.Rezervacije>(request);

            _context.Rezervacije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacije>(entity);
        }
        public Model.Rezervacije GetById(int id)
        {
            var query = _context.Rezervacije.Include(a => a.Korisnik).ThenInclude(q=>q.Grad).Include(b => b.TuristRuta).ThenInclude(c=>c.Kategorija).Include(d=>d.TuristRuta.Lokacija).AsQueryable();

            query = query.Where(x => x.RezervacijaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Rezervacije>(entity);
        }

        public List<Model.Rezervacije> GetUserRezervacije(int KorisnikId)
        {
            var query = _context.Rezervacije.AsQueryable();

            query = query.Where(x => x.KorisnikId == KorisnikId);

            query = query.Include(a => a.TuristRuta).ThenInclude(b=>b.Lokacija).Include(c=>c.TuristRuta.Kategorija);

            var list = query.ToList();

            List<Model.Rezervacije> listaRezervacija = _mapper.Map<List<Model.Rezervacije>>(list);
            foreach (var item in listaRezervacija)
            {
                var querySlika = _context.RuteSlike.AsQueryable();

                querySlika = querySlika.Where(x => x.TuristRutaId == item.TuristRutaId);

                var entitySlika = querySlika.FirstOrDefault();

                if (entitySlika != null)
                {
                    item.SlikaThumb = entitySlika.SlikaThumb;
                }
            }

            return listaRezervacija;
        }

        public List<Model.Rezervacije> GetMyRezervacije()
        {
            var query = _context.Rezervacije.AsQueryable();

            query = query.Where(x => x.KorisnikId == Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId);

            var list = query.ToList();

            List<Model.Rezervacije> listaRezervacija = _mapper.Map<List<Model.Rezervacije>>(list);
            foreach (var item in listaRezervacija)
            {
                var querySlika = _context.RuteSlike.AsQueryable();

                querySlika = querySlika.Where(x => x.TuristRutaId == item.TuristRutaId);

                var entitySlika = querySlika.FirstOrDefault();

                if (entitySlika != null)
                {
                    item.SlikaThumb = entitySlika.SlikaThumb;
                }
            }

            return listaRezervacija;
        }
    }
}
