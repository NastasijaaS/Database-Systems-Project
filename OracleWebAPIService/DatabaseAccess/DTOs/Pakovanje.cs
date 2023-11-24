using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class PakovanjeView
    {
        public int IdPakovanja { get; protected set; }
        public string VrstaPakovanja { get; set; }
        public IList<LekView> PakovanjaZaLekove { get; set; }
        public IList<UpakovanUView> PakovanjaUpakovanU { get; set; }

        public PakovanjeView()
        {

        }

        public PakovanjeView(Pakovanje p)
        {
            IdPakovanja = p.IdPakovanja;
            VrstaPakovanja = p.VrstaPakovanja;
        }
    }
}
