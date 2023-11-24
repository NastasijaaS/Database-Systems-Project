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
    public partial class ZaposleniForm : Form
    {
        public List<ZaposleniPregled> listaZaposlenih = null;
        public int brojZaposlenih = 0;
        public ZaposleniForm()
        {
            InitializeComponent();
        }
        private void ZaposleniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        //Metoda za popunjavanje liste 'lvSviZaposleni'
        public void popuniPodacima()
        {
            this.brojZaposlenih = 0;
            //Cistimo listu:
            this.lvListaZaposlenih.Items.Clear();

            List<ZaposleniPregled> zaposleni = DTOManager.vratiSveZaposlene();
            foreach (ZaposleniPregled z in zaposleni)
            {
                ListViewItem item;
                if (z.Farmaceut == 1)
                {
                    FarmaceutPregled f = (FarmaceutPregled)z;
                    item = new ListViewItem(new string[] { f.MaticniBroj, f.Ime, f.Prezime, f.Adresa, f.BrojTelefona.ToString(), f.DatumRodjenja.ToShortDateString(), f.Farmaceut.ToString(), f.Diplomirao.ToShortDateString(), f.ObnovioLicencu.ToShortDateString() });
                }
                else
                {
                    item = new ListViewItem(new string[] {  z.MaticniBroj, z.Ime, z.Prezime, z.Adresa, z.BrojTelefona.ToString(), z.DatumRodjenja.ToShortDateString(), z.Farmaceut.ToString()});
                }
                this.lvListaZaposlenih.Items.Add(item);
                this.brojZaposlenih++;
            }
            tbxUkupno.Text = this.brojZaposlenih.ToString();
            //Osvezavamo kako bi se up-dejtovao prikaz:
            this.lvListaZaposlenih.Refresh();

            //Vrsimo ucitavanje objekta u listu koja se cuva na ovoj formi:
            this.listaZaposlenih = zaposleni;
        }
        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            ZaposleniDodajForm form = new ZaposleniDodajForm(new ProdajnoMestoBasic(), DTOManager.vratiSveProdavnice());
            res = form.ShowDialog();

            if (res == DialogResult.OK)
                this.lvListaZaposlenih.Refresh();
            popuniPodacima();
        }
        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            //Ako je ???
            if(this.lvListaZaposlenih.SelectedItems.Count == 1)
            {
                ZaposleniUpdateForm frm = new ZaposleniUpdateForm(this.listaZaposlenih.ElementAt(this.lvListaZaposlenih.SelectedIndices[0]));
                DialogResult res = frm.ShowDialog();

                if (res == DialogResult.Yes)
                {
                    this.popuniPodacima();
                    MessageBox.Show("Izmenili ste korisnika!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.popuniPodacima();
                }
            }
            else
            {
                MessageBox.Show("Morate da izaberete korisnika pre pozivanja ove metode!", "Greska!",  MessageBoxButtons.OK);
            }
        }
        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            if(this.lvListaZaposlenih.SelectedItems.Count == 1)
            {
                //Provera da li stvarno zelimo da obrisemo ovog zaposlenog iz baze podataka?
                DialogResult res = MessageBox.Show("Da li stvarno zelite da obrisete zaposlenog iz baze podataka?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res == DialogResult.Yes)
                {
                    DTOManager.obrisiZaposlenog(this.listaZaposlenih.ElementAt(this.lvListaZaposlenih.SelectedIndices[0]).MaticniBroj);
                    MessageBox.Show("Uspesno smo obrisali korisnika iz baze podataka!", "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.popuniPodacima();
                }
                else
                {
                    MessageBox.Show("Kliknuo si otkazi, ne radimo nista!", "Nista :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Morate da izaberete jednog zaposlenog!", "Message", MessageBoxButtons.OK);
            }
        }
        private void btnRecepti_Click(object sender, EventArgs e)
        {
            if(this.lvListaZaposlenih.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Morate da izaberete jednog korisnika!", "Message", MessageBoxButtons.OK);
            }
            else
            {
                ZaposleniPregledajRecepteForm frm = new ZaposleniPregledajRecepteForm(this.listaZaposlenih.ElementAt(this.lvListaZaposlenih.SelectedIndices[0]));
                frm.ShowDialog();
            }
        }
        private void btnRadnoMesto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DTOManager.radnoMestoZaposlenog(this.listaZaposlenih.ElementAt(this.lvListaZaposlenih.SelectedIndices[0]).MaticniBroj), "Radno mesto: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
