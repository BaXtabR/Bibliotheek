namespace Bibliotheek
{
    partial class frmregistreren
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
            this.lblvnaam = new System.Windows.Forms.Label();
            this.txtvnaam = new System.Windows.Forms.TextBox();
            this.txtachternaam = new System.Windows.Forms.TextBox();
            this.lblachternaam = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtgebruikersnaam = new System.Windows.Forms.TextBox();
            this.lblgebruikersnaam = new System.Windows.Forms.Label();
            this.txtpaswoord = new System.Windows.Forms.TextBox();
            this.lblpaswoord = new System.Windows.Forms.Label();
            this.txtbevestigpaswoord = new System.Windows.Forms.TextBox();
            this.lblbevestigpaswoord = new System.Windows.Forms.Label();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvnaam
            // 
            this.lblvnaam.AutoSize = true;
            this.lblvnaam.Location = new System.Drawing.Point(31, 29);
            this.lblvnaam.Name = "lblvnaam";
            this.lblvnaam.Size = new System.Drawing.Size(58, 13);
            this.lblvnaam.TabIndex = 0;
            this.lblvnaam.Text = "Voornaam:";
            // 
            // txtvnaam
            // 
            this.txtvnaam.Location = new System.Drawing.Point(151, 26);
            this.txtvnaam.Name = "txtvnaam";
            this.txtvnaam.Size = new System.Drawing.Size(100, 20);
            this.txtvnaam.TabIndex = 1;
            // 
            // txtachternaam
            // 
            this.txtachternaam.Location = new System.Drawing.Point(151, 52);
            this.txtachternaam.Name = "txtachternaam";
            this.txtachternaam.Size = new System.Drawing.Size(100, 20);
            this.txtachternaam.TabIndex = 3;
            // 
            // lblachternaam
            // 
            this.lblachternaam.AutoSize = true;
            this.lblachternaam.Location = new System.Drawing.Point(31, 55);
            this.lblachternaam.Name = "lblachternaam";
            this.lblachternaam.Size = new System.Drawing.Size(64, 13);
            this.lblachternaam.TabIndex = 2;
            this.lblachternaam.Text = "Achternaam";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(151, 78);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(31, 81);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email:";
            // 
            // txtgebruikersnaam
            // 
            this.txtgebruikersnaam.Location = new System.Drawing.Point(151, 104);
            this.txtgebruikersnaam.Name = "txtgebruikersnaam";
            this.txtgebruikersnaam.Size = new System.Drawing.Size(100, 20);
            this.txtgebruikersnaam.TabIndex = 7;
            // 
            // lblgebruikersnaam
            // 
            this.lblgebruikersnaam.AutoSize = true;
            this.lblgebruikersnaam.Location = new System.Drawing.Point(31, 107);
            this.lblgebruikersnaam.Name = "lblgebruikersnaam";
            this.lblgebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lblgebruikersnaam.TabIndex = 6;
            this.lblgebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // txtpaswoord
            // 
            this.txtpaswoord.Location = new System.Drawing.Point(151, 130);
            this.txtpaswoord.Name = "txtpaswoord";
            this.txtpaswoord.Size = new System.Drawing.Size(100, 20);
            this.txtpaswoord.TabIndex = 9;
            // 
            // lblpaswoord
            // 
            this.lblpaswoord.AutoSize = true;
            this.lblpaswoord.Location = new System.Drawing.Point(31, 133);
            this.lblpaswoord.Name = "lblpaswoord";
            this.lblpaswoord.Size = new System.Drawing.Size(71, 13);
            this.lblpaswoord.TabIndex = 8;
            this.lblpaswoord.Text = "Wachtwoord:";
            // 
            // txtbevestigpaswoord
            // 
            this.txtbevestigpaswoord.Location = new System.Drawing.Point(151, 156);
            this.txtbevestigpaswoord.Name = "txtbevestigpaswoord";
            this.txtbevestigpaswoord.Size = new System.Drawing.Size(100, 20);
            this.txtbevestigpaswoord.TabIndex = 11;
            // 
            // lblbevestigpaswoord
            // 
            this.lblbevestigpaswoord.AutoSize = true;
            this.lblbevestigpaswoord.Location = new System.Drawing.Point(31, 159);
            this.lblbevestigpaswoord.Name = "lblbevestigpaswoord";
            this.lblbevestigpaswoord.Size = new System.Drawing.Size(115, 13);
            this.lblbevestigpaswoord.TabIndex = 10;
            this.lblbevestigpaswoord.Text = "Bevestig Wachtwoord:";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(151, 201);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(100, 42);
            this.btnBevestig.TabIndex = 12;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // frmregistreren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 255);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.txtbevestigpaswoord);
            this.Controls.Add(this.lblbevestigpaswoord);
            this.Controls.Add(this.txtpaswoord);
            this.Controls.Add(this.lblpaswoord);
            this.Controls.Add(this.txtgebruikersnaam);
            this.Controls.Add(this.lblgebruikersnaam);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtachternaam);
            this.Controls.Add(this.lblachternaam);
            this.Controls.Add(this.txtvnaam);
            this.Controls.Add(this.lblvnaam);
            this.Name = "frmregistreren";
            this.Text = "frmregistreren";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmregistreren_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvnaam;
        private System.Windows.Forms.TextBox txtvnaam;
        private System.Windows.Forms.TextBox txtachternaam;
        private System.Windows.Forms.Label lblachternaam;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtgebruikersnaam;
        private System.Windows.Forms.Label lblgebruikersnaam;
        private System.Windows.Forms.TextBox txtpaswoord;
        private System.Windows.Forms.Label lblpaswoord;
        private System.Windows.Forms.TextBox txtbevestigpaswoord;
        private System.Windows.Forms.Label lblbevestigpaswoord;
        private System.Windows.Forms.Button btnBevestig;
    }
}