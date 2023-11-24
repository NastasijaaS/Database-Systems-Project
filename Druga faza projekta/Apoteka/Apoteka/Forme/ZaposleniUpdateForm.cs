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
    public partial class ZaposleniUpdateForm : Form
    {
        public ZaposleniPregled zaposleni = null;
        public ZaposleniUpdateForm(ZaposleniPregled z)
        {
            InitializeComponent();
            this.zaposleni = z;
        }
        private void ZaposleniUpdateForm_Load(object sender, EventArgs e)
        {
            this.tbxIme.Text = this.zaposleni.Ime;
            this.tbxPrezime.Text = this.zaposleni.Prezime;
            this.dtimeRodjendan.Value = this.zaposleni.DatumRodjenja;
            this.tbxAdresa.Text = this.zaposleni.Adresa;
            this.tbxTelefon.Text = this.zaposleni.BrojTelefona.ToString();
            if(this.zaposleni.Farmaceut == 0)
            {
                this.gbxFarmaceut.Enabled = false;
            }
            else
            {
                //Nemamo ove argumente, moramo nekako da ih dodamo ili u zaposlenog
                //ili u novoj klasi farmaceut?
                //this.dtimeDiplomirao.Value = this.zaposleni.DatumDiplomiranja;
                //this.dtimeObnovio.Value = this.zaposleni.ObnovioLicencu;
            }
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            //Prvo pitamo da li stvarno zelimo da promenimo korisnika?
            DialogResult dlg = MessageBox.Show("Da li stvarno zelite da promenite korisnika?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                DTOManager.promeniZaposlenog(this.zaposleni.MaticniBroj, this.tbxIme.Text, this.tbxPrezime.Text, this.dtimeRodjendan.Value, this.tbxAdresa.Text, this.tbxTelefon.Text);
                //Pre ovoga samo trebamo da izvrsimo update u bazu podataka;
                //MessageBox.Show(novi, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
