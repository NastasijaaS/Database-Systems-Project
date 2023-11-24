using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class PakovanjeMapiranja : ClassMap<Pakovanje>
    {
        public PakovanjeMapiranja()
        {
            //Mapiranje tabele
            Table("PAKOVANJE");

            //mapiranje primarnog kljuca
            Id(x => x.IdPakovanja, "ID_PAKOVANJA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.VrstaPakovanja, "VRSTA_PAKOVANJA");


            HasManyToMany(x => x.PakovanjaZaLekove)
                .Table("UPAKOVAN_U")
                .ParentKeyColumn("ID_PAKOVANJA_2")
                .ChildKeyColumn("ID_LEKA_7")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.PakovanjaUpakovanU).KeyColumn("ID_PAKOVANJA_2").LazyLoad().Cascade.All().Inverse();
        }
    }
}
