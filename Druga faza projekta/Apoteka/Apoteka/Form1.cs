using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Apoteka.Entiteti;

namespace Apoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVratiProdajnoMesto_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                ProdajnoMesto p = s.Get<ProdajnoMesto>(2);

                MessageBox.Show(p.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVratiZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Zaposleni p = s.Get<Zaposleni>("5369421758632");

                MessageBox.Show(p.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
               
            }
        }

        private void btnVratiRecept_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Recept r = s.Get<Recept>(5263541);

                MessageBox.Show(r.Lekar);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnVratiProizvodjaca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Proizvodjac p = s.Get<Proizvodjac>("Hemofarm");

                MessageBox.Show(p.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnVratiTipLeka_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                TipLeka t = s.Get<TipLeka>(1);

                MessageBox.Show(t.Grupa);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnVratiPakovanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Pakovanje p = s.Get<Pakovanje>(1);

                MessageBox.Show(p.VrstaPakovanja);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici sa zadatim brojem
                Zaposleni p = s.Get<Zaposleni>("5445348635158");

                foreach (Recept o in p.Recepti)
                {
                    MessageBox.Show(o.DatumRealizacije + " " + o.DatumIzdavanja);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnVratiLek_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Lek l = s.Get<Lek>(2);

                MessageBox.Show(l.KomercijalniNaziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek r1 = s.Get<Lek>(1);

                foreach (Entiteti.Pakovanje p1 in r1.LekoviUPakovanja)
                {
                    MessageBox.Show(p1.VrstaPakovanja);
                }


                Entiteti.Pakovanje p2 = s.Get<Entiteti.Pakovanje>(2);

                foreach (Lek r2 in p2.PakovanjaZaLekove)
                {
                    MessageBox.Show(r2.KomercijalniNaziv + " " + r2.HemijskiNaziv);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

        }
    }
}
