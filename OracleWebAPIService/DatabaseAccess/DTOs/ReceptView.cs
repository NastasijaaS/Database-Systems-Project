using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ReceptView
    {
        public int SerijskiBroj { get; protected set; }
        public string Lekar { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumRealizacije { get; set; }
        public ProdajnoMestoView RealizovanU { get; set; }
        public ZaposleniView Prodao { get; set; }
        public IList<LekView> ReceptPrepisanZaLek { get; set; }

        public ReceptView()
        {

        }

        public ReceptView(Recept r)
        {
            SerijskiBroj = r.SerijskiBroj;
            Lekar = r.Lekar;
            DatumIzdavanja = r.DatumIzdavanja;
            DatumRealizacije = r.DatumRealizacije;
            RealizovanU = new ProdajnoMestoView(r.RealizovanU);
            Prodao = new ZaposleniView(r.Prodao);
        }
    }
}
