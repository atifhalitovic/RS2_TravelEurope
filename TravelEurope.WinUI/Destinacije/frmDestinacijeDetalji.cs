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

namespace TravelEurope.WinUI.Destinacije
{
    public partial class frmDestinacijeDetalji : Form
    {
        private readonly APIService _serviceDrzave = new APIService("Drzave");
        private readonly APIService _serviceLokacije = new APIService("Lokacije");

        private int _id;

        public frmDestinacijeDetalji(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.LokacijeInsertRequest
            {
                Naziv = txtNaziv.Text,
                DrzavaId = (cmbDrzave.SelectedItem as Model.Drzave).DrzavaId,
            };

            if (_id == 0)
            {
                Model.Lokacije entity = await _serviceLokacije.Insert<Model.Lokacije>(request);
                if (entity != null)
                {
                    MessageBox.Show("Destinacija uspješno dodana.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                Model.Lokacije entity = await _serviceLokacije.Update<Model.Lokacije>(_id, request);
                if (entity != null)
                {
                    MessageBox.Show("Destinacija uspješno izmijenjena.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void frmTuristickeRuteDetalji_Load(object sender, EventArgs e)
        {
            var listDrzave = await _serviceDrzave.Get<List<Model.Drzave>>(null);

            cmbDrzave.DataSource = listDrzave;
            cmbDrzave.DisplayMember = "Naziv";

            if (_id != 0)
                await UcitajDetaljeAsync();
        }

        private async Task UcitajDetaljeAsync()
        {
            var tr = await _serviceLokacije.GetById<Model.Lokacije>(_id);

            txtNaziv.Text = tr.Naziv;
            foreach (Model.Drzave item in cmbDrzave.Items)
            {
                if (item.DrzavaId == tr.DrzavaId)
                    cmbDrzave.SelectedItem = item;
            }
        }
    }
}
