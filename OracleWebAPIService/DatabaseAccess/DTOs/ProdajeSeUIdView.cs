using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ProdajeSeUIdView
    {
        public LekView LekProdajeSeU { get; set; }
        public ProdajnoMestoView ProdajeSeUProdajnoMesto { get; set; }

        public ProdajeSeUIdView()
        {

        }

        public ProdajeSeUIdView(ProdajeSeUId p)
        {
            LekProdajeSeU = new LekView(p.LekProdajeSeU);
            ProdajeSeUProdajnoMesto = new ProdajnoMestoView(p.ProdajeSeUProdajnoMesto);
        }


    }
}
