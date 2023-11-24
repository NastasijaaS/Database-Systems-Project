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
    public partial class LekUpakujForm : Form
    {
        public List<PakovanjePregled> pakovanja = null;
        public int lek;
        public LekUpakujForm(int lek, List<PakovanjePregled> list)
        {
            this.lek = lek;
            this.pakovanja = list;
            InitializeComponent();
        }
        private void LekUpakujForm_Load(object sender, EventArgs e)
        {
            foreach(PakovanjePregled p in this.pakovanja)
            {
                this.comboBox1.Items.Add(p.VrstaPakovanja);
            }
            //MessageBox.Show(this.lek.ToString(), "Message", MessageBoxButtons.OK);
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpakuj_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da upakujete lek?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                DTOManager.upakujLek(this.lek, this.pakovanja.ElementAt(this.comboBox1.SelectedIndex).IdPakovanja, Int32.Parse(this.textBox1.Text), this.textBox2.Text);
                MessageBox.Show(this.pakovanja.ElementAt(this.comboBox1.SelectedIndex).IdPakovanja.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
