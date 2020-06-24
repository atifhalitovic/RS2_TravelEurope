using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.Lokacije
{
    public partial class frmDodajDrzavu : Form
    {
        private readonly APIService _serviceDrzave = new APIService("Drzave");
        public frmDodajDrzavu()
        {
            InitializeComponent();
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.DrzaveInsertRequest
            {
                Naziv = txtNaziv.Text,

            };

            btnDodaj.Enabled = false;


            var entity = await _serviceDrzave.Insert<Model.Drzave>(request);
            if (entity != null)
            {
                MessageBox.Show("Država uspješno dodana.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
