
namespace Apoteka.Forme
{
    partial class LekoviForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lekovi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPrikaziInfOLeku = new System.Windows.Forms.Button();
            this.btnDodajLek = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBrojLekova = new System.Windows.Forms.TextBox();
            this.btnIndikacije = new System.Windows.Forms.Button();
            this.btnPrikaziProdajnaMesta = new System.Windows.Forms.Button();
            this.btnKontraindikacije = new System.Windows.Forms.Button();
            this.btnUpakuj = new System.Windows.Forms.Button();
            this.cbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.cbPakovanja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVratiSveLekove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lekovi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Svi lekovi u prodaji";
            // 
            // lekovi
            // 
            this.lekovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lekovi.FullRowSelect = true;
            this.lekovi.GridLines = true;
            this.lekovi.HideSelection = false;
            this.lekovi.Location = new System.Drawing.Point(6, 19);
            this.lekovi.Name = "lekovi";
            this.lekovi.Size = new System.Drawing.Size(397, 420);
            this.lekovi.TabIndex = 1;
            this.lekovi.UseCompatibleStateImageBehavior = false;
            this.lekovi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id leka";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Komercijalni naziv";
            this.columnHeader2.Width = 194;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cena";
            this.columnHeader4.Width = 137;
            // 
            // btnPrikaziInfOLeku
            // 
            this.btnPrikaziInfOLeku.Location = new System.Drawing.Point(427, 31);
            this.btnPrikaziInfOLeku.Name = "btnPrikaziInfOLeku";
            this.btnPrikaziInfOLeku.Size = new System.Drawing.Size(175, 23);
            this.btnPrikaziInfOLeku.TabIndex = 2;
            this.btnPrikaziInfOLeku.Text = "Prikazi vise informacija o leku";
            this.btnPrikaziInfOLeku.UseVisualStyleBackColor = true;
            this.btnPrikaziInfOLeku.Click += new System.EventHandler(this.btnPrikaziInfOLeku_Click);
            // 
            // btnDodajLek
            // 
            this.btnDodajLek.Location = new System.Drawing.Point(427, 60);
            this.btnDodajLek.Name = "btnDodajLek";
            this.btnDodajLek.Size = new System.Drawing.Size(175, 23);
            this.btnDodajLek.TabIndex = 3;
            this.btnDodajLek.Text = "Dodaj lek";
            this.btnDodajLek.UseVisualStyleBackColor = true;
            this.btnDodajLek.Click += new System.EventHandler(this.btnDodajLek_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(427, 89);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(175, 23);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni  lek";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(427, 118);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(175, 23);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "Izbrisi lek";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ukupan broj lekova";
            // 
            // tbxBrojLekova
            // 
            this.tbxBrojLekova.Location = new System.Drawing.Point(543, 431);
            this.tbxBrojLekova.Name = "tbxBrojLekova";
            this.tbxBrojLekova.Size = new System.Drawing.Size(60, 20);
            this.tbxBrojLekova.TabIndex = 7;
            // 
            // btnIndikacije
            // 
            this.btnIndikacije.Location = new System.Drawing.Point(427, 219);
            this.btnIndikacije.Name = "btnIndikacije";
            this.btnIndikacije.Size = new System.Drawing.Size(175, 23);
            this.btnIndikacije.TabIndex = 8;
            this.btnIndikacije.Text = "Indikacije za lek";
            this.btnIndikacije.UseVisualStyleBackColor = true;
            this.btnIndikacije.Click += new System.EventHandler(this.btnIndikacije_Click);
            // 
            // btnPrikaziProdajnaMesta
            // 
            this.btnPrikaziProdajnaMesta.Location = new System.Drawing.Point(427, 176);
            this.btnPrikaziProdajnaMesta.Name = "btnPrikaziProdajnaMesta";
            this.btnPrikaziProdajnaMesta.Size = new System.Drawing.Size(175, 23);
            this.btnPrikaziProdajnaMesta.TabIndex = 9;
            this.btnPrikaziProdajnaMesta.Text = "Prikazi prodajna mesta";
            this.btnPrikaziProdajnaMesta.UseVisualStyleBackColor = true;
            this.btnPrikaziProdajnaMesta.Click += new System.EventHandler(this.btnPrikaziProdajnaMesta_Click);
            // 
            // btnKontraindikacije
            // 
            this.btnKontraindikacije.Location = new System.Drawing.Point(427, 249);
            this.btnKontraindikacije.Name = "btnKontraindikacije";
            this.btnKontraindikacije.Size = new System.Drawing.Size(175, 23);
            this.btnKontraindikacije.TabIndex = 10;
            this.btnKontraindikacije.Text = "Kontraindikacije";
            this.btnKontraindikacije.UseVisualStyleBackColor = true;
            this.btnKontraindikacije.Click += new System.EventHandler(this.btnKontraindikacije_Click);
            // 
            // btnUpakuj
            // 
            this.btnUpakuj.Location = new System.Drawing.Point(427, 147);
            this.btnUpakuj.Name = "btnUpakuj";
            this.btnUpakuj.Size = new System.Drawing.Size(175, 23);
            this.btnUpakuj.TabIndex = 11;
            this.btnUpakuj.Text = "Upakuj lek";
            this.btnUpakuj.UseVisualStyleBackColor = true;
            this.btnUpakuj.Click += new System.EventHandler(this.btnUpakuj_Click);
            // 
            // cbProizvodjaci
            // 
            this.cbProizvodjaci.FormattingEnabled = true;
            this.cbProizvodjaci.Location = new System.Drawing.Point(427, 310);
            this.cbProizvodjaci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProizvodjaci.Name = "cbProizvodjaci";
            this.cbProizvodjaci.Size = new System.Drawing.Size(176, 21);
            this.cbProizvodjaci.TabIndex = 12;
            this.cbProizvodjaci.SelectedIndexChanged += new System.EventHandler(this.cbProizvodjaci_SelectedIndexChanged);
            // 
            // cbPakovanja
            // 
            this.cbPakovanja.FormattingEnabled = true;
            this.cbPakovanja.Location = new System.Drawing.Point(427, 358);
            this.cbPakovanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPakovanja.Name = "cbPakovanja";
            this.cbPakovanja.Size = new System.Drawing.Size(176, 21);
            this.cbPakovanja.TabIndex = 13;
            this.cbPakovanja.SelectedIndexChanged += new System.EventHandler(this.cbPakovanja_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filtriraj lekove po proizvođaču";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filtriraj lekove po pakovanju";
            // 
            // btnVratiSveLekove
            // 
            this.btnVratiSveLekove.Location = new System.Drawing.Point(427, 384);
            this.btnVratiSveLekove.Name = "btnVratiSveLekove";
            this.btnVratiSveLekove.Size = new System.Drawing.Size(175, 23);
            this.btnVratiSveLekove.TabIndex = 16;
            this.btnVratiSveLekove.Text = "Prikazi sve lekove";
            this.btnVratiSveLekove.UseVisualStyleBackColor = true;
            this.btnVratiSveLekove.Click += new System.EventHandler(this.btnVratiSveLekove_Click);
            // 
            // LekoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 463);
            this.Controls.Add(this.btnVratiSveLekove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPakovanja);
            this.Controls.Add(this.cbProizvodjaci);
            this.Controls.Add(this.btnUpakuj);
            this.Controls.Add(this.btnKontraindikacije);
            this.Controls.Add(this.btnPrikaziProdajnaMesta);
            this.Controls.Add(this.btnIndikacije);
            this.Controls.Add(this.tbxBrojLekova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPrikaziInfOLeku);
            this.Controls.Add(this.btnDodajLek);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.groupBox1);
            this.Name = "LekoviForm";
            this.Text = "LekoviForm";
            this.Load += new System.EventHandler(this.LekoviForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lekovi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPrikaziInfOLeku;
        private System.Windows.Forms.Button btnDodajLek;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBrojLekova;
        private System.Windows.Forms.Button btnIndikacije;
        private System.Windows.Forms.Button btnPrikaziProdajnaMesta;
        private System.Windows.Forms.Button btnKontraindikacije;
        private System.Windows.Forms.Button btnUpakuj;
        private System.Windows.Forms.ComboBox cbProizvodjaci;
        private System.Windows.Forms.ComboBox cbPakovanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVratiSveLekove;
    }
}