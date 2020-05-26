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
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvnaamtext
            // 
            this.lblvnaamtext.AutoSize = true;
            this.lblvnaamtext.Location = new System.Drawing.Point(12, 9);
            this.lblvnaamtext.Name = "lblvnaamtext";
            this.lblvnaamtext.Size = new System.Drawing.Size(58, 13);
            this.lblvnaamtext.TabIndex = 0;
            this.lblvnaamtext.Text = "Voornaam:";
            // 
            // lblvnaam
            // 
            this.lblvnaam.AutoSize = true;
            this.lblvnaam.Location = new System.Drawing.Point(110, 7);
            this.lblvnaam.Name = "lblvnaam";
            this.lblvnaam.Size = new System.Drawing.Size(24, 13);
            this.lblvnaam.TabIndex = 1;
            this.lblvnaam.Text = "test";
            this.lblvnaam.Click += new System.EventHandler(this.lblvnaam_Click);
            // 
            // lblanaam
            // 
            this.lblanaam.AutoSize = true;
            this.lblanaam.Location = new System.Drawing.Point(110, 34);
            this.lblanaam.Name = "lblanaam";
            this.lblanaam.Size = new System.Drawing.Size(24, 13);
            this.lblanaam.TabIndex = 3;
            this.lblanaam.Text = "test";
            this.lblanaam.Click += new System.EventHandler(this.lblanaam_Click);
            // 
            // lblanaamtext
            // 
            this.lblanaamtext.AutoSize = true;
            this.lblanaamtext.Location = new System.Drawing.Point(12, 34);
            this.lblanaamtext.Name = "lblanaamtext";
            this.lblanaamtext.Size = new System.Drawing.Size(67, 13);
            this.lblanaamtext.TabIndex = 2;
            this.lblanaamtext.Text = "Achternaam:";
            // 
            // lblgnaam
            // 
            this.lblgnaam.AutoSize = true;
            this.lblgnaam.Location = new System.Drawing.Point(110, 58);
            this.lblgnaam.Name = "lblgnaam";
            this.lblgnaam.Size = new System.Drawing.Size(24, 13);
            this.lblgnaam.TabIndex = 5;
            this.lblgnaam.Text = "test";
            this.lblgnaam.Click += new System.EventHandler(this.lblgnaam_Click);
            // 
            // lblgebruikersnaamtext
            // 
            this.lblgebruikersnaamtext.AutoSize = true;
            this.lblgebruikersnaamtext.Location = new System.Drawing.Point(12, 58);
            this.lblgebruikersnaamtext.Name = "lblgebruikersnaamtext";
            this.lblgebruikersnaamtext.Size = new System.Drawing.Size(85, 13);
            this.lblgebruikersnaamtext.TabIndex = 4;
            this.lblgebruikersnaamtext.Text = "gebruikersnaam:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(110, 88);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(24, 13);
            this.lblemail.TabIndex = 7;
            this.lblemail.Text = "test";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // lblemailtext
            // 
            this.lblemailtext.AutoSize = true;
            this.lblemailtext.Location = new System.Drawing.Point(12, 88);
            this.lblemailtext.Name = "lblemailtext";
            this.lblemailtext.Size = new System.Drawing.Size(35, 13);
            this.lblemailtext.TabIndex = 6;
            this.lblemailtext.Text = "Email:";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(15, 184);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(126, 41);
            this.btnTerug.TabIndex = 8;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // frmwijzigaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 237);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblemailtext);
            this.Controls.Add(this.lblgnaam);
            this.Controls.Add(this.lblgebruikersnaamtext);
            this.Controls.Add(this.lblanaam);
            this.Controls.Add(this.lblanaamtext);
            this.Controls.Add(this.lblvnaam);
            this.Controls.Add(this.lblvnaamtext);
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
        private System.Windows.Forms.Button btnTerug;
    }
}