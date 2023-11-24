using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class ProdajeSe
    {
        public virtual ProdajeSeUId Id {get; set;}
        public virtual int Kolicina { get; set; }

        public ProdajeSe()
        {
            Id = new ProdajeSeUId();
        }
    }
}
