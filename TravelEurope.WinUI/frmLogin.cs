using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            try
            {
                APIService.PrijavljeniKorisnik = await _service.Get<Model.Korisnici>(null, "MyProfile");
                if(APIService.PrijavljeniKorisnik.Uloga.Naziv == "Administrator")
                {
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    throw new Exception("Unos nije ispravan");
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
