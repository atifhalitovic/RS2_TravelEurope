using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEurope.Mobile.Models;
using TravelEurope.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.ViewsCustom
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RezervacijePage : ContentPage
	{
        public int _KorisnikId;
        private RezervacijeVM model = null;
		public RezervacijePage (int KorisnikId)
		{
			InitializeComponent ();
            _KorisnikId = KorisnikId;
            BindingContext = model = new RezervacijeVM(KorisnikId);
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RezervacijeMobile;
            var trenutniKorisnik = 1; // APIService.PrijavljeniKorisnik.KorisniciId;
            await Navigation.PushAsync(new RezervacijeDetailsPage(item.RezervacijaId, trenutniKorisnik, this.Navigation));
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}