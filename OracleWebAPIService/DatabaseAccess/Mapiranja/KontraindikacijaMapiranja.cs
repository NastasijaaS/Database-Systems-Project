using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;


namespace DatabaseAccess.Mapiranja
{
    class KontraindikacijaMapiranja : ClassMap<Kontraindikacija>
    {
        public KontraindikacijaMapiranja()
        {
            Table("KONTRAINDIKACIJE");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "ID_KONTRAINDIKACIJE").GeneratedBy.TriggerIdentity();


            Map(x => x.KontraindikacijaOpis, "KONTRAINDIKACIJA");

            //Mapiranje veze
            References(x => x.Lek).Column("ID_LEKA_4").LazyLoad();
        }
    }
}