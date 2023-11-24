
namespace Apoteka
{
    partial class PocetnaStranica
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
            this.btnProdajnaMesta = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.btnLekovi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProdajnaMesta
            // 
            this.btnProdajnaMesta.Location = new System.Drawing.Point(51, 213);
            this.btnProdajnaMesta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProdajnaMesta.Name = "btnProdajnaMesta";
            this.btnProdajnaMesta.Size = new System.Drawing.Size(135, 25);
            this.btnProdajnaMesta.TabIndex = 0;
            this.btnProdajnaMesta.Text = "Prodajna mesta";
            this.btnProdajnaMesta.UseVisualStyleBackColor = true;
            this.btnProdajnaMesta.Click += new System.EventHandler(this.btnProdajnaMesta_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(51, 293);
            this.btnZaposleni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(135, 25);
            this.btnZaposleni.TabIndex = 1;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // btnLekovi
            // 
            this.btnLekovi.Location = new System.Drawing.Point(51, 252);
            this.btnLekovi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLekovi.Name = "btnLekovi";
            this.btnLekovi.Size = new System.Drawing.Size(135, 25);
            this.btnLekovi.TabIndex = 2;
            this.btnLekovi.Text = "Lekovi";
            this.btnLekovi.UseVisualStyleBackColor = true;
            this.btnLekovi.Click += new System.EventHandler(this.btnLekovi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apoteka.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLekovi);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnProdajnaMesta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PocetnaStranica";
            this.Text = "PocetnaStranica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdajnaMesta;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Button btnLekovi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}