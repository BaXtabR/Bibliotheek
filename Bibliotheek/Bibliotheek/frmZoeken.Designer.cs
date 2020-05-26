namespace Bibliotheek
{
    partial class frmZoeken
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
            this.btnterug = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.txtZoekWaarde = new System.Windows.Forms.TextBox();
            this.gpbZoeken = new System.Windows.Forms.GroupBox();
            this.rdbTitel = new System.Windows.Forms.RadioButton();
            this.rdbgenre = new System.Windows.Forms.RadioButton();
            this.rdbISBN = new System.Windows.Forms.RadioButton();
            this.rdbAuteur = new System.Windows.Forms.RadioButton();
            this.rdbLeeg = new System.Windows.Forms.RadioButton();
            this.gpbZoeken.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnterug
            // 
            this.btnterug.Location = new System.Drawing.Point(12, 310);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(201, 52);
            this.btnterug.TabIndex = 7;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(12, 252);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(201, 52);
            this.btnZoeken.TabIndex = 6;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Visible = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // txtZoekWaarde
            // 
            this.txtZoekWaarde.Location = new System.Drawing.Point(11, 208);
            this.txtZoekWaarde.Name = "txtZoekWaarde";
            this.txtZoekWaarde.Size = new System.Drawing.Size(204, 22);
            this.txtZoekWaarde.TabIndex = 5;
            this.txtZoekWaarde.Visible = false;
            // 
            // gpbZoeken
            // 
            this.gpbZoeken.Controls.Add(this.rdbTitel);
            this.gpbZoeken.Controls.Add(this.rdbgenre);
            this.gpbZoeken.Controls.Add(this.rdbISBN);
            this.gpbZoeken.Controls.Add(this.rdbAuteur);
            this.gpbZoeken.Controls.Add(this.rdbLeeg);
            this.gpbZoeken.Location = new System.Drawing.Point(12, 12);
            this.gpbZoeken.Name = "gpbZoeken";
            this.gpbZoeken.Size = new System.Drawing.Size(202, 174);
            this.gpbZoeken.TabIndex = 4;
            this.gpbZoeken.TabStop = false;
            this.gpbZoeken.Text = "Zoeken Op";
            // 
            // rdbTitel
            // 
            this.rdbTitel.AutoSize = true;
            this.rdbTitel.Location = new System.Drawing.Point(6, 52);
            this.rdbTitel.Name = "rdbTitel";
            this.rdbTitel.Size = new System.Drawing.Size(56, 21);
            this.rdbTitel.TabIndex = 4;
            this.rdbTitel.TabStop = true;
            this.rdbTitel.Text = "Titel";
            this.rdbTitel.UseVisualStyleBackColor = true;
            this.rdbTitel.CheckedChanged += new System.EventHandler(this.rdbTitel_CheckedChanged);
            // 
            // rdbgenre
            // 
            this.rdbgenre.AutoSize = true;
            this.rdbgenre.Location = new System.Drawing.Point(6, 131);
            this.rdbgenre.Name = "rdbgenre";
            this.rdbgenre.Size = new System.Drawing.Size(69, 21);
            this.rdbgenre.TabIndex = 3;
            this.rdbgenre.TabStop = true;
            this.rdbgenre.Text = "Genre";
            this.rdbgenre.UseVisualStyleBackColor = true;
            this.rdbgenre.CheckedChanged += new System.EventHandler(this.rdbgenre_CheckedChanged);
            // 
            // rdbISBN
            // 
            this.rdbISBN.AutoSize = true;
            this.rdbISBN.Location = new System.Drawing.Point(6, 104);
            this.rdbISBN.Name = "rdbISBN";
            this.rdbISBN.Size = new System.Drawing.Size(60, 21);
            this.rdbISBN.TabIndex = 2;
            this.rdbISBN.TabStop = true;
            this.rdbISBN.Text = "ISBN";
            this.rdbISBN.UseVisualStyleBackColor = true;
            this.rdbISBN.CheckedChanged += new System.EventHandler(this.rdbISBN_CheckedChanged);
            // 
            // rdbAuteur
            // 
            this.rdbAuteur.AutoSize = true;
            this.rdbAuteur.Location = new System.Drawing.Point(6, 77);
            this.rdbAuteur.Name = "rdbAuteur";
            this.rdbAuteur.Size = new System.Drawing.Size(71, 21);
            this.rdbAuteur.TabIndex = 1;
            this.rdbAuteur.TabStop = true;
            this.rdbAuteur.Text = "Auteur";
            this.rdbAuteur.UseVisualStyleBackColor = true;
            this.rdbAuteur.CheckedChanged += new System.EventHandler(this.rdbAuteur_CheckedChanged);
            // 
            // rdbLeeg
            // 
            this.rdbLeeg.AutoSize = true;
            this.rdbLeeg.Location = new System.Drawing.Point(6, 25);
            this.rdbLeeg.Name = "rdbLeeg";
            this.rdbLeeg.Size = new System.Drawing.Size(17, 16);
            this.rdbLeeg.TabIndex = 0;
            this.rdbLeeg.TabStop = true;
            this.rdbLeeg.UseVisualStyleBackColor = true;
            this.rdbLeeg.CheckedChanged += new System.EventHandler(this.rdbLeeg_CheckedChanged);
            // 
            // frmZoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 436);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.txtZoekWaarde);
            this.Controls.Add(this.gpbZoeken);
            this.Name = "frmZoeken";
            this.Text = "frmZoeken";
            this.gpbZoeken.ResumeLayout(false);
            this.gpbZoeken.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnterug;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox txtZoekWaarde;
        private System.Windows.Forms.GroupBox gpbZoeken;
        private System.Windows.Forms.RadioButton rdbTitel;
        private System.Windows.Forms.RadioButton rdbgenre;
        private System.Windows.Forms.RadioButton rdbISBN;
        private System.Windows.Forms.RadioButton rdbAuteur;
        private System.Windows.Forms.RadioButton rdbLeeg;
    }
}