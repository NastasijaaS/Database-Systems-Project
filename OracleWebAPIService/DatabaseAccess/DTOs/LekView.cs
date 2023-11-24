using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class LekView
    {
        public int IdLeka { get; protected set; }
        public string DozaOdrasli { get; set; }
        public string DozaDeca { get; set; }
        public string DozaTrudnice { get; set; }
        public string Dejstvo { get; set; }
        public string HemijskiNaziv { get; set; }
        public int NaRecept { get; set; }
        public int ProcenatParticipacije { get; set; }
        public int Cena { get; set; }
        public string KomercijalniNaziv { get; set; }
        public TipLekaView PripadaGrupi { get; set; }
        public ProizvodjacView ProizvedenOd { get; set; }
        public IList<ProdajnoMestoView> ProdajeSeU { get; set; }
        public IList<ProdajeSeView> ProdajeSeUProdajnimMestima { get; set; }
        public IList<ReceptView> LekPrepisanNaRecept { get; set; }
        public IList<UpakovanUView> UpakovanULek { get; set; }
        public IList<PakovanjeView> LekoviUPakovanja { get; set; }

        public LekView()
        {

        }

        public LekView(Lek l)
        {
            IdLeka = l.IdLeka;
            DozaOdrasli = l.DozaOdrasli;
            DozaDeca = l.DozaDeca;
            DozaTrudnice = l.DozaTrudnice;
            Dejstvo = l.Dejstvo;
            HemijskiNaziv = l.HemijskiNaziv;
            NaRecept = l.NaRecept;
            ProcenatParticipacije = l.ProcenatParticipacije;
            Cena = l.Cena;
            KomercijalniNaziv = l.KomercijalniNaziv;
            PripadaGrupi = new TipLekaView(l.PripadaGrupi);
            ProizvedenOd = new ProizvodjacView(l.ProizvedenOd);
        }
    }
}
