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
    public partial class AzurirajVozilo : Form
    {
        private NovaDTO novaVozilo = null;
        private PolovnaDTO polovnaVozilo = null;
        private bool jePolovno = false;
        public AzurirajVozilo()
        {
            InitializeComponent();
        }

        public AzurirajVozilo(object vozilo)
        {
            InitializeComponent();

            if (vozilo is NovaDTO nova)
            {
                novaVozilo = nova;
                jePolovno = false;
                PopuniPoljaNova();
            }
            else if (vozilo is PolovnaDTO polovna)
            {
                polovnaVozilo = polovna;
                jePolovno = true;
                PopuniPoljaPolovna();
            }
        }
        private void PopuniPoljaNova()
        {
            txtBrSasije.Text = novaVozilo.BrSasije;
            txtMarka.Text = novaVozilo.Marka;
            txtModel.Text = novaVozilo.Model;
            txtGodProizvodnje.Text = novaVozilo.GodProizvodnje.ToString();
            txtSnagaMotora.Text = novaVozilo.SnagaMotora.ToString();
            txtKilometraza.Text = novaVozilo.Kilometraza.ToString();
            txtBrVrata.Text = novaVozilo.BrojVrata.ToString();
            txtBoja.Text = novaVozilo.Boja;
            txtTipGoriva.Text = novaVozilo.TipGoriva;
            txtCena.Text = novaVozilo.Cena.ToString();

            txtBrSasije.Enabled = false;

            grpPolovna.Visible = false;
        }

        private void PopuniPoljaPolovna()
        {
            txtBrSasije.Text = polovnaVozilo.BrSasije;
            txtMarka.Text = polovnaVozilo.Marka;
            txtModel.Text = polovnaVozilo.Model;
            txtGodProizvodnje.Text = polovnaVozilo.GodProizvodnje.ToString();
            txtSnagaMotora.Text = polovnaVozilo.SnagaMotora.ToString();
            txtKilometraza.Text = polovnaVozilo.Kilometraza.ToString();
            txtBrVrata.Text = polovnaVozilo.BrojVrata.ToString();
            txtBoja.Text = polovnaVozilo.Boja;
            txtTipGoriva.Text = polovnaVozilo.TipGoriva;
            txtCena.Text = polovnaVozilo.Cena.ToString();


            if (polovnaVozilo.DatumPoslednjeRegistracije.HasValue)
                dtpRegistracija.Value = polovnaVozilo.DatumPoslednjeRegistracije.Value;
            else
                dtpRegistracija.Value = DateTime.Today;
            txtIstorija.Text = polovnaVozilo.ServisnaIstorija;
            txtVlasnici.Text = polovnaVozilo.BrojPrethodnihVlasnika.ToString();

            txtBrSasije.Enabled = false;
        }



        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (jePolovno)
            {
                polovnaVozilo.Marka = txtMarka.Text;
                polovnaVozilo.Model = txtModel.Text;
                polovnaVozilo.GodProizvodnje = int.Parse(txtGodProizvodnje.Text);
                polovnaVozilo.SnagaMotora = int.Parse(txtSnagaMotora.Text);
                polovnaVozilo.Kilometraza = int.Parse(txtKilometraza.Text);
                polovnaVozilo.BrojVrata = int.Parse(txtBrVrata.Text);
                polovnaVozilo.Boja = txtBoja.Text;
                polovnaVozilo.TipGoriva = txtTipGoriva.Text;
                polovnaVozilo.Cena = int.Parse(txtCena.Text);
                polovnaVozilo.DatumPoslednjeRegistracije = dtpRegistracija.Value;
                polovnaVozilo.ServisnaIstorija = txtIstorija.Text;
                polovnaVozilo.BrojPrethodnihVlasnika = int.Parse(txtVlasnici.Text);

                DTOManager.IzmeniPolovnoVozilo(polovnaVozilo);
            }
            else
            {
                novaVozilo.Marka = txtMarka.Text;
                novaVozilo.Model = txtModel.Text;
                novaVozilo.GodProizvodnje = int.Parse(txtGodProizvodnje.Text);
                novaVozilo.SnagaMotora = int.Parse(txtSnagaMotora.Text);
                novaVozilo.Kilometraza = int.Parse(txtKilometraza.Text);
                novaVozilo.BrojVrata = int.Parse(txtBrVrata.Text);
                novaVozilo.Boja = txtBoja.Text;
                novaVozilo.TipGoriva = txtTipGoriva.Text;
                novaVozilo.Cena = int.Parse(txtCena.Text);
                DTOManager.IzmeniNovoVozilo(novaVozilo);
            }
            MessageBox.Show("Vozilo je uspešno izmenjeno.");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
