using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TravelEurope.Mobile.Views;
using TravelEurope.Mobile.ViewsCustom;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TravelEurope.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
            //MainPage = new NavigationPage(new StripePaymentGatewayPage(13,1));
            //MainPage = new NavigationPage(new RezervacijePage(1));
            //MainPage = new NavigationPage(new TuristRutePage());
            //MainPage = new NavigationPage(new SaputniciPorukePage(1));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
