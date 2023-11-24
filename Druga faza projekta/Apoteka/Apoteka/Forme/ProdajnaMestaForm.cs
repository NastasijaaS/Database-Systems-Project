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
    public partial class ProdajnaMestaForm : Form
    {
        public ProdajnaMestaForm()
        {
            InitializeComponent();
        }
        private void ProdajnaMestaForm_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listaProdajnihMesta.Items.Clear();
            List<ProdajnoMestoPregled> podaci = DTOManager.vratiSveProdavnice();

            foreach (ProdajnoMestoPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Adresa, p.Mesto });
                listaProdajnihMesta.Items.Add(item);
            }

            listaProdajnihMesta.Refresh();
        }
        private void btnDodajProdajnoMesto_Click(object sender, EventArgs e)
        {
            ProdajnoMestoDodajForm formaDodaj = new ProdajnoMestoDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }
        private void btnIzmeniProdajnoMesto_Click(object sender, EventArgs e)
        {
            if (listaProdajnihMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodajno mesto cije podatke zelite da izmenite!");
                return;
            }

            int idProdajnogMesta = Int32.Parse(listaProdajnihMesta.SelectedItems[0].SubItems[0].Text);
            ProdajnoMestoBasic ob = DTOManager.vratiProdajnoMesto(idProdajnogMesta);

            ProdajnoMestoUpdateForm formaUpdate = new ProdajnoMestoUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
        private void btnObrisiProdajnoMesto_Click(object sender, EventArgs e)
        {
            if (listaProdajnihMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodajno mesto koje zelite da obrisete!");
                return;
            }

            int idProdajnogMesta = Int32.Parse(listaProdajnihMesta.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano prodajno mesto?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiProdajnoMesto(idProdajnogMesta);
                MessageBox.Show("Brisanje prodavnice je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
        private void btnVratiLekove_Click(object sender, EventArgs e)
        {
            if (listaProdajnihMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu cije lekove zelite da vidite!");
                return;
            }

            int idProdajnogMesta = Int32.Parse(listaProdajnihMesta.SelectedItems[0].SubItems[0].Text);
            ProdajnoMestoBasic p = DTOManager.vratiProdajnoMesto(idProdajnogMesta);
            ProdajnoMestoLekoviForm forma = new ProdajnoMestoLekoviForm(p);
            forma.ShowDialog();
        }
        private void btnVratiRadnike_Click(object sender, EventArgs e)
        {
            if (listaProdajnihMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu cije zaposlene zelite da vidite!");
                return;
            }

            int idProdajnogMesta = Int32.Parse(listaProdajnihMesta.SelectedItems[0].SubItems[0].Text);
            ProdajnoMestoBasic p = DTOManager.vratiProdajnoMesto(idProdajnogMesta);
            ProdajnoMestoZaposleniForm forma = new ProdajnoMestoZaposleniForm(p);
            forma.ShowDialog();

        }
    }
}
