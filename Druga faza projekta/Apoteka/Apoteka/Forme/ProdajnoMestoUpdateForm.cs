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
    public partial class ProdajnoMestoUpdateForm : Form
    {
        ProdajnoMestoBasic prodajnomesto;
        public ProdajnoMestoUpdateForm(ProdajnoMestoBasic p)
        {
            InitializeComponent();
            this.prodajnomesto = p;
        }
        private void ProdajnoMestoUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE PRODAJNOG MESTA {prodajnomesto.Naziv.ToUpper()}";
        }
        public void popuniPodacima()
        {
            tbxNaziv.Text = this.prodajnomesto.Naziv;
            tbxAdresa.Text = this.prodajnomesto.Adresa;
            tbxMesto.Text = this.prodajnomesto.Mesto;
        }
        //Azuriraj postojece prodajno mesto
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene prodajnog mesta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.prodajnomesto.Naziv = tbxNaziv.Text;
                this.prodajnomesto.Adresa = tbxAdresa.Text;
                this.prodajnomesto.Mesto = tbxMesto.Text;

                DTOManager.azurirajProdajnoMesto(this.prodajnomesto);
                MessageBox.Show("Azuriranje prodajnog mesta je uspesno izvrseno!");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
