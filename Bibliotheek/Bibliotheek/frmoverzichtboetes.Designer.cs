namespace Bibliotheek
{
    partial class frmoverzichtboetes
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
            this.dgvOverzichtBoetes = new System.Windows.Forms.DataGridView();
            this.btnTerug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverzichtBoetes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOverzichtBoetes
            // 
            this.dgvOverzichtBoetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverzichtBoetes.Location = new System.Drawing.Point(0, 0);
            this.dgvOverzichtBoetes.Name = "dgvOverzichtBoetes";
            this.dgvOverzichtBoetes.RowTemplate.Height = 24;
            this.dgvOverzichtBoetes.Size = new System.Drawing.Size(802, 424);
            this.dgvOverzichtBoetes.TabIndex = 0;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(323, 430);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(137, 63);
            this.btnTerug.TabIndex = 1;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // frmoverzichtboetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.dgvOverzichtBoetes);
            this.Name = "frmoverzichtboetes";
            this.Text = "frmoverzichtboetes";
            this.Load += new System.EventHandler(this.frmoverzichtboetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverzichtBoetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOverzichtBoetes;
        private System.Windows.Forms.Button btnTerug;
    }
}