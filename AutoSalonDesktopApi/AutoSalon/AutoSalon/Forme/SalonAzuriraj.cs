using AutoSalon.Entiteti;
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
    public partial class SalonAzuriraj : Form
    {
        public SalonDodavanje salon;
        public int salonId;
        public SalonAzuriraj()
        {  
            InitializeComponent();
        }

        public SalonAzuriraj(SalonDodavanje sal, int salonId)
        {
            InitializeComponent();
            this.salon = sal;
            this.salonId = salonId;
        }


        public void PopuniTextBoxove(SalonDodavanje salon)
        {
            txtNaziv.Text = salon.Naziv;
            txtAdresa.Text = salon.Adresa;
            txtTelefon.Text = salon.Telefon;
            txtRadnoVreme.Text = salon.Radno_vreme;
            txtBrZaposlenih.Text = salon.Broj_zaposlenih.ToString();
            txtProizvodjac.Text = salon.Proizvodjac;

            if (salon.Tip == "nova")
            {
                rbNovi.Checked = true;
            }
            else if (salon.Tip == "polovna")
            {
                rbPolovni.Checked = true;
            }
            else
            {
                rbKomb.Checked = true;
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            salon.Naziv = txtNaziv.Text;
            salon.Adresa = txtAdresa.Text;
            salon.Telefon = txtTelefon.Text;
            salon.Radno_vreme = txtRadnoVreme.Text;
            salon.Broj_zaposlenih =  Int32.Parse(txtBrZaposlenih.Text);
            salon.Proizvodjac = txtProizvodjac.Text;

            DTOManager.azurirajSalon(salon, salonId);
            MessageBox.Show("Salon je uspešno izmenjen.");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SalonAzuriraj_Load(object sender, EventArgs e)
        {
            PopuniTextBoxove(salon);

        }
    }
}
