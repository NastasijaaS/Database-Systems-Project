namespace Apoteka.Forme
{
    partial class LekoviPrikaziProdajnaMesta
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
            this.lvProdajnaMesta = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvProdajnaMesta
            // 
            this.lvProdajnaMesta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Naziv,
            this.Adresa,
            this.Mesto});
            this.lvProdajnaMesta.FullRowSelect = true;
            this.lvProdajnaMesta.GridLines = true;
            this.lvProdajnaMesta.HideSelection = false;
            this.lvProdajnaMesta.Location = new System.Drawing.Point(12, 12);
            this.lvProdajnaMesta.Name = "lvProdajnaMesta";
            this.lvProdajnaMesta.Size = new System.Drawing.Size(481, 289);
            this.lvProdajnaMesta.TabIndex = 0;
            this.lvProdajnaMesta.UseCompatibleStateImageBehavior = false;
            this.lvProdajnaMesta.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 108;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 171;
            // 
            // Mesto
            // 
            this.Mesto.Text = "Mesto";
            this.Mesto.Width = 134;
            // 
            // LekoviPrikaziProdajnaMesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 313);
            this.Controls.Add(this.lvProdajnaMesta);
            this.Name = "LekoviPrikaziProdajnaMesta";
            this.Text = "LekoviPrikaziProdajnaMesta";
            this.Load += new System.EventHandler(this.LekoviPrikaziProdajnaMesta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProdajnaMesta;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Mesto;
    }
}