using TravelEurope.Model;
using TravelEurope.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TravelEurope.Mobile.Models;

namespace TravelEurope.Mobile.ViewModels
{
   public class PorukeVM : BaseViewModel
    {
        private readonly APIService _servicePoruke = new APIService("Poruke");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private readonly APIService _serviceRute = new APIService("TuristRute");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");

        int KorisnikId;

        public PorukeVM(int Korisnik)
        {
            KorisnikId = Korisnik;
            InitCommand = new Command(async () => await Init());

        }
        public PorukeVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Poruke> listaPoruka { get; set; } = new ObservableCollection<Model.Poruke>();
        public ObservableCollection<RezervacijeMobile> listaKorisnikaSaIstogPutovanja { get; set; } = new ObservableCollection<RezervacijeMobile>();


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var listaKorisnika = await _serviceKorisnici.Get<List<Korisnici>>(null);
            var search = new RezervacijeSearchRequest();
            var listaRezervacija = await _serviceRezervacije.Get<List<RezervacijeMobile>>(null);

            listaKorisnikaSaIstogPutovanja.Clear();
            foreach(var x in listaKorisnika)
            {
                foreach(var y in listaRezervacija)
                {   //provjerava se za buduce rute
                    if(x.KorisniciId == y.KorisnikId && y.TuristRuta.DatumPutovanja > DateTime.Now && x.KorisniciId != APIService.PrijavljeniKorisnik.KorisniciId)
                    {
                        listaKorisnikaSaIstogPutovanja.Add(y);
                    }
                }   
            }

            var req = new PorukeSearchRequest();
            req.PrimalacId = APIService.PrijavljeniKorisnik.KorisniciId;
            var lista = await _servicePoruke.Get<List<Poruke>>(req);
            listaPoruka.Clear();
            foreach (var x in lista)
            {
                listaPoruka.Add(x);
            }
        }
    }
}
