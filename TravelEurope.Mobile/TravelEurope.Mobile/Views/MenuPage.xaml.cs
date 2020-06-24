using TravelEurope.Mobile.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TravelEurope.Mobile.ViewsCustom;

namespace TravelEurope.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Pretplate, Title="Pretplate na kategorije" },
                new HomeMenuItem {Id = MenuItemType.Ponuda, Title="Ponuda turist ruta" },
                new HomeMenuItem {Id = MenuItemType.Rezervacije, Title="Vaše rezervacije" },
                new HomeMenuItem {Id = MenuItemType.Poruke, Title="Vaše poruke" },
                new HomeMenuItem {Id = MenuItemType.Profil, Title="Profil" },
                new HomeMenuItem {Id = MenuItemType.Logout, Title="Logout" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                if (id == (int)MenuItemType.Logout)
                {
                    APIService.PrijavljeniKorisnik = null;
                    APIService.Username = null;
                    APIService.Password = null;
                    Application.Current.MainPage = new LoginPage();
                    return;
                }
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}