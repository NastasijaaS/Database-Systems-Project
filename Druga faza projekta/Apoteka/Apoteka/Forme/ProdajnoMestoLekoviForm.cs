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
    public partial class ProdajnoMestoLekoviForm : Form
    {
        ProdajnoMestoBasic prodajnoMesto;
        public ProdajnoMestoLekoviForm()
        {
            InitializeComponent();
        }
        public ProdajnoMestoLekoviForm(ProdajnoMestoBasic p)
        {
            InitializeComponent();
            prodajnoMesto = p;
        }
        private void ProdajnoMestoLekoviForm_Load(object sender, EventArgs e)
        {
            this.Text = "ProdajnoMesto " + prodajnoMesto.Naziv.ToUpper();
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.lekovi.Items.Clear();
            List<LekPregled> lek = DTOManager.vratiLekoveZaProdajnoMesto(prodajnoMesto.Id);

            foreach (LekPregled r in lek)
            {
                ListViewItem item = new ListViewItem(new string[] { r.IdLeka.ToString(), r.DozaOdrasli, r.DozaDeca, r.DozaTrudnice, r.Dejstvo, r.HemijskiNaziv, r.NaRecept.ToString(), r.ProcenatParticipacije.ToString(), r.Cena.ToString(), r.KomercijalniNaziv });
                this.lekovi.Items.Add(item);
            }

            this.lekovi.Refresh();
        }
    }
}
