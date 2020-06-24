using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEurope.Model;

namespace TravelEurope.WinUI
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void PregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Korisnici.frmKorisnici();
            frm.Show();
        }

        private void PregledDrzavaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new Lokacije.frmDrzave();
            frm.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Korisnici.frmKorisniciDetalji();
            frm.Show();
        }

        private void pregledToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var frm = new TuristickeRute.frmTuristickeRute();
            frm.Show();
        }

        private void dodajTuristRutuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TuristickeRute.frmTuristickeRuteDodaj();
            frm.Show();
        }

        private void dodajDržavuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Lokacije.frmDodajDrzavu();
            frm.Show();
        }

        private void pregl_Click(object sender, EventArgs e)
        {
            var frm = new TuristickiVodici.frmTuristickiVodici();
            frm.Show();
        }

        private void dodajTurističkogVodičaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TuristickiVodici.frmTuristickiVodiciDetalji();
            frm.Show();
        }

        private void pregledToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new Destinacije.frmDestinacije();
            frm.Show();
        }

        private void dodajLokacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Destinacije.frmDestinacijeDetalji();
            frm.Show();
        }

        private void pregledToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var frm = new Rezervacije.frmRezervacije();
            frm.Show();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            var frm = new Korisnici.frmKorisnici();
            frm.Show();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            var frm = new TuristickeRute.frmTuristickeRute();
            frm.Show();
        }
    }
}
