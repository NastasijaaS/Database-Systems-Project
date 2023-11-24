using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using Apoteka.Entiteti;
using System.Windows.Forms;
using System.Threading.Tasks;
using NHibernate;


namespace Apoteka
{
    public class DTOManager
    {

        #region ProdajnaMesta


        public static List<ProdajnoMestoPregled> vratiSveProdavnice()
        {
            List<ProdajnoMestoPregled> prodajnaMesta = new List<ProdajnoMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProdajnoMesto> sveProdavnice = from o in s.Query<ProdajnoMesto>()
                                                                            select o;
                foreach (ProdajnoMesto p in sveProdavnice)
                {
                    prodajnaMesta.Add(new ProdajnoMestoPregled(p.Id, p.Naziv, p.Adresa, p.Mesto));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return prodajnaMesta;
        }
        public static void dodajProdajnoMesto(ProdajnoMestoBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.ProdajnoMesto o = new Apoteka.Entiteti.ProdajnoMesto();

                o.Naziv = p.Naziv;
                o.Adresa = p.Adresa;
                o.Mesto = p.Mesto;

                s.SaveOrUpdate(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static ProdajnoMestoBasic azurirajProdajnoMesto(ProdajnoMestoBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.ProdajnoMesto o = s.Load<Apoteka.Entiteti.ProdajnoMesto>(p.Id);
                o.Naziv = p.Naziv;
                o.Adresa = p.Adresa;
                o.Mesto = p.Mesto;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static ProdajnoMestoBasic vratiProdajnoMesto(int id)
        {
            ProdajnoMestoBasic pb = new ProdajnoMestoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.ProdajnoMesto o = s.Load<Apoteka.Entiteti.ProdajnoMesto>(id);
                pb = new ProdajnoMestoBasic(o.Id, o.Naziv, o.Adresa, o.Mesto);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }
        public static ProdajnoMestoPregled vratiProdajnoMestoPregled(int id)
        {
            ProdajnoMestoPregled pm = new ProdajnoMestoPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.ProdajnoMesto o = s.Load<Apoteka.Entiteti.ProdajnoMesto>(id);
                pm = new ProdajnoMestoPregled(o.Id, o.Naziv, o.Adresa, o.Mesto);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pm;
        }
        public static void obrisiProdajnoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.ProdajnoMesto o = s.Load<Apoteka.Entiteti.ProdajnoMesto>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        #endregion

        #region Zaposleni


        //Metoda za dodavanje radnika:
        public static void dodajZaposlenog(string mbr, string ime, string prezime, DateTime rodj, string adr, int tel, int farmaceut, DateTime dipl, DateTime obnovio, bool zaposli, int idMesta, DateTime radiOd)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Pravimo novog zaposlenog:
                Zaposleni z = new Zaposleni();
                Farmaceut f = new Farmaceut();
                
                if(farmaceut == 0)
                {

                    z.MaticniBroj = mbr;
                    z.Ime = ime;
                    z.Prezime = prezime;
                    z.DatumRodjenja = rodj;
                    z.Adresa = adr;
                    z.BrojTelefona = tel;
                    z.Farmaceut = farmaceut;
                }
                else
                {

                    f.MaticniBroj = mbr;
                    f.Ime = ime;
                    f.Prezime = prezime;
                    f.DatumRodjenja = rodj;
                    f.Adresa = adr;
                    f.BrojTelefona = tel;
                    f.Farmaceut = farmaceut;

                    f.Diplomirao = dipl;
                    f.ObnovioLicencu = obnovio;
                }

                string poruka = "Mbr: " + mbr + "\nIme: " + ime + "\nPrezime: " + prezime + "\nRodjen: " + rodj.ToShortDateString() + "\nAdresa: " + adr + "\nBroj telefona: " + tel + "\nFarmaceut: " + farmaceut;
                
                if(farmaceut == 0)
                {
                    s.SaveOrUpdate(z);
                }
                else
                {
                    s.SaveOrUpdate(f);
                    string dodatak = "\nDiplomirao: " + dipl.ToShortDateString() + "\nObnovio licencu: " + obnovio.ToShortDateString();
                    poruka += dodatak;
                }
                s.Flush();

                //Ako je cekiran CheckBox "Zaposli", trebamo da dodamo i radni odnos za radnika:
                if (zaposli)
                {
                    //Izvlacimo prodajno mesto:
                    ProdajnoMesto p = s.Load<ProdajnoMesto>(idMesta);

                    //Spajamo (Mesto&Radnika) i datum pocetka rada:
                    RadiU radiU = new RadiU();
                    radiU.DatumOd = radiOd;

                    //Spajamo radnika i radno mesto:
                    radiU.Id = new RadiUId();
                    radiU.Id.RadiUProdajnoMesto = p;
                    if(farmaceut == 0)
                    {
                        radiU.Id.ZaposleniRadiU = z;
                    }
                    else
                    {   //Mora parse, zato sto cuvamo referencu na drugi objekat: 
                        radiU.Id.ZaposleniRadiU = (Zaposleni)f;
                    }

                    //z.RadiUProdajnaMesta.Add(radiU);
                    s.SaveOrUpdate(radiU);
                    s.Flush();

                    s.Close();

                    string dodatak = "\nZaposlen u radno mesto: " + p.Naziv + " - " + p.Adresa + "\nOd datuma: " + radiOd.ToShortDateString();

                    MessageBox.Show("Uspesno dodat novi radnik: " + poruka + dodatak, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Uspesno dodat novi radnik: " + poruka, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                s.Close();
                return;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Metoda za ucitavanje svih zaposlenih iz baze podataka:
        public static List<ZaposleniPregled> vratiSveZaposlene()
        {
            //Lista zaposlenih koju popunjavamo iz baze i vracamo nazad na formu 'Zaposleni'
            List<ZaposleniPregled> zaposleniLista = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposleni> sviZaposleni = from o in s.Query<Zaposleni>() select o;

                foreach (Zaposleni z in sviZaposleni)
                {
                    ZaposleniPregled novi;
                    if (z.Farmaceut == 1)
                    {
                        Farmaceut f = s.Load<Farmaceut>(z.MaticniBroj);
                        novi = new FarmaceutPregled(z.MaticniBroj, z.Ime, z.Prezime, z.Adresa, z.BrojTelefona, z.DatumRodjenja, z.Farmaceut, f.Diplomirao, f.ObnovioLicencu);
                    }
                    else
                    {
                        novi = new ZaposleniPregled(z.MaticniBroj, z.Ime, z.Prezime, z.Adresa, z.BrojTelefona, z.DatumRodjenja, z.Farmaceut);
                    }

                    zaposleniLista.Add(novi);
                }

                s.Close();
                return zaposleniLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return zaposleniLista;
        }
        public static List<ZaposleniBasic> vratiSveZaposleneBasic()
        {
            List<ZaposleniBasic> radnici = new List<ZaposleniBasic>();
            List<FarmaceutBasic> farmaceuti = new List<FarmaceutBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Apoteka.Entiteti.Zaposleni> sviRadnici = from o in s.Query<Apoteka.Entiteti.Zaposleni>()
                                                                     select o;

                foreach (Apoteka.Entiteti.Zaposleni r in sviRadnici)
                {
                    radnici.Add(new ZaposleniBasic(r.MaticniBroj, r.Ime, r.Prezime,
                    r.Adresa, r.BrojTelefona, r.DatumRodjenja,
                    r.Farmaceut));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return radnici;
        }
        public static void promeniZaposlenog(string mbr, string ime, string prezime, DateTime rodj, string addr, string tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Zaposleni z = s.Get<Apoteka.Entiteti.Zaposleni>(mbr);
                z.Ime = ime;
                z.Prezime = prezime;
                z.DatumRodjenja = rodj;
                z.Adresa = addr;
                z.BrojTelefona = Int32.Parse(tel);

                s.Update(z);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void obrisiZaposlenog(string mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Zaposleni r = s.Load<Apoteka.Entiteti.Zaposleni>(mbr);
                if (r.Farmaceut == 1)
                {
                    //Isti mbr se koristi za obe tabele:
                    Apoteka.Entiteti.Farmaceut f = s.Load<Apoteka.Entiteti.Farmaceut>(mbr);
                    //Ne mozemo prvo da obrisemo zaposlenog zato sto farmaceut ima ref. na istog,
                    //pa mora ovim redosledom:
                    s.Delete(f);
                }

                r.ProdajnaMesta.Clear();
                r.RadiUProdajnaMesta.Clear(); //jedan radnik moze da radi i u vise prodavnica
                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        //Vrati naziv radnog mesta zaposlenog:
        public static String radnoMestoZaposlenog(string mbr)
        {
            string p = null;
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<RadiU> mesto = from o in s.Query<RadiU>() where o.Id.ZaposleniRadiU.MaticniBroj == mbr select o;

                p = "Apoteka: " + mesto.ElementAt(0).Id.RadiUProdajnoMesto.Naziv + "\nAdresa: " + mesto.ElementAt(0).Id.RadiUProdajnoMesto.Adresa;
                s.Close();

                return p;
            }
            catch (Exception ex)
            {

            }
            return p;
        }
        public static void obrisiZaposlenogIzProdavnice(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Zaposleni r = s.Load<Apoteka.Entiteti.Zaposleni>(id);
                r.ProdajnaMesta.Clear();
                // r.RadiUProdavnice.Clear(); jedan radnik moze da radi i u vise prodavnica //ovo mozda nece biti potrebno
                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        #region Farmaceut

        //Ok
        public static Farmaceut vratiFarmaceuta(string mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Farmaceut f = s.Load<Farmaceut>(mbr);

                MessageBox.Show("Diplomirao: " + f.Diplomirao + " Obnovio:" + f.ObnovioLicencu, "Message", MessageBoxButtons.OK);

                s.Close();
                return f;
            } catch (Exception ex)
            {
                //Console.
                return null;
            }
        }

        #endregion

        #endregion

        #region Recepti


        //Vrati sve recepte koji referenciraju ovog zaposlenog:
        public static List<ReceptPregled> vratiSveRecepte(String mbr)
        {
            //Lista recepta koju vracamo nazad:
            List<ReceptPregled> receptiLista = new List<ReceptPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Recept> recepti = from o in s.Query<Recept>() where o.Prodao.MaticniBroj == mbr select o;

                foreach (Recept r in recepti)
                {
                    receptiLista.Add(new ReceptPregled(r.SerijskiBroj, r.Lekar, r.DatumIzdavanja, r.DatumRealizacije));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return receptiLista;
        }


        #endregion

        #region Lek


        public static List<LekPregled> vratiSveLekovePregled()
        {
            List<LekPregled> prodaja = new List<LekPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lek> lekovi = from o in s.Query<Apoteka.Entiteti.Lek>()
                                                  select o;

                foreach (Lek l in lekovi)
                {
                    LekPregled lek = DTOManager.vratiLek1(l.IdLeka);
                    prodaja.Add(lek);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return prodaja;

        }
        public static LekPregled vratiLek(int id)
        {
            LekPregled rb = new LekPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Lek p = s.Load<Apoteka.Entiteti.Lek>(id);
                rb = new LekPregled(p.IdLeka, p.KomercijalniNaziv, p.Cena);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return rb;
        }
        public static LekPregled vratiLek1(int id)
        {
            LekPregled rb = new LekPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Lek p = s.Load<Apoteka.Entiteti.Lek>(id);
                rb = new LekPregled(p.IdLeka, p.DozaOdrasli, p.DozaDeca, p.DozaTrudnice, p.Dejstvo, p.HemijskiNaziv, p.NaRecept, p.ProcenatParticipacije, p.Cena, p.KomercijalniNaziv,p.PripadaGrupi.IdTipa, p.ProizvedenOd.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return rb;
        }
        //Vrati naziv tipa leka:
        public static String nazivTipaLeka(int id)
        {
            TipLeka tip = new TipLeka();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TipLeka> tipLeka = from i in s.Query<TipLeka>() where i.IdTipa == id select i;
                tip = tipLeka.ElementAt(0);

                s.Close();

                return tip.Grupa;
            }
            catch (Exception ex)
            {

            }
            return tip.Grupa;

        }

        public static List<LekPregled> vratiLekovePoPakovanju(String pak)
        {
            List<LekPregled> prodaja = new List<LekPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<UpakovanU> lekoviUpakovani = from o in s.Query<Apoteka.Entiteti.UpakovanU>() where o.Id.UpakovanUPakovanje.VrstaPakovanja == pak
                                          select o;
                //MessageBox.Show(lekoviUpakovani.Count().ToString());
                foreach (UpakovanU l in lekoviUpakovani)
                {
                    LekPregled lek = DTOManager.vratiLek1(l.Id.LekUpakovanU.IdLeka);
                    prodaja.Add(lek);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return prodaja;

        }

        public static List<LekPregled> vratiLekovePoProizvodjacu(String pro)
        {
            List<LekPregled> prodaja = new List<LekPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lek> lekoviProizvedeni = from o in s.Query<Apoteka.Entiteti.Lek>()
                                                         where o.ProizvedenOd.Naziv == pro
                                                         select o;
                //MessageBox.Show(lekoviProizvedeni.Count().ToString());
                foreach (Lek l in lekoviProizvedeni)
                {
                    LekPregled lek = DTOManager.vratiLek1(l.IdLeka);
                    prodaja.Add(lek);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return prodaja;

        }
        //Metoda za dodavanje novog leka u bazu podataka:
        public static void dodajLek(LekPregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //Pravimo novi objekat tipa lek:
                Apoteka.Entiteti.Lek o = new Apoteka.Entiteti.Lek();
                
                //Trazimo objekat TipLeka po id-ju:
                IEnumerable<TipLeka> tipLeka = from i in s.Query<TipLeka>() where i.IdTipa == p.tip select i;

                IEnumerable<Proizvodjac> pr = from d in s.Query<Proizvodjac>() where d.Naziv == p.proizvodjac.ToString() select d;

                //Samo stampamo sta smo nasli:
                TipLeka t = tipLeka.ElementAt(0);
                //Uzimamo proizvodjaca:
                Proizvodjac pro = pr.ElementAt(0);

                o.DozaDeca = p.DozaDeca;
                o.DozaOdrasli = p.DozaOdrasli;
                o.DozaTrudnice = p.DozaTrudnice;
                o.Dejstvo = p.Dejstvo;
                o.HemijskiNaziv = p.HemijskiNaziv;
                o.NaRecept = p.NaRecept;
                o.ProcenatParticipacije = p.ProcenatParticipacije;
                o.Cena = p.Cena;
                o.KomercijalniNaziv = p.KomercijalniNaziv;
                o.PripadaGrupi = t;
                o.ProizvedenOd = pro;

                s.SaveOrUpdate(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        //Metoda za brisanje leka iz baze podataka:
        public static void obrisiLekIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Lek p = s.Load<Apoteka.Entiteti.Lek>(id);

                //MessageBox.Show("Dobili smo id: " + id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show("Pronasli smo: " + p.KomercijalniNaziv, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //p.ProdajeSeU.Clear();
                //p.ProdajeSeUProdajnimMestima.Clear();
      
                //p.UpakovanULek.Clear();
                //p.LekoviUPakovanja.Clear();
                //p.LekPrepisanNaRecept.Clear();
             
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void izmeniLek(int sbr, string cena, string part, int recept)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek l = s.Get<Lek>(sbr);
                l.Cena = Int32.Parse(cena);
                l.ProcenatParticipacije = Int32.Parse(part);
                l.NaRecept = recept;

                s.Update(l);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static List<ProdajnoMestoPregled> mestaProdajeLekova(int sbr)
        {
            List<ProdajnoMestoPregled> lista = new List<ProdajnoMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProdajeSe> mesta = from i in s.Query<ProdajeSe>() where i.Id.LekProdajeSeU.IdLeka == sbr select i;
                List < ProdajnoMesto > prodajnaMesta = new List<ProdajnoMesto>();

                foreach(ProdajeSe d in mesta)
                {
                    prodajnaMesta.Add(d.Id.ProdajeSeUProdajnoMesto);
                }

                foreach(ProdajnoMesto m in prodajnaMesta)
                {
                    lista.Add(new ProdajnoMestoPregled(m.Id, m.Naziv, m.Adresa, m.Mesto));
                }

                s.Close();
                return lista;
            }
            catch(Exception ex)
            {

            }
            return lista;
        }
        public static List<LekPregled> vratiLekoveZaProdajnoMesto(int id)
        {
            List<LekPregled> lekovi = new List<LekPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Apoteka.Entiteti.ProdajeSe> sviLekovi = from o in s.Query<Apoteka.Entiteti.ProdajeSe>()
                                                                    where o.Id.ProdajeSeUProdajnoMesto.Id == id
                                                                    select o;

                foreach (Apoteka.Entiteti.ProdajeSe r in sviLekovi)
                {
                    lekovi.Add(new LekPregled(r.Id.LekProdajeSeU.IdLeka, r.Id.LekProdajeSeU.DozaOdrasli, r.Id.LekProdajeSeU.DozaDeca,
                    r.Id.LekProdajeSeU.DozaTrudnice, r.Id.LekProdajeSeU.Dejstvo, r.Id.LekProdajeSeU.HemijskiNaziv, r.Id.LekProdajeSeU.NaRecept,
                    r.Id.LekProdajeSeU.ProcenatParticipacije,
                    r.Id.LekProdajeSeU.Cena, r.Id.LekProdajeSeU.KomercijalniNaziv, r.Id.LekProdajeSeU.PripadaGrupi.IdTipa, r.Id.LekProdajeSeU.ProizvedenOd.Naziv));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }



            return lekovi;
        }
        public static List<ZaposleniPregled> vratiZaposleneZaProdajnoMesto(int id)
        {
            List<ZaposleniPregled> zaposleni = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Apoteka.Entiteti.RadiU> sviZaposleni = from o in s.Query<Apoteka.Entiteti.RadiU>()
                                                                    where o.Id.RadiUProdajnoMesto.Id == id
                                                                    select o;

                foreach (Apoteka.Entiteti.RadiU r in sviZaposleni)
                {
                    if(r.Id.ZaposleniRadiU.Farmaceut == 0) 
                    { 
                        zaposleni.Add(new ZaposleniPregled(r.Id.ZaposleniRadiU.MaticniBroj, r.Id.ZaposleniRadiU.Ime, r.Id.ZaposleniRadiU.Prezime,
                        r.Id.ZaposleniRadiU.Adresa, r.Id.ZaposleniRadiU.BrojTelefona,
                        r.Id.ZaposleniRadiU.DatumRodjenja, r.Id.ZaposleniRadiU.Farmaceut
                        ));            
                    }   //Inace je farmaceut?
                    else
                    {
                        Farmaceut f = s.Load<Farmaceut>(r.Id.ZaposleniRadiU.MaticniBroj);

                        zaposleni.Add(new FarmaceutPregled(r.Id.ZaposleniRadiU.MaticniBroj, r.Id.ZaposleniRadiU.Ime, r.Id.ZaposleniRadiU.Prezime,
                        r.Id.ZaposleniRadiU.Adresa, r.Id.ZaposleniRadiU.BrojTelefona,
                        r.Id.ZaposleniRadiU.DatumRodjenja, r.Id.ZaposleniRadiU.Farmaceut,
                        f.Diplomirao, f.ObnovioLicencu));
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }



            return zaposleni;
        }

        public static List<LekPregled> filtrirajListu(string proizv, string pak)
        {
            List<LekPregled> lista = new List<LekPregled>();
            //MessageBox.Show(proizv + " " + pak);
            try
            {
                ISession s = DataLayer.GetSession();

                //Ako ne filtriramo po proizvodjacu prvo:
                if(proizv == "")
                {
                    //Vracamo sve:
                    if(pak == "")
                    {
                        IEnumerable<Lek> lekovi = from o in s.Query<Lek>() select o;
                        foreach(Lek l in lekovi)
                        {
                            lista.Add(new LekPregled(l.IdLeka, l.DozaOdrasli, l.DozaDeca, l.DozaTrudnice, l.Dejstvo, l.HemijskiNaziv, l.NaRecept, l.ProcenatParticipacije, l.Cena, l.KomercijalniNaziv, l.PripadaGrupi.IdTipa, l.ProizvedenOd.Naziv));
                        }
                        return lista;
                    }
                    else
                    {
                        //Inace moramo da filtriramo po pakovanju:
                        IEnumerable<UpakovanUId> pakovanja = from o in s.Query<UpakovanUId>() where o.UpakovanUPakovanje.VrstaPakovanja == pak select o;
                        foreach(UpakovanUId l in pakovanja)
                        {
                            lista.Add(new LekPregled(l.LekUpakovanU.IdLeka, l.LekUpakovanU.DozaOdrasli, l.LekUpakovanU.DozaDeca, l.LekUpakovanU.DozaTrudnice, l.LekUpakovanU.Dejstvo, l.LekUpakovanU.HemijskiNaziv, l.LekUpakovanU.NaRecept, l.LekUpakovanU.ProcenatParticipacije, l.LekUpakovanU.Cena, l.LekUpakovanU.KomercijalniNaziv, l.LekUpakovanU.PripadaGrupi.IdTipa, l.LekUpakovanU.ProizvedenOd.Naziv));
                        }
                        return lista;
                    }
                }
                else
                {
                    //Inace moramo svakako prvo da filtriramo po proizvodjacu:
                    IEnumerable<Lek> lekovi = from o in s.Query<Lek>() where o.ProizvedenOd.Naziv == proizv select o;
                    foreach(Lek l in lekovi)
                    {
                        lista.Add(new LekPregled(l.IdLeka, l.DozaOdrasli, l.DozaDeca, l.DozaTrudnice, l.Dejstvo, l.HemijskiNaziv, l.NaRecept, l.ProcenatParticipacije, l.Cena, l.KomercijalniNaziv, l.PripadaGrupi.IdTipa, l.ProizvedenOd.Naziv));
                    }

                    if(pak == "")
                    {
                        //Trebaju nam sva pakovanja, znaci imamo sve sto nam treba:
                        return lista;
                    }
                    else
                    {
                        //Inace moramo prvo od svih lekova ovog proizvodjaca da izvucemo samo one sa odgovarajucim pakovanjem:
                        List<LekPregled> nova = new List<LekPregled>();

                        IEnumerable<Pakovanje> niz = from o in s.Query<Pakovanje>() where o.VrstaPakovanja == pak select o;
                        int idPak = niz.ElementAt(0).IdPakovanja;

                        foreach(LekPregled l in lista)
                        {
                            if (l.tip == idPak)
                                nova.Add(l);
                        }

                        return nova;
                    }
                }

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        #endregion

        #region Indikacije


        public static void dodajIndikaciju(int sbr, string tekst)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Indikacija i = new Apoteka.Entiteti.Indikacija();

                Lek l = s.Get<Lek>(sbr);

                i.Lek = l;
                i.IndikacijaOpis = tekst;

                s.Save(i);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void ukloniIndikaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Indikacija i = s.Load<Apoteka.Entiteti.Indikacija>(id);

                s.Delete(i);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<IndikacijaPregled> vratiSveIndikacijeLeka(int sbr)
        {
            List<IndikacijaPregled> lista = new List<IndikacijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Apoteka.Entiteti.Indikacija> indikacije = from i in s.Query<Apoteka.Entiteti.Indikacija>() where i.Lek.IdLeka == sbr select i;

                foreach (Indikacija d in indikacije)
                {
                    lista.Add(new IndikacijaPregled(d.Id, d.IndikacijaOpis));
                }

                s.Close();

                return lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lista;
        }


        #endregion

        #region Kontraindikacije


        public static void dodajKontraindikaciju(int sbr, string tekst)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Kontraindikacija k = new Apoteka.Entiteti.Kontraindikacija();

                Lek l = s.Get<Lek>(sbr);
                k.Lek = l;
                k.KontraindikacijaOpis = tekst;

                s.SaveOrUpdate(k);
                s.Flush();
               
                s.Close();
            }
            catch(Exception ex)
            {

            }
        }
        public static void ukloniKontraindikaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apoteka.Entiteti.Kontraindikacija k = s.Load<Apoteka.Entiteti.Kontraindikacija>(id);

                s.Delete(k);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<KontraindikacijaPregled> vratiSveKontraindikacijeLeka(int sbr)
        {
            List<KontraindikacijaPregled> lista = new List<KontraindikacijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Apoteka.Entiteti.Kontraindikacija> indikacije = from i in s.Query<Apoteka.Entiteti.Kontraindikacija>() where i.Lek.IdLeka == sbr select i;
                foreach (Kontraindikacija d in indikacije)
                {
                    lista.Add(new KontraindikacijaPregled(d.Id, d.KontraindikacijaOpis));
                }

                s.Close();

                return lista;
            }
            catch (Exception ex)
            {

            }

            return lista;
        }


        #endregion

        #region Pakovanje


        public static List<PakovanjePregled> vratiSvaPakovanja()
        {
            List<PakovanjePregled> lista = new List<PakovanjePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                //Izvlacimo sve?
                IEnumerable<Pakovanje> pakovanja = from i in s.Query<Pakovanje>() where i.IdPakovanja != 0 select i;
                foreach(Pakovanje p in pakovanja)
                {
                    lista.Add(new PakovanjePregled(p.IdPakovanja, p.VrstaPakovanja));
                    //MessageBox.Show(p.VrstaPakovanja + " " + p.IdPakovanja, "Message", MessageBoxButtons.OK);
                }

                s.Close();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lista;
        }
        public static void upakujLek(int id, int idPak, int kol, string sastav)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavamo objekat tipa leka:
                Lek l = s.Load<Lek>(id);

                //Ucitavamo objekat tipa pakovanje:
                Pakovanje p = s.Load<Pakovanje>(idPak);

                //Pravimo novi objekat tipa Upakovan_u(kolicina, sastav, upakovan_u_id):
                UpakovanU upakovan = new UpakovanU();
                upakovan.Id = new UpakovanUId();

                //Inicijalizujemo objekat veze izmenju pakovanja i leka:
                upakovan.Id.LekUpakovanU = l;
                upakovan.Id.UpakovanUPakovanje = p;

                upakovan.Kolicina = kol;
                upakovan.Sastav = sastav;

                s.SaveOrUpdate(upakovan);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Vrati sve informacije vezane za pakovanje i dati lek:
        public static string vratiPakovanje(int idLeka)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Uzimamo lek, jer moramo da pretrazimo listu lekova za pakovanje:
                Lek lek = s.Load<Lek>(idLeka);

                //Veza izmedju leka i pakovanja:
                IEnumerable<UpakovanU> veze = from o in s.Query<UpakovanU>() where o.Id.LekUpakovanU == lek select o;
                UpakovanU upakovan = veze.ElementAt(0);

                //Izvlacimo stvari koje nam trebau da vratimo:
                string response;
                response = upakovan.Sastav + "\nKolicina: " + upakovan.Kolicina + "\nVrsta pakovanja: " + upakovan.Id.UpakovanUPakovanje.VrstaPakovanja;

                s.Close();

                //Sastav - Kolicina - Pakovanje;
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }


        #endregion

        #region RadiU


        public static void dodajRadniOdnos(RadiUBasic radi)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadiU r = new RadiU();
                r.Id = new RadiUId();
                r.Id.RadiUProdajnoMesto = s.Get<Apoteka.Entiteti.ProdajnoMesto>(radi.Id.RadiUProdajnoMesto.Id);
                r.Id.ZaposleniRadiU = s.Get<Zaposleni>(radi.Id.ZaposleniRadiU.MaticniBroj);
                r.DatumOd = radi.DatumOd;
                r.DatumDo = radi.DatumDo;

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        #endregion

        #region Proizvodjac


        public static string imeProizvodjaca(string komNaziv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Mora IEnumerable zato sto imamo Query:
                IEnumerable<Lek> lekNiz = from o in s.Query<Lek>() where o.KomercijalniNaziv == komNaziv select o;
                Lek l = lekNiz.ElementAt(0);

                //Trazimo proizvodjaca koji u svom nizu ima lek sa ovim kom. nazivom:
                IEnumerable<Proizvodjac> proizvodjaci = from o in s.Query<Proizvodjac>() where o.Lekovi.Contains(l) select o;
                //Samo jedan proizvodjac ima lek sa ovim komercijalnim nazivom:
                Proizvodjac p = proizvodjaci.ElementAt(0);

                s.Close();

                //Sada samo trebamo da vratimo naziv ovog proizvodjaca:
                return p.Naziv;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }


        public static List<ProizvodjacPregled> vratiSveProizvodjace()
        {
            List<ProizvodjacPregled> lista = new List<ProizvodjacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                //Izvlacimo sve?
                IEnumerable<Proizvodjac> proizvodjaci = from i in s.Query<Proizvodjac>() select i;
                foreach (Proizvodjac p in proizvodjaci)
                {
                    lista.Add(new ProizvodjacPregled(p.Naziv));
                    //MessageBox.Show(p.VrstaPakovanja + " " + p.IdPakovanja, "Message", MessageBoxButtons.OK);
                }

                s.Close();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lista;
        }


        #endregion

    }
}
