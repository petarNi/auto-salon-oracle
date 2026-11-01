using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSalon.Entiteti;
using FluentNHibernate.Mapping;

namespace AutoSalon.Mapiranja
{
    class ZaposleniMap: SubclassMap<Zaposleni>
    {
        public ZaposleniMap()
        {
            Table("ZAPOSLENI");

            KeyColumn("JMBG");

            Map(x => x.Pozicija, "Pozicija");
            Map(x => x.Datum_zaposlenja, "Datum_zaposlenja");
            Map(x => x.Datum_funkcija, "Datum_funkcija");
            Map(x => x.Broj_prodatih, "Broj_prodatih");
            Map(x => x.Ocena_kupaca, "Ocena_kupaca");

            References(x => x.Salon).Column("Salon_id_zap").Cascade.All();

            HasMany(x => x.Voznje).KeyColumn("JMBG_ZAP").Inverse().Cascade.All();
        }
    }
}
