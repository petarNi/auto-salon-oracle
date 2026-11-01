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
    public partial class SalonDodaj : Form
    {
        public SalonDodavanje salon;
        public SalonDodaj()
        {
            InitializeComponent();
            salon = new SalonDodavanje();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            salon.Naziv = txtNaziv.Text.Trim();
            salon.Adresa = txtAdresa.Text.Trim();
            salon.Telefon = txtTelefon.Text.Trim();
            salon.Radno_vreme = txtRadnoVreme.Text.Trim();
            salon.Proizvodjac = txtProizvodjac.Text.Trim();
            if (rbNovi.Checked)
                salon.Tip = "nova";
            else if (rbPolovni.Checked)
                salon.Tip = "polovna";
            else if (rbKomb.Checked)
                salon.Tip = "kombinovana";
            else
            {
                MessageBox.Show("Morate izabrati tip salona!");
                return;
            }

            if (int.TryParse(txtBrZaposlenih.Text.Trim(), out int broj))
            {
                salon.Broj_zaposlenih = broj;
            }
            else
            {
                MessageBox.Show("Unesite validan broj za broj zaposlenih!");
                return;
            }

            DTOManager.dodajSalon(salon);
            MessageBox.Show("Salon je uspešno dodat!");
            this.Close();
        }

        private void rbNovi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNovi.Checked)
            {
                txtProizvodjac.Enabled = true;
                salon.Tip = "nova";

            }
        }

        private void rbPolovni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPolovni.Checked)
            {
                txtProizvodjac.Enabled = false;
                salon.Tip = "polovna";

            }
        }

        private void rbKomb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKomb.Checked)
            {
                txtProizvodjac.Enabled = true;
                salon.Tip = "kombinovana";

            }
        }
    }
}
