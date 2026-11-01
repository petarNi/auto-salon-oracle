using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSalon.Entiteti;
using System.Windows.Forms;
using NHibernate;
using System.Security.Policy;

namespace AutoSalon
{
    public class DTOManager
    {

        #region Saloni

        public static List<SalonPregled> vratiSveSalone()
        {
            List<SalonPregled> sviSaloni = new List<SalonPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Salon> saloni = s.Query<Salon>().ToList();

                foreach (Salon sal in saloni)
                {
                    SalonPregled sp = new SalonPregled
                    {
                        Id = (int)sal.Salon_Id,
                        Tip = sal.Tip_salona,
                        Naziv = sal.Naziv,
                        Adresa = sal.Adresa,
                        Radno_vreme = sal.Radno_vreme,
                        Telefon = sal.Telefon,
                        Broj_zaposlenih = sal.Broj_zaposlenih,
                        Proizvodjac = sal.Proizvodjac,

                    };

                    sviSaloni.Add(sp);
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return sviSaloni;
        }

        public static void dodajSalon(SalonDodavanje sal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = new Salon
                {
                    Tip_salona = sal.Tip,
                    Naziv = sal.Naziv,
                    Adresa = sal.Adresa,
                    Radno_vreme = sal.Radno_vreme,
                    Telefon = sal.Telefon,
                    Broj_zaposlenih = sal.Broj_zaposlenih,
                    Proizvodjac = sal.Proizvodjac,
                };

                s.Save(salon);
                s.Flush();
                s.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void azurirajSalon(SalonDodavanje sal, int salonId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Load<Salon>(salonId);
                if (salon == null)
                {
                    throw new Exception("Salon ne postoji");
                }

                salon.Naziv = sal.Naziv;
                salon.Adresa = sal.Adresa;
                salon.Radno_vreme = sal.Radno_vreme;
                salon.Telefon = sal.Telefon;
                salon.Proizvodjac = sal.Proizvodjac;
                salon.Tip_salona = sal.Tip;

                s.Update(salon);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void obrisiSalon(int salonId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Get<Salon>(salonId);
                if (salon == null)
                {
                    throw new Exception("Salon ne postoji");
                }
                s.Delete(salon);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static SalonDodavanje vratiSalonPoId(int id)
        {
            SalonDodavanje sal = new SalonDodavanje();
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Load<Salon>(id);

                sal = new SalonDodavanje
                {
                    Tip = salon.Tip_salona,
                    Naziv = salon.Naziv,
                    Adresa = salon.Adresa,
                    Telefon = salon.Telefon,
                    Radno_vreme = salon.Radno_vreme,
                    Broj_zaposlenih = salon.Broj_zaposlenih,
                    Proizvodjac = salon.Proizvodjac
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return sal;

        }

        #endregion

        #region Zaposleni
        public static List<ZaposleniDTO> VratiSveZaposlenePoSalonu(int salonId)
        {
            ISession s = DataLayer.GetSession();

            Salon salon = s.Get<Salon>(salonId);
            if (salon == null) {
                throw new Exception("Salon ne postoji");
            }

            List<Zaposleni> zaposleni = s.Query<Zaposleni>().Where(z => z.Salon == salon).ToList();

            List<ZaposleniDTO> rezultat = new List<ZaposleniDTO>();

            foreach (Zaposleni z in zaposleni)
            {
                ZaposleniDTO dto = new ZaposleniDTO
                {
                    JMBG = z.JMBG,
                    Pozicija = z.Pozicija,
                    DatumZaposlenja = z.Datum_zaposlenja,
                    Ime = z.Licno_ime,
                    Prezime = z.Prezime,
                    DatumFunkcije = z.Datum_funkcija,
                    BrojProdatih = z.Broj_prodatih,
                    OcenaKupaca = z.Ocena_kupaca
                };
                rezultat.Add(dto);
            }
            return rezultat;
        }

        public static Zaposleni vratiZaposlenogPoJMBG(string jmbg)
        {
            Zaposleni zaposleni = new Zaposleni();
            try
            {
                ISession s = DataLayer.GetSession();
                zaposleni = s.Load<Zaposleni>(jmbg);
                

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return zaposleni;
        }



        public static void ObrisiZaposlenog(string jmbg)
        {
            ISession s = DataLayer.GetSession();

            Zaposleni z = s.Get<Zaposleni>(jmbg);

            if (z == null)
                throw new Exception("Zaposleni ne postoji.");

            s.Delete(z);
            s.Flush();

        }

        public static List<ZaposleniDTO> VratiZaposlenePoPoziciji(int salonId, string pozicija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Get<Salon>(salonId);
                if (salon == null)
                {
                    throw new Exception("Salon ne postoji");
                }

                List<Zaposleni> zaposleniSaPozicijom = s.Query<Zaposleni>()
                                                        .Where(z => z.Pozicija == pozicija && z.Salon == salon)
                                                        .ToList();

                List<ZaposleniDTO> rezultat = new List<ZaposleniDTO>();

                foreach (Zaposleni z in zaposleniSaPozicijom)
                {
                    ZaposleniDTO dto = new ZaposleniDTO
                    {
                        JMBG = z.JMBG,
                        Pozicija = z.Pozicija,
                        DatumZaposlenja = z.Datum_zaposlenja,
                        Ime = z.Licno_ime,
                        Prezime = z.Prezime,
                        DatumFunkcije = z.Datum_funkcija,
                        BrojProdatih = z.Broj_prodatih,
                        OcenaKupaca = z.Ocena_kupaca
                    };

                    rezultat.Add(dto);
                }

                return rezultat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void AzurirajZaposlenog(ZaposleniDTO dto)
        {
            ISession s = DataLayer.GetSession();

            Zaposleni z = s.Get<Zaposleni>(dto.JMBG);

            if (z == null)
                throw new Exception("Zaposleni ne postoji.");

            z.Licno_ime = dto.Ime;
            z.Prezime = dto.Prezime;
            z.Pozicija = dto.Pozicija;
            z.Datum_zaposlenja = dto.DatumZaposlenja;
            z.Datum_funkcija = null;
            z.Broj_prodatih = null;
            z.Ocena_kupaca = null;

            if (dto.Pozicija.ToLower() == "menadzer")
            {
                z.Datum_funkcija = dto.DatumFunkcije;
            }
            else if (dto.Pozicija.ToLower() == "prodavac")
            {
                z.Broj_prodatih = dto.BrojProdatih;
                z.Ocena_kupaca = dto.OcenaKupaca;
            }

            s.Update(z);
            s.Flush();
        }

        public static void DodajZaposlenog(int salonId, ZaposleniDTO dto)
        {
            ISession s = DataLayer.GetSession();

            Salon salon = s.Get<Salon>(salonId);
            if (salon == null)
            {
                throw new Exception("Salon ne postoji");
            }

            Zaposleni z = new Zaposleni
            {
                Salon = salon,
                JMBG = dto.JMBG,
                Licno_ime = dto.Ime,
                Prezime = dto.Prezime,
                Datum_zaposlenja = dto.DatumZaposlenja,
                Pozicija = dto.Pozicija
            };

            if (dto.Pozicija == "menadzer")
            {
                z.Datum_funkcija = dto.DatumFunkcije;
            }
            else if (dto.Pozicija == "prodavac")
            {
                z.Broj_prodatih = dto.BrojProdatih;
                z.Ocena_kupaca = dto.OcenaKupaca;
            }

            s.Save(z);
            s.Flush();
        }



        #endregion

        #region Vozila

        public static Nova vratiNovo(string brSasije)
        {
            Nova nova = new Nova();
            try
            {
                ISession s = DataLayer.GetSession();

                nova = s.Get<Nova>(brSasije);
                s.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return nova;
        }
        public static Polovna vratiPolovno(string brSasije)
        {
            Polovna polovna = new Polovna();
            try
            {
                ISession s = DataLayer.GetSession();

                polovna = s.Get<Polovna>(brSasije);
                s.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return polovna;
        }
        public static List<NovaDTO> VratiNovaVozilaZaSalon(int salonId)
        {
            List<NovaDTO> rezultat = new List<NovaDTO>();

            ISession s = DataLayer.GetSession();

            Salon salon = s.Get<Salon>(salonId);
            if (salon == null)
            {
                throw new Exception("Salon ne postoji");
            }

            List<Nova> vozila = s.Query<Nova>()
                .Where(v => v.Salon == salon)
                .ToList();

            foreach (Nova v in vozila)
            {
                NovaDTO dto = new NovaDTO {
                    BrSasije = v.Br_sasije,
                    Model = v.Model,
                    Marka = v.Marka,
                    GodProizvodnje = v.God_proizvodnje,
                    SnagaMotora = v.Snaga_motora,
                    Kilometraza = v.Kilometraza,
                    BrojVrata = v.Broj_vrata,
                    Boja = v.Boja,
                    TipGoriva = v.Tip_goriva,
                    Cena = v.Cena,
                    SalonId = (int)v.Salon.Salon_Id
                };

                rezultat.Add(dto);
            }

            return rezultat;
        }

        public static List<PolovnaDTO> VratiPolovnaVozilaZaSalon(int salonId)
        {
            List<PolovnaDTO> rezultat = new List<PolovnaDTO>();

            ISession s = DataLayer.GetSession();

            IList<Polovna> vozila = s.Query<Polovna>()
                .Where(v => v.Salon.Salon_Id == salonId)
                .ToList();

            foreach (Polovna v in vozila)
            {
                PolovnaDTO dto = new PolovnaDTO {
                    BrSasije = v.Br_sasije,
                    Model = v.Model,
                    Marka = v.Marka,
                    GodProizvodnje = v.God_proizvodnje,
                    SnagaMotora = v.Snaga_motora,
                    Kilometraza = v.Kilometraza,
                    BrojVrata = v.Broj_vrata,
                    Boja = v.Boja,
                    TipGoriva = v.Tip_goriva,
                    Cena = v.Cena,
                    SalonId = (int)v.Salon.Salon_Id,
                    DatumPoslednjeRegistracije = v.Dat_poslednje_reg,
                    ServisnaIstorija = v.Servisna_istorija,
                    BrojPrethodnihVlasnika = v.Br_preth_vlasnika
                };

                rezultat.Add(dto);
            }

            return rezultat;
        }
        public static void ObrisiNovoVozilo(string brSasije)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nova vozilo = s.Load<Nova>(brSasije);
                s.Delete(vozilo);
                s.Flush();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void ObrisiPolovnoVozilo(string brSasije)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Polovna vozilo = s.Load<Polovna>(brSasije);
                s.Delete(vozilo);
                s.Flush();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void IzmeniNovoVozilo(NovaDTO dto)
        {
            ISession session = DataLayer.GetSession();

            Nova vozilo = session.Load<Nova>(dto.BrSasije);
            vozilo.Marka = dto.Marka;
            vozilo.Model = dto.Model;
            vozilo.God_proizvodnje = dto.GodProizvodnje;
            vozilo.Snaga_motora = dto.SnagaMotora;
            vozilo.Kilometraza = dto.Kilometraza;
            vozilo.Broj_vrata = dto.BrojVrata;
            vozilo.Boja = dto.Boja;
            vozilo.Tip_goriva = dto.TipGoriva;
            vozilo.Cena = dto.Cena;

            session.Update(vozilo);
            session.Flush();

        }
        public static void IzmeniPolovnoVozilo(PolovnaDTO dto)
        {
            ISession session = DataLayer.GetSession();

            Polovna vozilo = session.Load<Polovna>(dto.BrSasije);
            vozilo.Marka = dto.Marka;
            vozilo.Model = dto.Model;
            vozilo.God_proizvodnje = dto.GodProizvodnje;
            vozilo.Snaga_motora = dto.SnagaMotora;
            vozilo.Kilometraza = dto.Kilometraza;
            vozilo.Broj_vrata = dto.BrojVrata;
            vozilo.Boja = dto.Boja;
            vozilo.Tip_goriva = dto.TipGoriva;
            vozilo.Cena = dto.Cena;
            vozilo.Dat_poslednje_reg = dto.DatumPoslednjeRegistracije.HasValue
            ? dto.DatumPoslednjeRegistracije.Value
            : DateTime.MinValue;
            vozilo.Servisna_istorija = dto.ServisnaIstorija;
            vozilo.Br_preth_vlasnika = dto.BrojPrethodnihVlasnika;

            session.Update(vozilo);
            session.Flush();

        }
        public static void DodajNovoVozilo(NovaDTO novo)
        {
            using (ISession s = DataLayer.GetSession())
            {
                Nova entitet = new Nova
                {
                    Br_sasije = novo.BrSasije,
                    Marka = novo.Marka,
                    Model = novo.Model,
                    God_proizvodnje = novo.GodProizvodnje,
                    Snaga_motora = novo.SnagaMotora,
                    Kilometraza = novo.Kilometraza,
                    Broj_vrata = novo.BrojVrata,
                    Boja = novo.Boja,
                    Tip_goriva = novo.TipGoriva,
                    Cena = novo.Cena,
                    Salon = s.Load<Salon>(novo.SalonId)
                };

                s.Save(entitet);
                s.Flush();
            }
        }

        public static void DodajPolovnoVozilo(PolovnaDTO polovno)
        {
            ISession s = DataLayer.GetSession();

            Polovna p = new Polovna
            {
                Br_sasije = polovno.BrSasije,
                Marka = polovno.Marka,
                Model = polovno.Model,
                God_proizvodnje = polovno.GodProizvodnje,
                Snaga_motora = polovno.SnagaMotora,
                Kilometraza = polovno.Kilometraza,
                Broj_vrata = polovno.BrojVrata,
                Boja = polovno.Boja,
                Tip_goriva = polovno.TipGoriva,
                Cena =polovno.Cena,    
                Dat_poslednje_reg = polovno.DatumPoslednjeRegistracije.HasValue
                ? polovno.DatumPoslednjeRegistracije.Value
                : DateTime.MinValue,
                Servisna_istorija = polovno.ServisnaIstorija,
                Br_preth_vlasnika = polovno.BrojPrethodnihVlasnika,
                Salon = s.Load<Salon>(polovno.SalonId)
            };

            s.Save(p);
            s.Flush();
        }

     
    
    #endregion

        #region Voznja

   
        public static void rezervisiVoznju(VoznjaDTO voznja)
        {
            try
            {
                if(voznja == null)
                {
                    throw new Exception("Nevalidni podaci");
                }

                ISession s = DataLayer.GetSession();

                TestVoznja tv = new TestVoznja();

                tv.Datum_termina = voznja.Datum;
                tv.Vreme_termina = voznja.Vreme_termina;
                tv.Kupac = voznja.kupac;
                tv.Zaposleni = voznja.Zaposleni;
                foreach (var vozilo in voznja.NovaVozila)
                {
                    
                    Nova v = s.Get<Nova>(vozilo.BrSasije);

                    tv.NovaVozila.Add(v);
                }
                foreach (var vozilo in voznja.PolovnaVozila)
                {
                   
                    Polovna v = s.Get<Polovna>(vozilo.BrSasije);
                    tv.PolovnaVozila.Add(v);
                }

                s.Save(tv);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        #endregion

        #region Promocija

        public static List<PromocijaDTO> vratiSvePromocije()
        {
            List<PromocijaDTO> promocije = new List<PromocijaDTO>();
            try
            {
                ISession s = DataLayer.GetSession();
                List<Promocija> proms = s.Query<Promocija>().ToList();

                foreach (Promocija prom in proms)
                {
                    PromocijaDTO pr = new PromocijaDTO
                    {
                        Id = (int)prom.Promocija_Id,
                        Naziv = prom.Naziv,
                        Uslovi = prom.Uslovi,
                        Period_trajanja = prom.Period_trajanja,
                        Popust = prom.Popust
                    };

                    promocije.Add(pr);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return promocije;

        }

        public static PromocijaDTO vratiPromociju(int promId)
        {
            PromocijaDTO prom = new PromocijaDTO();
            try
            {
                ISession s = DataLayer.GetSession();
                Promocija p = s.Load<Promocija>(promId);
                prom = new PromocijaDTO
                {
                    Id = p.Promocija_Id,
                    Naziv = p.Naziv,
                    Uslovi = p.Uslovi,
                    Period_trajanja= p.Period_trajanja,
                    Popust = p.Popust
            
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return prom;

        }

        public static int obaviKupovinu(KupovinaDTO kup, Pravno pravno, Fizicko fizicko, string brojSasije, int salonId)
        {
            int cena = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salon = s.Get<Salon>(salonId);
                if(salon == null)
                {
                    throw new Exception("Salon ne postoji");
                }
                if(pravno != null)
                {
                    s.Save(pravno);
                    s.Flush();
                }
                if(fizicko != null)
                {
                    s.Save(fizicko);
                    s.Flush();
                }
                Nova nv = s.Get<Nova>(brojSasije);
                Polovna pv = null;
                if(nv == null)
                {
                    pv = s.Get<Polovna>(brojSasije);
                }

                if (nv == null && pv == null)
                {
                    throw new Exception("Vozilo sa tim brojem šasije ne postoji.");
                }

                Kupovina k = new Kupovina
                {
                    Placanje = kup.Placanje,
                    Kupac = kup.Kupac
                };
                if (kup.Promocija != null)
                {
                    var postojeca = s.Get<Promocija>(kup.Promocija.Id);
                    if (postojeca == null)
                        throw new Exception("Promocija ne postoji.");

                    k.Promocija = postojeca;
                }



                if (nv != null)
                {
                    if (k.Promocija != null) {
                        cena = (int)(nv.Cena - nv.Cena * (k.Promocija.Popust / 100.0));
                    }
                    else {
                        cena = nv.Cena;
                    }
                    k.Konacna_cena = cena;
                    nv.Kupovina = k;
                    nv.Promocija = k.Promocija;

                }
                else if (pv != null)
                {
                    if (k.Promocija != null) {
                        cena = (int)(pv.Cena - pv.Cena * (k.Promocija.Popust / 100.0));
                    } else {
                    cena = pv.Cena;
                    }
                    k.Konacna_cena = cena;
                    pv.Kupovina = k;
                    pv.Promocija = k.Promocija;


                }

                s.Save(k);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cena;
        }
        #endregion

        //List<KupacPregled> lista = new List<KupacPregled>();

        //ISession s = DataLayer.GetSession();
        //IList<Fizicko> fizicka = s.Query<Fizicko>()
        //                        .Where(f => f.Kupac.Kupovine.Any(k =>
        //                            k.NovaVozila.Any(n => n.Salon.Salon_Id == salonId) ||
        //                            k.PolovnaVozila.Any(p => p.Salon.Salon_Id == salonId)))
        //                        .ToList();

        //foreach (Fizicko fiz in fizicka)
        //{
        //    foreach (Kupovina kup in fiz.Kupac.Kupovine)
        //    {
        //        foreach (Nova nova in kup.NovaVozila.Where(n => n.Salon.Salon_Id == salonId))
        //        {
        //            lista.Add(new KupacPregled("fizicko", fiz.Licno_ime, fiz.Prezime, null, null, nova.Marka, nova.Model));
        //        }
        //        foreach (Polovna pol in kup.PolovnaVozila.Where(p => p.Salon.Salon_Id == salonId))
        //        {
        //            lista.Add(new KupacPregled("fizicko", fiz.Licno_ime, fiz.Prezime, null, null, pol.Marka, pol.Model));
        //        }
        //    }
        //}

        //IList<Pravno> pravna = s.Query<Pravno>()
        //                        .Where(p => p.Kupac.Kupovine.Any(k =>
        //                            k.NovaVozila.Any(n => n.Salon.Salon_Id == salonId) ||
        //                            k.PolovnaVozila.Any(pv => pv.Salon.Salon_Id == salonId)))
        //                        .ToList();

        //foreach (Pravno prav in pravna)
        //{
        //    foreach (Kupovina kup in prav.Kupac.Kupovine)
        //    {
        //        foreach (Nova nova in kup.NovaVozila.Where(n => n.Salon.Salon_Id == salonId))
        //        {
        //            lista.Add(new KupacPregled("pravno", null, null, prav.NazivFirme, prav.SedisteFirme, nova.Marka, nova.Model));
        //        }
        //        foreach (Polovna pol in kup.PolovnaVozila.Where(pv => pv.Salon.Salon_Id == salonId))
        //        {
        //            lista.Add(new KupacPregled("pravno", null, null, prav.NazivFirme, prav.SedisteFirme, pol.Marka, pol.Model));
        //        }
        //    }
        //}

        //return lista;

        #region Kupci

        public static List<KupacPregled> VratiKupceZaSalon(int salonId)
        {
            List<KupacPregled> kupci = new List<KupacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salon = s.Get<Salon>(salonId);
                List<Nova> nova = s.Query<Nova>().Where(n=> n.Salon.Salon_Id == salonId).ToList();
                List<Polovna> polovna = s.Query<Polovna>().Where(p => p.Salon.Salon_Id == salonId).ToList();

                foreach(Nova n in nova)
                {
                    if(n.Kupovina != null)
                    {
                        Fizicko fizicko = s.Query<Fizicko>().FirstOrDefault(f => f.Kupac.Kupac_Id == n.Kupovina.Kupac.Kupac_Id);
                        Pravno pravno = s.Query<Pravno>().FirstOrDefault(f => f.Kupac.Kupac_Id == n.Kupovina.Kupac.Kupac_Id);

                        if(fizicko != null)
                        {
                            kupci.Add(new KupacPregled("fizicko", fizicko.Licno_ime, fizicko.Prezime, null, null, n.Marka, n.Model));
                        }

                        if(pravno != null)
                        {
                            kupci.Add(new KupacPregled("pravno", null, null, pravno.NazivFirme, pravno.SedisteFirme, n.Marka, n.Model));
                        }
                    }
                }
                foreach (Polovna p in polovna)
                {
                    if (p.Kupovina != null)
                    {
                        Fizicko fizicko = s.Query<Fizicko>().FirstOrDefault(f => f.Kupac == p.Kupovina.Kupac);
                        Pravno pravno = s.Query<Pravno>().FirstOrDefault(f => f.Kupac == p.Kupovina.Kupac);

                        if(fizicko != null)
                        {
                            kupci.Add(new KupacPregled("fizicko", fizicko.Licno_ime, fizicko.Prezime, null, fizicko.Adresa, p.Marka, p.Model));
                        }

                        if(pravno != null)
                        {
                            kupci.Add(new KupacPregled("pravno", null, null, pravno.NazivFirme, null, p.Marka, p.Model));
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return kupci;
            
        }

        #endregion


    }
}

