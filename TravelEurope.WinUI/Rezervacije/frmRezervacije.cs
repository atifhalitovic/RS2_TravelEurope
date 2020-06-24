using TravelEurope.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceKategorije = new APIService("Kategorije");

        public frmRezervacije()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();

        }

        private async Task UcitajFormu()
        {
            var search = new Model.Requests.RezervacijeSearchRequest();
            if (chbDo.Checked)
            {
                search.DatumRezervacijeOd = dtpOd.Value;
            }
            if (chBOd.Checked)
            {
                search.DatumRezervacijeDo = dtpDo.Value;
            }
            List<Model.Rezervacije> lista = await _serviceRezervacije.Get<List<Model.Rezervacije>>(search);
            dgvRezervacija.AutoGenerateColumns = false;
            dgvRezervacija.DataSource = lista;
        }

        //Checkbox dozvoli/blokiraj unos datuma važenja rezervacije
        private void chBOd_CheckedChanged(object sender, EventArgs e)
        {
            if (chBOd.Checked)
                dtpOd.Enabled = true;
            else
                dtpOd.Enabled = false;
        }

        //Checkbox dozvoli/blokiraj unos datuma važenja rezervacije
        private void chbDo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDo.Checked)
                dtpDo.Enabled = true;
            else
                dtpDo.Enabled = false;
        }
        private void frmRezervacija_Load(object sender, EventArgs e)
        {
            dtpOd.Value = DateTime.Now.Date;
            dtpDo.Value = DateTime.Now.Date;
        }
    }
}