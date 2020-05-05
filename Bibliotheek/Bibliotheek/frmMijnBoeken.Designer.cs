namespace Bibliotheek
{
    partial class frmMijnBoeken
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
            this.lsbLijsboeken = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbLijsboeken
            // 
            this.lsbLijsboeken.FormattingEnabled = true;
            this.lsbLijsboeken.Location = new System.Drawing.Point(12, 12);
            this.lsbLijsboeken.Name = "lsbLijsboeken";
            this.lsbLijsboeken.Size = new System.Drawing.Size(776, 160);
            this.lsbLijsboeken.TabIndex = 0;
            // 
            // frmMijnBoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 267);
            this.Controls.Add(this.lsbLijsboeken);
            this.Name = "frmMijnBoeken";
            this.Text = "frmMijnBoeken";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbLijsboeken;
    }
}