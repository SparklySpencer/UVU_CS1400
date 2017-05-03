namespace Lab_02
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PBoxImage = new System.Windows.Forms.PictureBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PBoxImage
            // 
            this.PBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("PBoxImage.Image")));
            this.PBoxImage.Location = new System.Drawing.Point(77, 62);
            this.PBoxImage.Name = "PBoxImage";
            this.PBoxImage.Size = new System.Drawing.Size(260, 262);
            this.PBoxImage.TabIndex = 0;
            this.PBoxImage.TabStop = false;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Blackadder ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(81, 9);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(256, 31);
            this.LblInfo.TabIndex = 1;
            this.LblInfo.Text = "\"Programming in C# is fun!\"";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Info;
            this.BtnClose.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(144, 345);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(126, 41);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Click To End";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 398);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.PBoxImage);
            this.Name = "FrmMain";
            this.Text = "SC Lab_02";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxImage;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button BtnClose;
    }
}

