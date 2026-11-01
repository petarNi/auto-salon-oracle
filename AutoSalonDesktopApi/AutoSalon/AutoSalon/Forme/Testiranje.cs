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
    public partial class Testiranje : Form
    {
        public int salonId;
        public string brSasije;
        public string zapJMBG;
        public Fizicko Fizicko;
        public Pravno Pravno;
        public VoznjaDTO Voznja;

        private NovaDTO novaVozilo = null;
        private PolovnaDTO polovnaVozilo = null;
        private bool jePolovno = false;
        

        


        public Testiranje()
        {
            InitializeComponent();
        }

        public Testiranje(int id, string sasija, object vozilo)
        {
            InitializeComponent();
            salonId = id;
            brSasije = sasija;

            if (vozilo is NovaDTO nova)
            {
                novaVozilo = nova;
                jePolovno = false;
            }
            else if (vozilo is PolovnaDTO polovna)
            {
                polovnaVozilo = polovna;
                jePolovno = true;
            }
        }

        private void Testiranje_Load(object sender, EventArgs e)
        {
            List<ZaposleniDTO> zaposleni = DTOManager.VratiSveZaposlenePoSalonu(salonId);

            comboBox1.DisplayMember = "ImePrezime";
            comboBox1.ValueMember = "Jmbg";
            comboBox1.DataSource = zaposleni;

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                string jmbg = comboBox1.SelectedValue.ToString();
                zapJMBG = jmbg;
            }
        }

        public Kupac napraviKupca()
        {
            Kupac k = new Kupac();
            if (rbFizicko.Checked == true)
            {
                if(Fizicko != null)
                    Fizicko.Kupac = k;
            }

            if (rbPravno.Checked == true) {
                if (Pravno != null)
                     Pravno.Kupac = k;
            }

            return k;
        }
        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            if (rbPravno.Checked == true)
            {
                Pravno = new Pravno();
                Pravno.Emailovi = new List<string>();
                Pravno.Telefoni = new List<string>();
                Pravno.PIB = txtPIB.Text;
                Pravno.NazivFirme = txtNaziv.Text;
                Pravno.SedisteFirme = txtSediste.Text;
                Pravno.KontaktOsoba = txtKontakt.Text;
                Pravno.Emailovi.Add(txtEmailpravno.Text);
                Pravno.Telefoni.Add(txtTelPravno.Text);
            }
            if (rbFizicko.Checked == true)
            {
                Fizicko = new Fizicko();
                Fizicko.Emailovi = new List<string>();
                Fizicko.Telefoni = new List<string>();
                Fizicko.Licno_ime = txtIme.Text;
                Fizicko.Prezime = txtPrezime.Text;
                Fizicko.JMBG = txtJMBG.Text;
                Fizicko.Adresa = txtAdresa.Text;
                Fizicko.Emailovi.Add(txtEmailFiz.Text);
                Fizicko.Telefoni.Add(txtTelefonFiz.Text);
            }

            Voznja = new VoznjaDTO();
            Voznja.NovaVozila = new List<NovaDTO>();
            Voznja.PolovnaVozila = new List<PolovnaDTO>();

            Voznja.Datum = dateTimePicker1.Value;
            Voznja.Vreme_termina = txtTermin.Text;
            Voznja.Zaposleni = DTOManager.vratiZaposlenogPoJMBG(zapJMBG);
            Voznja.kupac = napraviKupca();
            if(novaVozilo != null)
            {
                Voznja.NovaVozila.Add(novaVozilo);
            }
            if(polovnaVozilo != null)
            {
                Voznja.PolovnaVozila.Add(polovnaVozilo);
            }

            DTOManager.rezervisiVoznju(Voznja);
            MessageBox.Show("Voznja rezervisana");
            Close();


        }

        private void rbPravno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPravno.Checked)
            {
                gbPravno.Visible = true; 
                gbFizicko.Visible = false; 
            }
        }

        private void rbFizicko_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFizicko.Checked)
            {
                gbFizicko.Visible = true;  
                gbPravno.Visible = false;  
            }
        }

     
    }
}
