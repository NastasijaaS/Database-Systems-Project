using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ProdajnoMestoView
    {
        public int Id { get; protected set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Mesto { get; set; }
        public IList<ReceptView> Recepti { get; set; }
        public IList<LekView> ProdajeLekove { get; set; }
        public IList<ProdajeSeView> ProdajeSeLek { get; set; }
        public IList<ZaposleniView> ZaposleniRadnici { get; set; }
        public IList<RadiUView> RadiUZaposleni { get; set; }

        public ProdajnoMestoView()
        {

        }

        public ProdajnoMestoView(ProdajnoMesto p)
        {
            Id = p.Id;
            Naziv = p.Naziv;
            Adresa = p.Adresa;
            Mesto = p.Mesto;
        }

    }
}
