using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseAccess.Entiteti
{
    public class TipLeka
    {
        public virtual int IdTipa { get; set; }
        public virtual string Grupa { get; set; }
        public virtual IList<Lek> Lekovi { get; set; }

        public TipLeka()
        {
            Lekovi = new List<Lek>();
        }

    }


}
