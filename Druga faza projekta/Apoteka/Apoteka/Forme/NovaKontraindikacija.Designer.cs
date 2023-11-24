namespace Apoteka.Forme
{
    partial class NovaKontraindikacija
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
            this.lblTekst = new System.Windows.Forms.Label();
            this.lblLek = new System.Windows.Forms.Label();
            this.tbxTekst = new System.Windows.Forms.TextBox();
            this.cbxLekovi = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(12, 15);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(37, 13);
            this.lblTekst.TabIndex = 0;
            this.lblTekst.Text = "Tekst:";
            // 
            // lblLek
            // 
            this.lblLek.AutoSize = true;
            this.lblLek.Location = new System.Drawing.Point(12, 41);
            this.lblLek.Name = "lblLek";
            this.lblLek.Size = new System.Drawing.Size(28, 13);
            this.lblLek.TabIndex = 1;
            this.lblLek.Text = "Lek:";
            // 
            // tbxTekst
            // 
            this.tbxTekst.Location = new System.Drawing.Point(84, 12);
            this.tbxTekst.Name = "tbxTekst";
            this.tbxTekst.Size = new System.Drawing.Size(199, 20);
            this.tbxTekst.TabIndex = 2;
            // 
            // cbxLekovi
            // 
            this.cbxLekovi.FormattingEnabled = true;
            this.cbxLekovi.Location = new System.Drawing.Point(180, 38);
            this.cbxLekovi.Name = "cbxLekovi";
            this.cbxLekovi.Size = new System.Drawing.Size(103, 21);
            this.cbxLekovi.TabIndex = 3;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 66);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(207, 66);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 5;
            this.btnPotvrdi.Text = "Dodaj";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // NovaKontraindikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(294, 101);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cbxLekovi);
            this.Controls.Add(this.tbxTekst);
            this.Controls.Add(this.lblLek);
            this.Controls.Add(this.lblTekst);
            this.Name = "NovaKontraindikacija";
            this.Text = "NovaKontraindikacija";
            this.Load += new System.EventHandler(this.NovaKontraindikacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Label lblLek;
        private System.Windows.Forms.TextBox tbxTekst;
        private System.Windows.Forms.ComboBox cbxLekovi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}