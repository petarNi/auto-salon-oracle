using SalonLibrary.Entiteti;

namespace SalonLibrary;

public static class DataProvider
{
    #region Salon


    public async static Task<Result<List<SalonView>, ErrorMessage>> VratiSveSalone()
    {
        List<SalonView> saloni = new List<SalonView>();
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return new ErrorMessage("Greška pri učitavanju salona", 400);


            }

            saloni = (await s.QueryOver<Salon>().ListAsync()).Select(p => new SalonView(p)).ToList();
        }
        catch (Exception ex)
        {
            return new ErrorMessage(ex.Message);

        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return saloni;

    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiSalon(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Salon salon = await s.LoadAsync<Salon>(id);

            await s.DeleteAsync(salon);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati salon sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajSalon(SalonView salon)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Salon sal = new()
            {
                Tip_salona = salon.Tip_salona,
                Naziv = salon.Naziv,
                Adresa = salon.Adresa,
                Telefon = salon.Telefon,
                Radno_vreme = salon.Radno_vreme,
                Broj_zaposlenih = salon.Broj_zaposlenih,
                Proizvodjac = salon.Proizvodjac
            };

            await s.SaveOrUpdateAsync(sal);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati salon.".ToError(400);
        }


        return true;
    }

    public async static Task<Result<SalonView, ErrorMessage>> AzurirajSalonAsync(SalonView sal)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Salon sl = await s.LoadAsync<Salon>(sal.Salon_Id);

            sl.Tip_salona = sal.Tip_salona;
            sl.Naziv = sal.Naziv;
            sl.Adresa = sal.Adresa;
            sl.Telefon = sal.Telefon;
            sl.Radno_vreme = sal.Radno_vreme;
            sl.Broj_zaposlenih = sal.Broj_zaposlenih;
            sl.Proizvodjac = sal.Proizvodjac;

            s.Update(sl);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati slagalicu.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return sal;
    }

    public async static Task<Result<SalonView, ErrorMessage>> VratiSalonPoId(int id)
    {
        SalonView salon;
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return new ErrorMessage("Greška pri učitavanju salona", 400);


            }

            Salon salon1 = (await s.LoadAsync<Salon>(id));

            salon = new SalonView(salon1);




        }
        catch (Exception ex)
        {
            return new ErrorMessage(ex.Message);

        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return salon;

    }

    #endregion

    #region Zaposleni

    public async static Task<Result<List<ZaposleniView>, ErrorMessage>> VratiSveZaposlene()
    {
        List<ZaposleniView> zaposleniLista = new List<ZaposleniView>();
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return new ErrorMessage("Greška pri učitavanju zaposlenih", 400);
            }
            

            IList<Zaposleni> lista = await s.QueryOver<Zaposleni>().ListAsync();

            foreach (Zaposleni z in lista)
            {
                if (!NHibernateUtil.IsInitialized(z.Emailovi))
                    NHibernateUtil.Initialize(z.Emailovi);

                if (!NHibernateUtil.IsInitialized(z.Telefoni))
                    NHibernateUtil.Initialize(z.Telefoni);

                if (!NHibernateUtil.IsInitialized(z.Salon) && z.Salon != null)
                    NHibernateUtil.Initialize(z.Salon);

                zaposleniLista.Add(new ZaposleniView(z));
            }
        }
        catch (Exception ex)
        {
            return new ErrorMessage(ex.Message);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return zaposleniLista;
    }

    public async static Task<Result<ZaposleniView, ErrorMessage>> VratiZaposlenogPoJMBG(string jmbg)
    {
        ZaposleniView zaposleni;
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return new ErrorMessage("Greška pri učitavanju zaposlenog", 400);
            }

            Zaposleni z = await s.QueryOver<Zaposleni>()
                             .Where(x => x.JMBG == jmbg)
                             .SingleOrDefaultAsync();

            if (z == null)
                return "Zaposleni nije pronađen.".ToError(404);

            if (!NHibernateUtil.IsInitialized(z.Emailovi))
                NHibernateUtil.Initialize(z.Emailovi);

            if (!NHibernateUtil.IsInitialized(z.Telefoni))
                NHibernateUtil.Initialize(z.Telefoni);

            if (!NHibernateUtil.IsInitialized(z.Salon) && z.Salon != null)
                NHibernateUtil.Initialize(z.Salon);

            zaposleni = new ZaposleniView(z);
        }
        catch (Exception ex)
        {
            return new ErrorMessage(ex.Message);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return zaposleni;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajZaposlenog(ZaposleniView zaposleni)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Zaposleni? postoji = await s.QueryOver<Zaposleni>()
                                       .Where(x => x.JMBG == zaposleni.JMBG)
                                       .SingleOrDefaultAsync();

            if (postoji != null)
                return "Zaposleni sa ovim JMBG postoji.".ToError(400);

            Zaposleni z = new()
            {
                JMBG = zaposleni.JMBG,
                Licno_ime = zaposleni.Licno_ime,
                Prezime = zaposleni.Prezime,
                Emailovi = zaposleni.Emailovi ?? new List<string>(),
                Telefoni = zaposleni.Telefoni ?? new List<string>(),
                Pozicija = zaposleni.Pozicija,
                Datum_zaposlenja = zaposleni.Datum_zaposlenja,
                Datum_funkcija = zaposleni.Datum_funkcija,
                Broj_prodatih = zaposleni.Broj_prodatih,
                Ocena_kupaca = zaposleni.Ocena_kupaca,
                Salon = zaposleni.SalonId != null ? await s.LoadAsync<Salon>(zaposleni.SalonId.Value) : null
            };

            await s.SaveOrUpdateAsync(z);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati zaposlenog.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<ZaposleniView, ErrorMessage>> AzurirajZaposlenogAsync(ZaposleniView zaposleni)
    {
        ISession? s = null;
        ZaposleniView result;


        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Zaposleni z = await s.QueryOver<Zaposleni>()
                             .Where(x => x.JMBG == zaposleni.JMBG)
                             .SingleOrDefaultAsync();

            if (z == null)
                return "Zaposleni nije pronađen.".ToError(404);

            z.JMBG = zaposleni.JMBG;
            z.Licno_ime = zaposleni.Licno_ime;
            z.Prezime = zaposleni.Prezime;
            z.Emailovi = zaposleni.Emailovi ?? new List<string>();
            z.Telefoni = zaposleni.Telefoni ?? new List<string>();
            z.Pozicija = zaposleni.Pozicija;
            z.Datum_zaposlenja = zaposleni.Datum_zaposlenja;
            z.Datum_funkcija = zaposleni.Datum_funkcija;
            z.Broj_prodatih = zaposleni.Broj_prodatih;
            z.Ocena_kupaca = zaposleni.Ocena_kupaca;
            z.Salon = zaposleni.SalonId != null ? await s.LoadAsync<Salon>(zaposleni.SalonId.Value) : null;

            s.Update(z);
            s.Flush();

            if (!NHibernateUtil.IsInitialized(z.Emailovi))
                NHibernateUtil.Initialize(z.Emailovi);

            if (!NHibernateUtil.IsInitialized(z.Telefoni))
                NHibernateUtil.Initialize(z.Telefoni);

            if (!NHibernateUtil.IsInitialized(z.Salon) && z.Salon != null)
                NHibernateUtil.Initialize(z.Salon);

            result = new ZaposleniView(z);
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati zaposlenog.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return zaposleni;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiZaposlenog(string jmbg)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            //Zaposleni z = await s.LoadAsync<Zaposleni>(jmbg);//ovo ce baci err jer jmbg nije mapiran kao primarni kljuc a i u osoba moze da bude null tkd ima greska tu negde

            Zaposleni? z = await s.QueryOver<Zaposleni>()
                               .Where(x => x.JMBG == jmbg)
                               .SingleOrDefaultAsync();

            if (z == null)
                return "Zaposleni nije pronađen.".ToError(404);

            await s.DeleteAsync(z);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati zaposlenog sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }


    #endregion
}

