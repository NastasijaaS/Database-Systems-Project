
namespace Apoteka.Forme
{
    partial class ProdajnoMestoZaposleniForm
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
            this.zaposleni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajZaposlenogUProdajnoMesto = new System.Windows.Forms.Button();
            this.btnObrisiZaposlenogIzProdajnogMesta = new System.Windows.Forms.Button();
            this.btnDodajNovogZaposlenog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zaposleni
            // 
            this.zaposleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.zaposleni.FullRowSelect = true;
            this.zaposleni.GridLines = true;
            this.zaposleni.HideSelection = false;
            this.zaposleni.Location = new System.Drawing.Point(11, 11);
            this.zaposleni.Margin = new System.Windows.Forms.Padding(2);
            this.zaposleni.Name = "zaposleni";
            this.zaposleni.Size = new System.Drawing.Size(607, 298);
            this.zaposleni.TabIndex = 0;
            this.zaposleni.UseCompatibleStateImageBehavior = false;
            this.zaposleni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adresa";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj telefona";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Datum rodjenja";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Farmaceut";
            this.columnHeader7.Width = 79;
            // 
            // btnDodajZaposlenogUProdajnoMesto
            // 
            this.btnDodajZaposlenogUProdajnoMesto.Location = new System.Drawing.Point(631, 11);
            this.btnDodajZaposlenogUProdajnoMesto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajZaposlenogUProdajnoMesto.Name = "btnDodajZaposlenogUProdajnoMesto";
            this.btnDodajZaposlenogUProdajnoMesto.Size = new System.Drawing.Size(130, 45);
            this.btnDodajZaposlenogUProdajnoMesto.TabIndex = 1;
            this.btnDodajZaposlenogUProdajnoMesto.Text = "Dodaj zaposlenog u prodajno mesto";
            this.btnDodajZaposlenogUProdajnoMesto.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenogUProdajnoMesto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnObrisiZaposlenogIzProdajnogMesta
            // 
            this.btnObrisiZaposlenogIzProdajnogMesta.Location = new System.Drawing.Point(631, 60);
            this.btnObrisiZaposlenogIzProdajnogMesta.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiZaposlenogIzProdajnogMesta.Name = "btnObrisiZaposlenogIzProdajnogMesta";
            this.btnObrisiZaposlenogIzProdajnogMesta.Size = new System.Drawing.Size(130, 45);
            this.btnObrisiZaposlenogIzProdajnogMesta.TabIndex = 2;
            this.btnObrisiZaposlenogIzProdajnogMesta.Text = "Obrisi zaposlenog iz prodajnog mesta";
            this.btnObrisiZaposlenogIzProdajnogMesta.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenogIzProdajnogMesta.Click += new System.EventHandler(this.btnObrisiZaposlenogIzProdajnogMesta_Click);
            // 
            // btnDodajNovogZaposlenog
            // 
            this.btnDodajNovogZaposlenog.Location = new System.Drawing.Point(631, 109);
            this.btnDodajNovogZaposlenog.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajNovogZaposlenog.Name = "btnDodajNovogZaposlenog";
            this.btnDodajNovogZaposlenog.Size = new System.Drawing.Size(130, 45);
            this.btnDodajNovogZaposlenog.TabIndex = 3;
            this.btnDodajNovogZaposlenog.Text = "Dodaj novog zaposlenog";
            this.btnDodajNovogZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajNovogZaposlenog.Click += new System.EventHandler(this.btnDodajNovogZaposlenog_Click);
            // 
            // ProdajnoMestoZaposleniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 320);
            this.Controls.Add(this.btnDodajNovogZaposlenog);
            this.Controls.Add(this.btnObrisiZaposlenogIzProdajnogMesta);
            this.Controls.Add(this.btnDodajZaposlenogUProdajnoMesto);
            this.Controls.Add(this.zaposleni);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProdajnoMestoZaposleniForm";
            this.Text = "ProdajnoMestoZaposleniForm";
            this.Load += new System.EventHandler(this.ProdajnoMestoZaposleniForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView zaposleni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnDodajZaposlenogUProdajnoMesto;
        private System.Windows.Forms.Button btnObrisiZaposlenogIzProdajnogMesta;
        private System.Windows.Forms.Button btnDodajNovogZaposlenog;
    }
}