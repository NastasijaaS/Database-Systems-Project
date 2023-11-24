using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class TipLekaMapiranja : ClassMap<TipLeka>
    {
        public TipLekaMapiranja()
        {
            //Mapiranje tabele
            Table("TIP_LEKA");

            //mapiranje primarnog kljuca
            Id(x => x.IdTipa, "ID_TIPA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Grupa, "GRUPA");
            HasMany(x => x.Lekovi).KeyColumn("GRUPA_LEKA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
