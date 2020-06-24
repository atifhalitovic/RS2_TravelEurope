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
    public class PorukeNovaVM : BaseViewModel
    {
        private readonly APIService _servicePoruke = new APIService("Poruke");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private readonly APIService _serviceRute = new APIService("TuristRute");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");

        private int _PosiljalacId;
        private int _PrimalacId;
        public PorukeInsertRequest novaPoruka { get; set; } = new PorukeInsertRequest();

        public string _sadrzajPoruke = string.Empty;
        public string SadrzajPoruke
        {
            get { return _sadrzajPoruke; }
            set { SetProperty(ref _sadrzajPoruke, value); }
        }

        public PorukeNovaVM(int PosiljalacId, int PrimalacId)
        {
            _PosiljalacId = PosiljalacId;
            _PrimalacId = PrimalacId;
            PosaljiCommand = new Command(async () => await PosaljiPoruku());
        }
        public PorukeNovaVM()
        {

        }

        public async Task Init()
        {
            await UcitajPorukaDetails();
        }

        public Korisnici _primalac;
        public Korisnici Primalac
        {
            get { return _primalac; }
            set { SetProperty(ref _primalac, value); }
        }

        public Korisnici _trenutni;
        public Korisnici TrenutniKorisnik
        {
            get { return _trenutni; }
            set { SetProperty(ref _trenutni, value); }
        }

        public DateTime _sada = DateTime.Now;
        public DateTime DatumVrijeme
        {
            get { return _sada; }
            set { SetProperty(ref _sada, value); }
        }

        private async Task UcitajPorukaDetails()
        {
            var temp = await _serviceKorisnici.GetById<Korisnici>(_PrimalacId);
            Primalac = temp;
            var temp2 = await _serviceKorisnici.GetById<Korisnici>(_PosiljalacId);
            TrenutniKorisnik = temp2;
            DatumVrijeme = DateTime.Now;
        }

        public ICommand InitCommand { get; set; }

        public Command PosaljiCommand { get; }

        public async Task PosaljiPoruku()
        {
            novaPoruka.PosiljalacId = APIService.PrijavljeniKorisnik.KorisniciId;
            novaPoruka.PrimalacId = _PrimalacId;
            novaPoruka.DatumVrijeme = DateTime.Now;
            novaPoruka.Sadrzaj = "Tema: " + SadrzajPoruke;

            try
            {
                await _servicePoruke.Insert<Model.Poruke>(novaPoruka);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
        }
    }
}
