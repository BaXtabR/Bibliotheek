namespace Bibliotheek
{
    partial class frmboetes
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
            this.lsbboetes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbboetes
            // 
            this.lsbboetes.FormattingEnabled = true;
            this.lsbboetes.Location = new System.Drawing.Point(12, 12);
            this.lsbboetes.Name = "lsbboetes";
            this.lsbboetes.Size = new System.Drawing.Size(682, 225);
            this.lsbboetes.TabIndex = 0;
            // 
            // frmboetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 342);
            this.Controls.Add(this.lsbboetes);
            this.Name = "frmboetes";
            this.Text = "frmboetes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbboetes;
    }
}