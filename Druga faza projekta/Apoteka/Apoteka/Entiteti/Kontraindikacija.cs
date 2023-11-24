using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Kontraindikacija
    {
        public virtual int Id { get; set; }
        public virtual string KontraindikacijaOpis { get; set; }

        public virtual Lek Lek { get; set; }

        public Kontraindikacija()
        {

        }
    }
}
