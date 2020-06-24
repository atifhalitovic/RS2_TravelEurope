using TravelEurope.Mobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TravelEurope.Mobile.ViewsCustom;

namespace TravelEurope.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public int KorisnikId;
        public MainPage(int Korisnik)
        {
            InitializeComponent();
            KorisnikId = Korisnik;
            MasterBehavior = MasterBehavior.Popover;
            //MenuPages.Add((int)MenuItemType.Pretplate, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Pretplate:
                        MenuPages.Add(id, new NavigationPage(new KategorijePage()));
                        break;
                    case (int)MenuItemType.Ponuda:
                        MenuPages.Add(id, new NavigationPage(new TuristRutePage()));
                        break;
                    case (int)MenuItemType.Rezervacije:
                        MenuPages.Add(id, new NavigationPage(new RezervacijePage(KorisnikId)));
                        break;
                    case (int)MenuItemType.Poruke:
                        MenuPages.Add(id, new NavigationPage(new SaputniciPorukePage(KorisnikId)));
                        break;
                    case (int)MenuItemType.Profil:
                        MenuPages.Add(id, new NavigationPage(new ProfilePage()));
                        break;
                    case (int)MenuItemType.Logout:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}