namespace Apoteka.Forme
{
    partial class LekPrikaziKontraindikacije
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
            this.lvKontraindikacije = new System.Windows.Forms.ListView();
            this.Kontraindikacije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajKontraindikaciju = new System.Windows.Forms.Button();
            this.btnUkloniIndikaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvKontraindikacije
            // 
            this.lvKontraindikacije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kontraindikacije});
            this.lvKontraindikacije.FullRowSelect = true;
            this.lvKontraindikacije.GridLines = true;
            this.lvKontraindikacije.HideSelection = false;
            this.lvKontraindikacije.Location = new System.Drawing.Point(12, 12);
            this.lvKontraindikacije.Name = "lvKontraindikacije";
            this.lvKontraindikacije.Size = new System.Drawing.Size(320, 280);
            this.lvKontraindikacije.TabIndex = 0;
            this.lvKontraindikacije.UseCompatibleStateImageBehavior = false;
            this.lvKontraindikacije.View = System.Windows.Forms.View.Details;
            // 
            // Kontraindikacije
            // 
            this.Kontraindikacije.Text = "Kontraindikacije";
            this.Kontraindikacije.Width = 223;
            // 
            // btnDodajKontraindikaciju
            // 
            this.btnDodajKontraindikaciju.Location = new System.Drawing.Point(338, 12);
            this.btnDodajKontraindikaciju.Name = "btnDodajKontraindikaciju";
            this.btnDodajKontraindikaciju.Size = new System.Drawing.Size(130, 23);
            this.btnDodajKontraindikaciju.TabIndex = 1;
            this.btnDodajKontraindikaciju.Text = "Dodaj kontraindikaciju";
            this.btnDodajKontraindikaciju.UseVisualStyleBackColor = true;
            this.btnDodajKontraindikaciju.Click += new System.EventHandler(this.btnDodajKontraindikaciju_Click);
            // 
            // btnUkloniIndikaciju
            // 
            this.btnUkloniIndikaciju.Location = new System.Drawing.Point(338, 41);
            this.btnUkloniIndikaciju.Name = "btnUkloniIndikaciju";
            this.btnUkloniIndikaciju.Size = new System.Drawing.Size(130, 23);
            this.btnUkloniIndikaciju.TabIndex = 2;
            this.btnUkloniIndikaciju.Text = "Ukloni kontraindikaciju";
            this.btnUkloniIndikaciju.UseVisualStyleBackColor = true;
            this.btnUkloniIndikaciju.Click += new System.EventHandler(this.btnUkloniIndikaciju_Click);
            // 
            // LekPrikaziKontraindikacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 311);
            this.Controls.Add(this.btnUkloniIndikaciju);
            this.Controls.Add(this.btnDodajKontraindikaciju);
            this.Controls.Add(this.lvKontraindikacije);
            this.Name = "LekPrikaziKontraindikacije";
            this.Text = "LekPrikaziKontraindikacije";
            this.Load += new System.EventHandler(this.LekPrikaziKontraindikacije_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvKontraindikacije;
        private System.Windows.Forms.ColumnHeader Kontraindikacije;
        private System.Windows.Forms.Button btnDodajKontraindikaciju;
        private System.Windows.Forms.Button btnUkloniIndikaciju;
    }
}