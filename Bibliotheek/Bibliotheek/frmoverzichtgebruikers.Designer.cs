namespace Bibliotheek
{
    partial class frmoverzichtgebruikers
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
            this.dgvOverzichtGebruikers = new System.Windows.Forms.DataGridView();
            this.btnTerug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverzichtGebruikers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOverzichtGebruikers
            // 
            this.dgvOverzichtGebruikers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverzichtGebruikers.Location = new System.Drawing.Point(0, 0);
            this.dgvOverzichtGebruikers.Name = "dgvOverzichtGebruikers";
            this.dgvOverzichtGebruikers.RowTemplate.Height = 24;
            this.dgvOverzichtGebruikers.Size = new System.Drawing.Size(801, 452);
            this.dgvOverzichtGebruikers.TabIndex = 0;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(339, 458);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(137, 63);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // frmoverzichtgebruikers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.dgvOverzichtGebruikers);
            this.Name = "frmoverzichtgebruikers";
            this.Text = "frmoverzichtgebruikers";
            this.Load += new System.EventHandler(this.frmoverzichtgebruikers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverzichtGebruikers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOverzichtGebruikers;
        private System.Windows.Forms.Button btnTerug;
    }
}