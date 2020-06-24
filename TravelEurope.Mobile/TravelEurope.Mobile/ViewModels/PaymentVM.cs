using System;
using System.Collections.Generic;
using System.Text;
using Acr.UserDialogs;
using TravelEurope.Mobile.Models;
using TravelEurope.Mobile.ViewsCustom;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Stripe;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using TravelEurope.Model.Requests;
using TravelEurope.Model;
using TravelEurope.Mobile.Views;
using System.Windows.Input;

namespace TravelEurope.Mobile.ViewModels
{
    public class PaymentVM : BindableBase
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");
        private readonly APIService _serviceOcjene = new APIService("Ocjene");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private readonly APIService _serviceRecenzije = new APIService("Recenzije");

        public ObservableCollection<Model.RuteSlike> SlikeList { get; set; } = new ObservableCollection<Model.RuteSlike>();

        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;


        private int _TuristRutaId;
        private int _KorisnikId;

        public TuristRuteMobile _ruta;
        public TuristRuteMobile Ruta
        {
            get { return _ruta; }
            set { SetProperty(ref _ruta, value); }
        }

        public Korisnici _korisnik;
        public Korisnici Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }

        private string StripeTestApiKey = "pk_test_Lv9kMJZk4ns08GJOPriyuXVO00a24FlJLh";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        private readonly INavigation Navigation;

        public PaymentVM(int TuristRutaId, int KorisnikId, INavigation nav)
        {
            _TuristRutaId = TuristRutaId;
            _KorisnikId = KorisnikId;
            this.Navigation = nav;
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
        }

        public PaymentVM()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            await UcitajPodatkeZaUplatu();
        }

        private async Task UcitajPodatkeZaUplatu()
        {
            var temp = await _serviceTuristRute.GetById<TuristRuteMobile>(_TuristRutaId);
            temp.UkupnaCijena = temp.CijenaPaketa * temp.TrajanjePutovanja + temp.CijenaOsiguranja * temp.TrajanjePutovanja;
            temp.DatumPovratka = temp.DatumPutovanja.AddDays(temp.TrajanjePutovanja);
            Ruta = temp;
            Korisnik = APIService.PrijavljeniKorisnik;
        }

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateTokenAsync();
                    Console.Write("TravelEurope" + "Token :" + Token);
                    if (Token.ToString() != null)
                    {
                        IsTransectionSuccess = await MakePaymentAsync(Token.Result);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("TravelEurope" + ex.Message);
            }
            finally
            {
                if (IsTransectionSuccess)
                {
                    await Navigation.PushAsync(new TuristRutePage());
                    Console.Write("TravelEurope" + "Payment Successful ");
                    UserDialogs.Instance.HideLoading();
                }
                else
                {

                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                    Console.Write("TravelEurope" + "Payment Failure ");
                }
            }

        });

        private async Task<string> CreateTokenAsync()
        {
            await UcitajPodatkeZaUplatu();
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = Korisnik.KorisnickoIme,
                        AddressLine1 = "Marka Marulića",
                        AddressLine2 = "23",
                        AddressCity = Korisnik.Grad.Naziv,
                        AddressZip = "88000",
                        AddressState = "Starmo",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "bam",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> MakePaymentAsync(string token)
        {
            await UcitajPodatkeZaUplatu();
            var stringUkupnaCijena = Convert.ToInt32(Ruta.UkupnaCijena);
            string kpnCijena = stringUkupnaCijena.ToString();
            string nazivRute = "Uplata za " + Ruta.Naziv + " " + Ruta.DatumPutovanja.ToShortDateString();
            try
            {
                StripeConfiguration.ApiKey = "sk_test_u5PVeLrvvFRQGj89siYcIEpw00fedaueHy";
                var options = new ChargeCreateOptions();

                options.Amount = (long)float.Parse(kpnCijena);
                options.Currency = "bam";
                options.Description = nazivRute;
                options.Source = stripeToken.Id;
                options.StatementDescriptor = "Custom descriptor";
                options.Capture = true;
                options.ReceiptEmail = Korisnik.Email.ToString();
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                UserDialogs.Instance.Alert("Uspješno ste platili putovanje. Vraćamo vas ponudu turističkih ruta.");
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("TravelEurope (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
            }
            return true;
        }
    }
}