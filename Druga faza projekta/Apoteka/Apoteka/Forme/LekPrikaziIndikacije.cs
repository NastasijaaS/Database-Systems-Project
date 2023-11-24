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
    public partial class LekPrikaziIndikacije : Form
    {
        public List<IndikacijaPregled> indikacije = null;
        public List<LekPregled> listaLekova = null;
        public LekBasic lek;
        public LekPrikaziIndikacije(List<IndikacijaPregled> lista, List<LekPregled> lekovi)
        {
            this.indikacije = lista;
            this.listaLekova = lekovi;
            InitializeComponent();
        }
        private void LekPrikaziIndikacije_Load(object sender, EventArgs e)
        {
            this.osveziPrikaz();
        }
        public void osveziPrikaz()
        {
            this.lvIndikacije.Items.Clear();
            foreach (IndikacijaPregled i in this.indikacije)
            {
                ListViewItem novi = new ListViewItem(new string[] { i.Indikacija });
                this.lvIndikacije.Items.Add(novi);
            }
            this.lvIndikacije.Refresh();
        }
        private void btnDodajIndikaciju_Click(object sender, EventArgs e)
        {
            NovaIndikacija frm = new NovaIndikacija(this.listaLekova);
            frm.ShowDialog();
            indikacije = DTOManager.vratiSveIndikacijeLeka(listaLekova[0].IdLeka);
            osveziPrikaz();
        }
        private void btnUkloniIndikaciju_Click(object sender, EventArgs e)
        {
            if(this.lvIndikacije.SelectedItems.Count == 1)
            {
                DTOManager.ukloniIndikaciju(this.indikacije.ElementAt(this.lvIndikacije.SelectedIndices[0]).Id);
                MessageBox.Show("Uspesno ste uklonili indikaciju iz leka!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                indikacije = DTOManager.vratiSveIndikacijeLeka(listaLekova[0].IdLeka);
                osveziPrikaz();
            }
            else
            {
                MessageBox.Show("Morate da izaberete samo jednu indikaciju!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
