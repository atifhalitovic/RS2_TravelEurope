using TravelEurope.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TravelEurope.Model.Requests;
using System.Linq;
using System.Security.Cryptography;

namespace TravelEurope.Mobile.ViewModels
{
    public class LoginVM : BaseViewModel
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        public int KorisnikId;

        public LoginVM()
        {
            LoginCommand = new Command(async () => await Login());
            Title = "Login";
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                APIService.PrijavljeniKorisnik = await _serviceKorisnici.Get<Model.Korisnici>(null, "MyProfile");
                var k = APIService.PrijavljeniKorisnik;

                KorisnikId = k.KorisniciId;
                Application.Current.MainPage = new MainPage(KorisnikId);
            }
            catch (Exception)
            {
                //string msg = "";
                //if (ex.InnerException != null)
                //    msg = ex.InnerException.ToString() + " - ";
                //await Application.Current.MainPage.DisplayAlert("Greška", msg + ex.Message, "OK");
            }
        }
    }
}
