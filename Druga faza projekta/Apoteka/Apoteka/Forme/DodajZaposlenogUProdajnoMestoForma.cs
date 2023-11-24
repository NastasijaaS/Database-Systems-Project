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
    public partial class DodajZaposlenogUProdajnoMestoForma : Form
    {
        ProdajnoMestoBasic prodajnoMesto;
        ZaposleniBasic zaposleni;
        public DodajZaposlenogUProdajnoMestoForma()
        {
            InitializeComponent();
        }

        public DodajZaposlenogUProdajnoMestoForma(ProdajnoMestoBasic p)
        {
            InitializeComponent();
            prodajnoMesto = p;
            popuniPodacima();
        }
        private void DodajZaposlenogUProdajnoMestoForma_Load(object sender, EventArgs e)
        {
            this.datumDo.Enabled = false;
        }

        public void popuniPodacima()
        {
            List<ZaposleniBasic> listaZaposlenih = DTOManager.vratiSveZaposleneBasic();
            foreach (ZaposleniBasic r in listaZaposlenih)
                cbZaposleni.Items.Add(r);
        }

        private void DodajPostojecegZaposlenogForma_Load(object sender, EventArgs e)
        {
            this.datumDo.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            RadiUBasic radi = new RadiUBasic();
            zaposleni = (ZaposleniBasic)cbZaposleni.SelectedItem;
            radi.Id = new RadiUIdBasic();
            radi.Id.RadiUProdajnoMesto = prodajnoMesto;
            radi.Id.ZaposleniRadiU = zaposleni;
            radi.DatumOd = datumOd.Value;
            if (cb1.Checked == false)
                radi.DatumDo = datumDo.Value;
            DTOManager.dodajRadniOdnos(radi);
            MessageBox.Show("Uspesno ste dodali novi radni odnos!");
            this.Close();

        }

        private void omoguciDatumDo(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
                datumDo.Enabled = false;
            else
                datumDo.Enabled = true;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            this.datumDo.Enabled = !this.datumDo.Enabled;
        }
    }
}
