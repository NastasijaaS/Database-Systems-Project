using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using DatabaseAccess.Entiteti;
using System.Threading.Tasks;
using NHibernate;
using DatabaseAccess.DTOs;

namespace DatabaseAccess
{
    public class DataProvider
    {

        #region ProdajnaMesta


        public static List<ProdajnoMestoView> VratiSveProdavnice()
        {
            List<ProdajnoMestoView> prodajnaMesta = new List<ProdajnoMestoView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProdajnoMesto> sveProdavnice = from o in s.Query<ProdajnoMesto>()
                                                                            select o;
                foreach (ProdajnoMesto p in sveProdavnice)
                {
                    prodajnaMesta.Add(new ProdajnoMestoView(p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return prodajnaMesta;
        }
        public static void DodajProdajnoMesto(ProdajnoMesto p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.ProdajnoMesto o = new DatabaseAccess.Entiteti.ProdajnoMesto();

                o.Naziv = p.Naziv;
                o.Adresa = p.Adresa;
                o.Mesto = p.Mesto;

                s.SaveOrUpdate(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static ProdajnoMesto AzurirajProdajnoMesto(ProdajnoMesto p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.ProdajnoMesto o = s.Load<DatabaseAccess.Entiteti.ProdajnoMesto>(p.Id);
                o.Naziv = p.Naziv;
                o.Adresa = p.Adresa;
                o.Mesto = p.Mesto;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return p;
        }
        public static ProdajnoMestoView VratiProdajnoMesto(int id)
        {
            ProdajnoMestoView pb = new ProdajnoMestoView();
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.ProdajnoMesto o = s.Load<DatabaseAccess.Entiteti.ProdajnoMesto>(id);
                pb = new ProdajnoMestoView(o);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return pb;
        }
        public static ProdajnoMestoView VratiProdajnoMestoPregled(int id)
        {
            ProdajnoMestoView pm = new ProdajnoMestoView();
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.ProdajnoMesto o = s.Load<DatabaseAccess.Entiteti.ProdajnoMesto>(id);
                pm = new ProdajnoMestoView(o);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return pm;
        }
        public static void ObrisiProdajnoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.ProdajnoMesto o = s.Load<DatabaseAccess.Entiteti.ProdajnoMesto>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        #endregion

        #region Zaposleni

        //Metoda za dodavanje radnika:
        public static void DodajZaposlenog(string mbr, string ime, string prezime, DateTime rodj, string adr, int tel, int farmaceut, DateTime dipl, DateTime obnovio, bool zaposli, int idMesta, DateTime radiOd)
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
                
                if(farmaceut == 0)
                {
                    s.SaveOrUpdate(z);
                }
                else
                {
                    s.SaveOrUpdate(f);
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

                    return;
                }

                s.Close();
                return;
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<ZaposleniView> VratiSveZaposlene()
        {
            //Lista zaposlenih koju popunjavamo iz baze i vracamo nazad na formu 'Zaposleni'
            List<ZaposleniView> zaposleniLista = new List<ZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposleni> sviZaposleni = from o in s.Query<Zaposleni>() select o;

                foreach (Zaposleni z in sviZaposleni)
                {
                    ZaposleniView novi;
                    if (z.Farmaceut == 1)
                    {
                        Farmaceut f = s.Load<Farmaceut>(z.MaticniBroj);
                        novi = new FarmaceutView(f);
                    }
                    else
                    {
                        novi = new ZaposleniView(z);
                    }

                    novi.Recepti = z.Recepti.Select(p => new ReceptView(p)).ToList();
                    novi.ProdajnaMesta = z.ProdajnaMesta.Select(p => new ProdajnoMestoView(p)).ToList();
                    novi.RadiUProdajnaMesta = z.RadiUProdajnaMesta.Select(p => new RadiUView(p)).ToList();

                    zaposleniLista.Add(novi);
                }

                s.Close();
                return zaposleniLista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return zaposleniLista;
        }
        public static List<ZaposleniView> VratiSveZaposleneBasic()
        {
            List<ZaposleniView> radnici = new List<ZaposleniView>();
            List<FarmaceutView> farmaceuti = new List<FarmaceutView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DatabaseAccess.Entiteti.Zaposleni> sviRadnici = from o in s.Query<DatabaseAccess.Entiteti.Zaposleni>()
                                                                     select o;

                foreach (DatabaseAccess.Entiteti.Zaposleni r in sviRadnici)
                {
                    radnici.Add(new ZaposleniView(r));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return radnici;
        }
        public static void PromeniZaposlenog(string mbr, string ime, string prezime, DateTime rodj, string addr, string tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.Zaposleni z = s.Get<DatabaseAccess.Entiteti.Zaposleni>(mbr);
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
                Console.WriteLine(ex.Message);
            }
        }
        public static void ObrisiZaposlenog(string mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.Zaposleni r = s.Load<DatabaseAccess.Entiteti.Zaposleni>(mbr);
                if (r.Farmaceut == 1)
                {
                    //Isti mbr se koristi za obe tabele:
                    DatabaseAccess.Entiteti.Farmaceut f = s.Load<DatabaseAccess.Entiteti.Farmaceut>(mbr);
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
                Console.WriteLine(ec.Message);
            }
        }
        public static String RadnoMestoZaposlenog(string mbr)
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
                Console.WriteLine(ex.Message);
            }
            return p;
        }
        public static void ObrisiZaposlenogIzProdavnice(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.Zaposleni r = s.Load<DatabaseAccess.Entiteti.Zaposleni>(id);
                r.ProdajnaMesta.Clear();
                // r.RadiUProdavnice.Clear(); jedan radnik moze da radi i u vise prodavnica //ovo mozda nece biti potrebno
                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static List<ZaposleniView> VratiZaposleneZaProdajnoMesto(int id)
        {
            List<ZaposleniView> zaposleni = new List<ZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<RadiU> sviZaposleni = from o in s.Query<RadiU>()
                                                  where o.Id.RadiUProdajnoMesto.Id == id
                                                  select o;

                foreach (RadiU r in sviZaposleni)
                {
                    if (r.Id.ZaposleniRadiU.Farmaceut == 0)
                    {
                        zaposleni.Add(new ZaposleniView(r.Id.ZaposleniRadiU));
                    }   //Inace je farmaceut?
                    else
                    {
                        Farmaceut f = s.Load<Farmaceut>(r.Id.ZaposleniRadiU.MaticniBroj);
                        //I ovo mozda pravi problem, ko zna?
                        zaposleni.Add(new FarmaceutView(f));
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }

            return zaposleni;
        }

        #region Farmaceut

        public static FarmaceutView VratiFarmaceuta(string mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Farmaceut f = s.Load<Farmaceut>(mbr);
                FarmaceutView fv = new FarmaceutView(f);
                fv.ProdajnaMesta = f.ProdajnaMesta.Select(p => new ProdajnoMestoView(p)).ToList();
                fv.RadiUProdajnaMesta = f.RadiUProdajnaMesta.Select(p => new RadiUView(p)).ToList();
                fv.Recepti = f.Recepti.Select(p => new ReceptView(p)).ToList();

                s.Close();

                return fv;

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void ObnoviLicencuFarmaceutu(string mbr, DateTime datum)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Farmaceut f = s.Load<Farmaceut>(mbr);
                f.ObnovioLicencu = datum;

                s.Update(f);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #endregion

        #region Recepti

        public static void DodajRecept(int sbr, string lekar, DateTime izdat, DateTime realizovan, string zaposleni, int mesto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Recept r = new Recept();

                Zaposleni z = s.Load<Zaposleni>(zaposleni);
                ProdajnoMesto p = s.Load<ProdajnoMesto>(mesto);

                r.SerijskiBroj = sbr;
                r.Lekar = lekar;
                r.DatumIzdavanja = izdat;
                r.DatumRealizacije = realizovan;
                r.Prodao = z;
                r.RealizovanU = p;

                s.Save(r);
                s.Flush();

                z.Recepti.Add(r);
                p.Recepti.Add(r);

                s.Update(z);
                s.Update(p);
                s.Flush();

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<ReceptView> VratiSveRecepte()
        {
            List<ReceptView> lista = new List<ReceptView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Recept> recepti = from o in s.Query<Recept>() select o;
                foreach(Recept r in recepti)
                {
                    lista.Add(new ReceptView(r));
                }

                s.Close();
                return lista;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static List<ReceptView> VratiSveRecepte(String mbr)
        {
            //Lista recepta koju vracamo nazad:
            List<ReceptView> receptiLista = new List<ReceptView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Recept> recepti = from o in s.Query<Recept>() where o.Prodao.MaticniBroj == mbr select o;

                foreach (Recept r in recepti)
                {
                    receptiLista.Add(new ReceptView(r));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return receptiLista;
        }
        public static List<LekView> VratiLekoveSaRecepta(int serial)
        {
            List<LekView> lista = new List<LekView>();
            try
            {
                ISession s = DataLayer.GetSession();

                Recept r = s.Load<Recept>(serial);
                foreach(Lek l in r.ReceptPrepisanZaLek)
                {
                    lista.Add(new LekView(l));
                }

                s.Close();
                return lista;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static List<LekView> DodajLekNaRecept(int rec, int lek)
        {
            try
            {
                List<LekView> lista = new List<LekView>();
                ISession s = DataLayer.GetSession();

                Recept t = s.Load<Recept>(rec);
                Lek l = s.Load<Lek>(lek);

                t.ReceptPrepisanZaLek.Add(l);

                s.Update(t);
                s.Flush();

                foreach(Lek le in t.ReceptPrepisanZaLek)
                {
                    lista.Add(new LekView(le));
                }

                s.Close();
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void ObrisiRecept(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Recept r = s.Load<Recept>(id);
                Zaposleni z = r.Prodao;
                ProdajnoMesto p = r.RealizovanU;

                //Moramo da izbacimo i recepte iz evidencije koje imamo u obj. Lek:
                foreach(Lek l in r.ReceptPrepisanZaLek)
                {
                    l.LekPrepisanNaRecept.Remove(r);
                    s.Update(l);
                    s.Flush();
                }

                r.ReceptPrepisanZaLek.Clear();
                s.Update(r);
                s.Flush();

                z.Recepti.Remove(r);
                p.Recepti.Remove(r);

                s.Update(z);
                s.Update(p);
                s.Flush();

                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Lek

        public static List<LekView> VratiSveLekovePregled()
        {
            List<LekView> prodaja = new List<LekView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lek> lekovi = from o in s.Query<DatabaseAccess.Entiteti.Lek>()
                                                  select o;

                foreach (Lek l in lekovi)
                {
                    LekView lek = DataProvider.VratiLek1(l.IdLeka);
                    prodaja.Add(lek);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return prodaja;

        }
        public static LekView VratiLek(int id)
        {
            LekView rb = new LekView();
            try
            {
                ISession s = DataLayer.GetSession();

                Lek p = s.Load<Lek>(id);
                rb = new LekView(p);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return rb;
        }
        public static LekView VratiLek1(int id)
        {
            LekView rb = new LekView();
            try
            {
                ISession s = DataLayer.GetSession();

                Lek p = s.Load<Lek>(id);
                rb = new LekView(p);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return rb;
        }
        public static String NazivTipaLeka(int id)
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
                Console.WriteLine(ex.Message);
            }
            return tip.Grupa;
        }
        public static List<LekView> VratiLekovePoPakovanju(String pak)
        {
            List<LekView> prodaja = new List<LekView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<UpakovanU> lekoviUpakovani = from o in s.Query<UpakovanU>() where o.Id.UpakovanUPakovanje.VrstaPakovanja == pak
                                          select o;
                //MessageBox.Show(lekoviUpakovani.Count().ToString());
                foreach (UpakovanU l in lekoviUpakovani)
                {
                    LekView lek = DataProvider.VratiLek1(l.Id.LekUpakovanU.IdLeka);
                    prodaja.Add(lek);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return prodaja;

        }
        public static List<LekView> VratiLekovePoProizvodjacu(String pro)
        {
            List<LekView> prodaja = new List<LekView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lek> lekoviProizvedeni = from o in s.Query<Lek>()
                                                         where o.ProizvedenOd.Naziv == pro
                                                         select o;
                //MessageBox.Show(lekoviProizvedeni.Count().ToString());
                foreach (Lek l in lekoviProizvedeni)
                {
                    LekView lek = DataProvider.VratiLek1(l.IdLeka);
                    prodaja.Add(lek);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return prodaja;

        }
        public static void DodajLek(Lek p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //Pravimo novi objekat tipa lek:
                Lek o = new Lek();
                
                //Trazimo objekat TipLeka po id-ju:
                IEnumerable<TipLeka> tipLeka = from i in s.Query<TipLeka>() where i.IdTipa == p.PripadaGrupi.IdTipa select i;

                IEnumerable<Proizvodjac> pr = from d in s.Query<Proizvodjac>() where d.Naziv == p.ProizvedenOd.Naziv.ToString() select d;

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
                Console.WriteLine(ec.Message);
            }
        }
        public static void ObrisiLekIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek p = s.Load<Lek>(id);

                //MessageBox.Show("Dobili smo id: " + id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show("Pronasli smo: " + p.KomercijalniNaziv, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void IzmeniLek(int sbr, string cena, string part, int recept)
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
                Console.WriteLine(ex.Message);
            }
        }
        public static List<ProdajnoMestoView> MestaProdajeLekova(int sbr)
        {
            List<ProdajnoMestoView> lista = new List<ProdajnoMestoView>();
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
                    lista.Add(new ProdajnoMestoView(m));
                }

                s.Close();
                return lista;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
        public static List<LekView> VratiLekoveZaProdajnoMesto(int id)
        {
            List<LekView> lekovi = new List<LekView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProdajeSe> sviLekovi = from o in s.Query<ProdajeSe>()
                                                                    where o.Id.ProdajeSeUProdajnoMesto.Id == id
                                                                    select o;

                foreach (ProdajeSe r in sviLekovi)
                {
                    //Takodje, postoji sansa da sam nesto zeznuo:
                    lekovi.Add(new LekView(r.Id.LekProdajeSeU));
                }

                s.Close();
                return lekovi;
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }
        }
        public static List<LekView> FiltrirajListu(string proizv, string pak)
        {
            List<LekView> lista = new List<LekView>();
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
                            lista.Add(new LekView(l));
                        }

                        s.Close();
                        return lista;
                    }
                    else
                    {
                        //Inace moramo da filtriramo po pakovanju:
                        IEnumerable<UpakovanUId> pakovanja = from o in s.Query<UpakovanUId>() where o.UpakovanUPakovanje.VrstaPakovanja == pak select o;
                        foreach(UpakovanUId l in pakovanja)
                        {
                            //Takodje, svasta sam obrisao:
                            lista.Add(new LekView(l.LekUpakovanU));
                        }

                        s.Close();
                        return lista;
                    }
                }
                else
                {
                    //Inace moramo svakako prvo da filtriramo po proizvodjacu:
                    IEnumerable<Lek> lekovi = from o in s.Query<Lek>() where o.ProizvedenOd.Naziv == proizv select o;
                    foreach(Lek l in lekovi)
                    {
                        lista.Add(new LekView(l));
                    }

                    if(pak == "")
                    {
                        //Trebaju nam sva pakovanja, znaci imamo sve sto nam treba:
                        s.Close();
                        return lista;
                    }
                    else
                    {
                        //Inace moramo prvo od svih lekova ovog proizvodjaca da izvucemo samo one sa odgovarajucim pakovanjem:
                        List<LekView> nova = new List<LekView>();

                        IEnumerable<Pakovanje> niz = from o in s.Query<Pakovanje>() where o.VrstaPakovanja == pak select o;
                        int idPak = niz.ElementAt(0).IdPakovanja;

                        foreach(LekView l in lista)
                        {
                            if (l.PripadaGrupi.IdTipa == idPak)
                                nova.Add(l);
                        }

                        s.Close();
                        return nova;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static List<LekView> VratiLekovePoTipu(string tip)
        {
            List<LekView> lista = new List<LekView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<TipLeka> tipovi = from o in s.Query<TipLeka>() where o.Grupa == tip select o;

                TipLeka t = tipovi.ElementAt(0);

                foreach(Lek l in t.Lekovi)
                {
                    LekView lv = new LekView(l);
                    lista.Add(lv);
                }

                s.Close();

                return lista;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void IzmeniTipLeka(int lekId, string tip)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek l = s.Load<Lek>(lekId);
                TipLeka temp = l.PripadaGrupi;
                
                IEnumerable<TipLeka> tipovi = from o in s.Query<TipLeka>() where o.Grupa == tip select o;
                TipLeka noviTip = tipovi.ElementAt(0);

                temp.Lekovi.Remove(l);
                noviTip.Lekovi.Add(l);
                l.PripadaGrupi = noviTip;

                s.Update(l);
                s.Update(temp);
                s.Update(noviTip);
                s.Flush();

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region ProdajeSe

        public static void DodajLekUProdajnoMesto(int lekId, int mestoId, int kol)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek l = s.Load<Lek>(lekId);
                ProdajnoMesto p = s.Load<ProdajnoMesto>(mestoId);

                ProdajeSe pro = new ProdajeSe();
                pro.Id = new ProdajeSeUId();

                pro.Id.LekProdajeSeU = l;
                pro.Id.ProdajeSeUProdajnoMesto = p;
                pro.Kolicina = kol;

                s.SaveOrUpdate(pro);
                s.Flush();

                l.ProdajeSeUProdajnimMestima.Add(pro);
                p.ProdajeLekove.Add(l);
                s.Update(l);
                s.Update(p);
                s.Flush();
                
                s.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region Indikacije


        public static void DodajIndikaciju(int sbr, string tekst)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Indikacija i = new Indikacija();

                Lek l = s.Get<Lek>(sbr);

                i.Lek = l;
                i.IndikacijaOpis = tekst;

                s.Save(i);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UkloniIndikaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Indikacija i = s.Load<Indikacija>(id);

                s.Delete(i);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<IndikacijaView> VratiSveIndikacijeLeka(int sbr)
        {
            List<IndikacijaView> lista = new List<IndikacijaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Indikacija> indikacije = from i in s.Query<Indikacija>() where i.Lek.IdLeka == sbr select i;

                foreach (Indikacija d in indikacije)
                {
                    lista.Add(new IndikacijaView(d));
                }

                s.Close();

                return lista;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
        public static void IzmeniIndikaciju(int sbr, string data)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Indikacija i = s.Load<Indikacija>(sbr);
                i.IndikacijaOpis = data;

                s.Update(i);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
      

        #endregion

        #region Kontraindikacije


        public static void DodajKontraindikaciju(int sbr, string tekst)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kontraindikacija k = new Kontraindikacija();

                Lek l = s.Get<Lek>(sbr);
                k.Lek = l;
                k.KontraindikacijaOpis = tekst;

                s.SaveOrUpdate(k);
                s.Flush();
               
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UkloniKontraindikaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kontraindikacija k = s.Load<Kontraindikacija>(id);

                s.Delete(k);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<KontraindikacijaView> VratiSveKontraindikacijeLeka(int sbr)
        {
            List<KontraindikacijaView> lista = new List<KontraindikacijaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Kontraindikacija> indikacije = from i in s.Query<Kontraindikacija>() where i.Lek.IdLeka == sbr select i;
                foreach (Kontraindikacija d in indikacije)
                {
                    lista.Add(new KontraindikacijaView(d));
                }

                s.Close();

                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
        public static void IzmeniKontraindikaciju(int sbr, string data)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kontraindikacija i = s.Load<Kontraindikacija>(sbr);
                i.KontraindikacijaOpis = data;

                s.Update(i);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        #endregion

        #region Pakovanje


        public static List<PakovanjeView> VratiSvaPakovanja()
        {
            List<PakovanjeView> lista = new List<PakovanjeView>();
            try
            {
                ISession s = DataLayer.GetSession();

                //Izvlacimo sve?
                IEnumerable<Pakovanje> pakovanja = from i in s.Query<Pakovanje>() where i.IdPakovanja != 0 select i;
                foreach(Pakovanje p in pakovanja)
                {
                    lista.Add(new PakovanjeView(p));
                    //MessageBox.Show(p.VrstaPakovanja + " " + p.IdPakovanja, "Message", MessageBoxButtons.OK);
                }

                s.Close();
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
        public static void UpakujLek(int id, int idPak, int kol, string sastav)
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
                Console.WriteLine(ex.Message);
            }
        }
        public static string VratiPakovanje(int idLeka)
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
                Console.WriteLine(ex.Message);
            }

            return null;
        }
        public static void IzmeniSastavPakovanja(int idPak, int lekId, int staraKol, int novaKol, string noviSastav)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Radimo query upit za odgovarajuci obj:
                IEnumerable<UpakovanU> lista = from o in s.Query<UpakovanU>()
                                         where o.Kolicina == staraKol &&
                                               o.Id.LekUpakovanU.IdLeka == lekId &&
                                               o.Id.UpakovanUPakovanje.IdPakovanja == idPak
                                         select o;
                
                //Posto smo radili query, morali smo da rezultat smestimo u listu, a posto je
                //svakako rezultat samo 1 objekat, vadimo ga sa nulte pozicije:
                UpakovanU u = lista.ElementAt(0);

                //Radimo update:
                u.Sastav = noviSastav;
                u.Kolicina = novaKol;

                s.Update(u);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ObrisiVezuLekPakovanje(int idLek, int idPak, int kol)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Radimo query upit za odgovarajuci obj:
                IEnumerable<UpakovanU> lista = from o in s.Query<UpakovanU>()
                                               where o.Kolicina == kol &&
                                                     o.Id.LekUpakovanU.IdLeka == idLek &&
                                                     o.Id.UpakovanUPakovanje.IdPakovanja == idPak
                                               select o;

                //Posto smo radili query, morali smo da rezultat smestimo u listu, a posto je
                //svakako rezultat samo 1 objekat, vadimo ga sa nulte pozicije:
                UpakovanU u = lista.ElementAt(0);

                IEnumerable<Pakovanje> pakovanja = from o in s.Query<Pakovanje>()
                                                   where o.PakovanjaUpakovanU == u
                                                   select o;

                Lek l = s.Load<Lek>(idLek);
                l.UpakovanULek.Remove(u);
                s.Update(l);
                s.Flush();

                //s.Delete(u.Id);
                //s.Flush();
                s.Delete(u);
                s.Flush();

                s.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region RadiU


        //Ovo stvarno nemam ideju da li ce da radi:
        public static void DodajRadniOdnos(RadiUView radi)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadiU r = new RadiU();
                r.Id = new RadiUId();
                r.Id.RadiUProdajnoMesto = s.Get<ProdajnoMesto>(radi.Id.RadiUProdajnoMesto.Id);
                r.Id.ZaposleniRadiU = s.Get<Zaposleni>(radi.Id.ZaposleniRadiU.MaticniBroj);
                r.DatumOd = radi.DatumOd;
                r.DatumDo = radi.DatumDo;

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        #endregion

        #region Proizvodjac


        public static string ImeProizvodjaca(string komNaziv)
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
                Console.WriteLine(ex.Message);
            }

            return null;
        }
        public static List<ProizvodjacView> VratiSveProizvodjace()
        {
            List<ProizvodjacView> lista = new List<ProizvodjacView>();
            try
            {
                ISession s = DataLayer.GetSession();

                //Izvlacimo sve?
                IEnumerable<Proizvodjac> proizvodjaci = from i in s.Query<Proizvodjac>() select i;
                foreach (Proizvodjac p in proizvodjaci)
                {
                    lista.Add(new ProizvodjacView(p));
                    //MessageBox.Show(p.VrstaPakovanja + " " + p.IdPakovanja, "Message", MessageBoxButtons.OK);
                }

                s.Close();
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
        public static void DodajProizvodjaca(Proizvodjac p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Proizvodjac novi = new Proizvodjac();
                novi.Naziv = p.Naziv;

                s.SaveOrUpdate(novi);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //public static void ObrisiProizvodjaca(string name)
        //{
        //    try
        //    {
        //        ISession s = DataLayer.GetSession();


                

        //        s.Close();
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        public static void IzmeniProizvodjaca(int sbr, string novi)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek l = s.Load<Lek>(sbr);
                Proizvodjac p = s.Load<Proizvodjac>(l.ProizvedenOd.Naziv);
                Proizvodjac pNovi = s.Load<Proizvodjac>(novi);

                p.Lekovi.Remove(l);
                pNovi.Lekovi.Add(l);
                l.ProizvedenOd = pNovi;

                s.Update(l);
                s.Update(p);
                s.Update(pNovi);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

    }
}
