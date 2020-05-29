namespace Bibliotheek
{
    partial class frmCommentMaken
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
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.gpblike = new System.Windows.Forms.GroupBox();
            this.lbltekst2 = new System.Windows.Forms.Label();
            this.rdbgoed = new System.Windows.Forms.RadioButton();
            this.rdbslecht = new System.Windows.Forms.RadioButton();
            this.lbltext2 = new System.Windows.Forms.Label();
            this.btntrug = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.gpblike.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(12, 156);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(266, 260);
            this.txtmessage.TabIndex = 0;
            // 
            // gpblike
            // 
            this.gpblike.Controls.Add(this.rdbslecht);
            this.gpblike.Controls.Add(this.rdbgoed);
            this.gpblike.Controls.Add(this.lbltekst2);
            this.gpblike.Location = new System.Drawing.Point(12, 12);
            this.gpblike.Name = "gpblike";
            this.gpblike.Size = new System.Drawing.Size(258, 100);
            this.gpblike.TabIndex = 1;
            this.gpblike.TabStop = false;
            // 
            // lbltekst2
            // 
            this.lbltekst2.AutoSize = true;
            this.lbltekst2.Location = new System.Drawing.Point(6, 16);
            this.lbltekst2.Name = "lbltekst2";
            this.lbltekst2.Size = new System.Drawing.Size(131, 13);
            this.lbltekst2.TabIndex = 2;
            this.lbltekst2.Text = "Wat vond je van het boek";
            // 
            // rdbgoed
            // 
            this.rdbgoed.AutoSize = true;
            this.rdbgoed.Location = new System.Drawing.Point(9, 32);
            this.rdbgoed.Name = "rdbgoed";
            this.rdbgoed.Size = new System.Drawing.Size(154, 17);
            this.rdbgoed.TabIndex = 3;
            this.rdbgoed.TabStop = true;
            this.rdbgoed.Text = "Ik vond het een goed boek";
            this.rdbgoed.UseVisualStyleBackColor = true;
            // 
            // rdbslecht
            // 
            this.rdbslecht.AutoSize = true;
            this.rdbslecht.Location = new System.Drawing.Point(9, 55);
            this.rdbslecht.Name = "rdbslecht";
            this.rdbslecht.Size = new System.Drawing.Size(137, 17);
            this.rdbslecht.TabIndex = 4;
            this.rdbslecht.TabStop = true;
            this.rdbslecht.Text = "Ik vond het slecht boek";
            this.rdbslecht.UseVisualStyleBackColor = true;
            // 
            // lbltext2
            // 
            this.lbltext2.AutoSize = true;
            this.lbltext2.Location = new System.Drawing.Point(12, 130);
            this.lbltext2.Name = "lbltext2";
            this.lbltext2.Size = new System.Drawing.Size(239, 13);
            this.lbltext2.TabIndex = 5;
            this.lbltext2.Text = "Schrijf hier waarom je het boek goed/slecht vond";
            // 
            // btntrug
            // 
            this.btntrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btntrug.Location = new System.Drawing.Point(12, 422);
            this.btntrug.Name = "btntrug";
            this.btntrug.Size = new System.Drawing.Size(122, 60);
            this.btntrug.TabIndex = 6;
            this.btntrug.Text = "Terug";
            this.btntrug.UseVisualStyleBackColor = true;
            this.btntrug.Click += new System.EventHandler(this.btntrug_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnsubmit.Location = new System.Drawing.Point(140, 422);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(138, 60);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.Text = "Verzenden";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // frmCommentMaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 494);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btntrug);
            this.Controls.Add(this.lbltext2);
            this.Controls.Add(this.gpblike);
            this.Controls.Add(this.txtmessage);
            this.Name = "frmCommentMaken";
            this.Text = "frmCommentMaken";
            this.Load += new System.EventHandler(this.frmCommentMaken_Load);
            this.gpblike.ResumeLayout(false);
            this.gpblike.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.GroupBox gpblike;
        private System.Windows.Forms.RadioButton rdbslecht;
        private System.Windows.Forms.RadioButton rdbgoed;
        private System.Windows.Forms.Label lbltekst2;
        private System.Windows.Forms.Label lbltext2;
        private System.Windows.Forms.Button btntrug;
        private System.Windows.Forms.Button btnsubmit;
    }
}