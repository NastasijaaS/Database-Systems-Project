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
    public partial class ZaposleniPregledajRecepteForm : Form
    {
        public List<ReceptPregled> listaRecepta = null;
        public ZaposleniPregled zaposleni = null;
        public ZaposleniPregledajRecepteForm(ZaposleniPregled z)
        {
            InitializeComponent();
            this.zaposleni = z;
        }
        private void ZaposleniPregledajRecepteForm_Load(object sender, EventArgs e)
        {
            this.ucitajPodatke();
        }
        public void ucitajPodatke()
        {
            //Cistimo listu:
            this.lvReceptiZaposlenog.Items.Clear();

            List<ReceptPregled> recepti = DTOManager.vratiSveRecepte(this.zaposleni.MaticniBroj);
            foreach (ReceptPregled r in recepti)
            {
                ListViewItem item = new ListViewItem(new string[] { r.SerijskiBroj.ToString(), r.Lekar, r.DatumIzdavanja.ToShortDateString(), r.DatumRealizacije.ToShortDateString() });
                this.lvReceptiZaposlenog.Items.Add(item);
            }
            //Osvezavamo kako bi se up-dejtovao prikaz:
            this.lvReceptiZaposlenog.Refresh();

            //Vrsimo ucitavanje objekta u listu koja se cuva na ovoj formi:
            this.listaRecepta = recepti;
        }
    }
}
