namespace Bibliotheek
{
    partial class frmcommentaar
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
            this.txtcommentaar1 = new System.Windows.Forms.TextBox();
            this.lblcommentaar = new System.Windows.Forms.Label();
            this.txtcommentaar2 = new System.Windows.Forms.TextBox();
            this.txtcommentaar3 = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lblgebruikercom1 = new System.Windows.Forms.Label();
            this.lblgebruikercom2 = new System.Windows.Forms.Label();
            this.lblgebruikercom3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnterug = new System.Windows.Forms.Button();
            this.pcbLike1 = new System.Windows.Forms.PictureBox();
            this.pcbLike2 = new System.Windows.Forms.PictureBox();
            this.pcbLike3 = new System.Windows.Forms.PictureBox();
            this.lblLeeg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLike1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLike2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLike3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcommentaar1
            // 
            this.txtcommentaar1.Location = new System.Drawing.Point(15, 119);
            this.txtcommentaar1.Multiline = true;
            this.txtcommentaar1.Name = "txtcommentaar1";
            this.txtcommentaar1.Size = new System.Drawing.Size(283, 192);
            this.txtcommentaar1.TabIndex = 0;
            // 
            // lblcommentaar
            // 
            this.lblcommentaar.AutoSize = true;
            this.lblcommentaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblcommentaar.Location = new System.Drawing.Point(341, 9);
            this.lblcommentaar.Name = "lblcommentaar";
            this.lblcommentaar.Size = new System.Drawing.Size(60, 26);
            this.lblcommentaar.TabIndex = 1;
            this.lblcommentaar.Text = "XXX";
            // 
            // txtcommentaar2
            // 
            this.txtcommentaar2.Location = new System.Drawing.Point(304, 119);
            this.txtcommentaar2.Multiline = true;
            this.txtcommentaar2.Name = "txtcommentaar2";
            this.txtcommentaar2.Size = new System.Drawing.Size(283, 192);
            this.txtcommentaar2.TabIndex = 2;
            // 
            // txtcommentaar3
            // 
            this.txtcommentaar3.Location = new System.Drawing.Point(593, 119);
            this.txtcommentaar3.Multiline = true;
            this.txtcommentaar3.Name = "txtcommentaar3";
            this.txtcommentaar3.Size = new System.Drawing.Size(283, 192);
            this.txtcommentaar3.TabIndex = 3;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnback.Location = new System.Drawing.Point(12, 372);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(110, 98);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "<==";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnnext.Location = new System.Drawing.Point(766, 372);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(110, 98);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = "==>";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lblgebruikercom1
            // 
            this.lblgebruikercom1.AutoSize = true;
            this.lblgebruikercom1.Location = new System.Drawing.Point(12, 103);
            this.lblgebruikercom1.Name = "lblgebruikercom1";
            this.lblgebruikercom1.Size = new System.Drawing.Size(28, 13);
            this.lblgebruikercom1.TabIndex = 6;
            this.lblgebruikercom1.Text = "XXX";
            // 
            // lblgebruikercom2
            // 
            this.lblgebruikercom2.AutoSize = true;
            this.lblgebruikercom2.Location = new System.Drawing.Point(301, 103);
            this.lblgebruikercom2.Name = "lblgebruikercom2";
            this.lblgebruikercom2.Size = new System.Drawing.Size(28, 13);
            this.lblgebruikercom2.TabIndex = 7;
            this.lblgebruikercom2.Text = "XXX";
            // 
            // lblgebruikercom3
            // 
            this.lblgebruikercom3.AutoSize = true;
            this.lblgebruikercom3.Location = new System.Drawing.Point(593, 103);
            this.lblgebruikercom3.Name = "lblgebruikercom3";
            this.lblgebruikercom3.Size = new System.Drawing.Size(28, 13);
            this.lblgebruikercom3.TabIndex = 8;
            this.lblgebruikercom3.Text = "XXX";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(304, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 86);
            this.button1.TabIndex = 9;
            this.button1.Text = "Commentaar geven";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnterug
            // 
            this.btnterug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnterug.Location = new System.Drawing.Point(128, 409);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(97, 61);
            this.btnterug.TabIndex = 10;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // pcbLike1
            // 
            this.pcbLike1.BackColor = System.Drawing.Color.Red;
            this.pcbLike1.Location = new System.Drawing.Point(195, 66);
            this.pcbLike1.Name = "pcbLike1";
            this.pcbLike1.Size = new System.Drawing.Size(100, 50);
            this.pcbLike1.TabIndex = 11;
            this.pcbLike1.TabStop = false;
            // 
            // pcbLike2
            // 
            this.pcbLike2.BackColor = System.Drawing.Color.Red;
            this.pcbLike2.Location = new System.Drawing.Point(487, 66);
            this.pcbLike2.Name = "pcbLike2";
            this.pcbLike2.Size = new System.Drawing.Size(100, 50);
            this.pcbLike2.TabIndex = 12;
            this.pcbLike2.TabStop = false;
            this.pcbLike2.Click += new System.EventHandler(this.pcbLike2_Click);
            // 
            // pcbLike3
            // 
            this.pcbLike3.BackColor = System.Drawing.Color.Red;
            this.pcbLike3.Location = new System.Drawing.Point(776, 66);
            this.pcbLike3.Name = "pcbLike3";
            this.pcbLike3.Size = new System.Drawing.Size(100, 50);
            this.pcbLike3.TabIndex = 13;
            this.pcbLike3.TabStop = false;
            // 
            // lblLeeg
            // 
            this.lblLeeg.AutoSize = true;
            this.lblLeeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblLeeg.Location = new System.Drawing.Point(123, 185);
            this.lblLeeg.Name = "lblLeeg";
            this.lblLeeg.Size = new System.Drawing.Size(60, 26);
            this.lblLeeg.TabIndex = 14;
            this.lblLeeg.Text = "XXX";
            this.lblLeeg.Visible = false;
            // 
            // frmcommentaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 482);
            this.Controls.Add(this.lblLeeg);
            this.Controls.Add(this.pcbLike3);
            this.Controls.Add(this.pcbLike2);
            this.Controls.Add(this.pcbLike1);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblgebruikercom3);
            this.Controls.Add(this.lblgebruikercom2);
            this.Controls.Add(this.lblgebruikercom1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtcommentaar3);
            this.Controls.Add(this.txtcommentaar2);
            this.Controls.Add(this.lblcommentaar);
            this.Controls.Add(this.txtcommentaar1);
            this.Name = "frmcommentaar";
            this.Text = "frmcommentaar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmcommentaar_FormClosed);
            this.Load += new System.EventHandler(this.frmcommentaar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLike1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLike2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLike3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcommentaar1;
        private System.Windows.Forms.Label lblcommentaar;
        private System.Windows.Forms.TextBox txtcommentaar2;
        private System.Windows.Forms.TextBox txtcommentaar3;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblgebruikercom1;
        private System.Windows.Forms.Label lblgebruikercom2;
        private System.Windows.Forms.Label lblgebruikercom3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnterug;
        private System.Windows.Forms.PictureBox pcbLike1;
        private System.Windows.Forms.PictureBox pcbLike2;
        private System.Windows.Forms.PictureBox pcbLike3;
        private System.Windows.Forms.Label lblLeeg;
    }
}