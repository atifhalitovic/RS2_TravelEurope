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

namespace TravelEurope.WinUI.TuristickiVodici
{
    public partial class frmTuristickiVodiciDetalji : Form
    {
        private readonly APIService _serviceVodici = new APIService("TuristickiVodici");
        private readonly APIService _serviceDrzave = new APIService("Drzave");
        private readonly APIService _serviceJezici = new APIService("StraniJezici");


        private int _id;

        public frmTuristickiVodiciDetalji(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.TuristickiVodiciInsertRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                StraniJezikId = (cmbJezici.SelectedItem as Model.StraniJezici).StraniJezikId,
            };

            if (_id == 0)
            {
                Model.TuristickiVodici entity = await _serviceVodici.Insert<Model.TuristickiVodici>(request);
                if (entity != null)
                {
                    MessageBox.Show("Turistički vodič uspješno dodan.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                Model.TuristickiVodici entity = await _serviceVodici.Update<Model.TuristickiVodici>(_id, request);
                if (entity != null)
                {
                    MessageBox.Show("Turistički vodič uspješno izmijenjen.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void frmTuristickeRuteDetalji_Load(object sender, EventArgs e)
        {
            var listJezici = await _serviceJezici.Get<List<Model.StraniJezici>>(null);

            cmbJezici.DataSource = listJezici;
            cmbJezici.DisplayMember = "Naziv";

            if (_id != 0)
                await UcitajDetaljeAsync();
        }

        private async Task UcitajDetaljeAsync()
        {
            var tr = await _serviceVodici.GetById<Model.TuristickiVodici>(_id);

            txtIme.Text = tr.Ime;
            txtPrezime.Text = tr.Prezime;
            foreach (Model.StraniJezici item in cmbJezici.Items)
            {
                if (item.StraniJezikId == tr.StraniJezikId)
                    cmbJezici.SelectedItem = item;
            }
        }
    }
}
