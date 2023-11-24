
namespace Apoteka.Forme
{
    partial class ZaposleniForm
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
            this.gbxKontrolaZaposleni = new System.Windows.Forms.GroupBox();
            this.btnRadnoMesto = new System.Windows.Forms.Button();
            this.tbxUkupno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecepti = new System.Windows.Forms.Button();
            this.btnObrisiZaposlenog = new System.Windows.Forms.Button();
            this.btnIzmeniZaposlenog = new System.Windows.Forms.Button();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Farmaceut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvListaZaposlenih = new System.Windows.Forms.ListView();
            this.Maticni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rodjen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diplomirao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Obnovio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboxListaZaposlenih = new System.Windows.Forms.GroupBox();
            this.gbxKontrolaZaposleni.SuspendLayout();
            this.gboxListaZaposlenih.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKontrolaZaposleni
            // 
            this.gbxKontrolaZaposleni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxKontrolaZaposleni.Controls.Add(this.btnRadnoMesto);
            this.gbxKontrolaZaposleni.Controls.Add(this.tbxUkupno);
            this.gbxKontrolaZaposleni.Controls.Add(this.label1);
            this.gbxKontrolaZaposleni.Controls.Add(this.btnRecepti);
            this.gbxKontrolaZaposleni.Controls.Add(this.btnObrisiZaposlenog);
            this.gbxKontrolaZaposleni.Controls.Add(this.btnIzmeniZaposlenog);
            this.gbxKontrolaZaposleni.Controls.Add(this.btnDodajZaposlenog);
            this.gbxKontrolaZaposleni.Location = new System.Drawing.Point(865, 12);
            this.gbxKontrolaZaposleni.Name = "gbxKontrolaZaposleni";
            this.gbxKontrolaZaposleni.Size = new System.Drawing.Size(232, 294);
            this.gbxKontrolaZaposleni.TabIndex = 1;
            this.gbxKontrolaZaposleni.TabStop = false;
            this.gbxKontrolaZaposleni.Text = "Kontorle za zaposlene";
            // 
            // btnRadnoMesto
            // 
            this.btnRadnoMesto.Location = new System.Drawing.Point(27, 169);
            this.btnRadnoMesto.Name = "btnRadnoMesto";
            this.btnRadnoMesto.Size = new System.Drawing.Size(175, 23);
            this.btnRadnoMesto.TabIndex = 5;
            this.btnRadnoMesto.Text = "Prikazi radno mesto";
            this.btnRadnoMesto.UseVisualStyleBackColor = true;
            this.btnRadnoMesto.Click += new System.EventHandler(this.btnRadnoMesto_Click);
            // 
            // tbxUkupno
            // 
            this.tbxUkupno.Location = new System.Drawing.Point(62, 223);
            this.tbxUkupno.Name = "tbxUkupno";
            this.tbxUkupno.Size = new System.Drawing.Size(100, 20);
            this.tbxUkupno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ukupan broj zaposlenih";
            // 
            // btnRecepti
            // 
            this.btnRecepti.Location = new System.Drawing.Point(27, 130);
            this.btnRecepti.Name = "btnRecepti";
            this.btnRecepti.Size = new System.Drawing.Size(175, 23);
            this.btnRecepti.TabIndex = 2;
            this.btnRecepti.Text = "Pregledaj recepte";
            this.btnRecepti.UseVisualStyleBackColor = true;
            this.btnRecepti.Click += new System.EventHandler(this.btnRecepti_Click);
            // 
            // btnObrisiZaposlenog
            // 
            this.btnObrisiZaposlenog.Location = new System.Drawing.Point(27, 101);
            this.btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            this.btnObrisiZaposlenog.Size = new System.Drawing.Size(175, 23);
            this.btnObrisiZaposlenog.TabIndex = 2;
            this.btnObrisiZaposlenog.Text = "Obrisi zaposlenog";
            this.btnObrisiZaposlenog.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenog.Click += new System.EventHandler(this.btnObrisiZaposlenog_Click);
            // 
            // btnIzmeniZaposlenog
            // 
            this.btnIzmeniZaposlenog.Location = new System.Drawing.Point(27, 72);
            this.btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            this.btnIzmeniZaposlenog.Size = new System.Drawing.Size(175, 23);
            this.btnIzmeniZaposlenog.TabIndex = 1;
            this.btnIzmeniZaposlenog.Text = "Izmeni zaposlenog";
            this.btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            this.btnIzmeniZaposlenog.Click += new System.EventHandler(this.btnIzmeniZaposlenog_Click);
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(27, 43);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(175, 23);
            this.btnDodajZaposlenog.TabIndex = 0;
            this.btnDodajZaposlenog.Text = "Dodaj zaposlenog";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 84;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 106;
            // 
            // Farmaceut
            // 
            this.Farmaceut.Text = "Farmaceut";
            this.Farmaceut.Width = 75;
            // 
            // lvListaZaposlenih
            // 
            this.lvListaZaposlenih.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Maticni,
            this.Ime,
            this.Prezime,
            this.Adresa,
            this.Telefon,
            this.Rodjen,
            this.Farmaceut,
            this.Diplomirao,
            this.Obnovio});
            this.lvListaZaposlenih.FullRowSelect = true;
            this.lvListaZaposlenih.GridLines = true;
            this.lvListaZaposlenih.HideSelection = false;
            this.lvListaZaposlenih.Location = new System.Drawing.Point(3, 12);
            this.lvListaZaposlenih.Name = "lvListaZaposlenih";
            this.lvListaZaposlenih.Size = new System.Drawing.Size(838, 275);
            this.lvListaZaposlenih.TabIndex = 0;
            this.lvListaZaposlenih.UseCompatibleStateImageBehavior = false;
            this.lvListaZaposlenih.View = System.Windows.Forms.View.Details;
            // 
            // Maticni
            // 
            this.Maticni.Text = "Maticni";
            this.Maticni.Width = 104;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 111;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 99;
            // 
            // Rodjen
            // 
            this.Rodjen.Text = "Rodjen";
            this.Rodjen.Width = 91;
            // 
            // Diplomirao
            // 
            this.Diplomirao.Text = "Diplomirao";
            this.Diplomirao.Width = 78;
            // 
            // Obnovio
            // 
            this.Obnovio.Text = "Obnovio";
            this.Obnovio.Width = 85;
            // 
            // gboxListaZaposlenih
            // 
            this.gboxListaZaposlenih.Controls.Add(this.lvListaZaposlenih);
            this.gboxListaZaposlenih.Location = new System.Drawing.Point(12, 12);
            this.gboxListaZaposlenih.Name = "gboxListaZaposlenih";
            this.gboxListaZaposlenih.Size = new System.Drawing.Size(847, 293);
            this.gboxListaZaposlenih.TabIndex = 2;
            this.gboxListaZaposlenih.TabStop = false;
            this.gboxListaZaposlenih.Text = "Informacije o zaposlenima";
            // 
            // ZaposleniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 319);
            this.Controls.Add(this.gboxListaZaposlenih);
            this.Controls.Add(this.gbxKontrolaZaposleni);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1125, 358);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1125, 358);
            this.Name = "ZaposleniForm";
            this.Text = "ZaposleniForm";
            this.Load += new System.EventHandler(this.ZaposleniForm_Load);
            this.gbxKontrolaZaposleni.ResumeLayout(false);
            this.gbxKontrolaZaposleni.PerformLayout();
            this.gboxListaZaposlenih.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxKontrolaZaposleni;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Farmaceut;
        private System.Windows.Forms.ListView lvListaZaposlenih;
        private System.Windows.Forms.Button btnObrisiZaposlenog;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.ColumnHeader Maticni;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Rodjen;
        private System.Windows.Forms.Button btnRecepti;
        private System.Windows.Forms.GroupBox gboxListaZaposlenih;
        private System.Windows.Forms.TextBox tbxUkupno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRadnoMesto;
        private System.Windows.Forms.ColumnHeader Diplomirao;
        private System.Windows.Forms.ColumnHeader Obnovio;
    }
}