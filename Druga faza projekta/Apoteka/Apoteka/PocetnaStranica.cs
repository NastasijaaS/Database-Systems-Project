using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apoteka.Forme;

namespace Apoteka
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnProdajnaMesta_Click(object sender, EventArgs e)
        {
            ProdajnaMestaForm forma = new ProdajnaMestaForm();
            forma.ShowDialog();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniForm forma = new ZaposleniForm();
            forma.ShowDialog();
        }

        private void btnLekovi_Click(object sender, EventArgs e)
        {
            LekoviForm forma = new LekoviForm();
            forma.ShowDialog();
        }
    }
}
