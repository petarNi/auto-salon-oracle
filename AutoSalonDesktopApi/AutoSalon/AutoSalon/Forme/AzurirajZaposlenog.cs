using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalon.Forme
{
    public partial class AzurirajZaposlenog : Form
    {
        private ZaposleniDTO zaposleni;
        public AzurirajZaposlenog(ZaposleniDTO z)
        {
            InitializeComponent();

            cmbPozicija.Items.Add("menadzer");
            cmbPozicija.Items.Add("prodavac");
            cmbPozicija.Items.Add("serviser");
            cmbPozicija.Items.Add("finansijski savetnik");

            this.zaposleni = z;
            PopuniPolja();
        }

        private void PopuniPolja()
        {
            txtIme.Text = zaposleni.Ime;
            txtPrezime.Text = zaposleni.Prezime;
            cmbPozicija.SelectedItem = zaposleni.Pozicija;

            dtpDatumZaposlenja.Value = zaposleni.DatumZaposlenja;
            dtpDatumFunkcije.Value = zaposleni.DatumFunkcije ?? DateTime.Today;

            txtBrojProdatih.Text = zaposleni.BrojProdatih?.ToString() ?? "";
            txtOcenaKupaca.Text = zaposleni.OcenaKupaca?.ToString() ?? "";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            zaposleni.Ime = txtIme.Text;
            zaposleni.Prezime = txtPrezime.Text;
            zaposleni.Pozicija = cmbPozicija.SelectedItem.ToString();
            zaposleni.DatumZaposlenja = dtpDatumZaposlenja.Value;
            zaposleni.DatumFunkcije = dtpDatumFunkcije.Value;

            if (int.TryParse(txtBrojProdatih.Text, out int brojProdatih))
                zaposleni.BrojProdatih = brojProdatih;
            else
                zaposleni.BrojProdatih = null;

            if (int.TryParse(txtOcenaKupaca.Text, out int ocena))
                zaposleni.OcenaKupaca = ocena;
            else
                zaposleni.OcenaKupaca = null;

            try
            {
                DTOManager.AzurirajZaposlenog(zaposleni);
                MessageBox.Show("Zaposleni uspešno ažuriran.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPozicija_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pozicija = cmbPozicija.SelectedItem.ToString();

            dtpDatumFunkcije.Enabled = (pozicija == "menadzer");
            txtBrojProdatih.Enabled = txtOcenaKupaca.Enabled = (pozicija == "prodavac");
        }
    }
}
