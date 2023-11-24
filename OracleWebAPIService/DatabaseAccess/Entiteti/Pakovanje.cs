using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Pakovanje
    {
        public virtual int IdPakovanja { get; protected set; }
        public virtual string VrstaPakovanja { get; set; }
        public virtual IList<Lek> PakovanjaZaLekove { get; set; }
        public virtual IList<UpakovanU> PakovanjaUpakovanU { get; set; }

        public Pakovanje()
        {
            PakovanjaZaLekove = new List<Lek>();
            PakovanjaUpakovanU = new List<UpakovanU>();
        }
    }
}
