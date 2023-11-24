using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;


namespace Apoteka.Mapiranja
{
    class FarmaceutMapiranja : SubclassMap<Farmaceut>
    {
        public FarmaceutMapiranja()
        {
            Table("FARMACEUT");

            KeyColumn("MATICNI_BROJ");

            Map(x => x.Diplomirao, "DIPLOMIRAO");
            Map(x => x.ObnovioLicencu, "OBNOVIO_LICENCU");
        }
    }
}
