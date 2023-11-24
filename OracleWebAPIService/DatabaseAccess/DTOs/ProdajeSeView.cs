using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ProdajeSeView
    {
        public ProdajeSeUIdView Id { get; set; }
        public int Kolicina { get; set; }

        public ProdajeSeView()
        {
        
        }

        public ProdajeSeView(ProdajeSe p)
        {
            Kolicina = p.Kolicina;
            Id = new ProdajeSeUIdView(p.Id);
        }

    }
}
