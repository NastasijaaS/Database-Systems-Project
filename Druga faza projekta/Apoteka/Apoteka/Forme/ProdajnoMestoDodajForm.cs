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
    public partial class ProdajnoMestoDodajForm : Form
    {
        ProdajnoMestoBasic prodajnomesto;
        public ProdajnoMestoDodajForm()
        {
            InitializeComponent();
            prodajnomesto = new ProdajnoMestoBasic();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo prodajno mesto?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.prodajnomesto.Naziv = tbxNaziv.Text;
                this.prodajnomesto.Adresa = txbAdresa.Text;
                this.prodajnomesto.Mesto = tbxMesto.Text;
             

                DTOManager.dodajProdajnoMesto(this.prodajnomesto);
                MessageBox.Show("Uspesno ste dodali novo prodajno mesto!");
                this.Close();
            }
            else
            {

            }

        }
    }
}
