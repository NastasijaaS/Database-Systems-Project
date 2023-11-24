using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka.Forme
{
    public partial class LekDodajForm : Form
    {
        public LekPregled lek;
        public LekDodajForm()
        {
            InitializeComponent();
            lek = new LekPregled();
        }
        private void btnDodajLek_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi lek?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.lek.DozaOdrasli = tbDozaO.Text;
                this.lek.DozaDeca = tbDozaD.Text;
                this.lek.DozaTrudnice = tbDozaT.Text;
                this.lek.Dejstvo = tbDejstvo.Text;
                this.lek.HemijskiNaziv = tbHemijski.Text;
                this.lek.ProcenatParticipacije = Int32.Parse(tbProcenat.Text);
                this.lek.Cena = Int32.Parse(tbCena.Text);
                this.lek.KomercijalniNaziv = tbKomercijalni.Text;

                if (cb1.Checked)
                {
                    this.lek.NaRecept = 1;
                }
                else
                    this.lek.NaRecept = 0;

                //Uzimamo index selektovanog elementa iz combo box-a:
                int index = cb2.SelectedIndex;

                //Mora +1 zato sto ovde indeksi krecu od 0, a u bazi krecu od 1:
                this.lek.tip = index+1;
                this.lek.proizvodjac = cb3.SelectedItem.ToString();

                //Dodajemo lek u bazu podataka:
                DTOManager.dodajLek(this.lek);
                MessageBox.Show("Uspesno ste dodali novi lek!");
                this.Close();
            }
            else
            {

            }
        }

        private void LekDodajForm_Load(object sender, EventArgs e)
        {
            List<ProizvodjacPregled> p = DTOManager.vratiSveProizvodjace();

            foreach(ProizvodjacPregled pr in p)
            {
                cb3.Items.Add(pr);
            }

        }
    }
}
