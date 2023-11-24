using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class ProdajnoMesto
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Mesto { get; set; }
        public virtual IList<Recept> Recepti { get; set; }
        public virtual IList<Lek> ProdajeLekove{ get; set; }
        public virtual IList<ProdajeSe> ProdajeSeLek { get; set; }
        public virtual IList<Zaposleni> ZaposleniRadnici { get; set; }
        public virtual IList<RadiU> RadiUZaposleni { get; set; }



        public ProdajnoMesto()
        {
            Recepti = new List<Recept>();
            ProdajeLekove = new List<Lek>();
            ProdajeSeLek = new List<ProdajeSe>();
            ZaposleniRadnici = new List<Zaposleni>();
            RadiUZaposleni = new List<RadiU>();

        }
    }
}
