using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.KorisniciSearchRequest
            {
                ImePrezime = txtImePrezime.Text
            };

            List<Model.Korisnici> lista = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);

            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = lista;
        }

        private async void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            var frm = new Korisnici.frmKorisniciDetalji();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmKorisniciDetalji(id);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }
    }
}
