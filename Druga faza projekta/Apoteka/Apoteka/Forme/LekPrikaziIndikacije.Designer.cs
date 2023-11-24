namespace Apoteka.Forme
{
    partial class LekPrikaziIndikacije
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
            this.lvIndikacije = new System.Windows.Forms.ListView();
            this.Indikacije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajIndikaciju = new System.Windows.Forms.Button();
            this.btnUkloniIndikaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvIndikacije
            // 
            this.lvIndikacije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Indikacije});
            this.lvIndikacije.FullRowSelect = true;
            this.lvIndikacije.GridLines = true;
            this.lvIndikacije.HideSelection = false;
            this.lvIndikacije.Location = new System.Drawing.Point(12, 12);
            this.lvIndikacije.Name = "lvIndikacije";
            this.lvIndikacije.Size = new System.Drawing.Size(320, 280);
            this.lvIndikacije.TabIndex = 0;
            this.lvIndikacije.UseCompatibleStateImageBehavior = false;
            this.lvIndikacije.View = System.Windows.Forms.View.Details;
            // 
            // Indikacije
            // 
            this.Indikacije.Text = "Indikacije";
            this.Indikacije.Width = 228;
            // 
            // btnDodajIndikaciju
            // 
            this.btnDodajIndikaciju.Location = new System.Drawing.Point(335, 12);
            this.btnDodajIndikaciju.Name = "btnDodajIndikaciju";
            this.btnDodajIndikaciju.Size = new System.Drawing.Size(135, 23);
            this.btnDodajIndikaciju.TabIndex = 1;
            this.btnDodajIndikaciju.Text = "Dodaj indikaciju";
            this.btnDodajIndikaciju.UseVisualStyleBackColor = true;
            this.btnDodajIndikaciju.Click += new System.EventHandler(this.btnDodajIndikaciju_Click);
            // 
            // btnUkloniIndikaciju
            // 
            this.btnUkloniIndikaciju.Location = new System.Drawing.Point(335, 41);
            this.btnUkloniIndikaciju.Name = "btnUkloniIndikaciju";
            this.btnUkloniIndikaciju.Size = new System.Drawing.Size(135, 23);
            this.btnUkloniIndikaciju.TabIndex = 2;
            this.btnUkloniIndikaciju.Text = "Ukloni indikaciju";
            this.btnUkloniIndikaciju.UseVisualStyleBackColor = true;
            this.btnUkloniIndikaciju.Click += new System.EventHandler(this.btnUkloniIndikaciju_Click);
            // 
            // LekPrikaziIndikacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 311);
            this.Controls.Add(this.btnUkloniIndikaciju);
            this.Controls.Add(this.btnDodajIndikaciju);
            this.Controls.Add(this.lvIndikacije);
            this.Name = "LekPrikaziIndikacije";
            this.Text = "LekPrikaziIndikacije";
            this.Load += new System.EventHandler(this.LekPrikaziIndikacije_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvIndikacije;
        private System.Windows.Forms.ColumnHeader Indikacije;
        private System.Windows.Forms.Button btnDodajIndikaciju;
        private System.Windows.Forms.Button btnUkloniIndikaciju;
    }
}