using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.TuristickiVodici
{
    public partial class frmTuristickiVodici : Form
    {
        private readonly APIService _serviceVodici = new APIService("TuristickiVodici");
        private readonly APIService _serviceJezici = new APIService("StraniJezici");

        public frmTuristickiVodici()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await PretragaVodica();
        }

        private async Task PretragaVodica()
        {
            var request = new Model.Requests.TuristickiVodiciSearchRequest();
            var JeziciObj = cmbSearchJezici.SelectedValue;

            if (int.TryParse(JeziciObj.ToString(), out int StraniJezikId))
            {
                request.StraniJezikId = StraniJezikId;
            }

            request.Ime = txtImeVodica.Text;

            var lista = await _serviceVodici.Get<List<Model.TuristickiVodici>>(request);

            dgvVodici.AutoGenerateColumns = false;
            dgvVodici.DataSource = lista;
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.TuristickiVodiciSearchRequest
            {
                Ime = txtImeVodica.Text
            };

            List<Model.TuristickiVodici> lista = await _serviceVodici.Get<List<Model.TuristickiVodici>>(request);

            dgvVodici.AutoGenerateColumns = false;
            dgvVodici.DataSource = lista;
        }

        private async void frmTuristickiVodic_Load(object sender, EventArgs e)
        {
            await LoadStraniJezici();
            await UcitajFormu();
        }

        private async Task LoadStraniJezici()
        {
            var listJezici = await _serviceJezici.Get<List<Model.StraniJezici>>(null);
            cmbSearchJezici.DisplayMember = "Naziv";
            cmbSearchJezici.DataSource = listJezici;
            cmbSearchJezici.ValueMember = "StraniJezikId";
        }

        private async void dgvTuristickiVodic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvVodici.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmTuristickiVodiciDetalji(id);
            frm.ShowDialog();
            await UcitajFormu();
        }

        private async void btnDodajVodica_Click(object sender, EventArgs e)
        {

            var frm = new frmTuristickiVodiciDetalji();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }
    }
}
