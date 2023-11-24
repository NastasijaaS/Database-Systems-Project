
namespace Apoteka.Forme
{
    partial class ProdajnaMestaForm
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
            this.btnDodajProdajnoMesto = new System.Windows.Forms.Button();
            this.btnIzmeniProdajnoMesto = new System.Windows.Forms.Button();
            this.btnObrisiProdajnoMesto = new System.Windows.Forms.Button();
            this.gbProdajnaMesta = new System.Windows.Forms.GroupBox();
            this.listaProdajnihMesta = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVratiLekove = new System.Windows.Forms.Button();
            this.btnVratiRadnike = new System.Windows.Forms.Button();
            this.gbProdajnaMesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajProdajnoMesto
            // 
            this.btnDodajProdajnoMesto.Location = new System.Drawing.Point(615, 42);
            this.btnDodajProdajnoMesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajProdajnoMesto.Name = "btnDodajProdajnoMesto";
            this.btnDodajProdajnoMesto.Size = new System.Drawing.Size(179, 28);
            this.btnDodajProdajnoMesto.TabIndex = 0;
            this.btnDodajProdajnoMesto.Text = "Dodaj prodajno mesto";
            this.btnDodajProdajnoMesto.UseVisualStyleBackColor = true;
            this.btnDodajProdajnoMesto.Click += new System.EventHandler(this.btnDodajProdajnoMesto_Click);
            // 
            // btnIzmeniProdajnoMesto
            // 
            this.btnIzmeniProdajnoMesto.Location = new System.Drawing.Point(615, 75);
            this.btnIzmeniProdajnoMesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmeniProdajnoMesto.Name = "btnIzmeniProdajnoMesto";
            this.btnIzmeniProdajnoMesto.Size = new System.Drawing.Size(179, 28);
            this.btnIzmeniProdajnoMesto.TabIndex = 1;
            this.btnIzmeniProdajnoMesto.Text = "Izmeni prodajno mesto";
            this.btnIzmeniProdajnoMesto.UseVisualStyleBackColor = true;
            this.btnIzmeniProdajnoMesto.Click += new System.EventHandler(this.btnIzmeniProdajnoMesto_Click);
            // 
            // btnObrisiProdajnoMesto
            // 
            this.btnObrisiProdajnoMesto.Location = new System.Drawing.Point(615, 108);
            this.btnObrisiProdajnoMesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiProdajnoMesto.Name = "btnObrisiProdajnoMesto";
            this.btnObrisiProdajnoMesto.Size = new System.Drawing.Size(179, 28);
            this.btnObrisiProdajnoMesto.TabIndex = 2;
            this.btnObrisiProdajnoMesto.Text = "Obrisi prodajno mesto";
            this.btnObrisiProdajnoMesto.UseVisualStyleBackColor = true;
            this.btnObrisiProdajnoMesto.Click += new System.EventHandler(this.btnObrisiProdajnoMesto_Click);
            // 
            // gbProdajnaMesta
            // 
            this.gbProdajnaMesta.Controls.Add(this.listaProdajnihMesta);
            this.gbProdajnaMesta.Location = new System.Drawing.Point(15, 14);
            this.gbProdajnaMesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProdajnaMesta.Name = "gbProdajnaMesta";
            this.gbProdajnaMesta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProdajnaMesta.Size = new System.Drawing.Size(595, 364);
            this.gbProdajnaMesta.TabIndex = 3;
            this.gbProdajnaMesta.TabStop = false;
            this.gbProdajnaMesta.Text = "Lista prodajnih mesta";
            // 
            // listaProdajnihMesta
            // 
            this.listaProdajnihMesta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Naziv,
            this.Adresa,
            this.Mesto});
            this.listaProdajnihMesta.FullRowSelect = true;
            this.listaProdajnihMesta.GridLines = true;
            this.listaProdajnihMesta.HideSelection = false;
            this.listaProdajnihMesta.Location = new System.Drawing.Point(5, 28);
            this.listaProdajnihMesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaProdajnihMesta.Name = "listaProdajnihMesta";
            this.listaProdajnihMesta.Size = new System.Drawing.Size(583, 325);
            this.listaProdajnihMesta.TabIndex = 0;
            this.listaProdajnihMesta.UseCompatibleStateImageBehavior = false;
            this.listaProdajnihMesta.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.DisplayIndex = 3;
            this.Id.Text = "Id";
            // 
            // Naziv
            // 
            this.Naziv.DisplayIndex = 0;
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 109;
            // 
            // Adresa
            // 
            this.Adresa.DisplayIndex = 1;
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 152;
            // 
            // Mesto
            // 
            this.Mesto.DisplayIndex = 2;
            this.Mesto.Text = "Mesto";
            this.Mesto.Width = 113;
            // 
            // btnVratiLekove
            // 
            this.btnVratiLekove.Location = new System.Drawing.Point(613, 304);
            this.btnVratiLekove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVratiLekove.Name = "btnVratiLekove";
            this.btnVratiLekove.Size = new System.Drawing.Size(179, 28);
            this.btnVratiLekove.TabIndex = 4;
            this.btnVratiLekove.Text = "Vrati lekove";
            this.btnVratiLekove.UseVisualStyleBackColor = true;
            this.btnVratiLekove.Click += new System.EventHandler(this.btnVratiLekove_Click);
            // 
            // btnVratiRadnike
            // 
            this.btnVratiRadnike.Location = new System.Drawing.Point(613, 340);
            this.btnVratiRadnike.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVratiRadnike.Name = "btnVratiRadnike";
            this.btnVratiRadnike.Size = new System.Drawing.Size(179, 28);
            this.btnVratiRadnike.TabIndex = 5;
            this.btnVratiRadnike.Text = "Vrati radnike";
            this.btnVratiRadnike.UseVisualStyleBackColor = true;
            this.btnVratiRadnike.Click += new System.EventHandler(this.btnVratiRadnike_Click);
            // 
            // ProdajnaMestaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 384);
            this.Controls.Add(this.btnVratiRadnike);
            this.Controls.Add(this.btnVratiLekove);
            this.Controls.Add(this.gbProdajnaMesta);
            this.Controls.Add(this.btnObrisiProdajnoMesto);
            this.Controls.Add(this.btnIzmeniProdajnoMesto);
            this.Controls.Add(this.btnDodajProdajnoMesto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProdajnaMestaForm";
            this.Text = "ProdajnaMestaForm";
            this.Load += new System.EventHandler(this.ProdajnaMestaForm_Load_1);
            this.gbProdajnaMesta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajProdajnoMesto;
        private System.Windows.Forms.Button btnIzmeniProdajnoMesto;
        private System.Windows.Forms.Button btnObrisiProdajnoMesto;
        private System.Windows.Forms.GroupBox gbProdajnaMesta;
        private System.Windows.Forms.ListView listaProdajnihMesta;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Mesto;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button btnVratiLekove;
        private System.Windows.Forms.Button btnVratiRadnike;
    }
}