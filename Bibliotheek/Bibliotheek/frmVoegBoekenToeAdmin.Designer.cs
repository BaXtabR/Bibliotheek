namespace Bibliotheek
{
    partial class frmVoegBoekenToeAdmin
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
            this.lbltitel = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttitel = new System.Windows.Forms.TextBox();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.txtauteur = new System.Windows.Forms.TextBox();
            this.txtafbeelding = new System.Windows.Forms.TextBox();
            this.txtomschrijving = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnVerzenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Location = new System.Drawing.Point(12, 39);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(27, 13);
            this.lbltitel.TabIndex = 0;
            this.lbltitel.Text = "Titel";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(12, 74);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(72, 13);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN-nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Auteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Afbeelding";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Omschrijving";
            // 
            // txttitel
            // 
            this.txttitel.Location = new System.Drawing.Point(105, 36);
            this.txttitel.Name = "txttitel";
            this.txttitel.Size = new System.Drawing.Size(100, 20);
            this.txttitel.TabIndex = 5;
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(105, 74);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(100, 20);
            this.txtisbn.TabIndex = 6;
            // 
            // txtauteur
            // 
            this.txtauteur.Location = new System.Drawing.Point(105, 110);
            this.txtauteur.Name = "txtauteur";
            this.txtauteur.Size = new System.Drawing.Size(100, 20);
            this.txtauteur.TabIndex = 7;
            // 
            // txtafbeelding
            // 
            this.txtafbeelding.Location = new System.Drawing.Point(105, 145);
            this.txtafbeelding.Name = "txtafbeelding";
            this.txtafbeelding.Size = new System.Drawing.Size(100, 20);
            this.txtafbeelding.TabIndex = 8;
            // 
            // txtomschrijving
            // 
            this.txtomschrijving.Location = new System.Drawing.Point(15, 208);
            this.txtomschrijving.Multiline = true;
            this.txtomschrijving.Name = "txtomschrijving";
            this.txtomschrijving.Size = new System.Drawing.Size(190, 291);
            this.txtomschrijving.TabIndex = 9;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(15, 555);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(190, 40);
            this.btnTerug.TabIndex = 10;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // btnVerzenden
            // 
            this.btnVerzenden.Location = new System.Drawing.Point(15, 505);
            this.btnVerzenden.Name = "btnVerzenden";
            this.btnVerzenden.Size = new System.Drawing.Size(190, 40);
            this.btnVerzenden.TabIndex = 11;
            this.btnVerzenden.Text = "Verzenden";
            this.btnVerzenden.UseVisualStyleBackColor = true;
            this.btnVerzenden.Click += new System.EventHandler(this.btnVerzenden_Click);
            // 
            // VoegBoekenToeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 607);
            this.Controls.Add(this.btnVerzenden);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.txtomschrijving);
            this.Controls.Add(this.txtafbeelding);
            this.Controls.Add(this.txtauteur);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.txttitel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lbltitel);
            this.Name = "VoegBoekenToeAdmin";
            this.Text = "VoegBoekenToeAdmin";
            this.Load += new System.EventHandler(this.VoegBoekenToeAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttitel;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.TextBox txtauteur;
        private System.Windows.Forms.TextBox txtafbeelding;
        private System.Windows.Forms.TextBox txtomschrijving;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnVerzenden;
    }
}