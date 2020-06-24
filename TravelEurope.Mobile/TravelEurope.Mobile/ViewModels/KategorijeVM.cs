using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelEurope.Mobile.Models;
using TravelEurope.Model;
using TravelEurope.Model.Requests;
using Xamarin.Forms;

namespace TravelEurope.Mobile.ViewModels
{
    public class KategorijeVM : BaseViewModel
    {
        private readonly APIService _serviceKategorije = new APIService("Kategorije");
        private readonly APIService _servicePretplate = new APIService("Pretplate");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        public ObservableCollection<KategorijeMobile> KategorijeList { get; set; } = new ObservableCollection<KategorijeMobile>();
        public ObservableCollection<KategorijeMobile> PretplaceneKategorijeList { get; set; } = new ObservableCollection<KategorijeMobile>();
        public ObservableCollection<Pretplate> PretplateList { get; set; } = new ObservableCollection<Pretplate>();

        private readonly INavigation Navigation;
        public ICommand NavigateToSearchPageCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public ICommand PretplatiCommand { get; set; }
        public ICommand UkiniPretplatuCommand { get; set; }

        public KategorijeVM()
        {
            PretplatiCommand = new Command<KategorijeMobile>(async (obj) => await Pretplati(obj));
            UkiniPretplatuCommand = new Command<KategorijeMobile>(async (obj) => await UkiniPretplatu(obj));
        }

        public async Task Init()
        {
            APIService.PrijavljeniKorisnik = await _serviceKorisnici.Get<Model.Korisnici>(null, "MyProfile");
            var listKategorije = await _serviceKategorije.Get<List<KategorijeMobile>>(null);
            var listPretplate = await _servicePretplate.Get<List<Pretplate>>(null);
            var listPretplaceneKategorije = new List<KategorijeMobile>();

            foreach (var x in listKategorije)
            {
                foreach (var y in listPretplate)
                {
                    if (x.KategorijaId == y.KategorijaId && y.KorisnikId == APIService.PrijavljeniKorisnik.KorisniciId)
                    {
                        listPretplaceneKategorije.Add(x);
                    }
                }
            }

            PretplaceneKategorijeList.Clear();
            foreach (var item in listPretplaceneKategorije)
            {
                PretplaceneKategorijeList.Add(item);
            }
            PretplaceneKategorijeList.OrderBy(a => a.Naziv);

            KategorijeList.Clear();
            foreach (var item in listKategorije)
            {
                KategorijeList.Add(item);
            }
            KategorijeList.OrderBy(a => a.Naziv);
        }

        public async Task AddPretplate(PretplateInsertRequest request)
        {
            var entity = await _servicePretplate.Insert<Model.Pretplate>(request);
        }
        public async Task RemovePretplata(int id)
        {
            var success = await _servicePretplate.Remove(id);
            if (success)
            {
                await Init();
            }
        }
        public async Task Pretplati(KategorijeMobile obj)
        {
            PretplateInsertRequest korak = new PretplateInsertRequest();
            korak.KategorijaId = obj.KategorijaId;
            korak.KorisnikId = APIService.PrijavljeniKorisnik.KorisniciId;
            bool yes = false;

            foreach (var x in PretplaceneKategorijeList)
            {
                if (x.KategorijaId == korak.KategorijaId)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Ne možete se pretplatiti više puta na istu kategoriju!", "OK");
                    yes = true;
                    //await Init();
                }
            }
            if(yes==false)
            {
                await AddPretplate(korak);
                await Init();
            }
            await Init();
        }
        public async Task UkiniPretplatu(KategorijeMobile obj)
        {
            KategorijeMobile novi = obj;
            await RemovePretplata(novi.KategorijaId);
            await Init();
        }

        bool _provjera = false;
        public bool Provjera
        {
            get { return _provjera; }
            set { SetProperty(ref _provjera, value); }
        }
    }
}
