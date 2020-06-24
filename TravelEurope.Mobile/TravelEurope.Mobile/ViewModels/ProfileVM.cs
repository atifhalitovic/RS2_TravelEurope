using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TravelEurope.Mobile.ViewModels
{

    public class ProfileVM : BaseViewModel
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        private Model.Requests.KorisniciUpdateProfilRequest _korisnik;

        public Model.Requests.KorisniciUpdateProfilRequest Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }

        public ICommand SaveProfileCommand { get; set; }

        public ProfileVM()
        {
            Title = "Profile";
            SaveProfileCommand = new Command(async () => await SaveProfile());
        }

        private async Task SaveProfile()
        {
            var entity = await _serviceKorisnici.Insert<Model.Korisnici>(Korisnik, "UpdateProfile");
            if (entity != null)
            {
                APIService.Username = Korisnik.KorisnickoIme;
                if (!string.IsNullOrWhiteSpace(Korisnik.Lozinka))
                {
                    APIService.Password = Korisnik.Lozinka;
                }
                await Application.Current.MainPage.DisplayAlert("Profil", "Profil je uspješno izmijenjen.", "OK");
            }
        }

        public async Task Init()
        {
            if (Korisnik == null)
                Korisnik = await _serviceKorisnici.Get<Model.Requests.KorisniciUpdateProfilRequest>(null, "MyProfile");
        }
    }
}
