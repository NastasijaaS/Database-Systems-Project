namespace Apoteka.Forme
{
    partial class NovaIndikacija
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cboxLek = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(14, 15);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(37, 13);
            this.lblTekst.TabIndex = 0;
            this.lblTekst.Text = "Tekst:";
            // 
            // lblLek
            // 
            this.lblLek.AutoSize = true;
            this.lblLek.Location = new System.Drawing.Point(14, 41);
            this.lblLek.Name = "lblLek";
            this.lblLek.Size = new System.Drawing.Size(28, 13);
            this.lblLek.TabIndex = 1;
            this.lblLek.Text = "Lek:";
            // 
            // tbxTekst
            // 
            this.tbxTekst.Location = new System.Drawing.Point(87, 12);
            this.tbxTekst.Name = "tbxTekst";
            this.tbxTekst.Size = new System.Drawing.Size(195, 20);
            this.tbxTekst.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(207, 66);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 66);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cboxLek
            // 
            this.cboxLek.FormattingEnabled = true;
            this.cboxLek.Location = new System.Drawing.Point(161, 38);
            this.cboxLek.Name = "cboxLek";
            this.cboxLek.Size = new System.Drawing.Size(121, 21);
            this.cboxLek.TabIndex = 6;
            // 
            // NovaIndikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(294, 101);
            this.Controls.Add(this.cboxLek);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxTekst);
            this.Controls.Add(this.lblLek);
            this.Controls.Add(this.lblTekst);
            this.Name = "NovaIndikacija";
            this.Text = "NovaIndikacija";
            this.Load += new System.EventHandler(this.NovaIndikacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Label lblLek;
        private System.Windows.Forms.TextBox tbxTekst;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cboxLek;
    }
}