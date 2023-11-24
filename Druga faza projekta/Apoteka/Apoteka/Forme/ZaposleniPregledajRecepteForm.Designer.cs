namespace Apoteka.Forme
{
    partial class ZaposleniPregledajRecepteForm
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
            this.gboxRecepti = new System.Windows.Forms.GroupBox();
            this.lvReceptiZaposlenog = new System.Windows.Forms.ListView();
            this.SBR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lekar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Izdat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Realizovan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboxRecepti.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxRecepti
            // 
            this.gboxRecepti.Controls.Add(this.lvReceptiZaposlenog);
            this.gboxRecepti.Location = new System.Drawing.Point(12, 12);
            this.gboxRecepti.Name = "gboxRecepti";
            this.gboxRecepti.Size = new System.Drawing.Size(451, 327);
            this.gboxRecepti.TabIndex = 0;
            this.gboxRecepti.TabStop = false;
            this.gboxRecepti.Text = "Recepti:";
            // 
            // lvReceptiZaposlenog
            // 
            this.lvReceptiZaposlenog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SBR,
            this.Lekar,
            this.Izdat,
            this.Realizovan});
            this.lvReceptiZaposlenog.FullRowSelect = true;
            this.lvReceptiZaposlenog.GridLines = true;
            this.lvReceptiZaposlenog.HideSelection = false;
            this.lvReceptiZaposlenog.Location = new System.Drawing.Point(6, 19);
            this.lvReceptiZaposlenog.Name = "lvReceptiZaposlenog";
            this.lvReceptiZaposlenog.Size = new System.Drawing.Size(439, 302);
            this.lvReceptiZaposlenog.TabIndex = 0;
            this.lvReceptiZaposlenog.UseCompatibleStateImageBehavior = false;
            this.lvReceptiZaposlenog.View = System.Windows.Forms.View.Details;
            // 
            // SBR
            // 
            this.SBR.Text = "SBR";
            // 
            // Lekar
            // 
            this.Lekar.Text = "Lekar";
            // 
            // Izdat
            // 
            this.Izdat.Text = "Izdat";
            // 
            // Realizovan
            // 
            this.Realizovan.Text = "Realizovan";
            // 
            // ZaposleniPregledajRecepteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 349);
            this.Controls.Add(this.gboxRecepti);
            this.Name = "ZaposleniPregledajRecepteForm";
            this.Text = "ZaposleniPregledajRecepteForm";
            this.Load += new System.EventHandler(this.ZaposleniPregledajRecepteForm_Load);
            this.gboxRecepti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxRecepti;
        private System.Windows.Forms.ListView lvReceptiZaposlenog;
        private System.Windows.Forms.ColumnHeader SBR;
        private System.Windows.Forms.ColumnHeader Lekar;
        private System.Windows.Forms.ColumnHeader Izdat;
        private System.Windows.Forms.ColumnHeader Realizovan;
    }
}