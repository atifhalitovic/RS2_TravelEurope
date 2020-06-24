using TravelEurope.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TravelEurope.Mobile.ViewsCustom;
using TravelEurope.Model;

namespace TravelEurope.Mobile.ViewModels
{
    public class RezervacijeDetailsVM : BaseViewModel
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");
        private readonly APIService _serviceOcjene = new APIService("Ocjene");
        private readonly APIService _serviceRecenzije = new APIService("Recenzije");

        public ObservableCollection<Model.RuteSlike> SlikeList { get; set; } = new ObservableCollection<Model.RuteSlike>();
        public ICommand UkiniRezervacijuCommand { get; set; }

        private int _RezervacijaId;
        private int _KorisnikId;

        private readonly INavigation Navigation;

        public RezervacijeMobile _rezervacija;
        public RezervacijeMobile Rezervacija
        {
            get { return _rezervacija; }
            set { SetProperty(ref _rezervacija, value); }
        }

        public DateTime DatumPovratka { get; set; }
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

        public int Ocjena { get; set; }

        #region stars

        private Star _star1;
        public Star Star1
        {
            get { return _star1; }
            set { SetProperty(ref _star1, value); }
        }
        private Star _star2;
        public Star Star2
        {
            get { return _star2; }
            set { SetProperty(ref _star2, value); }
        }
        private Star _star3;
        public Star Star3
        {
            get { return _star3; }
            set { SetProperty(ref _star3, value); }
        }
        private Star _star4;
        public Star Star4
        {
            get { return _star4; }
            set { SetProperty(ref _star4, value); }
        }
        private Star _star5;
        public Star Star5
        {
            get { return _star5; }
            set { SetProperty(ref _star5, value); }
        }

        #endregion

        public ICommand InitCommand { get; set; }
        public ICommand OcijeniStarCommand { get; set; }

        public RezervacijeDetailsVM(int KorisnikId, int RezervacijaId, INavigation Navigation)
        {
            this.Navigation = Navigation;
            _RezervacijaId = RezervacijaId;
            _KorisnikId = KorisnikId;
            OcijeniStarCommand = new Command<string>(async (Ocjena) => await OcijeniStar(Ocjena, _RezervacijaId));
            UkiniRezervacijuCommand = new Command(async () => await UkiniRezervaciju());

            Star1 = new Star();
            Star2 = new Star();
            Star3 = new Star();
            Star4 = new Star();
            Star5 = new Star();
        }

        public async Task UkiniRezervaciju()
        {
            await RemoveRezervacija(_RezervacijaId);
            await Navigation.PushAsync(new RezervacijePage(_KorisnikId));
        }

        public async Task RemoveRezervacija(int id)
        {
            var success = await _serviceRezervacije.Remove(id);
            await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste obrisali rezervaciju, vraćamo vas na prethodnu stranicu.", "OK");
        }


        private void UpdateZvjezdice()
        {
            var star_emptyinside = new Star { Slika = "star_empty.png" };
            var Star_Filled = new Star { Slika = "star_filled.png" };

            Star1 = star_emptyinside;
            Star2 = star_emptyinside;
            Star3 = star_emptyinside;
            Star4 = star_emptyinside;
            Star5 = star_emptyinside;

            if (Ocjena >= 1)
                Star1 = Star_Filled;
            if (Ocjena >= 2)
                Star2 = Star_Filled;
            if (Ocjena >= 3)
                Star3 = Star_Filled;
            if (Ocjena >= 4)
                Star4 = Star_Filled;
            if (Ocjena == 5)
                Star5 = Star_Filled;
        }

        private async Task OcijeniStar(string _ocjena, int RezervacijaId)
        {
            int OcjenaBroj = int.TryParse(_ocjena, out int value) ? value : 0;
            if (OcjenaBroj >= 1 && OcjenaBroj <= 5)
            {
                var request = new Model.Requests.OcjeneInsertRequest
                {
                    RezervacijaId = _RezervacijaId,
                    Ocjena = OcjenaBroj
                };

                Ocjena = OcjenaBroj;

                UpdateZvjezdice();

                await _serviceOcjene.Insert<Model.Ocjene>(request, "OcijeniRutu");

                await UcitajRutaDetails();
            }
        }

        public async Task Init()
        {
            await UcitajRutaDetails();

            UpdateZvjezdice();

            await UcitajSlike();
        }

        private async Task UcitajRutaDetails()
        {
            var temp = await _serviceRezervacije.GetById<RezervacijeMobile>(_RezervacijaId);
            Title = temp.TuristRuta.Naziv;

            Ocjena = await UcitajOcjene(_RezervacijaId);
            temp.UkupnaCijena = temp.TuristRuta.CijenaPaketa * temp.TuristRuta.TrajanjePutovanja + temp.TuristRuta.CijenaOsiguranja * temp.TuristRuta.TrajanjePutovanja;
            temp.DatumPovratka = temp.TuristRuta.DatumPutovanja.AddDays(temp.TuristRuta.TrajanjePutovanja);
            Rezervacija = temp;

            var request = new Model.Requests.OcjeneSearchRequest
            {
                RezervacijaId = temp.RezervacijaId,
                KorisnikId = APIService.PrijavljeniKorisnik.KorisniciId
            };

            var PostojecaOcjena = await _serviceOcjene.Get<Model.Ocjene>(request);
            if(PostojecaOcjena==null)
            {
                Ocjena = 0;
            }
            else if (PostojecaOcjena.Ocjena != Ocjena)
            {
                Ocjena = PostojecaOcjena.Ocjena;
            }
        }

        private async Task<int> UcitajOcjene(int id)
        {
            var requestOcjene = new Model.Requests.OcjeneSearchRequest();
            requestOcjene.RezervacijaId = id;
            requestOcjene.KorisnikId = APIService.PrijavljeniKorisnik.KorisniciId;

            Ocjene _ocjene = null;
            try
            {
                _ocjene = await _serviceOcjene.Get<Model.Ocjene>(requestOcjene);
            }
            catch
            {

            }
            if (_ocjene == null) return 0;
            return _ocjene.Ocjena;
        }

        private async Task UcitajSlike()
        {
            var request = new Model.Requests.RuteSlikeSearchRequest
            {
                TuristRutaId = Rezervacija.TuristRutaId
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
    }
}
