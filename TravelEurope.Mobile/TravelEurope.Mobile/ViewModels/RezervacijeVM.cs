using TravelEurope.Mobile.Models;
using TravelEurope.Mobile.ViewsCustom;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TravelEurope.Model.Requests;
using TravelEurope.Model;

namespace TravelEurope.Mobile.ViewModels
{
    public class RezervacijeVM : BaseViewModel
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");

        public ObservableCollection<RezervacijeMobile> RezervacijeList { get; set; } = new ObservableCollection<RezervacijeMobile>();
        //public ObservableCollection<RezervacijeMobile> RezervacijeListZavrsene { get; set; } = new ObservableCollection<RezervacijeMobile>();

        private readonly INavigation Navigation;
        public ICommand InitCommand { get; set; }
        public ICommand NavigateToSearchPageCommand { get; set; }
        private int _KorisnikId { get; set; }

        public RezervacijeVM(int KorisnikId)
        {
            _KorisnikId = KorisnikId;
        }

        private int ukupnoRezervacija;
        //private int ukupnoRezervacijaUToku;
        //private int ukupnoRezervacijaZavrsenih;
        private decimal ukupnoUtroseno;

        public int UkupnoRezervacija
        {
            set { SetProperty(ref ukupnoRezervacija, value); }
            get { return ukupnoRezervacija; }
        }
        //public int UkupnoRezervacijaUToku
        //{
        //    set { SetProperty(ref ukupnoRezervacijaUToku, value); }
        //    get { return ukupnoRezervacijaUToku; }
        //}
        //public int UkupnoRezervacijaZavrsenih
        //{
        //    set { SetProperty(ref ukupnoRezervacijaZavrsenih, value); }
        //    get { return ukupnoRezervacijaZavrsenih; }
        //}
        public decimal UkupnoUtroseno
        {
            set { SetProperty(ref ukupnoUtroseno, value); }
            get { return ukupnoUtroseno; }
        }


        public async Task Init()
        {
            List<RezervacijeMobile> listRezervacije;
            if (_KorisnikId != 0)
            {
                listRezervacije = await _serviceRezervacije.GetById<List<RezervacijeMobile>>(APIService.PrijavljeniKorisnik.KorisniciId, "GetUserRezervacije");
            }
            else
            {
                listRezervacije = await _serviceRezervacije.Get<List<RezervacijeMobile>>(null, "GetMyRezervacije");
            }

            int brojRezervacija = 0;
            //uToku = 0, Zavrsene = 0;
            decimal ukupno = 0;

            RezervacijeList.Clear();
            foreach (var item in listRezervacije)
            {
                RezervacijeList.Add(item);
                //uToku++;
                //Zavrsene++;
                ukupno += item.TuristRuta.CijenaPaketa * item.TuristRuta.TrajanjePutovanja + item.TuristRuta.CijenaOsiguranja * item.TuristRuta.TrajanjePutovanja;
                brojRezervacija++;
            }
            UkupnoRezervacija = brojRezervacija;
            //UkupnoRezervacijaUToku = uToku;
            //UkupnoRezervacijaZavrsenih = Zavrsene;
            UkupnoUtroseno = ukupno;
        }
    }
}
