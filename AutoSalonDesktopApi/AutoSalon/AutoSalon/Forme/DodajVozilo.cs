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
    public partial class DodajVozilo : Form
    {
        private int salonId;

        public DodajVozilo()
        {
            InitializeComponent();
        }
        public DodajVozilo(int salonId)
        {
            InitializeComponent();
            this.salonId = salonId;

            cmbGorivo.Items.Add("benzin");
            cmbGorivo.Items.Add("dizel");
            cmbGorivo.Items.Add("električni");
            cmbGorivo.SelectedIndex = 0;
            rbNovo.Checked = true;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (rbNovo.Checked)
            {
                NovaDTO novo = new NovaDTO
                {
                    BrSasije = txtBrSasije.Text,
                    Marka = txtModel.Text,
                    Model = txtMarka.Text,
                    GodProizvodnje = int.Parse(txtGodProizvodnje.Text),
                    SnagaMotora = int.Parse(txtSnagaMotora.Text),
                    Kilometraza = int.Parse(txtKilometraza.Text),
                    BrojVrata = int.Parse(txtBrVrata.Text),
                    Boja = txtBoja.Text,
                    TipGoriva = cmbGorivo.SelectedItem.ToString(),
                    Cena = int.Parse(txtCena.Text),
                    SalonId = salonId
                };

                DTOManager.DodajNovoVozilo(novo);
                MessageBox.Show("Uspesno ste dodali vozilo");
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (rbPolovno.Checked)
            {
                string servisna = txtIstorija.Text;
                int brojVlasnika = int.Parse(txtVlasnici.Text);
                DateTime datumReg = dtpRegistracija.Value;
                PolovnaDTO polovno = new PolovnaDTO
                {
                    BrSasije = txtBrSasije.Text,
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    GodProizvodnje = int.Parse(txtGodProizvodnje.Text),
                    SnagaMotora = int.Parse(txtSnagaMotora.Text),
                    Kilometraza = int.Parse(txtKilometraza.Text),
                    BrojVrata = int.Parse(txtBrVrata.Text),
                    Boja = txtBoja.Text,
                    TipGoriva = cmbGorivo.SelectedItem.ToString(),
                    Cena = int.Parse(txtCena.Text),
                    SalonId = salonId,
                    DatumPoslednjeRegistracije = datumReg,
                    ServisnaIstorija = servisna,
                    BrojPrethodnihVlasnika = brojVlasnika
                };

                DTOManager.DodajPolovnoVozilo(polovno);
                MessageBox.Show("Uspesno ste dodali vozilo");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbNovo_CheckedChanged(object sender, EventArgs e)
        {
            txtIstorija.Enabled = !rbNovo.Checked;
            dtpRegistracija.Enabled = !rbNovo.Checked;
            txtVlasnici.Enabled = !rbNovo.Checked;

        }
    }
}
