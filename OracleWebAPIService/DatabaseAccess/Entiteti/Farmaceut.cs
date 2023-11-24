using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Farmaceut : Zaposleni
    {
        public virtual DateTime Diplomirao { get; set; }
        public virtual DateTime ObnovioLicencu { get; set; }

        public Farmaceut()
            :base()
        {

        }
    }
}