namespace Lab_25
{
    partial class Form1
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
            this.Mnu = new System.Windows.Forms.MenuStrip();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_FilePath = new System.Windows.Forms.Label();
            this.TxtFileStatus = new System.Windows.Forms.ListBox();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtDisplayData = new System.Windows.Forms.TextBox();
            this.Mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu
            // 
            this.Mnu.BackColor = System.Drawing.Color.Plum;
            this.Mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout,
            this.MnuExit});
            this.Mnu.Location = new System.Drawing.Point(0, 0);
            this.Mnu.Name = "Mnu";
            this.Mnu.Size = new System.Drawing.Size(337, 24);
            this.Mnu.TabIndex = 0;
            this.Mnu.Text = "menuStrip1";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(52, 20);
            this.MnuAbout.Text = "About";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "Exit";
            // 
            // Lbl_FilePath
            // 
            this.Lbl_FilePath.AutoSize = true;
            this.Lbl_FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FilePath.Location = new System.Drawing.Point(12, 44);
            this.Lbl_FilePath.Name = "Lbl_FilePath";
            this.Lbl_FilePath.Size = new System.Drawing.Size(94, 24);
            this.Lbl_FilePath.TabIndex = 1;
            this.Lbl_FilePath.Text = "Filename:";
            // 
            // TxtFileStatus
            // 
            this.TxtFileStatus.FormattingEnabled = true;
            this.TxtFileStatus.Location = new System.Drawing.Point(117, 71);
            this.TxtFileStatus.Name = "TxtFileStatus";
            this.TxtFileStatus.Size = new System.Drawing.Size(208, 303);
            this.TxtFileStatus.TabIndex = 2;
            // 
            // BtnRead
            // 
            this.BtnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRead.Location = new System.Drawing.Point(12, 80);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(94, 30);
            this.BtnRead.TabIndex = 3;
            this.BtnRead.Text = "Read File";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(12, 116);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 30);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save File";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnWriteFile_Click);
            // 
            // TxtDisplayData
            // 
            this.TxtDisplayData.Location = new System.Drawing.Point(112, 49);
            this.TxtDisplayData.Name = "TxtDisplayData";
            this.TxtDisplayData.ReadOnly = true;
            this.TxtDisplayData.Size = new System.Drawing.Size(213, 20);
            this.TxtDisplayData.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 386);
            this.Controls.Add(this.TxtDisplayData);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.TxtFileStatus);
            this.Controls.Add(this.Lbl_FilePath);
            this.Controls.Add(this.Mnu);
            this.MainMenuStrip = this.Mnu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Mnu.ResumeLayout(false);
            this.Mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.Label Lbl_FilePath;
        private System.Windows.Forms.ListBox TxtFileStatus;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtDisplayData;
    }
}

