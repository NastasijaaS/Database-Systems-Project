using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class TipLekaView
    {
        public int IdTipa { get; set; }
        public string Grupa { get; set; }
        public IList<LekView> Lekovi { get; set; }

        public TipLekaView()
        {

        }

        public TipLekaView(TipLeka t)
        {
            IdTipa = t.IdTipa;
            Grupa = t.Grupa;
        }
    }
}
