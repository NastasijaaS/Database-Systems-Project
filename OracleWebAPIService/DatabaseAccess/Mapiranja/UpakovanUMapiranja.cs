//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;


namespace DatabaseAccess.Mapiranja
{
    public class UpakovanUMapiranja : ClassMap<UpakovanU>
    {
        public UpakovanUMapiranja()
        {
            Table("UPAKOVAN_U");

            CompositeId(x => x.Id)
                .KeyReference(x => x.LekUpakovanU, "ID_LEKA_7")
                .KeyReference(x => x.UpakovanUPakovanje, "ID_PAKOVANJA_2");

            Map(x => x.Kolicina).Column("KOLICINA");
            Map(x => x.Sastav).Column("SASTAV");

        }
    }
}
