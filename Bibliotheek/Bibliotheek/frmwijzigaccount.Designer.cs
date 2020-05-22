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
            this.lblanaam = new System.Windows.Forms.Label();
            this.lblanaamtext = new System.Windows.Forms.Label();
            this.lblgnaam = new System.Windows.Forms.Label();
            this.lblgebruikersnaamtext = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblemailtext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblvnaamtext
            // 
            this.lblvnaamtext.AutoSize = true;
            this.lblvnaamtext.Location = new System.Drawing.Point(16, 11);
            this.lblvnaamtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvnaamtext.Name = "lblvnaamtext";
            this.lblvnaamtext.Size = new System.Drawing.Size(77, 17);
            this.lblvnaamtext.TabIndex = 0;
            this.lblvnaamtext.Text = "Voornaam:";
            // 
            // lblvnaam
            // 
            this.lblvnaam.AutoSize = true;
            this.lblvnaam.Location = new System.Drawing.Point(146, 9);
            this.lblvnaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvnaam.Name = "lblvnaam";
            this.lblvnaam.Size = new System.Drawing.Size(31, 17);
            this.lblvnaam.TabIndex = 1;
            this.lblvnaam.Text = "test";
            this.lblvnaam.Click += new System.EventHandler(this.lblvnaam_Click);
            // 
            // lblanaam
            // 
            this.lblanaam.AutoSize = true;
            this.lblanaam.Location = new System.Drawing.Point(146, 42);
            this.lblanaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblanaam.Name = "lblanaam";
            this.lblanaam.Size = new System.Drawing.Size(31, 17);
            this.lblanaam.TabIndex = 3;
            this.lblanaam.Text = "test";
            this.lblanaam.Click += new System.EventHandler(this.lblanaam_Click);
            // 
            // lblanaamtext
            // 
            this.lblanaamtext.AutoSize = true;
            this.lblanaamtext.Location = new System.Drawing.Point(16, 42);
            this.lblanaamtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblanaamtext.Name = "lblanaamtext";
            this.lblanaamtext.Size = new System.Drawing.Size(88, 17);
            this.lblanaamtext.TabIndex = 2;
            this.lblanaamtext.Text = "Achternaam:";
            // 
            // lblgnaam
            // 
            this.lblgnaam.AutoSize = true;
            this.lblgnaam.Location = new System.Drawing.Point(146, 72);
            this.lblgnaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgnaam.Name = "lblgnaam";
            this.lblgnaam.Size = new System.Drawing.Size(31, 17);
            this.lblgnaam.TabIndex = 5;
            this.lblgnaam.Text = "test";
            this.lblgnaam.Click += new System.EventHandler(this.lblgnaam_Click);
            // 
            // lblgebruikersnaamtext
            // 
            this.lblgebruikersnaamtext.AutoSize = true;
            this.lblgebruikersnaamtext.Location = new System.Drawing.Point(16, 72);
            this.lblgebruikersnaamtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgebruikersnaamtext.Name = "lblgebruikersnaamtext";
            this.lblgebruikersnaamtext.Size = new System.Drawing.Size(114, 17);
            this.lblgebruikersnaamtext.TabIndex = 4;
            this.lblgebruikersnaamtext.Text = "gebruikersnaam:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(146, 108);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 17);
            this.lblemail.TabIndex = 7;
            this.lblemail.Text = "test";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // lblemailtext
            // 
            this.lblemailtext.AutoSize = true;
            this.lblemailtext.Location = new System.Drawing.Point(16, 108);
            this.lblemailtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemailtext.Name = "lblemailtext";
            this.lblemailtext.Size = new System.Drawing.Size(46, 17);
            this.lblemailtext.TabIndex = 6;
            this.lblemailtext.Text = "Email:";
            // 
            // frmwijzigaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 292);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblemailtext);
            this.Controls.Add(this.lblgnaam);
            this.Controls.Add(this.lblgebruikersnaamtext);
            this.Controls.Add(this.lblanaam);
            this.Controls.Add(this.lblanaamtext);
            this.Controls.Add(this.lblvnaam);
            this.Controls.Add(this.lblvnaamtext);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmwijzigaccount";
            this.Text = "frmwijzigaccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmwijzigaccount_FormClosed);
            this.Load += new System.EventHandler(this.frmwijzigaccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvnaamtext;
        private System.Windows.Forms.Label lblvnaam;
        private System.Windows.Forms.Label lblanaam;
        private System.Windows.Forms.Label lblanaamtext;
        private System.Windows.Forms.Label lblgnaam;
        private System.Windows.Forms.Label lblgebruikersnaamtext;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblemailtext;
    }
}