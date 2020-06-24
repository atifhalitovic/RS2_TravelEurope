using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEurope.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.ViewsCustom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijeDetailsPage : ContentPage
    {
        private int _rezervacijaId;
        private int _korisnikId;
        private RezervacijeDetailsVM model;
        private readonly INavigation Navigation;

        public RezervacijeDetailsPage(int rezervacijaId, int korisnikId, INavigation Navigation)
        {
            InitializeComponent();
            _rezervacijaId = rezervacijaId;
            _korisnikId = korisnikId;
            this.Navigation = Navigation;
            BindingContext = model = new RezervacijeDetailsVM(_korisnikId, _rezervacijaId, Navigation);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}
