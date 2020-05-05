namespace Bibliotheek
{
    partial class frminloggen
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
            this.lblgebruikersnaam = new System.Windows.Forms.Label();
            this.txtgebruikersnaam = new System.Windows.Forms.TextBox();
            this.lblpaswoord = new System.Windows.Forms.Label();
            this.txtpaswoord = new System.Windows.Forms.TextBox();
            this.btninloggen = new System.Windows.Forms.Button();
            this.btnregistreren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgebruikersnaam
            // 
            this.lblgebruikersnaam.AutoSize = true;
            this.lblgebruikersnaam.Location = new System.Drawing.Point(26, 15);
            this.lblgebruikersnaam.Name = "lblgebruikersnaam";
            this.lblgebruikersnaam.Size = new System.Drawing.Size(84, 13);
            this.lblgebruikersnaam.TabIndex = 0;
            this.lblgebruikersnaam.Text = "Gebruikersnaam";
            // 
            // txtgebruikersnaam
            // 
            this.txtgebruikersnaam.Location = new System.Drawing.Point(116, 12);
            this.txtgebruikersnaam.Name = "txtgebruikersnaam";
            this.txtgebruikersnaam.Size = new System.Drawing.Size(100, 20);
            this.txtgebruikersnaam.TabIndex = 1;
            // 
            // lblpaswoord
            // 
            this.lblpaswoord.AutoSize = true;
            this.lblpaswoord.Location = new System.Drawing.Point(26, 57);
            this.lblpaswoord.Name = "lblpaswoord";
            this.lblpaswoord.Size = new System.Drawing.Size(71, 13);
            this.lblpaswoord.TabIndex = 2;
            this.lblpaswoord.Text = "Wachtwoord:";
            // 
            // txtpaswoord
            // 
            this.txtpaswoord.Location = new System.Drawing.Point(116, 54);
            this.txtpaswoord.Name = "txtpaswoord";
            this.txtpaswoord.Size = new System.Drawing.Size(100, 20);
            this.txtpaswoord.TabIndex = 3;
            // 
            // btninloggen
            // 
            this.btninloggen.Location = new System.Drawing.Point(29, 116);
            this.btninloggen.Name = "btninloggen";
            this.btninloggen.Size = new System.Drawing.Size(91, 38);
            this.btninloggen.TabIndex = 4;
            this.btninloggen.Text = "Inloggen";
            this.btninloggen.UseVisualStyleBackColor = true;
            this.btninloggen.Click += new System.EventHandler(this.btninloggen_Click);
            // 
            // btnregistreren
            // 
            this.btnregistreren.Location = new System.Drawing.Point(126, 116);
            this.btnregistreren.Name = "btnregistreren";
            this.btnregistreren.Size = new System.Drawing.Size(91, 38);
            this.btnregistreren.TabIndex = 5;
            this.btnregistreren.Text = "Registreren";
            this.btnregistreren.UseVisualStyleBackColor = true;
            this.btnregistreren.Click += new System.EventHandler(this.btnregistreren_Click);
            // 
            // frminloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 189);
            this.Controls.Add(this.btnregistreren);
            this.Controls.Add(this.btninloggen);
            this.Controls.Add(this.txtpaswoord);
            this.Controls.Add(this.lblpaswoord);
            this.Controls.Add(this.txtgebruikersnaam);
            this.Controls.Add(this.lblgebruikersnaam);
            this.Name = "frminloggen";
            this.Text = "Inloggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgebruikersnaam;
        private System.Windows.Forms.TextBox txtgebruikersnaam;
        private System.Windows.Forms.Label lblpaswoord;
        private System.Windows.Forms.TextBox txtpaswoord;
        private System.Windows.Forms.Button btninloggen;
        private System.Windows.Forms.Button btnregistreren;
    }
}

