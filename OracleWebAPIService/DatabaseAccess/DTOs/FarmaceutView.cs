using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class FarmaceutView : ZaposleniView
    {
        public DateTime Diplomirao { get; set; }
        public DateTime ObnovioLicencu { get; set; }

        public FarmaceutView()
            : base()
        {

        }

        public FarmaceutView(Farmaceut f) : base(f)
        {
            Diplomirao = f.Diplomirao;
            ObnovioLicencu = f.ObnovioLicencu;
        }

    }
}
