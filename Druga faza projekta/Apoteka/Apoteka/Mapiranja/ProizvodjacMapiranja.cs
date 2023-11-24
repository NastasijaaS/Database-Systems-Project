using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ProizvodjacMapiranja : ClassMap<Proizvodjac>
    {
        public ProizvodjacMapiranja()
        {
            //Mapiranje tabele
            Table("PROIZVODJAC");

            //mapiranje primarnog kljuca
            Id(x => x.Naziv, "NAZIV").GeneratedBy.Assigned();
            HasMany(x => x.Lekovi).KeyColumn("NAZIV_PROIZVODJACA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
