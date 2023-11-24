namespace Apoteka.Forme
{
    partial class LekUpakujForm
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
            this.lblTipPakovanja = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblSastav = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnUpakuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipPakovanja
            // 
            this.lblTipPakovanja.AutoSize = true;
            this.lblTipPakovanja.Location = new System.Drawing.Point(16, 84);
            this.lblTipPakovanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipPakovanja.Name = "lblTipPakovanja";
            this.lblTipPakovanja.Size = new System.Drawing.Size(55, 17);
            this.lblTipPakovanja.TabIndex = 0;
            this.lblTipPakovanja.Text = "Sastav:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(16, 52);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(61, 17);
            this.lblKolicina.TabIndex = 1;
            this.lblKolicina.Text = "Kolicina:";
            // 
            // lblSastav
            // 
            this.lblSastav.AutoSize = true;
            this.lblSastav.Location = new System.Drawing.Point(16, 18);
            this.lblSastav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSastav.Name = "lblSastav";
            this.lblSastav.Size = new System.Drawing.Size(101, 17);
            this.lblSastav.TabIndex = 2;
            this.lblSastav.Text = "Tip pakovanja:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(20, 148);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 28);
            this.btnOtkazi.TabIndex = 6;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnUpakuj
            // 
            this.btnUpakuj.Location = new System.Drawing.Point(228, 148);
            this.btnUpakuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpakuj.Name = "btnUpakuj";
            this.btnUpakuj.Size = new System.Drawing.Size(100, 28);
            this.btnUpakuj.TabIndex = 7;
            this.btnUpakuj.Text = "Upakuj";
            this.btnUpakuj.UseVisualStyleBackColor = true;
            this.btnUpakuj.Click += new System.EventHandler(this.btnUpakuj_Click);
            // 
            // LekUpakujForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 193);
            this.Controls.Add(this.btnUpakuj);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSastav);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblTipPakovanja);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LekUpakujForm";
            this.Text = "LekUpakujForm";
            this.Load += new System.EventHandler(this.LekUpakujForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipPakovanja;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblSastav;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnUpakuj;
    }
}