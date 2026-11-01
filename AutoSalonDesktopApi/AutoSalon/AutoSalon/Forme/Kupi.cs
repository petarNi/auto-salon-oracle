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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoSalon.Forme
{
    public partial class Kupi : Form
    {
        public string NacinPlacanja;
        public int salonId;
        public int promId;
        public string brSasije;
        public Fizicko Fizicko;
        public Pravno Pravno;

        private NovaDTO novaVozilo = null;
        private PolovnaDTO polovnaVozilo = null;
        private bool jePolovno = false;

        public Kupi()
        {
            InitializeComponent();
        }

        public Kupi(int id, string sasija, object vozilo)
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

        private void cmbPromocije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPromocije.SelectedValue != null)
            {
                 promId = Int32.Parse(cmbPromocije.SelectedValue.ToString());                 
            }
        }

        private void rbGotovina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGotovina.Checked == true) 
            {
                NacinPlacanja = "gotovina";
                btnKupi.Enabled = true;
            }
        }

        private void rbKredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKredit.Checked == true) 
            {
                NacinPlacanja = "kredit";
                btnKupi.Enabled = true;
            }
        }

        private void rbLeasing_CheckedChanged(object sender, EventArgs e)
        {
            if(rbLeasing.Checked == true) 
            {
                NacinPlacanja = "leasing"; 
                btnKupi.Enabled = true;
            }
        }

        public Kupac napraviKupca()
        {
            Kupac k = new Kupac();
            if (rbFizicko.Checked == true)
            {
                if (Fizicko != null)
                    Fizicko.Kupac = k;
            }

            if (rbPravno.Checked == true)
            {
                if (Pravno != null)
                    Pravno.Kupac = k;
            }

            return k;
        }

        private void btnKupi_Click(object sender, EventArgs e)
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

            

            KupovinaDTO kupovina = new KupovinaDTO();


            kupovina.Kupac = napraviKupca();
            NacinPlacanja p = new NacinPlacanja();
            p.Tip = NacinPlacanja;
            kupovina.Placanje = p;
            kupovina.Promocija = DTOManager.vratiPromociju(promId);
            
            int konacnaCena =  DTOManager.obaviKupovinu(kupovina, Pravno, Fizicko, brSasije, salonId);
            
            MessageBox.Show("Vozilo je kupljeno. Konacna cena " + konacnaCena);
            Close();
            

        }

        private void Kupi_Load(object sender, EventArgs e)
        {
            List<PromocijaDTO> promocije = new List<PromocijaDTO>();
            promocije = DTOManager.vratiSvePromocije();

            cmbPromocije.DisplayMember = "Prikaz";
            cmbPromocije.ValueMember = "PromId";
            cmbPromocije.DataSource = promocije;

            btnKupi.Enabled = false;
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
