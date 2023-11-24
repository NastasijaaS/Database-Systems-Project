namespace Apoteka.Forme
{
    partial class LekIzmeniForma
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
            this.lblCena = new System.Windows.Forms.Label();
            this.lblParticipacija = new System.Windows.Forms.Label();
            this.lblRecept = new System.Windows.Forms.Label();
            this.tbxCena = new System.Windows.Forms.TextBox();
            this.tbxProcenat = new System.Windows.Forms.TextBox();
            this.cbxRecept = new System.Windows.Forms.CheckBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(12, 15);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(35, 13);
            this.lblCena.TabIndex = 0;
            this.lblCena.Text = "Cena:";
            // 
            // lblParticipacija
            // 
            this.lblParticipacija.AutoSize = true;
            this.lblParticipacija.Location = new System.Drawing.Point(12, 41);
            this.lblParticipacija.Name = "lblParticipacija";
            this.lblParticipacija.Size = new System.Drawing.Size(112, 13);
            this.lblParticipacija.TabIndex = 1;
            this.lblParticipacija.Text = "Procenat participacije:";
            // 
            // lblRecept
            // 
            this.lblRecept.AutoSize = true;
            this.lblRecept.Location = new System.Drawing.Point(12, 64);
            this.lblRecept.Name = "lblRecept";
            this.lblRecept.Size = new System.Drawing.Size(57, 13);
            this.lblRecept.TabIndex = 2;
            this.lblRecept.Text = "Na recept:";
            // 
            // tbxCena
            // 
            this.tbxCena.Location = new System.Drawing.Point(152, 12);
            this.tbxCena.Name = "tbxCena";
            this.tbxCena.Size = new System.Drawing.Size(100, 20);
            this.tbxCena.TabIndex = 3;
            // 
            // tbxProcenat
            // 
            this.tbxProcenat.Location = new System.Drawing.Point(152, 38);
            this.tbxProcenat.Name = "tbxProcenat";
            this.tbxProcenat.Size = new System.Drawing.Size(100, 20);
            this.tbxProcenat.TabIndex = 4;
            // 
            // cbxRecept
            // 
            this.cbxRecept.AutoSize = true;
            this.cbxRecept.Location = new System.Drawing.Point(237, 64);
            this.cbxRecept.Name = "cbxRecept";
            this.cbxRecept.Size = new System.Drawing.Size(15, 14);
            this.cbxRecept.TabIndex = 5;
            this.cbxRecept.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(12, 92);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(177, 92);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 7;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // LekIzmeniForma
            // 
            this.AcceptButton = this.btnPromeni;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(264, 131);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cbxRecept);
            this.Controls.Add(this.tbxProcenat);
            this.Controls.Add(this.tbxCena);
            this.Controls.Add(this.lblRecept);
            this.Controls.Add(this.lblParticipacija);
            this.Controls.Add(this.lblCena);
            this.Name = "LekIzmeniForma";
            this.Text = "LekIzmeniForma";
            this.Load += new System.EventHandler(this.LekIzmeniForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblParticipacija;
        private System.Windows.Forms.Label lblRecept;
        private System.Windows.Forms.TextBox tbxCena;
        private System.Windows.Forms.TextBox tbxProcenat;
        private System.Windows.Forms.CheckBox cbxRecept;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPromeni;
    }
}