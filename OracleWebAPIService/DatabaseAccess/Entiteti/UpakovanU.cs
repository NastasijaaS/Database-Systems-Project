using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class UpakovanU
    {
        public virtual UpakovanUId Id { get; set; }
        public virtual int Kolicina { get; set; }
        public virtual string Sastav { get; set; }

        public UpakovanU()
        {
            Id = new UpakovanUId();
        }
    }
}
