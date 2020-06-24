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
using TravelEurope.Model.Requests;
using TravelEurope.WinUI.Helper;

namespace TravelEurope.WinUI.TuristickeRute
{
    public partial class frmTuristickeRute : Form
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceKategorije = new APIService("Kategorije");

        public frmTuristickeRute()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await PretragaRuta();
        }

        private async Task PretragaRuta()
        {
            var request = new Model.Requests.TuristRuteSearchRequest();
            var KategorijeObj = cmbSearchKategorija.SelectedValue;

            if (int.TryParse(KategorijeObj.ToString(), out int KategorijaId))
            {
                request.KategorijaId = KategorijaId;
            }

            request.Naziv = txtNazivRute.Text;

            var result = await _serviceTuristRute.Get<List<Model.TuristRute>>(request);
            dgvTuristRuta.AutoGenerateColumns = false;
            dgvTuristRuta.DataSource = result;
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.TuristRuteSearchRequest
            {
                Naziv = txtNazivRute.Text
            };

            List<Model.TuristRute> lista = await _serviceTuristRute.Get<List<Model.TuristRute>>(request);

            dgvTuristRuta.AutoGenerateColumns = false;
            dgvTuristRuta.DataSource = lista;
        }

        private async void frmTuristRuta_Load(object sender, EventArgs e)
        {
            await LoadKategorijaVozila();
            await UcitajFormu();
        }

        private async Task LoadKategorijaVozila()
        {
            var listKategorije = await _serviceKategorije.Get<List<Model.Kategorije>>(null);
            cmbSearchKategorija.DisplayMember = "Naziv";
            cmbSearchKategorija.DataSource = listKategorije;
            cmbSearchKategorija.ValueMember = "KategorijaId";
        }

        private async void btnDodajRutu_Click(object sender, EventArgs e)
        {

            var frm = new frmTuristickeRuteDodaj();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }

        private async void dgvTuristRuta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvTuristRuta.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmTuristickeRuteDetalji(id);
            frm.ShowDialog();
            await UcitajFormu();
        }
    }
}
