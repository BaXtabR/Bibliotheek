namespace Bibliotheek
{
    partial class frmmeer_info
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
            this.lblauteur = new System.Windows.Forms.Label();
            this.lblauteurtext = new System.Windows.Forms.Label();
            this.lblisbn = new System.Windows.Forms.Label();
            this.lblisbntext = new System.Windows.Forms.Label();
            this.lblomschrijving = new System.Windows.Forms.Label();
            this.btnterug = new System.Windows.Forms.Button();
            this.txtomschrijving = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblauteur
            // 
            this.lblauteur.AutoSize = true;
            this.lblauteur.Location = new System.Drawing.Point(12, 25);
            this.lblauteur.Name = "lblauteur";
            this.lblauteur.Size = new System.Drawing.Size(54, 17);
            this.lblauteur.TabIndex = 0;
            this.lblauteur.Text = "Auteur:";
            // 
            // lblauteurtext
            // 
            this.lblauteurtext.AutoSize = true;
            this.lblauteurtext.Location = new System.Drawing.Point(64, 25);
            this.lblauteurtext.Name = "lblauteurtext";
            this.lblauteurtext.Size = new System.Drawing.Size(35, 17);
            this.lblauteurtext.TabIndex = 1;
            this.lblauteurtext.Text = "XXX";
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Location = new System.Drawing.Point(12, 56);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(43, 17);
            this.lblisbn.TabIndex = 2;
            this.lblisbn.Text = "ISBN:";
            // 
            // lblisbntext
            // 
            this.lblisbntext.AutoSize = true;
            this.lblisbntext.Location = new System.Drawing.Point(64, 56);
            this.lblisbntext.Name = "lblisbntext";
            this.lblisbntext.Size = new System.Drawing.Size(35, 17);
            this.lblisbntext.TabIndex = 3;
            this.lblisbntext.Text = "XXX";
            // 
            // lblomschrijving
            // 
            this.lblomschrijving.AutoSize = true;
            this.lblomschrijving.Location = new System.Drawing.Point(12, 90);
            this.lblomschrijving.Name = "lblomschrijving";
            this.lblomschrijving.Size = new System.Drawing.Size(93, 17);
            this.lblomschrijving.TabIndex = 4;
            this.lblomschrijving.Text = "Omschrijving:";
            // 
            // btnterug
            // 
            this.btnterug.Location = new System.Drawing.Point(15, 312);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(234, 73);
            this.btnterug.TabIndex = 6;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // txtomschrijving
            // 
            this.txtomschrijving.Location = new System.Drawing.Point(12, 110);
            this.txtomschrijving.Multiline = true;
            this.txtomschrijving.Name = "txtomschrijving";
            this.txtomschrijving.Size = new System.Drawing.Size(237, 196);
            this.txtomschrijving.TabIndex = 7;
            // 
            // frmmeer_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 443);
            this.Controls.Add(this.txtomschrijving);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.lblomschrijving);
            this.Controls.Add(this.lblisbntext);
            this.Controls.Add(this.lblisbn);
            this.Controls.Add(this.lblauteurtext);
            this.Controls.Add(this.lblauteur);
            this.Name = "frmmeer_info";
            this.Text = "meer_info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmeer_info_FormClosed);
            this.Load += new System.EventHandler(this.frmmeer_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblauteur;
        private System.Windows.Forms.Label lblauteurtext;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.Label lblisbntext;
        private System.Windows.Forms.Label lblomschrijving;
        private System.Windows.Forms.Button btnterug;
        private System.Windows.Forms.TextBox txtomschrijving;
    }
}