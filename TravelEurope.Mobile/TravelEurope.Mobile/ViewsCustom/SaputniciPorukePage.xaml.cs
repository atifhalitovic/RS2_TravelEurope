using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEurope.Mobile.Models;
using TravelEurope.Mobile.ViewModels;
using TravelEurope.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.ViewsCustom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SaputniciPorukePage : ContentPage
    {
        private PorukeVM model = null;
        private int KorisnikId;
        public SaputniciPorukePage(int KorisnikId)
        {
            InitializeComponent();
            BindingContext = model = new PorukeVM(KorisnikId);
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RezervacijeMobile;
            int trenutniKorisnikId = APIService.PrijavljeniKorisnik.KorisniciId;
            await Navigation.PushAsync(new PorukaNovaPage(trenutniKorisnikId, item.KorisnikId));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}
