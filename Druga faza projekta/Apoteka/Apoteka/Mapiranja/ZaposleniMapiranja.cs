using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            //Mapiranje tabele
            Table("ZAPOSLENI");

            //mapiranje primarnog kljuca
            Id(x => x.MaticniBroj, "MATICNI_BROJ").GeneratedBy.Assigned();

            //FIXME: Problem:
            //DiscriminateSubClassesOnColumn("FARMACEUT_FLAG", 0);

            //mapiranje svojstava
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            //Map(x => x.Diplomirao, "DIPLOMIRAO");
            //Map(x => x.ObnovioLicencu, "OBNOVIO_LICENCU");
            Map(x => x.Farmaceut, "FARMACEUT_FLAG");




            HasMany(x => x.Recepti).KeyColumn("MATICNI_BROJ_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.ProdajnaMesta)
                .Table("RADI_U")
                .ParentKeyColumn("MBR_ZAPOSLENOG")
                .ChildKeyColumn("ID_PRODAJNOG_MESTA_2")
                .Cascade.All();

            HasMany(x => x.RadiUProdajnaMesta).KeyColumn("MBR_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
        }
    }

    //public class FarmaceutMapiranja : SubclassMap<Farmaceut>
    //{
    //    public FarmaceutMapiranja()
    //    {
    //        DiscriminatorValue(1);
    //    }

    //}
}
