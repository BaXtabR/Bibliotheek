namespace Bibliotheek
{
    partial class frmhome
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
            this.btnbib = new System.Windows.Forms.Button();
            this.btnMijnboeken = new System.Windows.Forms.Button();
            this.btnboetes = new System.Windows.Forms.Button();
            this.btnaccount = new System.Windows.Forms.Button();
            this.btnoverzichboetes = new System.Windows.Forms.Button();
            this.btnoverzichtaccounts = new System.Windows.Forms.Button();
            this.btnoverzichtboeken = new System.Windows.Forms.Button();
            this.lblgebebruiker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbib
            // 
            this.btnbib.Location = new System.Drawing.Point(40, 94);
            this.btnbib.Name = "btnbib";
            this.btnbib.Size = new System.Drawing.Size(129, 62);
            this.btnbib.TabIndex = 1;
            this.btnbib.Text = "Boeken";
            this.btnbib.UseVisualStyleBackColor = true;
            this.btnbib.Click += new System.EventHandler(this.btnbib_Click);
            // 
            // btnMijnboeken
            // 
            this.btnMijnboeken.Location = new System.Drawing.Point(40, 162);
            this.btnMijnboeken.Name = "btnMijnboeken";
            this.btnMijnboeken.Size = new System.Drawing.Size(129, 62);
            this.btnMijnboeken.TabIndex = 2;
            this.btnMijnboeken.Text = "Mijn Boeken";
            this.btnMijnboeken.UseVisualStyleBackColor = true;
            this.btnMijnboeken.Click += new System.EventHandler(this.btnMijnboeken_Click);
            // 
            // btnboetes
            // 
            this.btnboetes.Location = new System.Drawing.Point(40, 230);
            this.btnboetes.Name = "btnboetes";
            this.btnboetes.Size = new System.Drawing.Size(129, 62);
            this.btnboetes.TabIndex = 3;
            this.btnboetes.Text = "Boetes";
            this.btnboetes.UseVisualStyleBackColor = true;
            this.btnboetes.Click += new System.EventHandler(this.btnboetes_Click);
            // 
            // btnaccount
            // 
            this.btnaccount.Location = new System.Drawing.Point(643, 12);
            this.btnaccount.Name = "btnaccount";
            this.btnaccount.Size = new System.Drawing.Size(129, 62);
            this.btnaccount.TabIndex = 4;
            this.btnaccount.Text = "Mijn account";
            this.btnaccount.UseVisualStyleBackColor = true;
            this.btnaccount.Click += new System.EventHandler(this.btnaccount_Click);
            // 
            // btnoverzichboetes
            // 
            this.btnoverzichboetes.Location = new System.Drawing.Point(643, 239);
            this.btnoverzichboetes.Name = "btnoverzichboetes";
            this.btnoverzichboetes.Size = new System.Drawing.Size(129, 62);
            this.btnoverzichboetes.TabIndex = 8;
            this.btnoverzichboetes.Text = "Overzicht Boetes";
            this.btnoverzichboetes.UseVisualStyleBackColor = true;
            this.btnoverzichboetes.Click += new System.EventHandler(this.btnoverzichboetes_Click);
            // 
            // btnoverzichtaccounts
            // 
            this.btnoverzichtaccounts.Location = new System.Drawing.Point(643, 171);
            this.btnoverzichtaccounts.Name = "btnoverzichtaccounts";
            this.btnoverzichtaccounts.Size = new System.Drawing.Size(129, 62);
            this.btnoverzichtaccounts.TabIndex = 7;
            this.btnoverzichtaccounts.Text = "Overzicht Accounts";
            this.btnoverzichtaccounts.UseVisualStyleBackColor = true;
            this.btnoverzichtaccounts.Click += new System.EventHandler(this.btnoverzichtaccounts_Click);
            // 
            // btnoverzichtboeken
            // 
            this.btnoverzichtboeken.Location = new System.Drawing.Point(643, 103);
            this.btnoverzichtboeken.Name = "btnoverzichtboeken";
            this.btnoverzichtboeken.Size = new System.Drawing.Size(129, 62);
            this.btnoverzichtboeken.TabIndex = 6;
            this.btnoverzichtboeken.Text = "Overzicht Boeken";
            this.btnoverzichtboeken.UseVisualStyleBackColor = true;
            this.btnoverzichtboeken.Click += new System.EventHandler(this.btnoverzichtboeken_Click);
            // 
            // lblgebebruiker
            // 
            this.lblgebebruiker.AutoSize = true;
            this.lblgebebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgebebruiker.Location = new System.Drawing.Point(250, 37);
            this.lblgebebruiker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgebebruiker.Name = "lblgebebruiker";
            this.lblgebebruiker.Size = new System.Drawing.Size(66, 24);
            this.lblgebebruiker.TabIndex = 9;
            this.lblgebebruiker.Text = "label1";
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 428);
            this.Controls.Add(this.lblgebebruiker);
            this.Controls.Add(this.btnoverzichboetes);
            this.Controls.Add(this.btnoverzichtaccounts);
            this.Controls.Add(this.btnoverzichtboeken);
            this.Controls.Add(this.btnaccount);
            this.Controls.Add(this.btnboetes);
            this.Controls.Add(this.btnMijnboeken);
            this.Controls.Add(this.btnbib);
            this.Name = "frmhome";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmhome_FormClosed);
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbib;
        private System.Windows.Forms.Button btnMijnboeken;
        private System.Windows.Forms.Button btnboetes;
        private System.Windows.Forms.Button btnaccount;
        private System.Windows.Forms.Button btnoverzichboetes;
        private System.Windows.Forms.Button btnoverzichtaccounts;
        private System.Windows.Forms.Button btnoverzichtboeken;
        private System.Windows.Forms.Label lblgebebruiker;
    }
}