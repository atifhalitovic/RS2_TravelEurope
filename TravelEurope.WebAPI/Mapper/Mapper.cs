using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.WebAPI.Database;

namespace TravelEurope.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Ocjene, Model.Ocjene>();
            CreateMap<Database.Poruke, Model.Poruke>();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.Drzave, Model.Drzave>();
            CreateMap<Database.Gradovi, Model.Gradovi>();
            CreateMap<Database.Lokacije, Model.Lokacije>();
            CreateMap<Database.TuristRute, Model.TuristRute>();
            CreateMap<Database.TuristickiVodici, Model.TuristickiVodici>();
            CreateMap<Database.StraniJezici, Model.StraniJezici>();
            CreateMap<Database.RuteSlike, Model.RuteSlike>();
            CreateMap<Database.Pretplate, Model.Pretplate>();
            CreateMap<Database.Kategorije, Model.Kategorije>();
            CreateMap<Database.Poruke, Model.Poruke>();

            CreateMap<Database.Rezervacije, Model.Rezervacije>();
            CreateMap<Database.Rezervacije, Model.Rezervacije>().ReverseMap();


            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<Database.TuristRute, Model.TuristRute>().ReverseMap();
            CreateMap<Database.TuristickiVodici, Model.TuristickiVodici>().ReverseMap();
            CreateMap<Database.Kategorije, Model.Kategorije>().ReverseMap();
            CreateMap<Database.StraniJezici, Model.StraniJezici>().ReverseMap();
            CreateMap<Database.RuteSlike, Model.RuteSlike>().ReverseMap();
            CreateMap<Database.Gradovi, Model.Gradovi>().ReverseMap();
            CreateMap<Database.Drzave, Model.Drzave>().ReverseMap();
            CreateMap<Database.Pretplate, Model.Pretplate>().ReverseMap();


            CreateMap<Database.Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Requests.KorisniciUpdateRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Requests.KorisniciUpdateProfilRequest>().ReverseMap();

            CreateMap<Database.TuristRute, Model.Requests.TuristRuteInsertRequest>().ReverseMap();
            CreateMap<Database.TuristickiVodici, Model.Requests.TuristickiVodiciInsertRequest>().ReverseMap();

            CreateMap<Database.Uloge, Model.Requests.UlogeInsertRequest>().ReverseMap();
            CreateMap<Database.Drzave, Model.Requests.DrzaveInsertRequest>().ReverseMap();
            CreateMap<Database.Gradovi, Model.Requests.GradoviInsertRequest>().ReverseMap();
            CreateMap<Database.Lokacije, Model.Requests.LokacijeInsertRequest>().ReverseMap();
            CreateMap<Database.RuteSlike, Model.Requests.RuteSlikeInsertRequest>().ReverseMap();
            CreateMap<Database.Kategorije, Model.Requests.KategorijeInsertRequest>().ReverseMap();
            CreateMap<Database.Pretplate, Model.Requests.PretplateInsertRequest>().ReverseMap();
            CreateMap<Database.Ocjene, Model.Requests.OcjeneInsertRequest>().ReverseMap();

            CreateMap<Database.Poruke, Model.Requests.PorukeInsertRequest>().ReverseMap();

            CreateMap<Database.Rezervacije, Model.Requests.RezervacijeInsertRequest>().ReverseMap();

        }
    }
}
