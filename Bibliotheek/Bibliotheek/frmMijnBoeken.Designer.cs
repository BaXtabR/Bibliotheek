namespace Bibliotheek
{
    partial class frmMijnBoeken
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
            this.lsbboekbezit = new System.Windows.Forms.ListBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnTerugbrengen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbboekbezit
            // 
            this.lsbboekbezit.FormattingEnabled = true;
            this.lsbboekbezit.Location = new System.Drawing.Point(0, 0);
            this.lsbboekbezit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbboekbezit.Name = "lsbboekbezit";
            this.lsbboekbezit.Size = new System.Drawing.Size(240, 368);
            this.lsbboekbezit.TabIndex = 0;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(134, 400);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(91, 41);
            this.btnTerug.TabIndex = 1;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnTerugbrengen
            // 
            this.btnTerugbrengen.Location = new System.Drawing.Point(12, 400);
            this.btnTerugbrengen.Name = "btnTerugbrengen";
            this.btnTerugbrengen.Size = new System.Drawing.Size(91, 41);
            this.btnTerugbrengen.TabIndex = 2;
            this.btnTerugbrengen.Text = "Inleveren";
            this.btnTerugbrengen.UseVisualStyleBackColor = true;
            this.btnTerugbrengen.Click += new System.EventHandler(this.btnTerugbrengen_Click);
            // 
            // frmMijnBoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 453);
            this.Controls.Add(this.btnTerugbrengen);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lsbboekbezit);
            this.Name = "frmMijnBoeken";
            this.Text = "frmMijnBoeken";
            this.Load += new System.EventHandler(this.frmMijnBoeken_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbboekbezit;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnTerugbrengen;
    }
}