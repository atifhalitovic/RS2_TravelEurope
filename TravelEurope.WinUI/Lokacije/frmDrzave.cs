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

namespace TravelEurope.WinUI.Lokacije
{
    public partial class frmDrzave : Form
    {
        private readonly APIService _serviceDrzave = new APIService("Drzave");

        public frmDrzave()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.DrzaveSearchRequest
            {
                Naziv = txtNazivDrzave.Text
            };

            List<Model.Drzave> lista = await _serviceDrzave.Get<List<Model.Drzave>>(request);

            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.DataSource = lista;
        }

        private async void frmDrzava_Load(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async void dgvDrzava_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvDrzave.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmUrediDrzavu(id);
            frm.ShowDialog();
            await UcitajFormu();
        }

        private async void btnDodajDrzavu_Click(object sender, EventArgs e)
        {

            var frm = new frmDodajDrzavu();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }
    }
}
