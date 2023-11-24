using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;


namespace DatabaseAccess.Mapiranja
{
    class IndikacijaMapiranja : ClassMap<Indikacija>
    {
        public IndikacijaMapiranja()
        {
            Table("INDIKACIJE");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "ID_INDIKACIJE").GeneratedBy.TriggerIdentity();

            
            Map(x => x.IndikacijaOpis, "INDIKACIJA");

            //Mapiranje veze
            References(x => x.Lek).Column("ID_LEKA_3").LazyLoad();
        }
    }
}
