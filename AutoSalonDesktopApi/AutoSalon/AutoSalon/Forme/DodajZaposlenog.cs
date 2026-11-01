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
    public partial class DodajZaposlenog : Form
    {
        public int salonId;
        public DodajZaposlenog(int id)
        {
            salonId = id;
            InitializeComponent();
            cmbPozicija.Items.Add("menadzer");
            cmbPozicija.Items.Add("prodavac");
            cmbPozicija.Items.Add("serviser");
            cmbPozicija.Items.Add("finansijski savetnik");

            cmbPozicija.SelectedIndex = 0;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string jmbg = txtJMBG.Text.Trim();
            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string pozicija = cmbPozicija.SelectedItem.ToString();
            DateTime datumZaposlenja = dtpDatumZaposlenja.Value;

            DateTime? datumFunkcije = null;
            int? brojProdatih = null;
            int? ocenaKupaca = null;

            if (pozicija == "menadzer")
            {
                datumFunkcije = dtpDatumFunkcije.Value;
            }
            else if (pozicija == "prodavac")
            {
                if (int.TryParse(txtBrojProdatih.Text, out int broj))
                    brojProdatih = broj;

                if (int.TryParse(txtOcenaKupaca.Text, out int ocena))
                    ocenaKupaca = ocena;
            }

            try
            {
                ZaposleniDTO novi = new ZaposleniDTO(
                    jmbg,
                    pozicija,
                    datumZaposlenja,
                    ime,
                    prezime,
                    datumFunkcije,
                    brojProdatih,
                    ocenaKupaca
                );

                DTOManager.DodajZaposlenog(salonId, novi);
                MessageBox.Show("Zaposleni dodat.");
                DTOManager.VratiSveZaposlenePoSalonu(salonId);
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
