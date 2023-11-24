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
    public partial class LekPrikaziKontraindikacije : Form
    {
        public List<KontraindikacijaPregled> kontraindikacije = null;
        public List<LekPregled> lekovi = null;
        public LekPrikaziKontraindikacije(List<KontraindikacijaPregled> kontra, List<LekPregled> lek)
        {
            this.kontraindikacije = kontra;
            this.lekovi = lek;
            InitializeComponent();
        }
        private void LekPrikaziKontraindikacije_Load(object sender, EventArgs e)
        {
            ucitajPrikaz();
        }
        public void ucitajPrikaz()
        {
            this.lvKontraindikacije.Items.Clear();
            foreach(KontraindikacijaPregled k in this.kontraindikacije)
            {
                ListViewItem novi = new ListViewItem(new string[] { k.Indikacija });
                this.lvKontraindikacije.Items.Add(novi);
            }
            this.lvKontraindikacije.Refresh();
        }
        private void btnDodajKontraindikaciju_Click(object sender, EventArgs e)
        {
            NovaKontraindikacija frm = new NovaKontraindikacija(this.lekovi);
            frm.ShowDialog();
            this.kontraindikacije = DTOManager.vratiSveKontraindikacijeLeka(this.lekovi[0].IdLeka);
            ucitajPrikaz();
        }
        private void btnUkloniIndikaciju_Click(object sender, EventArgs e)
        {
            if(this.lvKontraindikacije.SelectedIndices.Count == 1)
            {
                DTOManager.ukloniKontraindikaciju(this.kontraindikacije.ElementAt(this.lvKontraindikacije.SelectedIndices[0]).Id);
                MessageBox.Show("Uspesno ste obrisali kontraindikaciju iz leka!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.kontraindikacije = DTOManager.vratiSveKontraindikacijeLeka(this.lekovi[0].IdLeka);
                ucitajPrikaz();
            }
            else
            {
                MessageBox.Show("Morate da izaberete samo jednu stavku!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
