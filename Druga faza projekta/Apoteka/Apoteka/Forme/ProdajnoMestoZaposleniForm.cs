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
    public partial class ProdajnoMestoZaposleniForm : Form
    {
        ProdajnoMestoBasic prodajnoMesto;
        public ProdajnoMestoZaposleniForm()
        {
            InitializeComponent();
        }
        public ProdajnoMestoZaposleniForm(ProdajnoMestoBasic p)
        {
            InitializeComponent();
            prodajnoMesto = p;
        }
        private void ProdajnoMestoZaposleniForm_Load(object sender, EventArgs e)
        {
            this.Text = "ProdajnoMesto " + prodajnoMesto.Naziv.ToUpper();
            popuniPodacima();
        }
        public void popuniPodacima()
        {

            this.zaposleni.Items.Clear();
            List<ZaposleniPregled> radnici = DTOManager.vratiZaposleneZaProdajnoMesto(prodajnoMesto.Id);

            foreach (ZaposleniPregled r in radnici)
            {
                ListViewItem item = new ListViewItem(new string[] { r.MaticniBroj, r.Ime, r.Prezime, r.Adresa, r.BrojTelefona.ToString(), r.DatumRodjenja.ToShortDateString(), r.Farmaceut.ToString() });
                this.zaposleni.Items.Add(item);
            }

            this.zaposleni.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DodajZaposlenogUProdajnoMestoForma forma = new DodajZaposlenogUProdajnoMestoForma(prodajnoMesto);
            forma.ShowDialog();
            popuniPodacima();
        }
        private void btnObrisiZaposlenogIzProdajnogMesta_Click(object sender, EventArgs e)
        {
            if (zaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }

            string idZaposleni = (zaposleni.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiZaposlenogIzProdavnice(idZaposleni);
                MessageBox.Show("Brisanje zaposlenog je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
        private void btnDodajNovogZaposlenog_Click(object sender, EventArgs e)
        {
            List<ProdajnoMestoPregled> lista = new List<ProdajnoMestoPregled>();
            lista.Add(DTOManager.vratiProdajnoMestoPregled(this.prodajnoMesto.Id));
            ZaposleniDodajForm frm = new ZaposleniDodajForm(new ProdajnoMestoBasic(), lista);
            frm.Show();
            this.zaposleni.Refresh();
        }
    }
}

