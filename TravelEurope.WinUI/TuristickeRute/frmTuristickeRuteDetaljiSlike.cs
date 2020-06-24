using TravelEurope.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.TuristickeRute
{
    public partial class frmTuristickeRuteDetaljiSlike : Form
    {
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");
        private int _id;
        private int _TuristRutaId;

        private RuteSlikeInsertRequest request = new RuteSlikeInsertRequest();

        public frmTuristickeRuteDetaljiSlike(int id, int TuristRutaId)
        {
            _id = id;
            _TuristRutaId = TuristRutaId;
            InitializeComponent();
        }

        private async void frmRuteDodajSlike_Load(object sender, EventArgs e)
        {
            if (_id != 0)
                await UcitajDetalje();
        }


        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.Opis = txtOpis.Text;
            request.TuristRutaId = _TuristRutaId;

            if (_id == 0)
            {
                var entity = await _serviceRuteSlike.Insert<Model.RuteSlike>(request);
                if (entity != null)
                {
                    MessageBox.Show("Slika uspješno dodana.");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceRuteSlike.Update<Model.RuteSlike>(_id, request);
                if (entity != null)
                {
                    MessageBox.Show("Slika uspješno izmijenjena.");
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private async Task UcitajDetalje()
        {
            var slika = await _serviceRuteSlike.GetById<Model.RuteSlike>(_id);

            txtOpis.Text = slika.Opis;
            request.Slika = slika.Slika;
            request.SlikaThumb = slika.SlikaThumb;

            byte[] image = slika.Slika;
            MemoryStream ms = new MemoryStream(image);
            pbSlika.Image = Image.FromStream(ms);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image originalImage = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                originalImage.Save(ms, ImageFormat.Jpeg);

                request.Slika = ms.ToArray();

                Image resizedImage = originalImage;
                resizedImage = ImageHelper.ResizeImage(originalImage, new Size(200, 200));

                ms = new MemoryStream();
                resizedImage.Save(ms, ImageFormat.Jpeg);
                request.SlikaThumb = ms.ToArray();

                pbSlika.Image = originalImage;
            }
        }
    }

}
