using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.Destinacije
{
    public partial class frmDestinacije : Form
    {
        private readonly APIService _serviceLokacije = new APIService("Lokacije");
        private readonly APIService _serviceDrzave = new APIService("Drzave");

        public frmDestinacije()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await PretragaDestinacija();
        }

        private async Task PretragaDestinacija()
        {
            var request = new Model.Requests.LokacijeSearchRequest();
            var DrzaveObj = cmbSearchDrzave.SelectedValue;

            if (int.TryParse(DrzaveObj.ToString(), out int DrzavaId))
            {
                request.DrzavaId = DrzavaId;
            }

            request.Naziv = txtNazivDestinacije.Text;

            var lista = await _serviceLokacije.Get<List<Model.Lokacije>>(request);

            dgvDestinacije.AutoGenerateColumns = false;
            dgvDestinacije.DataSource = lista;
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.LokacijeSearchRequest
            {
                Naziv = txtNazivDestinacije.Text
            };

            List<Model.Lokacije> lista = await _serviceLokacije.Get<List<Model.Lokacije>>(request);

            dgvDestinacije.AutoGenerateColumns = false;
            dgvDestinacije.DataSource = lista;
        }

        private async void frmDestinacije_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
            await UcitajFormu();
        }

        private async Task LoadDrzave()
        {
            var listDrzave = await _serviceDrzave.Get<List<Model.Drzave>>(null);
            cmbSearchDrzave.DisplayMember = "Naziv";
            cmbSearchDrzave.DataSource = listDrzave;
            cmbSearchDrzave.ValueMember = "DrzavaId";
        }

        private async void dgvDestinacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvDestinacije.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmDestinacijeDetalji(id);
            frm.ShowDialog();
            await UcitajFormu();
        }

        private async void btnDodajDestinaciju_Click(object sender, EventArgs e)
        {

            var frm = new frmDestinacijeDetalji();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }
    }
}
