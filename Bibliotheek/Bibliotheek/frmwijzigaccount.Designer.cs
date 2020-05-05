namespace Bibliotheek
{
    partial class frmwijzigaccount
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
            this.lblvnaamtext = new System.Windows.Forms.Label();
            this.lblvnaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblvnaamtext
            // 
            this.lblvnaamtext.AutoSize = true;
            this.lblvnaamtext.Location = new System.Drawing.Point(12, 9);
            this.lblvnaamtext.Name = "lblvnaamtext";
            this.lblvnaamtext.Size = new System.Drawing.Size(38, 13);
            this.lblvnaamtext.TabIndex = 0;
            this.lblvnaamtext.Text = "Naam:";
            // 
            // lblvnaam
            // 
            this.lblvnaam.AutoSize = true;
            this.lblvnaam.Location = new System.Drawing.Point(53, 9);
            this.lblvnaam.Name = "lblvnaam";
            this.lblvnaam.Size = new System.Drawing.Size(24, 13);
            this.lblvnaam.TabIndex = 1;
            this.lblvnaam.Text = "test";
            this.lblvnaam.Click += new System.EventHandler(this.lblvnaam_Click);
            // 
            // frmwijzigaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 64);
            this.Controls.Add(this.lblvnaam);
            this.Controls.Add(this.lblvnaamtext);
            this.Name = "frmwijzigaccount";
            this.Text = "frmwijzigaccount";
            this.Load += new System.EventHandler(this.frmwijzigaccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvnaamtext;
        private System.Windows.Forms.Label lblvnaam;
    }
}