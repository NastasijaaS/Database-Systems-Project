using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Farmaceut : Zaposleni
    {
        //public virtual string MaticniBroj { get; set; }
        public virtual DateTime Diplomirao { get; set; }
        public virtual DateTime ObnovioLicencu { get; set; }

        public Farmaceut()
            :base()
        {

        }
    }
}