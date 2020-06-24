using TravelEurope.Mobile.Models;
using TravelEurope.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TravelEurope.Mobile.ViewModels
{
    public class TuristRuteSearchViewModel : BaseViewModel
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceOcjene = new APIService("Ocjene");

        public ObservableCollection<TuristRuteMobile> RuteList { get; set; } = new ObservableCollection<TuristRuteMobile>();
        private string _searchText;

        private TuristickeRuteSearchRequest Request = new TuristickeRuteSearchRequest();

        public ICommand SearchCommand { get; set; }

        public string SearchText
        {
            get { return _searchText; }
            set { SetProperty(ref _searchText, value); }
        }

        //public TuristRuteSearchViewModel(TuristickeRuteSearchRequest request = null)
        //{
        //    Title = "Search Rute";

        //    SearchCommand = new Command(async () => await Search());
        //    SearchCommand.Execute(null);
        //}

        //public async Task Search()
        //{
        //    Request.Naziv = SearchText;

        //    var listTuristRute = await _serviceTuristRute.Get<List<TuristRuteMobile>>(Request, "GetListSaSlikama");

        //    RuteList.Clear();
        //    foreach (var item in listTuristRute)
        //    {
        //        item.OcjenaKorisnika = await UcitajOcjene(item.TuristRutaId);
        //        RuteList.Add(item);
        //    }
        //}


        //private async Task<float> UcitajOcjene(int IgraId)
        //{
        //    var requestOcjene = new Model.Requests.OcjeneSearchRequest
        //    {
        //        IgraId = IgraId
        //    };
        //    var Ocjene = await _serviceOcjene.Get<List<Model.Ocjene>>(requestOcjene);
        //    if (Ocjene.Count == 0)
        //        return 0;

        //    double suma = 0;
        //    foreach (var item in Ocjene)
        //    {
        //        suma += item.Ocjena;
        //    }

        //    int prosjekInt = (int)(suma / Ocjene.Count * 100);

        //    return prosjekInt / (float)100;

        //}
    }
}
