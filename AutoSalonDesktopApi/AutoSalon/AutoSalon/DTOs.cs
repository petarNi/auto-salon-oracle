using AutoSalon.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AutoSalon
{

    #region Saloni
    public class SalonPregled
    {
        public int Id;
        public string Tip;
        public string Naziv;
        public string Adresa;
        public string Telefon;
        public string Radno_vreme;
        public int Broj_zaposlenih;
        public string Proizvodjac;

        public SalonPregled()
        {

        }
        public SalonPregled(int id, string tip, string naziv, string adresa, string telefon, string radno_vreme, int broj_zaposlenih, string proizvodjac){
            if(tip == "polovna")
            {
                proizvodjac = null;
            }
            Id = id;
            Tip = tip;
            Naziv = naziv;
            Adresa = adresa;
            Telefon = telefon;
            Radno_vreme = radno_vreme;
            Broj_zaposlenih = broj_zaposlenih;
            Proizvodjac = proizvodjac;
        }

    }

    public class SalonDodavanje
    {
        public string Tip;
        public string Naziv;
        public string Adresa;
        public string Telefon;
        public string Radno_vreme;
        public int Broj_zaposlenih;
        public string Proizvodjac;

        public SalonDodavanje()
        {

        }
        public SalonDodavanje(string tip, string naziv, string adresa, string telefon, string radno_vreme, int broj_zaposlenih, string proizvodjac)
        {
            if (tip == "polovna")
            {
                proizvodjac = null;
            }
            Tip = tip;
            Naziv = naziv;
            Adresa = adresa;
            Telefon = telefon;
            Radno_vreme = radno_vreme;
            Broj_zaposlenih = broj_zaposlenih;
            Proizvodjac = proizvodjac;
        }

    }

    #endregion

    #region Zaposleni
    public class ZaposleniDTO
    {
        public string JMBG;
        public string Pozicija;
        public DateTime DatumZaposlenja;
        public string Ime;
        public string Prezime;
        public DateTime? DatumFunkcije;
        public int? BrojProdatih;
        public int? OcenaKupaca;

        public ZaposleniDTO()
        {

        }

        public ZaposleniDTO(string jmbg, string pozicija, DateTime datumZaposlenja, string ime, string prezime, DateTime? datumFunkcije = null, int? brojProdatih = null, int? ocenaKupaca = null)
        {
            this.JMBG = jmbg;
            this.Pozicija = pozicija;
            this.DatumZaposlenja = datumZaposlenja;
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumFunkcije = datumFunkcije;
            this.BrojProdatih = brojProdatih;
            this.OcenaKupaca = ocenaKupaca;
        }

        //svojstva za prikaz
        public string ImePrezime => $"{Ime}{Prezime}";
        public string Jmbg => $"{JMBG}";

        public string Prikaz
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{JMBG} | {Ime} {Prezime} | {Pozicija} | {DatumZaposlenja.ToShortDateString()}");

                if (DatumFunkcije.HasValue)
                    sb.Append($" | Datum funkcije: {DatumFunkcije.Value.ToShortDateString()}");

                if (BrojProdatih.HasValue)
                    sb.Append($" | Broj prodatih: {BrojProdatih}");

                if (OcenaKupaca.HasValue)
                    sb.Append($" | Ocena: {OcenaKupaca}");

                return sb.ToString();
            }
        }
    }

    #endregion

    #region Vozila

    public class NovaDTO
    {
        public string BrSasije;
        public string Model;
        public string Marka;
        public int GodProizvodnje;
        public int SnagaMotora;
        public int Kilometraza;
        public int BrojVrata;
        public string Boja;
        public string TipGoriva;
        public int Cena;

        public int SalonId;
        public string Tip => "Nova";

        public NovaDTO()
        {

        }

        public NovaDTO(string brSasije, string model, string marka, int godProizvodnje, int snagaMotora, int kilometraza, int brojVrata, string boja, string tipGoriva, int cena, int salonId)
        {
            this.BrSasije = brSasije;
            this.Model = model;
            this.Marka = marka;
            this.GodProizvodnje = godProizvodnje;
            this.SnagaMotora = snagaMotora;
            this.Kilometraza = kilometraza;
            this.BrojVrata = brojVrata;
            this.Boja = boja;
            this.TipGoriva = tipGoriva;
            this.Cena = cena;
            this.SalonId = salonId;
        }
    }
    public class PolovnaDTO
    {
        public string BrSasije;
        public string Model;
        public string Marka;
        public int GodProizvodnje;
        public int SnagaMotora;
        public int Kilometraza;
        public int BrojVrata;
        public string Boja;
        public string TipGoriva;
        public int Cena;
        public DateTime? DatumPoslednjeRegistracije;
        public string ServisnaIstorija;
        public int BrojPrethodnihVlasnika;

        public int SalonId;
        public string Tip => "Polovna";

        public PolovnaDTO()
        {

        }

        public PolovnaDTO(string brSasije, string model, string marka, int godProizvodnje, int snagaMotora, int kilometraza, int brojVrata, string boja, string tipGoriva,int cena, int salonId, DateTime datumPoslednjeRegistracije, string servisnaIstorija, int brojPrethodnihVlasnika)
        {
            this.BrSasije = brSasije;
            this.Model = model;
            this.Marka = marka;
            this.GodProizvodnje = godProizvodnje;
            this.SnagaMotora = snagaMotora;
            this.Kilometraza = kilometraza;
            this.BrojVrata = brojVrata;
            this.Boja = boja;
            this.TipGoriva = tipGoriva;
            this.Cena = cena;
            this.SalonId = salonId;
            this.DatumPoslednjeRegistracije = datumPoslednjeRegistracije;
            this.ServisnaIstorija = servisnaIstorija;
            this.BrojPrethodnihVlasnika = brojPrethodnihVlasnika;
        }
    }
    #endregion

    #region Voznja

    public class VoznjaDTO
    {
        public DateTime Datum;
        public string Vreme_termina;
        public Zaposleni Zaposleni;
        public Kupac kupac;
        public List<NovaDTO> NovaVozila;
        public List<PolovnaDTO> PolovnaVozila;

        public VoznjaDTO()
        {

        }

        public VoznjaDTO(DateTime dat, string termin, Zaposleni zap, Kupac kup)
        {
            Datum = dat;
            Vreme_termina = termin;
            Zaposleni = zap;
            kupac = kup;
        }
    }

    #endregion

    #region Promocija

    public class PromocijaDTO
    {
        public int Id;
        public string Naziv;
        public string Uslovi;
        public string Period_trajanja;
        public int Popust;

        public string Prikaz => $"{Naziv} {Popust}%";
        public string PromId => $"{Id}";

        public PromocijaDTO()
        {

        }
    }

    #endregion

    #region Kupovina

    public class KupovinaDTO
    {
        public int Konacna_cena;
        public Kupac Kupac;
        public PromocijaDTO Promocija;
        public NacinPlacanja Placanje;

        public KupovinaDTO()
        {

        }
    }

    #endregion

    #region Kupci

    public class KupacPregled
    {
        public string TipKupca;
        public string Ime;
        public string Prezime;
        public string NazivFirme;
        public string SedisteFirme;
        public string Marka;
        public string Model;

        public KupacPregled()
        {

        }

        public KupacPregled(string tipKupca, string ime, string prezime, string nazivFirme, string sedisteFirme, string marka, string model)
        {
            if (tipKupca == "fizicko")
            {
                nazivFirme = null;
                sedisteFirme = null;
            }
            else if (tipKupca == "pravno")
            {
                ime = null;
                prezime = null;
            }
            TipKupca = tipKupca;
            Ime = ime;
            Prezime = prezime;
            NazivFirme = nazivFirme;
            SedisteFirme = sedisteFirme;
            Marka = marka;
            Model = model;
        }
    }

    #endregion
}
