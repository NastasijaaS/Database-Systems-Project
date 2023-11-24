using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class RadiUIdView
    {
        public ZaposleniView ZaposleniRadiU { get; set; }
        public ProdajnoMestoView RadiUProdajnoMesto { get; set; }

        public RadiUIdView()
        {

        }

        public RadiUIdView(RadiUId r)
        {
            ZaposleniRadiU = new ZaposleniView(r.ZaposleniRadiU);
            RadiUProdajnoMesto = new ProdajnoMestoView(r.RadiUProdajnoMesto);
        }
    }
}
