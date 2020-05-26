namespace Bibliotheek
{
    partial class frmboetes
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
            this.lsbboetes = new System.Windows.Forms.ListBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbboetes
            // 
            this.lsbboetes.FormattingEnabled = true;
            this.lsbboetes.Location = new System.Drawing.Point(12, 12);
            this.lsbboetes.Name = "lsbboetes";
            this.lsbboetes.Size = new System.Drawing.Size(682, 225);
            this.lsbboetes.TabIndex = 0;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 289);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(91, 41);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // frmboetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 342);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lsbboetes);
            this.Name = "frmboetes";
            this.Text = "frmboetes";
            this.Load += new System.EventHandler(this.frmboetes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbboetes;
        private System.Windows.Forms.Button btnTerug;
    }
}