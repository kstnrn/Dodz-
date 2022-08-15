namespace Dodz
{
    partial class UCHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.PicBoxHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxHome
            // 
            this.PicBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxHome.Image")));
            this.PicBoxHome.Location = new System.Drawing.Point(0, 0);
            this.PicBoxHome.Name = "PicBoxHome";
            this.PicBoxHome.Size = new System.Drawing.Size(1208, 660);
            this.PicBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxHome.TabIndex = 0;
            this.PicBoxHome.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales and Stock Management";
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBoxHome);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1200, 729);
            this.Load += new System.EventHandler(this.UCHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxHome;
        private System.Windows.Forms.Label label1;
    }
}
