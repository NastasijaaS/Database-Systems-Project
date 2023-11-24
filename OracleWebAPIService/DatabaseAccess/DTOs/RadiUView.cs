using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class RadiUView
    {
        public RadiUIdView Id { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }

        public RadiUView()
        {

        }

        public RadiUView(RadiU r)
        {
            Id = new RadiUIdView(r.Id);
            DatumOd = r.DatumOd;
            DatumDo = r.DatumDo;
        }
    }
}
