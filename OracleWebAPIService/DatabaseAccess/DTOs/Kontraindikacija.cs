using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class KontraindikacijaView
    {
        public int Id { get; set; }
        public string KontraindikacijaOpis { get; set; }
        public LekView Lek { get; set; }
        public KontraindikacijaView()
        {

        }

        public KontraindikacijaView(Kontraindikacija k)
        {
            Id = k.Id;
            KontraindikacijaOpis = k.KontraindikacijaOpis;
            Lek = new LekView(k.Lek);
        }
    }
}
