namespace Bibliotheek
{
    partial class frmRandomBoek
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
            this.btnontlenen2 = new System.Windows.Forms.Button();
            this.lbltiteltext2 = new System.Windows.Forms.Label();
            this.lbltitel2 = new System.Windows.Forms.Label();
            this.btnmeerinfo2 = new System.Windows.Forms.Button();
            this.pcbstatus2 = new System.Windows.Forms.PictureBox();
            this.lblstatusboek2 = new System.Windows.Forms.Label();
            this.pcbboek2 = new System.Windows.Forms.PictureBox();
            this.btnterug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbboek2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnontlenen2
            // 
            this.btnontlenen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnontlenen2.Location = new System.Drawing.Point(11, 343);
            this.btnontlenen2.Margin = new System.Windows.Forms.Padding(2);
            this.btnontlenen2.Name = "btnontlenen2";
            this.btnontlenen2.Size = new System.Drawing.Size(176, 44);
            this.btnontlenen2.TabIndex = 31;
            this.btnontlenen2.Text = "Ontlenen";
            this.btnontlenen2.UseVisualStyleBackColor = true;
            // 
            // lbltiteltext2
            // 
            this.lbltiteltext2.AutoSize = true;
            this.lbltiteltext2.Location = new System.Drawing.Point(50, 270);
            this.lbltiteltext2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltiteltext2.Name = "lbltiteltext2";
            this.lbltiteltext2.Size = new System.Drawing.Size(28, 13);
            this.lbltiteltext2.TabIndex = 30;
            this.lbltiteltext2.Text = "XXX";
            // 
            // lbltitel2
            // 
            this.lbltitel2.AutoSize = true;
            this.lbltitel2.Location = new System.Drawing.Point(16, 270);
            this.lbltitel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitel2.Name = "lbltitel2";
            this.lbltitel2.Size = new System.Drawing.Size(30, 13);
            this.lbltitel2.TabIndex = 29;
            this.lbltitel2.Text = "Titel:";
            // 
            // btnmeerinfo2
            // 
            this.btnmeerinfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnmeerinfo2.Location = new System.Drawing.Point(11, 294);
            this.btnmeerinfo2.Margin = new System.Windows.Forms.Padding(2);
            this.btnmeerinfo2.Name = "btnmeerinfo2";
            this.btnmeerinfo2.Size = new System.Drawing.Size(176, 44);
            this.btnmeerinfo2.TabIndex = 28;
            this.btnmeerinfo2.Text = "Meer info";
            this.btnmeerinfo2.UseVisualStyleBackColor = true;
            this.btnmeerinfo2.Click += new System.EventHandler(this.btnmeerinfo2_Click);
            // 
            // pcbstatus2
            // 
            this.pcbstatus2.BackColor = System.Drawing.Color.Red;
            this.pcbstatus2.Location = new System.Drawing.Point(64, 241);
            this.pcbstatus2.Margin = new System.Windows.Forms.Padding(2);
            this.pcbstatus2.Name = "pcbstatus2";
            this.pcbstatus2.Size = new System.Drawing.Size(123, 15);
            this.pcbstatus2.TabIndex = 27;
            this.pcbstatus2.TabStop = false;
            // 
            // lblstatusboek2
            // 
            this.lblstatusboek2.AutoSize = true;
            this.lblstatusboek2.Location = new System.Drawing.Point(16, 243);
            this.lblstatusboek2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstatusboek2.Name = "lblstatusboek2";
            this.lblstatusboek2.Size = new System.Drawing.Size(40, 13);
            this.lblstatusboek2.TabIndex = 26;
            this.lblstatusboek2.Text = "Status:";
            // 
            // pcbboek2
            // 
            this.pcbboek2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pcbboek2.Location = new System.Drawing.Point(11, 11);
            this.pcbboek2.Margin = new System.Windows.Forms.Padding(2);
            this.pcbboek2.Name = "pcbboek2";
            this.pcbboek2.Size = new System.Drawing.Size(176, 213);
            this.pcbboek2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbboek2.TabIndex = 25;
            this.pcbboek2.TabStop = false;
            // 
            // btnterug
            // 
            this.btnterug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnterug.Location = new System.Drawing.Point(11, 391);
            this.btnterug.Margin = new System.Windows.Forms.Padding(2);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(176, 44);
            this.btnterug.TabIndex = 32;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // frmRandomBoek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 447);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.btnontlenen2);
            this.Controls.Add(this.lbltiteltext2);
            this.Controls.Add(this.lbltitel2);
            this.Controls.Add(this.btnmeerinfo2);
            this.Controls.Add(this.pcbstatus2);
            this.Controls.Add(this.lblstatusboek2);
            this.Controls.Add(this.pcbboek2);
            this.Name = "frmRandomBoek";
            this.Text = "frmRandomBoek";
            this.Load += new System.EventHandler(this.frmRandomBoek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbstatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbboek2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnontlenen2;
        private System.Windows.Forms.Label lbltiteltext2;
        private System.Windows.Forms.Label lbltitel2;
        private System.Windows.Forms.Button btnmeerinfo2;
        private System.Windows.Forms.PictureBox pcbstatus2;
        private System.Windows.Forms.Label lblstatusboek2;
        private System.Windows.Forms.PictureBox pcbboek2;
        private System.Windows.Forms.Button btnterug;
    }
}