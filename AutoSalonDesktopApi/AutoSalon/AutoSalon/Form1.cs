using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using AutoSalon.Entiteti;
using System.Net.Http.Headers;

namespace AutoSalon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipVozila.Items.Add("Nova");
            cmbTipVozila.Items.Add("Polovna");
        }

        private void cmdUcitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AutoSalon.Entiteti.Salon salon = s.Load<AutoSalon.Entiteti.Salon>(1);

                MessageBox.Show(salon.Naziv);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Salon salon = new Entiteti.Salon();

                salon.Naziv = "PanicRent";
                salon.Adresa = "Narodnih heroja";
                salon.Tip_salona = "nova";
                salon.Broj_zaposlenih = 9;
                salon.Radno_vreme = "08-16";
                salon.Telefon = "064312686";
                salon.Proizvodjac = "Toyota";
                s.Save(salon);


                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AutoSalon.Entiteti.Salon salon = s.Load<AutoSalon.Entiteti.Salon>(1);

                foreach(Zaposleni z in salon.Zaposleni)
                {
                    MessageBox.Show(z.Licno_ime + " "+ z.Pozicija);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AutoSalon.Entiteti.Salon salon = s.Load<AutoSalon.Entiteti.Salon>(1);

                Zaposleni z = new Zaposleni();
                z.JMBG = "5874936528915";
                z.Licno_ime = "Milovanka";
                z.Prezime = "Dimic";
                z.Pozicija = "menadzer";
                z.Datum_funkcija = new DateTime(2024, 2,5);
                z.Emailovi.Add("milovanka@gmail.com");
                z.Telefoni.Add("0641185947");
                z.Salon = salon;


                s.Save(z);

                salon.Zaposleni.Add(z);
                s.Save(salon);

                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajFizicko_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac k = new Kupac();
                s.Save(k);
                s.Flush();

                Fizicko f = new Fizicko();

                f.JMBG = "1702756285657";
                f.Licno_ime = "Aca";
                f.Prezime = "Dimic";
                f.Adresa = "Bulevar Mladosti";
                f.Kupac = k;

                s.Save(f);
                s.Flush();
                s.Close();
                
            }
            catch(Exception ex)
            {   
                MessageBox.Show(ex.Message);
                
            }

        }

        private void cmdDodajPravno_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac k = new Kupac();
                s.Save(k);
                s.Flush();

                Pravno p = new Pravno();

                p.PIB = "325647893";
                p.SedisteFirme = "Njojork";
                p.KontaktOsoba = "Luka Dimic";
                p.NazivFirme = "Dexico";
                p.Kupac = k;

                s.Save(p);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmdDodajKupovinu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NacinPlacanja nk = new NacinPlacanja();
                nk.Tip = "gotovina";

                s.Save(nk);
                s.Flush();
                Promocija p = new Promocija();

                p.Naziv = "JESENJE SNIZENJE";
                p.Popust = 10;
                p.Period_trajanja = "03.08-17.08";
                p.Uslovi = "leasing";

                s.Save(p);
                s.Flush();
                Kupac k = s.Load<Entiteti.Kupac>(5);

                Kupovina kp = new Kupovina();
                kp.Placanje = nk;
                kp.Kupac = k;
                kp.Promocija = p;
                kp.Konacna_cena = 25000;

                s.Save(kp);
                s.Flush();
                MessageBox.Show("Kupovinu izvrsio" + " " + kp.Kupac.Kupac_Id + " " + "s promocijom" + kp.Promocija.Naziv + " " + "placeno" + " " + kp.Placanje.Tip);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Load<Salon>(1);
                //Kupovina kupovina = s.Load<Kupovina>(1);
                //Promocija promocija = s.Load<Promocija>(1);

                string izabraniTip = cmbTipVozila.SelectedItem.ToString();

                if (izabraniTip == "Nova")
                {
                    Nova novo = new Nova();

                    novo.Br_sasije = "JH4KA8260MC987654";
                    novo.Marka = "Skoda";
                    novo.Model = "Octavia";
                    novo.God_proizvodnje = 2024;
                    novo.Snaga_motora = 130;
                    novo.Tip_goriva = "benzin";
                    novo.Kilometraza = 0;
                    novo.Broj_vrata = 5;
                    novo.Boja = "Crna";
                    novo.Salon = salon;
                    //novo.Kupovina = kupovina;
                    //novo.Promocija = promocija;


                    s.Save(novo);
                }

                else if (izabraniTip == "Polovna")
                {
                    Polovna polovno = new Polovna();

                    polovno.Br_sasije = "1H4KA000000087654";
                    polovno.Marka = "Opel";
                    polovno.Model = "Astra";
                    polovno.God_proizvodnje = 2015;
                    polovno.Snaga_motora = 100;
                    polovno.Tip_goriva = "dizel";
                    polovno.Kilometraza = 150000;
                    polovno.Broj_vrata = 5;
                    polovno.Boja = "Plava";
                    polovno.Dat_poslednje_reg = new DateTime(2024, 1, 10);
                    polovno.Servisna_istorija = "Kompletna servisna istorija";
                    polovno.Br_preth_vlasnika = 1;
                    polovno.Salon = salon;
                    //polovno.Kupovina = kupovina;
                    //polovno.Promocija = promocija;


                    s.Save(polovno);
                }
                else
                {
                    MessageBox.Show("Izaberite tip vozila.");
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajVoznju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nova novo = s.Load<Entiteti.Nova>("JH4KA8260MC012345");
                Zaposleni z = s.Load<Entiteti.Zaposleni>("5874936528915");
                Kupac k = s.Load<Entiteti.Kupac>(5);

                TestVoznja tv = new TestVoznja();

                tv.NovaVozila.Add(novo);
                tv.Datum_termina = new DateTime(2024, 2, 10);
                tv.Vreme_termina = "20:00";
                tv.Ocena = 5;
                tv.Zakljucak = "Svidja mi se";
                tv.Zaposleni = z;
                tv.Kupac = k;

                k.Voznje.Add(tv);
                z.Voznje.Add(tv);
                novo.TestVoznja = tv;

                s.Save(tv);
                s.Flush();

                MessageBox.Show("Test voznju nadgledao " + z.JMBG + " " + " i kupio je kupac s id " + k.Kupac_Id);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            try
            {
                ISession s = DataLayer.GetSession();

                string tipVozila = cmbTipVozila.SelectedItem.ToString();

                Zaposleni z = s.Load<Zaposleni>("5874936528915");
                Kupac k = s.Load<Kupac>(5);

                TestVoznja tv = new TestVoznja();
                tv.Datum_termina = new DateTime(2024, 2, 10);
                tv.Vreme_termina = "20:00";
                tv.Ocena = 5;
                tv.Zakljucak = "Svidja mi se";
                tv.Zaposleni = z;
                tv.Kupac = k;

                if (tipVozila == "Nova")
                {
                    Nova novo = s.Load<Nova>("JH4KA8260MC012345");

                    if (novo.TestVoznja != null)
                    {
                        MessageBox.Show("Ovo vozilo ima test voznju.");
                        s.Close();
                        return;
                    }

                    tv.NovaVozila.Add(novo);
                    novo.TestVoznja = tv;
                }
                else if (tipVozila == "Polovna")
                {
                    Polovna polovno = s.Load<Polovna>("1H4KA000000087654");

                    if (polovno.TestVoznja != null)
                    {
                        MessageBox.Show("Ovo vozilo ima test voznju.");
                        s.Close();
                        return;
                    }

                    tv.PolovnaVozila.Add(polovno);
                    polovno.TestVoznja = tv;
                }
                else
                {
                    MessageBox.Show("Morate izabrati tip vozila.");
                    s.Close();
                    return;
                }

                z.Voznje.Add(tv);
                k.Voznje.Add(tv);

                s.Save(tv);
                s.Flush();
                s.Close();

                MessageBox.Show("Test voznju nadgledao " + z.JMBG + " " + " i kupio je kupac s id " + k.Kupac_Id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
