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
using TravelEurope.WinUI.Helper;

namespace TravelEurope.WinUI.TuristickeRute
{
    public partial class frmTuristickeRuteDetalji : Form
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceLokacije = new APIService("Lokacije");
        private readonly APIService _serviceVodici = new APIService("TuristickiVodici");
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");
        private readonly APIService _serviceKategorije = new APIService("Kategorije");

        private int _id;
        TuristRuteInsertRequest NovaRutaRequest = new TuristRuteInsertRequest();

        public frmTuristickeRuteDetalji(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private async void frmTuristickeRuteDetalji_Load(object sender, EventArgs e)
        {
            await LoadLokacije();
            await LoadKategorije();
            await LoadVodice();
            if (_id != 0)
                await UcitajDetaljeAsync();

            await UcitajListuSlika();

            if (_id != 0)
                await UcitajDetaljeAsync();
        }

        private async Task LoadLokacije()
        {
            var listLokacije = await _serviceLokacije.Get<List<Model.Lokacije>>(null);
            cmbLokacije.DisplayMember = "Naziv";
            cmbLokacije.DataSource = listLokacije;
        }

        private async Task LoadVodice()
        {
            var listVodici = await _serviceVodici.Get<List<Model.TuristickiVodici>>(null);
            cmbVodici.DisplayMember = "ImePrezimeJezik";
            cmbVodici.DataSource = listVodici;
        }

        private async Task LoadKategorije()
        {
            var listKategorije = await _serviceKategorije.Get<List<Model.Kategorije>>(null);
            cmbKategorije.DisplayMember = "Naziv";
            cmbKategorije.DataSource = listKategorije;
        }

        private async Task UcitajDetaljeAsync()
        {
            var tr = await _serviceTuristRute.GetById<Model.TuristRute>(_id);

            txtNaziv.Text = tr.Naziv;
            txtOpis.Text = tr.Opis;
            cmbLokacije.Text = tr.Lokacija.Naziv;
            cmbKategorije.Text = tr.Kategorija.Naziv;
            cmbVodici.Text = tr.TuristickiVodic.Ime;
            cmbTrajanjePutovanja.Text = tr.TrajanjePutovanja.ToString();
            txtCijenaIznajmljivanja.Text = tr.CijenaPaketa.ToString();
            txtCijenaOsiguranja.Text = tr.CijenaOsiguranja.ToString();
            dtpDatumPolaska.Value = tr.DatumPutovanja;
            dtpDatumPolaska.MaxDate = new DateTime(2030, 1, 1);


            foreach (Model.Lokacije item in cmbLokacije.Items)
            {
                if (item.LokacijaId == tr.LokacijaId)
                    cmbLokacije.SelectedItem = item;
            }
            foreach (Model.TuristickiVodici item in cmbVodici.Items)
            {
                if (item.TuristickiVodicId == tr.TuristickiVodicId)
                    cmbVodici.SelectedItem = item;
            }
            foreach (Model.Kategorije item in cmbKategorije.Items)
            {
                if (item.KategorijaId == tr.KategorijaId)
                    cmbKategorije.SelectedItem = item;
            }
        }

        private async void btnDodajVodica_Click(object sender, EventArgs e)
        {
            var frm = new TuristickiVodici.frmTuristickiVodiciDetalji();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listVodici = await _serviceVodici.Get<List<Model.TuristickiVodici>>(null);
                cmbVodici.DataSource = listVodici;
            }
        }

        private async void btnDodajDrzavu_Click(object sender, EventArgs e)
        {
            var frm = new Lokacije.frmDodajDrzavu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listDrzave = await _serviceLokacije.Get<List<Model.Drzave>>(null);
                cmbLokacije.DataSource = listDrzave;
            }
        }

        private async Task UcitajListuSlika()
        {
            var requestRuteSlike = new Model.Requests.RuteSlikeSearchRequest
            {
                TuristRutaId = _id
            };
            var listRuteSlike = await _serviceRuteSlike.Get<List<Model.RuteSlike>>(requestRuteSlike);
            dgvSlike.AutoGenerateColumns = false;
            dgvSlike.DataSource = listRuteSlike;
        }

        private async void dgvSlike_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvSlike.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmTuristickeRuteDetaljiSlike(id, _id);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajListuSlika();
        }

        private async void btnIzbrisiSliku_Click(object sender, EventArgs e)
        {
            var RuteSlikeId = int.Parse(dgvSlike.SelectedRows[0].Cells[0].Value.ToString());

            var success = await _serviceRuteSlike.Remove(RuteSlikeId);
            if (success)
            {
                MessageBox.Show("Slika je izbrisana.");
                await UcitajListuSlika();
            }
        }

        private void dgvSlike_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dgvSlike.SelectedRows.Count;
            if (rowsCount == 0)
                btnIzbrisiSliku.Enabled = false;
            else
                btnIzbrisiSliku.Enabled = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool provjera = this.ValidateChildren();
            if (provjera)
            {
                NovaRutaRequest.TuristRutaId = _id;
                NovaRutaRequest.Naziv = txtNaziv.Text;
                NovaRutaRequest.Opis = txtOpis.Text;
                NovaRutaRequest.TuristickiVodicId = (cmbVodici.SelectedItem as Model.TuristickiVodici).TuristickiVodicId;
                NovaRutaRequest.LokacijaId = (cmbLokacije.SelectedItem as Model.Lokacije).LokacijaId;
                NovaRutaRequest.KategorijaId = (cmbKategorije.SelectedItem as Model.Kategorije).KategorijaId;
                NovaRutaRequest.DatumPutovanja = dtpDatumPolaska.Value;
                NovaRutaRequest.TrajanjePutovanja = int.Parse(cmbTrajanjePutovanja.SelectedItem.ToString());
                NovaRutaRequest.CijenaPaketa = decimal.Parse(txtCijenaIznajmljivanja.Text);
                NovaRutaRequest.CijenaOsiguranja = decimal.Parse(txtCijenaOsiguranja.Text);

                if (_id == 0)
                {
                    Model.TuristRute entity = await _serviceTuristRute.Insert<Model.TuristRute>(NovaRutaRequest);
                    if (entity != null)
                    {
                        MessageBox.Show("Turist ruta uspješno dodana.");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    Model.TuristRute entity = await _serviceTuristRute.Update<Model.TuristRute>(_id, NovaRutaRequest);
                    if (entity != null)
                    {
                        MessageBox.Show("Turist ruta uspješno izmijenjena.");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }

        private async void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var frm = new frmTuristickeRuteDetaljiSlike(0, _id);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajListuSlika();
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {

        }
    }
}
