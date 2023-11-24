using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class LekMapiranja : ClassMap<Lek>
    {
        public LekMapiranja()
        {
            //Mapiranje tabele
            Table("LEK");

            //mapiranje primarnog kljuca
            Id(x => x.IdLeka, "ID_LEKA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.DozaOdrasli, "DOZA_ODRASLI");
            Map(x => x.DozaDeca, "DOZA_DECA");
            Map(x => x.DozaTrudnice, "DOZA_TRUDNICE");
            Map(x => x.Dejstvo, "DEJSTVO");
            Map(x => x.HemijskiNaziv, "HEMIJSKI_NAZIV");
            Map(x => x.NaRecept, "NA_RECEPT");
            Map(x => x.ProcenatParticipacije, "PROCENAT_PARTICIPACIJE");
            Map(x => x.Cena, "CENA");
            Map(x => x.KomercijalniNaziv, "KOMERCIJALNI_NAZIV");

            References(x => x.PripadaGrupi).Column("GRUPA_LEKA").LazyLoad();
            References(x => x.ProizvedenOd).Column("NAZIV_PROIZVODJACA").LazyLoad();

            HasManyToMany(x => x.ProdajeSeU)
                .Table("PRODAJE_SE")
                .ParentKeyColumn("ID_LEKA_1")
                .ChildKeyColumn("ID_PRODAJNOG_MESTA_1")
                .Cascade.All();

            HasMany(x => x.ProdajeSeUProdajnimMestima).KeyColumn("ID_LEKA_1").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.LekPrepisanNaRecept)
               .Table("PREPISAN_LEK")
               .ParentKeyColumn("ID_LEKA_2")
               .ChildKeyColumn("SB_RECEPTA")
               .Inverse()
               .Cascade.All();


            HasManyToMany(x => x.LekoviUPakovanja)
                .Table("UPAKOVAN_U")
                .ParentKeyColumn("ID_LEKA_7")
                .ChildKeyColumn("ID_PAKOVANJA_2")
                .Cascade.All();

            HasMany(x => x.UpakovanULek).KeyColumn("ID_LEKA_7").LazyLoad().Cascade.All().Inverse();
        }
    }
}
