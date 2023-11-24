using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ProdajeSeMapiranje : ClassMap<ProdajeSe>
    {
        public ProdajeSeMapiranje()
        {
            Table("PRODAJE_SE");

            CompositeId(x => x.Id)
                .KeyReference(x => x.LekProdajeSeU, "ID_LEKA_1")
                .KeyReference(x => x.ProdajeSeUProdajnoMesto, "ID_PRODAJNOG_MESTA_1");

            Map(x => x.Kolicina).Column("KOLICINA");
        }
    }
}
