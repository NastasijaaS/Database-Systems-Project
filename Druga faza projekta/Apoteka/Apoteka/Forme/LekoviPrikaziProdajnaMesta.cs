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
    public partial class LekoviPrikaziProdajnaMesta : Form
    {
        public List<ProdajnoMestoPregled> prodajnaMesta = null;
        public LekoviPrikaziProdajnaMesta(List<ProdajnoMestoPregled> mesta)
        {
            this.prodajnaMesta = mesta;
            InitializeComponent();
        }
        private void LekoviPrikaziProdajnaMesta_Load(object sender, EventArgs e)
        {
            this.lvProdajnaMesta.Items.Clear();
            foreach(ProdajnoMestoPregled p in this.prodajnaMesta)
            {
                ListViewItem novi = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Adresa, p.Mesto });
                this.lvProdajnaMesta.Items.Add(novi);
            }
            this.lvProdajnaMesta.Refresh();
        }
    }
}
