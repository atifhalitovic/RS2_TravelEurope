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
    public class TuristRuteVM : BaseViewModel
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _kategorijePutovanja = new APIService("Kategorije");
        private readonly APIService _servicePretplate = new APIService("Pretplate");

        public ObservableCollection<TuristRuteMobile> RuteList { get; set; } = new ObservableCollection<TuristRuteMobile>();

        private readonly INavigation Navigation;
        public ICommand NavigateToSearchPageCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public TuristRuteVM(INavigation navigation)
        {
            this.Navigation = navigation;
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            var listPretplate = await _servicePretplate.Get<List<Pretplate>>(null);

            var listTuristRute = await _serviceTuristRute.Get<List<TuristRuteMobile>>(null, "GetListSaSlikama");

            RuteList.Clear();
            foreach (var x in listTuristRute)
            {
                foreach (var y in listPretplate)
                {
                    if (x.KategorijaId == y.KategorijaId && y.KorisnikId == APIService.PrijavljeniKorisnik.KorisniciId)
                    {
                        RuteList.Add(x);
                    }
                }
            }
        }
    }
}
