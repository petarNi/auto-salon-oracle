using AutoSalon.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalon.Forme
{
    public partial class Saloni : Form
    {
        public Saloni()
        {
            InitializeComponent();

        }


        public void PopuniListView(List<SalonPregled> saloniZaPrikaz)
        {
            listViewSaloni.Items.Clear();


            foreach (var sal in saloniZaPrikaz)
            {
                ListViewItem item = new ListViewItem(sal.Id.ToString());

                item.SubItems.Add(sal.Naziv);
                item.SubItems.Add(sal.Adresa);
                item.SubItems.Add(sal.Telefon);
                item.SubItems.Add(sal.Radno_vreme);
                item.SubItems.Add(sal.Broj_zaposlenih.ToString());
                item.SubItems.Add(sal.Proizvodjac);

                listViewSaloni.Items.Add(item);
            }
        }


        public List<SalonPregled> filtrirajSalone(string tipSalona)
        {
            List<SalonPregled> sSaloni = DTOManager.vratiSveSalone();
            List<SalonPregled> fSaloni = sSaloni.Where(s => s.Tip.ToLower() == tipSalona.ToLower()).ToList();

            return fSaloni;
        }

        private void Saloni_Load(object sender, EventArgs e)
        {
            List<SalonPregled> sviSaloni = DTOManager.vratiSveSalone();
            PopuniListView(sviSaloni);
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var filtiraniSaloni = filtrirajSalone("nova");
            PopuniListView(filtiraniSaloni);
        }

        private void btnPolovni_Click(object sender, EventArgs e)
        {
            var filtiraniSaloni = filtrirajSalone("polovna");
            PopuniListView(filtiraniSaloni);

        }

        private void btnKombinovani_Click(object sender, EventArgs e)
        {
            var filtiraniSaloni = filtrirajSalone("kombinovana");
            PopuniListView(filtiraniSaloni);
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {


            if (listViewSaloni.SelectedItems.Count > 0)
            {
                ListViewItem selektovani = listViewSaloni.SelectedItems[0];

                int id = int.Parse(selektovani.Text);

                ZaposleniPoSalonu zps = new ZaposleniPoSalonu(id);
                zps.Show();

            }
            else
            {
                MessageBox.Show("Morate izabrati salon.");
            }
        }

        private void btnDodajSalon_Click(object sender, EventArgs e)
        {
            SalonDodaj salonDodaj = new SalonDodaj();
            salonDodaj.Show();            
            DTOManager.vratiSveSalone();  
            
        }

        private void btnBezFiltera_Click(object sender, EventArgs e)
        {
            var sviSaloni = DTOManager.vratiSveSalone();
            PopuniListView(sviSaloni);
        }

        private void btnObrisiSalon_Click(object sender, EventArgs e)
        {

            if (listViewSaloni.SelectedItems.Count > 0)
            {
                ListViewItem selektovani = listViewSaloni.SelectedItems[0];

                

                int id = int.Parse(selektovani.Text);

                DTOManager.obrisiSalon(id);
                var msgbox = MessageBox.Show("Obrisali ste salon");

                if (msgbox == DialogResult.OK) {
                    DTOManager.vratiSveSalone();
                }

            }
            else
            {
                MessageBox.Show("Morate izabrati salon.");
            }

        }

        private void btnAzurirajSalon_Click(object sender, EventArgs e)
        {
            if (listViewSaloni.SelectedItems.Count > 0)
            {
                ListViewItem selektovani = listViewSaloni.SelectedItems[0];

                int id = int.Parse(selektovani.Text);

                SalonDodavanje salon =  DTOManager.vratiSalonPoId(id);
                SalonAzuriraj saf = new SalonAzuriraj(salon, id);
                saf.Show();                

            }
            else
            {
                MessageBox.Show("Morate izabrati salon.");
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {

            if (listViewSaloni.SelectedItems.Count > 0)
            {
                ListViewItem selektovani = listViewSaloni.SelectedItems[0];

                int id = int.Parse(selektovani.Text);

                VozilaPoSalonu vps = new VozilaPoSalonu(id);
                vps.Show();

            }
            else
            {
                MessageBox.Show("Morate izabrati salon.");
            }
        }

        private void btnKupci_Click(object sender, EventArgs e)
        {
            if (listViewSaloni.SelectedItems.Count > 0)
            {
                ListViewItem selektovani = listViewSaloni.SelectedItems[0];
                int id = int.Parse(selektovani.Text);

                KupciPoSalonu formaKupci = new KupciPoSalonu(id);
                formaKupci.Show();
            }
            else
            {
                MessageBox.Show("Morate izabrati salon.");
            }
        }
    }
}
