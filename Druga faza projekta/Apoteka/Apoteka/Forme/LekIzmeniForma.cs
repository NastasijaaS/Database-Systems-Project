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
    public partial class LekIzmeniForma : Form
    {
        public LekPregled lek = null;
        public LekIzmeniForma(LekPregled l)
        {
            this.lek = l;
            InitializeComponent();
        }
        private void LekIzmeniForma_Load(object sender, EventArgs e)
        {
            this.tbxCena.Text = this.lek.Cena.ToString();
            this.tbxProcenat.Text = this.lek.ProcenatParticipacije.ToString();
            if (this.lek.NaRecept == 1)
                this.cbxRecept.Checked = true;
            else
                this.cbxRecept.Checked = false;
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Da li stvarno zelite da promenite lek?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                int recept;
                if (this.cbxRecept.Checked)
                    recept = 1;
                else
                    recept = 0;
                DTOManager.izmeniLek(this.lek.IdLeka, this.tbxCena.Text, this.tbxProcenat.Text, recept);
                this.Close();
            }
            else
                this.Close();
        }
    }
}
