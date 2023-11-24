using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Proizvodjac
    {
        public virtual string Naziv { get; set; }
        public virtual IList<Lek> Lekovi { get; set; }

        public Proizvodjac()
        {
            Lekovi = new List<Lek>();
        }


    }
}
