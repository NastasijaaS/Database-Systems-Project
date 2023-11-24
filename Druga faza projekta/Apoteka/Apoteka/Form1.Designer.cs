
namespace Apoteka
{
    partial class Form1
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
            this.btnVratiProdajnoMesto = new System.Windows.Forms.Button();
            this.btnVratiZaposlenog = new System.Windows.Forms.Button();
            this.btnVratiRecept = new System.Windows.Forms.Button();
            this.btnVratiLek = new System.Windows.Forms.Button();
            this.btnVratiProizvodjaca = new System.Windows.Forms.Button();
            this.btnVratiTipLeka = new System.Windows.Forms.Button();
            this.btnVratiPakovanje = new System.Windows.Forms.Button();
            this.btnOneToMany = new System.Windows.Forms.Button();
            this.btnManyToMany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVratiProdajnoMesto
            // 
            this.btnVratiProdajnoMesto.Location = new System.Drawing.Point(12, 12);
            this.btnVratiProdajnoMesto.Name = "btnVratiProdajnoMesto";
            this.btnVratiProdajnoMesto.Size = new System.Drawing.Size(142, 23);
            this.btnVratiProdajnoMesto.TabIndex = 0;
            this.btnVratiProdajnoMesto.Text = "Vrati prodajno mesto";
            this.btnVratiProdajnoMesto.UseVisualStyleBackColor = true;
            this.btnVratiProdajnoMesto.Click += new System.EventHandler(this.btnVratiProdajnoMesto_Click);
            // 
            // btnVratiZaposlenog
            // 
            this.btnVratiZaposlenog.Location = new System.Drawing.Point(13, 42);
            this.btnVratiZaposlenog.Name = "btnVratiZaposlenog";
            this.btnVratiZaposlenog.Size = new System.Drawing.Size(141, 23);
            this.btnVratiZaposlenog.TabIndex = 1;
            this.btnVratiZaposlenog.Text = "Vrati zaposlenog";
            this.btnVratiZaposlenog.UseVisualStyleBackColor = true;
            this.btnVratiZaposlenog.Click += new System.EventHandler(this.btnVratiZaposlenog_Click);
            // 
            // btnVratiRecept
            // 
            this.btnVratiRecept.Location = new System.Drawing.Point(13, 72);
            this.btnVratiRecept.Name = "btnVratiRecept";
            this.btnVratiRecept.Size = new System.Drawing.Size(141, 23);
            this.btnVratiRecept.TabIndex = 2;
            this.btnVratiRecept.Text = "Vrati recept";
            this.btnVratiRecept.UseVisualStyleBackColor = true;
            this.btnVratiRecept.Click += new System.EventHandler(this.btnVratiRecept_Click);
            // 
            // btnVratiLek
            // 
            this.btnVratiLek.Location = new System.Drawing.Point(13, 102);
            this.btnVratiLek.Name = "btnVratiLek";
            this.btnVratiLek.Size = new System.Drawing.Size(141, 23);
            this.btnVratiLek.TabIndex = 3;
            this.btnVratiLek.Text = "Vrati lek";
            this.btnVratiLek.UseVisualStyleBackColor = true;
            this.btnVratiLek.Click += new System.EventHandler(this.btnVratiLek_Click);
            // 
            // btnVratiProizvodjaca
            // 
            this.btnVratiProizvodjaca.Location = new System.Drawing.Point(13, 132);
            this.btnVratiProizvodjaca.Name = "btnVratiProizvodjaca";
            this.btnVratiProizvodjaca.Size = new System.Drawing.Size(141, 23);
            this.btnVratiProizvodjaca.TabIndex = 4;
            this.btnVratiProizvodjaca.Text = "Vrati proizvodjaca";
            this.btnVratiProizvodjaca.UseVisualStyleBackColor = true;
            this.btnVratiProizvodjaca.Click += new System.EventHandler(this.btnVratiProizvodjaca_Click);
            // 
            // btnVratiTipLeka
            // 
            this.btnVratiTipLeka.Location = new System.Drawing.Point(13, 162);
            this.btnVratiTipLeka.Name = "btnVratiTipLeka";
            this.btnVratiTipLeka.Size = new System.Drawing.Size(141, 23);
            this.btnVratiTipLeka.TabIndex = 5;
            this.btnVratiTipLeka.Text = "Vrati tip leka";
            this.btnVratiTipLeka.UseVisualStyleBackColor = true;
            this.btnVratiTipLeka.Click += new System.EventHandler(this.btnVratiTipLeka_Click);
            // 
            // btnVratiPakovanje
            // 
            this.btnVratiPakovanje.Location = new System.Drawing.Point(13, 192);
            this.btnVratiPakovanje.Name = "btnVratiPakovanje";
            this.btnVratiPakovanje.Size = new System.Drawing.Size(141, 23);
            this.btnVratiPakovanje.TabIndex = 6;
            this.btnVratiPakovanje.Text = "Vrati pakovanje";
            this.btnVratiPakovanje.UseVisualStyleBackColor = true;
            this.btnVratiPakovanje.Click += new System.EventHandler(this.btnVratiPakovanje_Click);
            // 
            // btnOneToMany
            // 
            this.btnOneToMany.Location = new System.Drawing.Point(13, 222);
            this.btnOneToMany.Name = "btnOneToMany";
            this.btnOneToMany.Size = new System.Drawing.Size(141, 23);
            this.btnOneToMany.TabIndex = 7;
            this.btnOneToMany.Text = "ONE TO MANY";
            this.btnOneToMany.UseVisualStyleBackColor = true;
            this.btnOneToMany.Click += new System.EventHandler(this.btnOneToMany_Click);
            // 
            // btnManyToMany
            // 
            this.btnManyToMany.Location = new System.Drawing.Point(13, 252);
            this.btnManyToMany.Name = "btnManyToMany";
            this.btnManyToMany.Size = new System.Drawing.Size(141, 23);
            this.btnManyToMany.TabIndex = 8;
            this.btnManyToMany.Text = "MANY TO MANY";
            this.btnManyToMany.UseVisualStyleBackColor = true;
            this.btnManyToMany.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManyToMany);
            this.Controls.Add(this.btnOneToMany);
            this.Controls.Add(this.btnVratiPakovanje);
            this.Controls.Add(this.btnVratiTipLeka);
            this.Controls.Add(this.btnVratiProizvodjaca);
            this.Controls.Add(this.btnVratiLek);
            this.Controls.Add(this.btnVratiRecept);
            this.Controls.Add(this.btnVratiZaposlenog);
            this.Controls.Add(this.btnVratiProdajnoMesto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVratiProdajnoMesto;
        private System.Windows.Forms.Button btnVratiZaposlenog;
        private System.Windows.Forms.Button btnVratiRecept;
        private System.Windows.Forms.Button btnVratiLek;
        private System.Windows.Forms.Button btnVratiProizvodjaca;
        private System.Windows.Forms.Button btnVratiTipLeka;
        private System.Windows.Forms.Button btnVratiPakovanje;
        private System.Windows.Forms.Button btnOneToMany;
        private System.Windows.Forms.Button btnManyToMany;
    }
}

