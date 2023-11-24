using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;


namespace DatabaseAccess.Mapiranja
{
    public class ReceptMapiranja : ClassMap<Recept>
    {
        public ReceptMapiranja()
        {
            //Mapiranje tabele
            Table("RECEPT");

            //mapiranje primarnog kljuca
            Id(x => x.SerijskiBroj, "SERIJSKI_BROJ").GeneratedBy.Assigned();

            //mapiranje svojstava.
            Map(x => x.Lekar, "LEKAR");
            Map(x => x.DatumIzdavanja, "DATUM_IZDAVANJA");
            Map(x => x.DatumRealizacije, "DATUM_REALIZACIJE");

            References(x => x.RealizovanU).Column("ID_PRODAJNOG_MESTA").LazyLoad();

            References(x => x.Prodao).Column("MATICNI_BROJ_ZAPOSLENOG").LazyLoad();

            HasManyToMany(x => x.ReceptPrepisanZaLek)
               .Table("PREPISAN_LEK")
               .ParentKeyColumn("SB_RECEPTA")
               .ChildKeyColumn("ID_LEKA_2")
               .Cascade.All();
        }

    }

}
