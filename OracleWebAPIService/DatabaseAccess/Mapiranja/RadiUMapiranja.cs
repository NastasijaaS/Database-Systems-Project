using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;


namespace DatabaseAccess.Mapiranja
{
    public class RadiUMapiranja : ClassMap<RadiU>
    {
        public RadiUMapiranja()
        {
            Table("RADI_U");

            CompositeId(x => x.Id)
                .KeyReference(x => x.ZaposleniRadiU, "MBR_ZAPOSLENOG")
                .KeyReference(x => x.RadiUProdajnoMesto, "ID_PRODAJNOG_MESTA_2");

            Map(x => x.DatumOd).Column("OD_DATUM");
            Map(x => x.DatumDo).Column("DO_DATUM");

        }
    }
}
