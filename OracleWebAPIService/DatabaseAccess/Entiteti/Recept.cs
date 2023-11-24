using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Recept
    {
        public virtual int SerijskiBroj { get; set; }
        public virtual string Lekar { get; set; }
        public virtual DateTime DatumIzdavanja { get; set; }
        public virtual DateTime DatumRealizacije { get; set; }
        public virtual ProdajnoMesto RealizovanU { get; set; }
        public virtual Zaposleni Prodao { get; set; }
        public virtual IList<Lek> ReceptPrepisanZaLek { get; set; }

        public Recept()
        {
            ReceptPrepisanZaLek = new List<Lek>();
        }


    }
}
