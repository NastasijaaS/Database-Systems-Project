namespace Apoteka.Forme
{
    partial class ZaposleniUpdateForm
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblDiplomirao = new System.Windows.Forms.Label();
            this.lblObnovio = new System.Windows.Forms.Label();
            this.gbxFarmaceut = new System.Windows.Forms.GroupBox();
            this.dtimeObnovio = new System.Windows.Forms.DateTimePicker();
            this.dtimeDiplomirao = new System.Windows.Forms.DateTimePicker();
            this.dtimeRodjendan = new System.Windows.Forms.DateTimePicker();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.tbxAdresa = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.gbxFarmaceut.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(17, 15);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(17, 41);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(17, 70);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(81, 13);
            this.lblDatumRodjenja.TabIndex = 2;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(16, 93);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(17, 119);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblDiplomirao
            // 
            this.lblDiplomirao.AutoSize = true;
            this.lblDiplomirao.Location = new System.Drawing.Point(6, 25);
            this.lblDiplomirao.Name = "lblDiplomirao";
            this.lblDiplomirao.Size = new System.Drawing.Size(59, 13);
            this.lblDiplomirao.TabIndex = 5;
            this.lblDiplomirao.Text = "Diplomirao:";
            // 
            // lblObnovio
            // 
            this.lblObnovio.AutoSize = true;
            this.lblObnovio.Location = new System.Drawing.Point(5, 51);
            this.lblObnovio.Name = "lblObnovio";
            this.lblObnovio.Size = new System.Drawing.Size(87, 13);
            this.lblObnovio.TabIndex = 6;
            this.lblObnovio.Text = "Obnovio licencu:";
            // 
            // gbxFarmaceut
            // 
            this.gbxFarmaceut.Controls.Add(this.dtimeObnovio);
            this.gbxFarmaceut.Controls.Add(this.dtimeDiplomirao);
            this.gbxFarmaceut.Controls.Add(this.lblDiplomirao);
            this.gbxFarmaceut.Controls.Add(this.lblObnovio);
            this.gbxFarmaceut.Location = new System.Drawing.Point(11, 142);
            this.gbxFarmaceut.Name = "gbxFarmaceut";
            this.gbxFarmaceut.Size = new System.Drawing.Size(304, 82);
            this.gbxFarmaceut.TabIndex = 7;
            this.gbxFarmaceut.TabStop = false;
            this.gbxFarmaceut.Text = "Farmaceut:";
            // 
            // dtimeObnovio
            // 
            this.dtimeObnovio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeObnovio.Location = new System.Drawing.Point(202, 45);
            this.dtimeObnovio.Name = "dtimeObnovio";
            this.dtimeObnovio.Size = new System.Drawing.Size(100, 20);
            this.dtimeObnovio.TabIndex = 8;
            // 
            // dtimeDiplomirao
            // 
            this.dtimeDiplomirao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeDiplomirao.Location = new System.Drawing.Point(202, 19);
            this.dtimeDiplomirao.Name = "dtimeDiplomirao";
            this.dtimeDiplomirao.Size = new System.Drawing.Size(100, 20);
            this.dtimeDiplomirao.TabIndex = 7;
            // 
            // dtimeRodjendan
            // 
            this.dtimeRodjendan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeRodjendan.Location = new System.Drawing.Point(213, 64);
            this.dtimeRodjendan.Name = "dtimeRodjendan";
            this.dtimeRodjendan.Size = new System.Drawing.Size(100, 20);
            this.dtimeRodjendan.TabIndex = 8;
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(213, 12);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(100, 20);
            this.tbxIme.TabIndex = 9;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(213, 38);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbxPrezime.TabIndex = 10;
            // 
            // tbxAdresa
            // 
            this.tbxAdresa.Location = new System.Drawing.Point(213, 90);
            this.tbxAdresa.Name = "tbxAdresa";
            this.tbxAdresa.Size = new System.Drawing.Size(100, 20);
            this.tbxAdresa.TabIndex = 11;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(213, 116);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefon.TabIndex = 12;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(11, 236);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 13;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(240, 236);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 14;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // ZaposleniUpdateForm
            // 
            this.AcceptButton = this.btnPotvrdi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(325, 269);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxAdresa);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.dtimeRodjendan);
            this.Controls.Add(this.gbxFarmaceut);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "ZaposleniUpdateForm";
            this.Text = "ZaposleniUpdateForm";
            this.Load += new System.EventHandler(this.ZaposleniUpdateForm_Load);
            this.gbxFarmaceut.ResumeLayout(false);
            this.gbxFarmaceut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblDiplomirao;
        private System.Windows.Forms.Label lblObnovio;
        private System.Windows.Forms.GroupBox gbxFarmaceut;
        private System.Windows.Forms.DateTimePicker dtimeObnovio;
        private System.Windows.Forms.DateTimePicker dtimeDiplomirao;
        private System.Windows.Forms.DateTimePicker dtimeRodjendan;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.TextBox tbxAdresa;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}