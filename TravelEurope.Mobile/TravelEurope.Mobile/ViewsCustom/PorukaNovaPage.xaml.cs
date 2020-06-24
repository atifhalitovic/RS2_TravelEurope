using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEurope.Mobile.ViewModels;
using TravelEurope.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.ViewsCustom
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PorukaNovaPage : ContentPage
	{
        private PorukeNovaVM model = null;
        private int _PosiljalacId;
        private int _PrimalacId;


        public PorukaNovaPage(int PosiljalacId, int PrimalacId)
        {
            InitializeComponent();
            _PosiljalacId = PosiljalacId;
            _PrimalacId = PrimalacId;
            BindingContext = model = new PorukeNovaVM(_PosiljalacId, PrimalacId);
        }

        public PorukaNovaPage()
        {
            InitializeComponent();
        }

        private async void ButtonPosalji_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste poslali poruku", "OK");
            await Navigation.PopAsync();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}