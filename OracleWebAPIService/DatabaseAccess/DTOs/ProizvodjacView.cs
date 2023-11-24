using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ProizvodjacView
    {
        public string Naziv { get; set; }
        public IList<LekView> Lekovi { get; set; }

        public ProizvodjacView()
        {

        }

        public ProizvodjacView(Proizvodjac p)
        {
            Naziv = p.Naziv;
        }

    }
}
