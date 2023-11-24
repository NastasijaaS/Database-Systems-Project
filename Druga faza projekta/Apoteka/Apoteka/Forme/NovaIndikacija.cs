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
    public partial class NovaIndikacija : Form
    {
        public List<LekPregled> lekovi = null;
        public NovaIndikacija(List<LekPregled> lekovi)
        {
            this.lekovi = lekovi;
            InitializeComponent();
        }
        private void NovaIndikacija_Load(object sender, EventArgs e)
        {
            foreach (LekPregled l in this.lekovi)
            {
                this.cboxLek.Items.Add(l.KomercijalniNaziv);
            }
            this.cboxLek.SelectedIndex = 0;
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da dodate indikaciju?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                DTOManager.dodajIndikaciju(this.lekovi.ElementAt(this.cboxLek.SelectedIndex).IdLeka, this.tbxTekst.Text);
                MessageBox.Show("Uspesno dodata nova indikacija!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
