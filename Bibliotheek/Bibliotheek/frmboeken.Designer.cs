namespace Bibliotheek
{
    partial class frmboeken
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
            this.btnachteruit = new System.Windows.Forms.Button();
            this.btnvooruit = new System.Windows.Forms.Button();
            this.pcbboek1 = new System.Windows.Forms.PictureBox();
            this.pcbboek2 = new System.Windows.Forms.PictureBox();
            this.pcbboek3 = new System.Windows.Forms.PictureBox();
            this.lblstatusboek1 = new System.Windows.Forms.Label();
            this.pcbstatus1 = new System.Windows.Forms.PictureBox();
            this.pcbstatus2 = new System.Windows.Forms.PictureBox();
            this.lblstatusboek2 = new System.Windows.Forms.Label();
            this.pcbstatus3 = new System.Windows.Forms.PictureBox();
            this.lblstatusboek3 = new System.Windows.Forms.Label();
            this.btnmeerinfo2 = new System.Windows.Forms.Button();
            this.btnmeerinfo3 = new System.Windows.Forms.Button();
            this.lbltitel1 = new System.Windows.Forms.Label();
            this.lbltitel2 = new System.Windows.Forms.Label();
            this.lbltitel3 = new System.Windows.Forms.Label();
            this.lbltiteltext1 = new System.Windows.Forms.Label();
            this.lbltiteltext2 = new System.Windows.Forms.Label();
            this.lbltiteltext3 = new System.Windows.Forms.Label();
            this.btnmeerinfo1 = new System.Windows.Forms.Button();
            this.btnterug = new System.Windows.Forms.Button();
            this.btnontlenen1 = new System.Windows.Forms.Button();
            this.btnontlenen2 = new System.Windows.Forms.Button();
            this.btnontlenen3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbboek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbboek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbboek3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstatus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstatus3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnachteruit
            // 
            this.btnachteruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnachteruit.Location = new System.Drawing.Point(12, 483);
            this.btnachteruit.Name = "btnachteruit";
            this.btnachteruit.Size = new System.Drawing.Size(141, 67);
            this.btnachteruit.TabIndex = 0;
            this.btnachteruit.Text = "<==";
            this.btnachteruit.UseVisualStyleBackColor = true;
            this.btnachteruit.Click += new System.EventHandler(this.btnachteruit_Click);
            // 
            // btnvooruit
            // 
            this.btnvooruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvooruit.Location = new System.Drawing.Point(862, 483);
            this.btnvooruit.Name = "btnvooruit";
            this.btnvooruit.Size = new System.Drawing.Size(141, 67);
            this.btnvooruit.TabIndex = 1;
            this.btnvooruit.Text = "==>";
            this.btnvooruit.UseVisualStyleBackColor = true;
            this.btnvooruit.Click += new System.EventHandler(this.btnvooruit_Click);
            // 
            // pcbboek1
            // 
            this.pcbboek1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pcbboek1.Location = new System.Drawing.Point(12, 12);
            this.pcbboek1.Name = "pcbboek1";
            this.pcbboek1.Size = new System.Drawing.Size(235, 216);
            this.pcbboek1.TabIndex = 2;
            this.pcbboek1.TabStop = false;
            // 
            // pcbboek2
            // 
            this.pcbboek2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pcbboek2.Location = new System.Drawing.Point(392, 12);
            this.pcbboek2.Name = "pcbboek2";
            this.pcbboek2.Size = new System.Drawing.Size(235, 216);
            this.pcbboek2.TabIndex = 3;
            this.pcbboek2.TabStop = false;
            // 
            // pcbboek3
            // 
            this.pcbboek3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pcbboek3.Location = new System.Drawing.Point(768, 12);
            this.pcbboek3.Name = "pcbboek3";
            this.pcbboek3.Size = new System.Drawing.Size(235, 216);
            this.pcbboek3.TabIndex = 4;
            this.pcbboek3.TabStop = false;
            // 
            // lblstatusboek1
            // 
            this.lblstatusboek1.AutoSize = true;
            this.lblstatusboek1.Location = new System.Drawing.Point(18, 238);
            this.lblstatusboek1.Name = "lblstatusboek1";
            this.lblstatusboek1.Size = new System.Drawing.Size(52, 17);
            this.lblstatusboek1.TabIndex = 5;
            this.lblstatusboek1.Text = "Status:";
            // 
            // pcbstatus1
            // 
            this.pcbstatus1.BackColor = System.Drawing.Color.Red;
            this.pcbstatus1.Location = new System.Drawing.Point(82, 236);
            this.pcbstatus1.Name = "pcbstatus1";
            this.pcbstatus1.Size = new System.Drawing.Size(164, 18);
            this.pcbstatus1.TabIndex = 6;
            this.pcbstatus1.TabStop = false;
            // 
            // pcbstatus2
            // 
            this.pcbstatus2.BackColor = System.Drawing.Color.Red;
            this.pcbstatus2.Location = new System.Drawing.Point(463, 238);
            this.pcbstatus2.Name = "pcbstatus2";
            this.pcbstatus2.Size = new System.Drawing.Size(164, 18);
            this.pcbstatus2.TabIndex = 8;
            this.pcbstatus2.TabStop = false;
            // 
            // lblstatusboek2
            // 
            this.lblstatusboek2.AutoSize = true;
            this.lblstatusboek2.Location = new System.Drawing.Point(399, 240);
            this.lblstatusboek2.Name = "lblstatusboek2";
            this.lblstatusboek2.Size = new System.Drawing.Size(52, 17);
            this.lblstatusboek2.TabIndex = 7;
            this.lblstatusboek2.Text = "Status:";
            // 
            // pcbstatus3
            // 
            this.pcbstatus3.BackColor = System.Drawing.Color.Red;
            this.pcbstatus3.Location = new System.Drawing.Point(839, 240);
            this.pcbstatus3.Name = "pcbstatus3";
            this.pcbstatus3.Size = new System.Drawing.Size(164, 18);
            this.pcbstatus3.TabIndex = 10;
            this.pcbstatus3.TabStop = false;
            // 
            // lblstatusboek3
            // 
            this.lblstatusboek3.AutoSize = true;
            this.lblstatusboek3.Location = new System.Drawing.Point(775, 242);
            this.lblstatusboek3.Name = "lblstatusboek3";
            this.lblstatusboek3.Size = new System.Drawing.Size(52, 17);
            this.lblstatusboek3.TabIndex = 9;
            this.lblstatusboek3.Text = "Status:";
            // 
            // btnmeerinfo2
            // 
            this.btnmeerinfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnmeerinfo2.Location = new System.Drawing.Point(392, 303);
            this.btnmeerinfo2.Name = "btnmeerinfo2";
            this.btnmeerinfo2.Size = new System.Drawing.Size(235, 54);
            this.btnmeerinfo2.TabIndex = 13;
            this.btnmeerinfo2.Text = "Meer info";
            this.btnmeerinfo2.UseVisualStyleBackColor = true;
            this.btnmeerinfo2.Click += new System.EventHandler(this.btnmeerinfo2_Click);
            // 
            // btnmeerinfo3
            // 
            this.btnmeerinfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnmeerinfo3.Location = new System.Drawing.Point(768, 303);
            this.btnmeerinfo3.Name = "btnmeerinfo3";
            this.btnmeerinfo3.Size = new System.Drawing.Size(235, 54);
            this.btnmeerinfo3.TabIndex = 14;
            this.btnmeerinfo3.Text = "Meer info";
            this.btnmeerinfo3.UseVisualStyleBackColor = true;
            this.btnmeerinfo3.Click += new System.EventHandler(this.btnmeerinfo3_Click);
            // 
            // lbltitel1
            // 
            this.lbltitel1.AutoSize = true;
            this.lbltitel1.Location = new System.Drawing.Point(18, 273);
            this.lbltitel1.Name = "lbltitel1";
            this.lbltitel1.Size = new System.Drawing.Size(39, 17);
            this.lbltitel1.TabIndex = 15;
            this.lbltitel1.Text = "Titel:";
            // 
            // lbltitel2
            // 
            this.lbltitel2.AutoSize = true;
            this.lbltitel2.Location = new System.Drawing.Point(399, 273);
            this.lbltitel2.Name = "lbltitel2";
            this.lbltitel2.Size = new System.Drawing.Size(39, 17);
            this.lbltitel2.TabIndex = 16;
            this.lbltitel2.Text = "Titel:";
            // 
            // lbltitel3
            // 
            this.lbltitel3.AutoSize = true;
            this.lbltitel3.Location = new System.Drawing.Point(775, 273);
            this.lbltitel3.Name = "lbltitel3";
            this.lbltitel3.Size = new System.Drawing.Size(39, 17);
            this.lbltitel3.TabIndex = 17;
            this.lbltitel3.Text = "Titel:";
            // 
            // lbltiteltext1
            // 
            this.lbltiteltext1.AutoSize = true;
            this.lbltiteltext1.Location = new System.Drawing.Point(63, 273);
            this.lbltiteltext1.Name = "lbltiteltext1";
            this.lbltiteltext1.Size = new System.Drawing.Size(35, 17);
            this.lbltiteltext1.TabIndex = 18;
            this.lbltiteltext1.Text = "XXX";
            // 
            // lbltiteltext2
            // 
            this.lbltiteltext2.AutoSize = true;
            this.lbltiteltext2.Location = new System.Drawing.Point(444, 273);
            this.lbltiteltext2.Name = "lbltiteltext2";
            this.lbltiteltext2.Size = new System.Drawing.Size(35, 17);
            this.lbltiteltext2.TabIndex = 19;
            this.lbltiteltext2.Text = "XXX";
            // 
            // lbltiteltext3
            // 
            this.lbltiteltext3.AutoSize = true;
            this.lbltiteltext3.Location = new System.Drawing.Point(820, 273);
            this.lbltiteltext3.Name = "lbltiteltext3";
            this.lbltiteltext3.Size = new System.Drawing.Size(35, 17);
            this.lbltiteltext3.TabIndex = 20;
            this.lbltiteltext3.Text = "XXX";
            // 
            // btnmeerinfo1
            // 
            this.btnmeerinfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnmeerinfo1.Location = new System.Drawing.Point(12, 303);
            this.btnmeerinfo1.Name = "btnmeerinfo1";
            this.btnmeerinfo1.Size = new System.Drawing.Size(235, 54);
            this.btnmeerinfo1.TabIndex = 21;
            this.btnmeerinfo1.Text = "Meer info";
            this.btnmeerinfo1.UseVisualStyleBackColor = true;
            this.btnmeerinfo1.Click += new System.EventHandler(this.btnmeerinfo1_Click);
            // 
            // btnterug
            // 
            this.btnterug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnterug.Location = new System.Drawing.Point(447, 483);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(141, 67);
            this.btnterug.TabIndex = 22;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // btnontlenen1
            // 
            this.btnontlenen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnontlenen1.Location = new System.Drawing.Point(12, 363);
            this.btnontlenen1.Name = "btnontlenen1";
            this.btnontlenen1.Size = new System.Drawing.Size(235, 54);
            this.btnontlenen1.TabIndex = 23;
            this.btnontlenen1.Text = "Ontlenen";
            this.btnontlenen1.UseVisualStyleBackColor = true;
            this.btnontlenen1.Click += new System.EventHandler(this.btnontlenen1_Click);
            // 
            // btnontlenen2
            // 
            this.btnontlenen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnontlenen2.Location = new System.Drawing.Point(392, 363);
            this.btnontlenen2.Name = "btnontlenen2";
            this.btnontlenen2.Size = new System.Drawing.Size(235, 54);
            this.btnontlenen2.TabIndex = 24;
            this.btnontlenen2.Text = "Ontlenen";
            this.btnontlenen2.UseVisualStyleBackColor = true;
            this.btnontlenen2.Click += new System.EventHandler(this.btnontlenen2_Click);
            // 
            // btnontlenen3
            // 
            this.btnontlenen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnontlenen3.Location = new System.Drawing.Point(768, 363);
            this.btnontlenen3.Name = "btnontlenen3";
            this.btnontlenen3.Size = new System.Drawing.Size(235, 54);
            this.btnontlenen3.TabIndex = 25;
            this.btnontlenen3.Text = "Ontlenen";
            this.btnontlenen3.UseVisualStyleBackColor = true;
            this.btnontlenen3.Click += new System.EventHandler(this.btnontlenen3_Click);
            // 
            // frmboeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 562);
            this.Controls.Add(this.btnontlenen3);
            this.Controls.Add(this.btnontlenen2);
            this.Controls.Add(this.btnontlenen1);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.btnmeerinfo1);
            this.Controls.Add(this.lbltiteltext3);
            this.Controls.Add(this.lbltiteltext2);
            this.Controls.Add(this.lbltiteltext1);
            this.Controls.Add(this.lbltitel3);
            this.Controls.Add(this.lbltitel2);
            this.Controls.Add(this.lbltitel1);
            this.Controls.Add(this.btnmeerinfo3);
            this.Controls.Add(this.btnmeerinfo2);
            this.Controls.Add(this.pcbstatus3);
            this.Controls.Add(this.lblstatusboek3);
            this.Controls.Add(this.pcbstatus2);
            this.Controls.Add(this.lblstatusboek2);
            this.Controls.Add(this.pcbstatus1);
            this.Controls.Add(this.lblstatusboek1);
            this.Controls.Add(this.pcbboek3);
            this.Controls.Add(this.pcbboek2);
            this.Controls.Add(this.pcbboek1);
            this.Controls.Add(this.btnvooruit);
            this.Controls.Add(this.btnachteruit);
            this.Name = "frmboeken";
            this.Text = "frmboeken";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmboeken_FormClosed);
            this.Load += new System.EventHandler(this.frmboeken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbboek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbboek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbboek3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstatus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstatus3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnachteruit;
        private System.Windows.Forms.Button btnvooruit;
        private System.Windows.Forms.PictureBox pcbboek1;
        private System.Windows.Forms.PictureBox pcbboek2;
        private System.Windows.Forms.PictureBox pcbboek3;
        private System.Windows.Forms.Label lblstatusboek1;
        private System.Windows.Forms.PictureBox pcbstatus1;
        private System.Windows.Forms.PictureBox pcbstatus2;
        private System.Windows.Forms.Label lblstatusboek2;
        private System.Windows.Forms.PictureBox pcbstatus3;
        private System.Windows.Forms.Label lblstatusboek3;
        private System.Windows.Forms.Button btnmeerinfo2;
        private System.Windows.Forms.Button btnmeerinfo3;
        private System.Windows.Forms.Label lbltitel1;
        private System.Windows.Forms.Label lbltitel2;
        private System.Windows.Forms.Label lbltitel3;
        private System.Windows.Forms.Label lbltiteltext1;
        private System.Windows.Forms.Label lbltiteltext2;
        private System.Windows.Forms.Label lbltiteltext3;
        private System.Windows.Forms.Button btnmeerinfo1;
        private System.Windows.Forms.Button btnterug;
        private System.Windows.Forms.Button btnontlenen1;
        private System.Windows.Forms.Button btnontlenen2;
        private System.Windows.Forms.Button btnontlenen3;
    }
}