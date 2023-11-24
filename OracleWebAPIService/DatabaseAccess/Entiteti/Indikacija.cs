using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Indikacija
    {
        public virtual int Id { get; set; }
        public virtual string IndikacijaOpis { get; set; }
        public virtual Lek Lek { get; set; }

        public Indikacija()
        {

        }
    }
}
