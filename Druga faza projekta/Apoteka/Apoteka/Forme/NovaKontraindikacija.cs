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
    public partial class NovaKontraindikacija : Form
    {
        public List<LekPregled> lekovi = null;
        public NovaKontraindikacija(List<LekPregled> list)
        {
            this.lekovi = list;
            InitializeComponent();
        }
        private void NovaKontraindikacija_Load(object sender, EventArgs e)
        {
            foreach(LekPregled l in this.lekovi)
            {
                this.cbxLekovi.Items.Add(l.KomercijalniNaziv);
            }
            this.cbxLekovi.SelectedIndex = 0;
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da dodate kontraindikaciju za lek?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                DTOManager.dodajKontraindikaciju(this.lekovi.ElementAt(this.cbxLekovi.SelectedIndex).IdLeka, this.tbxTekst.Text);
                MessageBox.Show("Uspesno smo dodali kontaindikaciju!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
