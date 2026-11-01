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
    public partial class ZaposleniPoSalonu : Form
    {
        public int salonId;
        public ZaposleniPoSalonu()
        {
            InitializeComponent();
        }

        public ZaposleniPoSalonu(int id)
        {
            InitializeComponent();
            salonId = id;
            cmbPozicija.Items.Add("menadzer");
            cmbPozicija.Items.Add("prodavac");
            cmbPozicija.Items.Add("serviser");
            cmbPozicija.Items.Add("finansijski savetnik");

            UcitajSveZaposlene();
        }

        private void UcitajSveZaposlene()
        {
            lbZaposleni.DataSource = DTOManager.VratiSveZaposlenePoSalonu(salonId);
            lbZaposleni.DisplayMember = "Prikaz";

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lbZaposleni.SelectedItem is ZaposleniDTO selektovani)
            {
                try
                {
                    DTOManager.ObrisiZaposlenog(selektovani.JMBG);
                    MessageBox.Show("Zaposleni obrisan.");
                    UcitajSveZaposlene();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Izaberite zaposlenog za brisanje.");
            }
        }

        private void cmbPozicija_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izabranaPozicija = cmbPozicija.SelectedItem.ToString();
            //lbZaposleni.Items.Clear();
            List<ZaposleniDTO> filtrirani = DTOManager.VratiZaposlenePoPoziciji(salonId,izabranaPozicija);

            /*foreach (ZaposleniDTO z in filtrirani)
            {
                lbZaposleni.Items.Add(z);
            }*/
            lbZaposleni.DataSource = filtrirani;
            lbZaposleni.DisplayMember = "Prikaz";
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (lbZaposleni.SelectedItem is ZaposleniDTO selektovani)
            {
                AzurirajZaposlenog forma = new AzurirajZaposlenog(selektovani);
                forma.ShowDialog();
                UcitajSveZaposlene();
            }
            else
            {
                MessageBox.Show("Izaberite zaposlenog koga želite da ažurirate.");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenog formaDodaj = new DodajZaposlenog(salonId);
            if (formaDodaj.ShowDialog() == DialogResult.OK)
            {
                UcitajSveZaposlene();
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
