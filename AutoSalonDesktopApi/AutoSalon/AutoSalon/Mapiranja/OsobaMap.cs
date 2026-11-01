using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSalon.Entiteti;
using FluentNHibernate.Mapping;

namespace AutoSalon.Mapiranja
{
    class OsobaMap: ClassMap<Osoba>
    {
        public OsobaMap() 
        {
            Table("OSOBA");

            Id(x => x.JMBG, "JMBG").GeneratedBy.Assigned();
            Map(x => x.Licno_ime, "Licno_ime");
            Map(x => x.Prezime, "Prezime");

            HasMany(x => x.Telefoni).Table("TEL_OSOBA").KeyColumn("JMBG_O").Element("Tel_osoba").Cascade.All();
            HasMany(x => x.Emailovi).Table("EMAIL_OSOBA").KeyColumn("JMBG_OS").Element("Email_osoba").Cascade.All();
                
        }

    }
}
