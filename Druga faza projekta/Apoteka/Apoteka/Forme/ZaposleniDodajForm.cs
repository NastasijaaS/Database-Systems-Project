using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;

namespace Apoteka.Forme
{
    public partial class ZaposleniDodajForm : Form
    {
        ProdajnoMestoBasic prodajnoMesto;
        public List<ProdajnoMestoPregled> prodajnaMesta = null;
        public ZaposleniDodajForm()
        {
            InitializeComponent();
        }
        public ZaposleniDodajForm(ProdajnoMestoBasic p, List<ProdajnoMestoPregled> mesta)
        {
            prodajnoMesto = p;
            this.prodajnaMesta = mesta;
            InitializeComponent();
        }
        private void cbxFarmaceut_CheckedChanged(object sender, EventArgs e)
        {
            gboxFarmaceut.Enabled = !gboxFarmaceut.Enabled;
        }
        private void ZaposleniDodajForm_Load(object sender, EventArgs e)
        {
            gboxFarmaceut.Enabled = false;
            gbxDodajRadnoMesto.Enabled = false;

            foreach(ProdajnoMestoPregled p in this.prodajnaMesta)
            {
                this.cboxProdajnoMesto.Items.Add(p.Naziv);
            }
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Da li ste sigurni da zelite da dodate korisnika?",
                                                "Potvrda", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DateTime dipl = new DateTime();
                DateTime obn = new DateTime();
                int idMesta = 0;
                DateTime radiOd = new DateTime(2022, 1, 1);

                int far = 0;
                if (this.cbxFarmaceut.Checked)
                {
                    far = 1;
                    dipl = this.dtimeDiplomirao.Value;
                    obn = this.dtimeObnovio.Value;
                }
                
                //Posto moramo da posaljemo argumente, cak i ako ih ne koristimo, moramo da proverimo prvo da li trebamo
                //da ih procitamo ili mozemo da ostavimo neke bezveze vrednosti:
                if (this.cbxZaposli.Checked)
                {
                    idMesta = this.prodajnaMesta.ElementAt(this.cboxProdajnoMesto.SelectedIndex).Id;
                    radiOd = this.dtimePocetak.Value;
                }

                //Na osnovu flegova koje saljemo sama odlucuje da li dodaje novog zaposlenog u prodajno mesto i koje ili ne:
                DTOManager.dodajZaposlenog(this.tbxMbr.Text, this.tbxIme.Text, this.tbxPrezime.Text, this.dtimeRodjendan.Value, this.tbxAdresa.Text, Int32.Parse(this.tbxTelefon.Text), far, dipl, obn, this.cbxZaposli.Checked, idMesta, radiOd);

            }
            else
            {
                this.Close();
            }
        }
        private void cbxZaposli_CheckedChanged(object sender, EventArgs e)
        {
            this.gbxDodajRadnoMesto.Enabled = !this.gbxDodajRadnoMesto.Enabled;
        }
    }
}
