using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Zaposleni
    {
        public virtual string MaticniBroj { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual int BrojTelefona { get; set; }
        public virtual int Farmaceut { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual IList<Recept> Recepti { get; set; }
        public virtual IList<ProdajnoMesto> ProdajnaMesta { get; set; }
        public virtual IList<RadiU> RadiUProdajnaMesta { get; set; }

        public Zaposleni()
        {
            Recepti = new List<Recept>();
            ProdajnaMesta = new List<ProdajnoMesto>();
            RadiUProdajnaMesta = new List<RadiU>();
        }

    }
}
