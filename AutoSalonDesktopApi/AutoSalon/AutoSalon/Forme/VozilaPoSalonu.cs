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
    public partial class VozilaPoSalonu : Form
    {

        public int salonId;
        private List<NovaDTO> novaVozila = new List<NovaDTO>();
        private List<PolovnaDTO> polovnaVozila = new List<PolovnaDTO>();

        public VozilaPoSalonu()
        {
            InitializeComponent();
        }
        public VozilaPoSalonu(int id)
        {
            InitializeComponent();
            this.salonId = id;
            UcitajVozila(salonId);

        }

        public void UcitajVozila(int salonId)
        {
            lvVozila.Items.Clear();

            List<NovaDTO> nVozila = DTOManager.VratiNovaVozilaZaSalon(salonId);
            List<PolovnaDTO> pVozila = DTOManager.VratiPolovnaVozilaZaSalon(salonId);

            foreach (NovaDTO vozilo in novaVozila)
            {
                ListViewItem item = new ListViewItem(vozilo.BrSasije);
                item.SubItems.Add(vozilo.Marka);
                item.SubItems.Add(vozilo.Model);
                item.SubItems.Add(vozilo.GodProizvodnje.ToString());
                item.SubItems.Add(vozilo.SnagaMotora.ToString());
                item.SubItems.Add(vozilo.Kilometraza.ToString());
                item.SubItems.Add(vozilo.BrojVrata.ToString());
                item.SubItems.Add(vozilo.Boja);
                item.SubItems.Add(vozilo.TipGoriva);

                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");

                item.SubItems.Add("Nova");
                item.SubItems.Add(vozilo.Cena.ToString());

                lvVozila.Items.Add(item);
            }

            foreach (PolovnaDTO vozilo in polovnaVozila)
            {
                ListViewItem item = new ListViewItem(vozilo.BrSasije);
                item.SubItems.Add(vozilo.Marka);
                item.SubItems.Add(vozilo.Model);
                item.SubItems.Add(vozilo.GodProizvodnje.ToString());
                item.SubItems.Add(vozilo.SnagaMotora.ToString());
                item.SubItems.Add(vozilo.Kilometraza.ToString());
                item.SubItems.Add(vozilo.BrojVrata.ToString());
                item.SubItems.Add(vozilo.Boja);
                item.SubItems.Add(vozilo.TipGoriva);

                item.SubItems.Add(vozilo.DatumPoslednjeRegistracije != null
                    ? vozilo.DatumPoslednjeRegistracije.Value.ToShortDateString()
                    : "");
                item.SubItems.Add(vozilo.ServisnaIstorija);
                item.SubItems.Add(vozilo.BrojPrethodnihVlasnika.ToString());

                item.SubItems.Add("Polovna");
                item.SubItems.Add(vozilo.Cena.ToString());

                lvVozila.Items.Add(item);
            }

            this.novaVozila = nVozila;
            this.polovnaVozila = pVozila;
        }

        private void PrikaziVozila(List<NovaDTO> nova, List<PolovnaDTO> polovna)
        {
            lvVozila.Items.Clear();

            

            foreach (NovaDTO v in nova)
            {
                ListViewItem item = new ListViewItem(v.BrSasije);
                item.SubItems.Add(v.Marka);
                item.SubItems.Add(v.Model);
                item.SubItems.Add(v.GodProizvodnje.ToString());
                item.SubItems.Add(v.SnagaMotora.ToString());
                item.SubItems.Add(v.Kilometraza.ToString());
                item.SubItems.Add(v.BrojVrata.ToString());
                item.SubItems.Add(v.Boja);
                item.SubItems.Add(v.TipGoriva);
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("Nova");
                item.SubItems.Add(v.Cena.ToString());
               

                lvVozila.Items.Add(item);
            }
            

            
            foreach (PolovnaDTO v in polovna)
            {
                ListViewItem item = new ListViewItem(v.BrSasije);
                item.SubItems.Add(v.Marka);
                item.SubItems.Add(v.Model);
                item.SubItems.Add(v.GodProizvodnje.ToString());
                item.SubItems.Add(v.SnagaMotora.ToString());
                item.SubItems.Add(v.Kilometraza.ToString());
                item.SubItems.Add(v.BrojVrata.ToString());
                item.SubItems.Add(v.Boja);
                item.SubItems.Add(v.TipGoriva);
                item.SubItems.Add(v.DatumPoslednjeRegistracije.HasValue
                    ? v.DatumPoslednjeRegistracije.Value.ToShortDateString()
                    : ""); item.SubItems.Add(v.ServisnaIstorija);
                item.SubItems.Add(v.BrojPrethodnihVlasnika.ToString());
                item.SubItems.Add("Polovna");
                item.SubItems.Add(v.Cena.ToString());

               
                lvVozila.Items.Add(item);
            }
            
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lvVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje želite da obrišete.");
                return;
            }

            ListViewItem item = lvVozila.SelectedItems[0];
            string brSasije = item.SubItems[0].Text;
            string tip = item.SubItems[12].Text;

            try
            {
                if (tip == "Nova")
                {
                    DTOManager.ObrisiNovoVozilo(brSasije);
                    novaVozila.RemoveAll(v => v.BrSasije == brSasije);
                    MessageBox.Show("Vozilo uspešno obrisano.");

                }
                else if (tip == "Polovna")
                {
                    DTOManager.ObrisiPolovnoVozilo(brSasije);
                    polovnaVozila.RemoveAll(v => v.BrSasije == brSasije);
                    MessageBox.Show("Vozilo uspešno obrisano.");
                }

                if (rbNova.Checked)
                    PrikaziVozila(novaVozila, new List<PolovnaDTO>());
                else if (rbPolovna.Checked)
                    PrikaziVozila(new List<NovaDTO>(), polovnaVozila);
                else
                    PrikaziVozila(novaVozila, polovnaVozila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void VozilaPoSalonu_Load(object sender, EventArgs e)
        {
            List<NovaDTO> svaNova = DTOManager.VratiNovaVozilaZaSalon(salonId);
            List<PolovnaDTO> svaPolovna = DTOManager.VratiPolovnaVozilaZaSalon(salonId);
            PrikaziVozila(svaNova, svaPolovna);
           

            UcitajVozila(salonId);
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (lvVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje želite da ažurirate.");
                return;
            }

            ListViewItem item = lvVozila.SelectedItems[0];
            object selektovano = null;
            string tip = item.SubItems[12].Text;

            if (tip == "Nova")
                selektovano = novaVozila.FirstOrDefault(v => v.BrSasije == item.SubItems[0].Text);
            else if (tip == "Polovna")
                selektovano = polovnaVozila.FirstOrDefault(v => v.BrSasije == item.SubItems[0].Text);

            if (selektovano != null)
            {
                AzurirajVozilo forma = new AzurirajVozilo(selektovano);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    UcitajVozila(salonId);
                    rbNova.Checked = false;
                    rbPolovna.Checked = false;
                }
            }
        }

 
  


        private void btnDodaj_Click(object sender, EventArgs e)
        {

            DodajVozilo forma = new DodajVozilo(salonId);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                UcitajVozila(salonId);
                rbNova.Checked = false;
                rbPolovna.Checked = false;
            }
        }

        private void rbNova_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNova.Checked)
            {
                PrikaziVozila(novaVozila, new List<PolovnaDTO>());
            }
        }

        private void rbPolovna_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPolovna.Checked)
            {
                PrikaziVozila(new List<NovaDTO>(), polovnaVozila);
            }
        }


        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            PrikaziVozila(novaVozila, polovnaVozila);
            rbNova.Checked = false;
            rbPolovna.Checked = false;
        }

        private void btnTestiraj_Click(object sender, EventArgs e)
        {
             if (lvVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje želite da ažurirate.");
                return;
            }

            ListViewItem item = lvVozila.SelectedItems[0];
            string brSasije = item.SubItems[0].Text;
            string tip = item.SubItems[12].Text;
            object selektovano = null;

            if (tip == "Nova")
                selektovano = novaVozila.FirstOrDefault(v => v.BrSasije == item.SubItems[0].Text);
            else if (tip == "Polovna")
                selektovano = polovnaVozila.FirstOrDefault(v => v.BrSasije == item.SubItems[0].Text);

            Testiranje t = new Testiranje(salonId, brSasije, selektovano);
            t.Show();
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            if (lvVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje želite da ažurirate.");
                return;
            }

            ListViewItem item = lvVozila.SelectedItems[0];
            string brSasije = item.SubItems[0].Text;
            string tip = item.SubItems[12].Text;
            object selektovano = null;
            bool kupljeno = false;

            if (tip == "Nova")
            {
                Nova voz = DTOManager.vratiNovo(brSasije);
                if(voz.Kupovina != null)
                {
                    MessageBox.Show("Ovo vozilo je vec kupljeno");
                    kupljeno = true;
                }
                selektovano = novaVozila.FirstOrDefault(v => v.BrSasije == item.SubItems[0].Text);
                
            }
            else if (tip == "Polovna")
            {
                Polovna pol = DTOManager.vratiPolovno(brSasije);
                if(pol.Kupovina != null)
                {
                    MessageBox.Show("Ovo vozilo je vec kupljeno");
                    kupljeno = true;
                }
                selektovano = polovnaVozila.FirstOrDefault(v => v.BrSasije == brSasije);
            }

            if (!kupljeno)
            {
                Kupi k = new Kupi(salonId, brSasije, selektovano);
                k.Show();
            }
        }

        private void lvVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
