using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class ZaposleniView
    {
        public string MaticniBroj { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public int BrojTelefona { get; set; }
        public int Farmaceut { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public IList<ReceptView> Recepti { get; set; }
        public IList<ProdajnoMestoView> ProdajnaMesta { get; set; }
        public IList<RadiUView> RadiUProdajnaMesta { get; set; }

        public ZaposleniView()
        {

        }

        public ZaposleniView(Zaposleni z)
        {
            MaticniBroj = z.MaticniBroj;
            Ime = z.Ime;
            Prezime = z.Prezime;
            Adresa = z.Adresa;
            BrojTelefona = z.BrojTelefona;
            Farmaceut = z.Farmaceut;
        } 

    }
}
