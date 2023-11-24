namespace Apoteka.Forme
{
    partial class ZaposleniDodajForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxFarmaceut = new System.Windows.Forms.CheckBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblMaticniBroj = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblFarmaceut = new System.Windows.Forms.Label();
            this.gboxFarmaceut = new System.Windows.Forms.GroupBox();
            this.dtimeObnovio = new System.Windows.Forms.DateTimePicker();
            this.dtimeDiplomirao = new System.Windows.Forms.DateTimePicker();
            this.lblObnovio = new System.Windows.Forms.Label();
            this.lblDiplomirao = new System.Windows.Forms.Label();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.tbxMbr = new System.Windows.Forms.TextBox();
            this.tbxAdresa = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.dtimeRodjendan = new System.Windows.Forms.DateTimePicker();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.gbxDodajRadnoMesto = new System.Windows.Forms.GroupBox();
            this.dtimePocetak = new System.Windows.Forms.DateTimePicker();
            this.cboxProdajnoMesto = new System.Windows.Forms.ComboBox();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.lblProdajnoMesto = new System.Windows.Forms.Label();
            this.lblZaposli = new System.Windows.Forms.Label();
            this.cbxZaposli = new System.Windows.Forms.CheckBox();
            this.gboxFarmaceut.SuspendLayout();
            this.gbxDodajRadnoMesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFarmaceut
            // 
            this.cbxFarmaceut.AutoSize = true;
            this.cbxFarmaceut.Location = new System.Drawing.Point(291, 185);
            this.cbxFarmaceut.Name = "cbxFarmaceut";
            this.cbxFarmaceut.Size = new System.Drawing.Size(15, 14);
            this.cbxFarmaceut.TabIndex = 0;
            this.cbxFarmaceut.UseVisualStyleBackColor = true;
            this.cbxFarmaceut.CheckedChanged += new System.EventHandler(this.cbxFarmaceut_CheckedChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(20, 18);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(20, 45);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblMaticniBroj
            // 
            this.lblMaticniBroj.AutoSize = true;
            this.lblMaticniBroj.Location = new System.Drawing.Point(20, 71);
            this.lblMaticniBroj.Name = "lblMaticniBroj";
            this.lblMaticniBroj.Size = new System.Drawing.Size(64, 13);
            this.lblMaticniBroj.TabIndex = 3;
            this.lblMaticniBroj.Text = "Maticni broj:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(20, 100);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(81, 13);
            this.lblDatumRodjenja.TabIndex = 4;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(20, 126);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 5;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(20, 155);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(46, 13);
            this.lblBrojTelefona.TabIndex = 6;
            this.lblBrojTelefona.Text = "Telefon:";
            // 
            // lblFarmaceut
            // 
            this.lblFarmaceut.AutoSize = true;
            this.lblFarmaceut.Location = new System.Drawing.Point(20, 185);
            this.lblFarmaceut.Name = "lblFarmaceut";
            this.lblFarmaceut.Size = new System.Drawing.Size(60, 13);
            this.lblFarmaceut.TabIndex = 7;
            this.lblFarmaceut.Text = "Farmaceut:";
            // 
            // gboxFarmaceut
            // 
            this.gboxFarmaceut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gboxFarmaceut.Controls.Add(this.dtimeObnovio);
            this.gboxFarmaceut.Controls.Add(this.dtimeDiplomirao);
            this.gboxFarmaceut.Controls.Add(this.lblObnovio);
            this.gboxFarmaceut.Controls.Add(this.lblDiplomirao);
            this.gboxFarmaceut.Location = new System.Drawing.Point(3, 230);
            this.gboxFarmaceut.Name = "gboxFarmaceut";
            this.gboxFarmaceut.Size = new System.Drawing.Size(317, 87);
            this.gboxFarmaceut.TabIndex = 8;
            this.gboxFarmaceut.TabStop = false;
            this.gboxFarmaceut.Text = "Farmaceut:";
            // 
            // dtimeObnovio
            // 
            this.dtimeObnovio.CustomFormat = "";
            this.dtimeObnovio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeObnovio.Location = new System.Drawing.Point(203, 49);
            this.dtimeObnovio.Name = "dtimeObnovio";
            this.dtimeObnovio.Size = new System.Drawing.Size(105, 20);
            this.dtimeObnovio.TabIndex = 17;
            // 
            // dtimeDiplomirao
            // 
            this.dtimeDiplomirao.CustomFormat = "";
            this.dtimeDiplomirao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeDiplomirao.Location = new System.Drawing.Point(203, 19);
            this.dtimeDiplomirao.Name = "dtimeDiplomirao";
            this.dtimeDiplomirao.Size = new System.Drawing.Size(105, 20);
            this.dtimeDiplomirao.TabIndex = 16;
            // 
            // lblObnovio
            // 
            this.lblObnovio.AutoSize = true;
            this.lblObnovio.Location = new System.Drawing.Point(17, 55);
            this.lblObnovio.Name = "lblObnovio";
            this.lblObnovio.Size = new System.Drawing.Size(87, 13);
            this.lblObnovio.TabIndex = 3;
            this.lblObnovio.Text = "Obnovio licencu:";
            // 
            // lblDiplomirao
            // 
            this.lblDiplomirao.AutoSize = true;
            this.lblDiplomirao.Location = new System.Drawing.Point(17, 25);
            this.lblDiplomirao.Name = "lblDiplomirao";
            this.lblDiplomirao.Size = new System.Drawing.Size(59, 13);
            this.lblDiplomirao.TabIndex = 2;
            this.lblDiplomirao.Text = "Diplomirao:";
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(206, 15);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(100, 20);
            this.tbxIme.TabIndex = 9;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(206, 42);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbxPrezime.TabIndex = 10;
            // 
            // tbxMbr
            // 
            this.tbxMbr.Location = new System.Drawing.Point(206, 68);
            this.tbxMbr.Name = "tbxMbr";
            this.tbxMbr.Size = new System.Drawing.Size(100, 20);
            this.tbxMbr.TabIndex = 11;
            // 
            // tbxAdresa
            // 
            this.tbxAdresa.Location = new System.Drawing.Point(206, 123);
            this.tbxAdresa.Name = "tbxAdresa";
            this.tbxAdresa.Size = new System.Drawing.Size(100, 20);
            this.tbxAdresa.TabIndex = 13;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(206, 152);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefon.TabIndex = 14;
            // 
            // dtimeRodjendan
            // 
            this.dtimeRodjendan.CustomFormat = "";
            this.dtimeRodjendan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeRodjendan.Location = new System.Drawing.Point(206, 94);
            this.dtimeRodjendan.Name = "dtimeRodjendan";
            this.dtimeRodjendan.Size = new System.Drawing.Size(100, 20);
            this.dtimeRodjendan.TabIndex = 15;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(12, 405);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 16;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(236, 405);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // gbxDodajRadnoMesto
            // 
            this.gbxDodajRadnoMesto.Controls.Add(this.dtimePocetak);
            this.gbxDodajRadnoMesto.Controls.Add(this.cboxProdajnoMesto);
            this.gbxDodajRadnoMesto.Controls.Add(this.lblPocetak);
            this.gbxDodajRadnoMesto.Controls.Add(this.lblProdajnoMesto);
            this.gbxDodajRadnoMesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbxDodajRadnoMesto.Location = new System.Drawing.Point(3, 323);
            this.gbxDodajRadnoMesto.Name = "gbxDodajRadnoMesto";
            this.gbxDodajRadnoMesto.Size = new System.Drawing.Size(317, 76);
            this.gbxDodajRadnoMesto.TabIndex = 18;
            this.gbxDodajRadnoMesto.TabStop = false;
            this.gbxDodajRadnoMesto.Text = "Radno mesto:";
            // 
            // dtimePocetak
            // 
            this.dtimePocetak.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimePocetak.Location = new System.Drawing.Point(203, 46);
            this.dtimePocetak.Name = "dtimePocetak";
            this.dtimePocetak.Size = new System.Drawing.Size(105, 20);
            this.dtimePocetak.TabIndex = 3;
            // 
            // cboxProdajnoMesto
            // 
            this.cboxProdajnoMesto.FormattingEnabled = true;
            this.cboxProdajnoMesto.Location = new System.Drawing.Point(203, 19);
            this.cboxProdajnoMesto.Name = "cboxProdajnoMesto";
            this.cboxProdajnoMesto.Size = new System.Drawing.Size(105, 21);
            this.cboxProdajnoMesto.TabIndex = 2;
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Location = new System.Drawing.Point(17, 52);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(50, 13);
            this.lblPocetak.TabIndex = 1;
            this.lblPocetak.Text = "Pocetak:";
            // 
            // lblProdajnoMesto
            // 
            this.lblProdajnoMesto.AutoSize = true;
            this.lblProdajnoMesto.Location = new System.Drawing.Point(17, 22);
            this.lblProdajnoMesto.Name = "lblProdajnoMesto";
            this.lblProdajnoMesto.Size = new System.Drawing.Size(83, 13);
            this.lblProdajnoMesto.TabIndex = 0;
            this.lblProdajnoMesto.Text = "Prodajno mesto:";
            // 
            // lblZaposli
            // 
            this.lblZaposli.AutoSize = true;
            this.lblZaposli.Location = new System.Drawing.Point(20, 210);
            this.lblZaposli.Name = "lblZaposli";
            this.lblZaposli.Size = new System.Drawing.Size(44, 13);
            this.lblZaposli.TabIndex = 19;
            this.lblZaposli.Text = "Zaposli:";
            // 
            // cbxZaposli
            // 
            this.cbxZaposli.AutoSize = true;
            this.cbxZaposli.Location = new System.Drawing.Point(291, 210);
            this.cbxZaposli.Name = "cbxZaposli";
            this.cbxZaposli.Size = new System.Drawing.Size(15, 14);
            this.cbxZaposli.TabIndex = 20;
            this.cbxZaposli.UseVisualStyleBackColor = true;
            this.cbxZaposli.CheckedChanged += new System.EventHandler(this.cbxZaposli_CheckedChanged);
            // 
            // ZaposleniDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 435);
            this.Controls.Add(this.cbxZaposli);
            this.Controls.Add(this.lblZaposli);
            this.Controls.Add(this.gbxDodajRadnoMesto);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.dtimeRodjendan);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxAdresa);
            this.Controls.Add(this.tbxMbr);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.gboxFarmaceut);
            this.Controls.Add(this.lblFarmaceut);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblMaticniBroj);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.cbxFarmaceut);
            this.Name = "ZaposleniDodajForm";
            this.Text = "ZaposleniDodajForm";
            this.Load += new System.EventHandler(this.ZaposleniDodajForm_Load);
            this.gboxFarmaceut.ResumeLayout(false);
            this.gboxFarmaceut.PerformLayout();
            this.gbxDodajRadnoMesto.ResumeLayout(false);
            this.gbxDodajRadnoMesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxFarmaceut;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblMaticniBroj;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Label lblFarmaceut;
        private System.Windows.Forms.GroupBox gboxFarmaceut;
        private System.Windows.Forms.DateTimePicker dtimeObnovio;
        private System.Windows.Forms.DateTimePicker dtimeDiplomirao;
        private System.Windows.Forms.Label lblObnovio;
        private System.Windows.Forms.Label lblDiplomirao;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.TextBox tbxMbr;
        private System.Windows.Forms.TextBox tbxAdresa;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.DateTimePicker dtimeRodjendan;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox gbxDodajRadnoMesto;
        private System.Windows.Forms.DateTimePicker dtimePocetak;
        private System.Windows.Forms.ComboBox cboxProdajnoMesto;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.Label lblProdajnoMesto;
        private System.Windows.Forms.Label lblZaposli;
        private System.Windows.Forms.CheckBox cbxZaposli;
    }
}