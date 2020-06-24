using TravelEurope.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TravelEurope.Model.Requests;
using TravelEurope.Model;
using TravelEurope.Mobile.ViewsCustom;

namespace TravelEurope.Mobile.ViewModels
{
    public class TuristRuteDetailsVM : BaseViewModel
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");
        private readonly APIService _serviceOcjene = new APIService("Ocjene");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _servicePreporuka = new APIService("Preporuka");
        private readonly APIService _servicePretplate = new APIService("Pretplate");


        public ObservableCollection<Model.RuteSlike> SlikeList { get; set; } = new ObservableCollection<Model.RuteSlike>();
        public ObservableCollection<TuristRuteMobile> PreporuceneRuteList { get; set; } = new ObservableCollection<TuristRuteMobile>();

        private readonly INavigation Navigation;
        private int _TuristRutaId;
        private int _KorisnikId;

        private TuristRuteMobile _ruta;
        public TuristRuteMobile Ruta
        {
            get { return _ruta; }
            set { SetProperty(ref _ruta, value); }
        }


        bool _provjera = false;
        public bool Provjera
        {
            get { return _provjera; }
            set { SetProperty(ref _provjera, value); }
        }

        public int TrenutnaSlika { get; set; } = 0;

        private byte[] _prikazanaSlika;

        public byte[] PrikazanaSlika
        {
            get { return _prikazanaSlika; }
            set { SetProperty(ref _prikazanaSlika, value); }
        }

        public int Ocjene { get; set; }
        public ICommand InitCommand { get; set; }

        public TuristRuteDetailsVM(int TuristRutaId, int KorisnikId, INavigation navigation)
        {
            _TuristRutaId = TuristRutaId;
            _KorisnikId = KorisnikId;
            this.Navigation = navigation;
        }

        public async Task Init()
        {
            await UcitajRutaDetails();

            await UcitajSlike();

            List<TuristRuteMobile> listRute = await _servicePreporuka.GetById<List<TuristRuteMobile>>(_TuristRutaId);

            PreporuceneRuteList.Clear();
            foreach (var item in listRute)
            {
                PreporuceneRuteList.Add(item);
            }
        }

        private async Task UcitajRutaDetails()
        {
            var temp = await _serviceTuristRute.GetById<TuristRuteMobile>(_TuristRutaId);
            Title = temp.Naziv;

            temp.UkupnaCijena = temp.CijenaPaketa * temp.TrajanjePutovanja + temp.CijenaOsiguranja * temp.TrajanjePutovanja;
            Ruta = temp;
        }

        private async Task UcitajSlike()
        {
            var request = new Model.Requests.RuteSlikeSearchRequest
            {
                TuristRutaId = _TuristRutaId
            };

            var listSlike = await _serviceRuteSlike.Get<List<Model.RuteSlike>>(request);
            SlikeList.Clear();
            foreach (var item in listSlike)
            {
                SlikeList.Add(item);
            }

            if (listSlike.Count > 0)
            {
                PrikazanaSlika = listSlike[0].Slika;
            }
        }

        public async Task PozivPaymentaAsync()
        {
            await Navigation.PushAsync(new StripePaymentGatewayPage(_TuristRutaId, _KorisnikId));
            //var atif = Navigation.PushAsync(new StripePaymentGatewayPage(_TuristRutaId, _KorisnikId));
            //atif.Wait();
            //return atif.IsCompleted;
        }
        public async void AddRezervaciju()
        {
            var listPretplate = await _servicePretplate.Get<List<Pretplate>>(null);

            bool pretplacen = false;
            foreach(var x in listPretplate)
            {
                if (_ruta.KategorijaId == x.KategorijaId && x.KorisnikId == APIService.PrijavljeniKorisnik.KorisniciId)
                {
                    pretplacen = true;
                }
            }
            if (pretplacen)
            {
                var listRezervacijaZaUsera = await _serviceRezervacije.GetById<List<RezervacijeMobile>>(_KorisnikId, "GetUserRezervacije");
                bool ima = false;

                foreach(var x in listRezervacijaZaUsera)
                {
                    if (x.TuristRutaId == _TuristRutaId)
                    {
                        ima = true;
                    }
                }

                if(!ima)
                {
                    var request = new RezervacijeInsertRequest
                    {
                        TuristRutaId = _TuristRutaId,
                        KorisnikId = APIService.PrijavljeniKorisnik.KorisniciId,
                        DatumRezervacije = DateTime.Now
                    };

                    if (PozivPaymentaAsync().GetAwaiter().IsCompleted)
                    {
                        var entity = await _serviceRezervacije.Insert<Model.Rezervacije>(request);
                    }
                }
                else await Application.Current.MainPage.DisplayAlert("Obavijest", "Ne možete rezervisati isti turistički paket opet.", "OK");
                await Init();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Ne možete rezervisati putovanje na čiju kategoriju niste pretplaćeni!", "OK");
                await Init();
            }
        }
    }
}
