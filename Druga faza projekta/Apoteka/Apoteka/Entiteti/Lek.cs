using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Lek
    {
        public virtual int IdLeka { get; protected set; }
        public virtual string DozaOdrasli { get; set; }
        public virtual string DozaDeca { get; set; }
        public virtual string DozaTrudnice { get; set; }
        public virtual string Dejstvo { get; set; }
        public virtual string HemijskiNaziv { get; set; }
        public virtual int NaRecept { get; set; }
        public virtual int ProcenatParticipacije { get; set; }
        public virtual int Cena { get; set; }
        public virtual string KomercijalniNaziv { get; set; }


        public virtual TipLeka PripadaGrupi { get; set; }
        public virtual Proizvodjac ProizvedenOd { get; set; }
        public virtual IList<ProdajnoMesto> ProdajeSeU { get; set; }
        public virtual IList<ProdajeSe> ProdajeSeUProdajnimMestima { get; set; }
        public virtual IList<Recept> LekPrepisanNaRecept { get; set; }
        public virtual IList<UpakovanU> UpakovanULek { get; set; }
        public virtual IList<Pakovanje> LekoviUPakovanja { get; set; }


        public Lek()
        {
            ProdajeSeU = new List<ProdajnoMesto>();
            ProdajeSeUProdajnimMestima = new List<ProdajeSe>();
            LekPrepisanNaRecept = new List<Recept>();
            UpakovanULek = new List<UpakovanU>();
            LekoviUPakovanja = new List<Pakovanje>();
        }
    }
}
