using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class IndikacijaView
    {
        public int Id { get; set; }
        public string IndikacijaOpis { get; set; }
        public LekView Lek { get; set; }

        public IndikacijaView()
        {

        }

        public IndikacijaView(Indikacija i)
        {
            Id = i.Id;
            IndikacijaOpis = i.IndikacijaOpis;
            Lek = new LekView(i.Lek);
        }
    }
}
