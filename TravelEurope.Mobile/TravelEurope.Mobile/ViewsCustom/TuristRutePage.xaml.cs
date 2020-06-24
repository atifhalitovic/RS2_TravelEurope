using TravelEurope.Mobile.Models;
using TravelEurope.Mobile.ViewModels;
using TravelEurope.Mobile.ViewsCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TuristRutePage : ContentPage
    {
        private TuristRuteVM model = null;
        public TuristRutePage()
        {
            InitializeComponent();
            BindingContext = model = new TuristRuteVM(this.Navigation);
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as TuristRuteMobile;
            int trenutniKorisnikId = APIService.PrijavljeniKorisnik.KorisniciId;
            await Navigation.PushAsync(new TuristRuteDetailsPage(item.TuristRutaId, trenutniKorisnikId));
        }

        private void FilterToolbarItem_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new TuristRuteFilterPage());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}