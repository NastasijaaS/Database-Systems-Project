using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Entiteti;

namespace Apoteka
{

    #region ProdajnaMesta

    public class ProdajnoMestoPregled
    {
        public int Id;
        public string Naziv;
        public string Adresa;
        public string Mesto;


        public ProdajnoMestoPregled()
        {

        }
        public ProdajnoMestoPregled(int id, string naziv, string adresa, string mesto)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Adresa = adresa;
            this.Mesto = mesto;

        }
    }

    public class ProdajnoMestoBasic
    {
        public int Id;
        public string Naziv;
        public string Adresa;
        public string Mesto;

        public virtual IList<LekBasic> Lekovi { get; set; }

        public virtual IList<ZaposleniBasic> Radnici { get; set; }

        public ProdajnoMestoBasic()
        {
            Lekovi = new List<LekBasic>();
            Radnici = new List<ZaposleniBasic>();
        }
        public ProdajnoMestoBasic(int id, string naziv, string adresa, string mesto)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Adresa = adresa;
            this.Mesto = mesto;

        }
    }

    #endregion

    #region Zaposleni

    public class ZaposleniPregled
    {
        public string MaticniBroj;
        public string Ime;
        public string Prezime;
        public string Adresa;
        public int BrojTelefona;
        public DateTime DatumRodjenja;
        public int Farmaceut;
        public ZaposleniPregled()
        {

        }
        public ZaposleniPregled(string mbr, string ime, string prezime, string adresa, int brTelefona, DateTime datumRodjenja, int farmaceut)
        {
            this.MaticniBroj = mbr;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.BrojTelefona = brTelefona;
            this.DatumRodjenja = datumRodjenja;
            this.Farmaceut = farmaceut;
        }
    }

    public class ZaposleniBasic
    {
        public string MaticniBroj;
        public string Ime;
        public string Prezime;
        public string Adresa;
        public int BrojTelefona;
        public DateTime DatumRodjenja;
        public int Farmaceut;
        public DateTime Diplomirao;
        public DateTime ObnovioLicencu;

        public IList<RadiUBasic> RadiUProdajnaMesta { get; set; }

        public ZaposleniBasic()
        {
            RadiUProdajnaMesta = new List<RadiUBasic>();

        }
        public ZaposleniBasic(string mbr, string ime, string prezime, string adresa, int brTelefona, DateTime datumRodjenja, int farmaceut)
        {
            this.MaticniBroj = mbr;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.BrojTelefona = brTelefona;
            this.DatumRodjenja = datumRodjenja;
            this.Farmaceut = farmaceut;
        }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }

    public class FarmaceutPregled : ZaposleniPregled
    {
        public DateTime Diplomirao;
        public DateTime ObnovioLicencu;
        public FarmaceutPregled()
        {

        }

        public FarmaceutPregled(string mbr, string ime, string prezime, string adr, int brTel, DateTime datumRodjenja, int farmaceut, DateTime dipl, DateTime obnovioLic)
            : base(mbr, ime, prezime, adr, brTel, datumRodjenja, farmaceut)
        {
            this.Diplomirao = dipl;
            this.ObnovioLicencu = obnovioLic;
        }
    }

    public class FarmaceutBasic : ZaposleniBasic
    {


        public FarmaceutBasic()
        {
        }
        public FarmaceutBasic(string mbr, string ime, string prezime, string adresa, int brTelefona, DateTime datumRodjenja, int farmaceut, DateTime dipl, DateTime obnovio)
        {
            this.MaticniBroj = mbr;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.BrojTelefona = brTelefona;
            this.DatumRodjenja = datumRodjenja;
            this.Farmaceut = farmaceut;
            this.Diplomirao = dipl;
            this.ObnovioLicencu = obnovio;
        }
        public override string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }

    #endregion

    #region RadiU 
    public class RadiUPregled
    {
        public RadiUId Id;
        public DateTime DatumOd;
        public DateTime? DatumDo;

        public RadiUPregled()
        {

        }

        public RadiUPregled(RadiUId id, DateTime datumOd, DateTime? datumDo)
        {
            this.Id = id;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
        }

    }

    public class RadiUBasic
    {
        public RadiUIdBasic Id;
        public DateTime DatumOd;
        public DateTime? DatumDo;

        public RadiUBasic()
        {

        }

        public RadiUBasic(RadiUIdBasic id, DateTime datumOd, DateTime? datumDo)
        {
            this.Id = id;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
        }

    }
    public class RadiUIdBasic
    {
        public ZaposleniBasic ZaposleniRadiU { get; set; }
        public ProdajnoMestoBasic RadiUProdajnoMesto { get; set; }

        public RadiUIdBasic()
        {

        }

    }

    #endregion

    #region Lek
    public class LekBasic
    {
        public int IdLeka { get; set; }
        public string DozaOdrasli { get; set; }
        public string DozaDeca { get; set; }
        public string DozaTrudnice { get; set; }
        public string Dejstvo { get; set; }
        public string HemijskiNaziv { get; set; }
        public int NaRecept { get; set; }
        public int ProcenatParticipacije { get; set; }
        public int Cena { get; set; }
        public string KomercijalniNaziv { get; set; }

        public virtual IList<ProdajeSeBasic> ProdajeSeUProdajnimMestima { get; set; }
        public virtual IList<Recept> LekPrepisanNaRecept { get; set; }
        public virtual IList<UpakovanUBasic> UpakovanULek { get; set; }



        public LekBasic()
        {

            ProdajeSeUProdajnimMestima = new List<ProdajeSeBasic>();
            LekPrepisanNaRecept = new List<Recept>();
            UpakovanULek = new List<UpakovanUBasic>();

        }

        public LekBasic(int lId, string dozao, string dozad, string dozat, string dej, string hem, int nr, int proc, int cena, string kn)
        {
            this.IdLeka = lId;
            this.DozaOdrasli = dozao;
            this.DozaDeca = dozad;
            this.DozaTrudnice = dozat;
            this.Dejstvo = dej;
            this.HemijskiNaziv = hem;
            this.NaRecept = nr;
            this.ProcenatParticipacije = proc;
            this.Cena = cena;
            this.KomercijalniNaziv = kn;
        }

    }


    public class LekPregled
    {
        public int IdLeka { get; set; }
        public string DozaOdrasli { get; set; }
        public string DozaDeca { get; set; }
        public string DozaTrudnice { get; set; }
        public string Dejstvo { get; set; }
        public string HemijskiNaziv { get; set; }
        public int NaRecept { get; set; }
        public int ProcenatParticipacije { get; set; }
        public int Cena { get; set; }
        public string KomercijalniNaziv { get; set; }

        public int tip { get; set; }
        public string proizvodjac { get; set; }



        public LekPregled(int lId, string dozao, string dozad, string dozat, string dej, string hem, int nr, int proc, int cena, string kn,int tip, string proizvodjac)
        {
            this.IdLeka = lId;
            this.DozaOdrasli = dozao;
            this.DozaDeca = dozad;
            this.DozaTrudnice = dozat;
            this.Dejstvo = dej;
            this.HemijskiNaziv = hem;
            this.NaRecept = nr;
            this.ProcenatParticipacije = proc;
            this.Cena = cena;
            this.KomercijalniNaziv = kn;
            this.tip = tip;
            this.proizvodjac = proizvodjac;
           
        }
        public LekPregled(int id,string kn,int cena)
        {
            this.IdLeka = id;
            this.KomercijalniNaziv = kn;
            this.Cena = cena;
            //this.tip = tip;
        }
        public LekPregled()
        {

        }




    }


    #endregion

    #region ProdajeSe
    public class ProdajeSePregled
    {
        public ProdajeSeIdBasic Id;
        public int Kolicina;
      

        public ProdajeSePregled()
        {

        }

        public ProdajeSePregled(ProdajeSeIdBasic id, int k)
        {
            this.Id = id;
            this.Kolicina = k;
           
        }

    }

    public class ProdajeSeBasic
    {
        public ProdajeSeIdBasic Id;
        public int Kolicina;


        public ProdajeSeBasic()
        {

        }

        public ProdajeSeBasic(ProdajeSeIdBasic id, int k)
        {
            this.Id = id;
            this.Kolicina = k;


        }

    }

    public class ProdajeSeIdBasic
    {
        public LekBasic ProdajeSeLek { get; set; }
        public ProdajnoMestoBasic ProdajeSeUProdajnoMesto { get; set; }

        public ProdajeSeIdBasic()
        {

        }

    }

    #endregion

    #region UpakovanU
    public class UpakovanUPregled
    {
        public UpakovanUIdBasic Id;
        public int Kolicina;
        public string Sastav;


        public UpakovanUPregled()
        {

        }

        public UpakovanUPregled(UpakovanUIdBasic id, int k,string sas)
        {
            this.Id = id;
            this.Kolicina = k;
            this.Sastav = sas;

        }

    }

    public class UpakovanUBasic
    {
        public UpakovanUIdBasic Id;
        public int Kolicina;
        public string Sastav;


        public UpakovanUBasic()
        {

        }

        public UpakovanUBasic(UpakovanUIdBasic id, int k,string sas)
        {
            this.Id = id;
            this.Kolicina = k;
            this.Sastav = sas;


        }

    }

    public class UpakovanUIdBasic
    {
        public LekBasic PakujeSeLek { get; set; }
        public PakovanjeBasic LekPakovanje { get; set; }

        public UpakovanUIdBasic()
        {

        }

    }

    #endregion

    #region Pakovanje
    public class PakovanjePregled
    {
        public int IdPakovanja;
        public string VrstaPakovanja;
     


        public PakovanjePregled()
        {

        }
        public PakovanjePregled(int id, string vrsta)
        {
            this.IdPakovanja = id;
            this.VrstaPakovanja = vrsta;
         

        }

        public override string ToString()
        {
            return VrstaPakovanja;
        }
    }

    public class PakovanjeBasic
    {
        public int IdPakovanja;
        public string VrstaPakovanja;
     

        public virtual IList<UpakovanUBasic> UpakovanUPakovanje { get; set; }

        public PakovanjeBasic()
        {
            UpakovanUPakovanje = new List<UpakovanUBasic>();
        }
        public PakovanjeBasic(int id, string vrsta )
        {
            this.IdPakovanja = id;
            this.VrstaPakovanja = vrsta;
           

        }
    }

    #endregion

    #region Indikacija

    public class IndikacijaPregled
    {
        public int Id { get; set; }
        public string Indikacija { get; set; }


        public IndikacijaPregled()
        {

        }

        public IndikacijaPregled(int id, string ind)
        {
            this.Id = id;
            this.Indikacija = ind;
        }
    }

    public class IndikacijaBasic
    {
        public int Id { get; set; }
        public string Indikacija { get; set; }

        public LekBasic Lek { get; set; }

        public IndikacijaBasic()
        {

        }

        public IndikacijaBasic(int id, string ind, LekBasic l)
        {
            this.Id = id;
            this.Indikacija = ind;
            this.Lek = l;
        }
    }
    #endregion

    #region Kontraindikacija

    public class KontraindikacijaPregled
    {
        public int Id { get; set; }
        public string Indikacija { get; set; }


        public KontraindikacijaPregled()
        {

        }

        public KontraindikacijaPregled(int id, string ind)
        {
            this.Id = id;
            this.Indikacija = ind;
        }
    }

    public class KontraindikacijaBasic
    {
        public int Id { get; set; }
        public string Indikacija { get; set; }

        public LekBasic Lek { get; set; }

        public KontraindikacijaBasic()
        {

        }

        public KontraindikacijaBasic(int id, string ind, LekBasic l)
        {
            this.Id = id;
            this.Indikacija = ind;
            this.Lek = l;
        }
    }
    #endregion

    #region Proizvodjac

    public class ProizvodjacPregled
    {

        public string Naziv;
   

        public ProizvodjacPregled()
        {

        }
        public ProizvodjacPregled(string na)
        {
            this.Naziv = na;
          
        }

        public override string ToString()
        {
            return Naziv;
        }

    }

    #endregion

    #region TipLeka
    public class TipLekaPregled
    {

        public int IdTipa;
        public string Grupa;


        public TipLekaPregled()
        {

        }
        public TipLekaPregled(int id,string gr)
        {
            this.IdTipa = id;
            this.Grupa = gr;

        }
    }


    #endregion

    #region Recept

    public class ReceptPregled
    {

        public  int SerijskiBroj { get;  set; }
        public  string Lekar { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public  DateTime DatumRealizacije { get; set; }


        public ReceptPregled()
        {

        }
        public ReceptPregled(int serbr, string lek,DateTime dati,DateTime datumre)
        {
            this.SerijskiBroj = serbr;
            this.Lekar = lek;
            this.DatumIzdavanja = dati;
            this.DatumRealizacije = datumre;

        }
    }

    public class ReceptBasic
    {

        public int SerijskiBroj { get; set; }
        public string Lekar { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumRealizacije { get; set; }

        public virtual ProdajnoMestoBasic RealizovanU { get; set; }
        public virtual ZaposleniBasic Prodao { get; set; }

        public virtual IList<LekBasic> ReceptPrepisanZaLek { get; set; }

        public ReceptBasic()
        {
            ReceptPrepisanZaLek = new List<LekBasic>();

        }
        public ReceptBasic(int serbr, string lek, DateTime dati, DateTime datumre)
        {
            this.SerijskiBroj = serbr;
            this.Lekar = lek;
            this.DatumIzdavanja = dati;
            this.DatumRealizacije = datumre;

        }
    }



    #endregion

}

