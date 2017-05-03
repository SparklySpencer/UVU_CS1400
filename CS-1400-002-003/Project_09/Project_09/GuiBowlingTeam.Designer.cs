namespace Project_09
{
    partial class FrmBowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBowing));
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.LblName = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.RTxtDisplay = new System.Windows.Forms.RichTextBox();
            this.MnuInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.MnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout,
            this.MnuInstructions,
            this.MnuReset,
            this.MnuClear,
            this.MnuExit});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(612, 24);
            this.MnuStrip.TabIndex = 0;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(52, 20);
            this.MnuAbout.Text = "About";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("AR DESTINE", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(34, 31);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(68, 25);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name:";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("AR DESTINE", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(288, 31);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(134, 25);
            this.LblScore.TabIndex = 3;
            this.LblScore.Text = "Total Score:";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.White;
            this.TxtName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(108, 29);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(174, 30);
            this.TxtName.TabIndex = 5;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // TxtScore
            // 
            this.TxtScore.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtScore.Location = new System.Drawing.Point(428, 29);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(138, 30);
            this.TxtScore.TabIndex = 6;
            this.TxtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtScore_KeyPress);
            // 
            // RTxtDisplay
            // 
            this.RTxtDisplay.BackColor = System.Drawing.Color.DarkViolet;
            this.RTxtDisplay.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtDisplay.ForeColor = System.Drawing.Color.White;
            this.RTxtDisplay.Location = new System.Drawing.Point(39, 138);
            this.RTxtDisplay.Name = "RTxtDisplay";
            this.RTxtDisplay.ReadOnly = true;
            this.RTxtDisplay.Size = new System.Drawing.Size(532, 236);
            this.RTxtDisplay.TabIndex = 7;
            this.RTxtDisplay.Text = "";
            // 
            // MnuInstructions
            // 
            this.MnuInstructions.Name = "MnuInstructions";
            this.MnuInstructions.Size = new System.Drawing.Size(81, 20);
            this.MnuInstructions.Text = "Instructions";
            this.MnuInstructions.Click += new System.EventHandler(this.MnuInstructions_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(39, 91);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(527, 25);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add New Player";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // MnuReset
            // 
            this.MnuReset.Name = "MnuReset";
            this.MnuReset.Size = new System.Drawing.Size(47, 20);
            this.MnuReset.Text = "Reset";
            this.MnuReset.Click += new System.EventHandler(this.MnuReset_Click);
            // 
            // MnuClear
            // 
            this.MnuClear.Name = "MnuClear";
            this.MnuClear.Size = new System.Drawing.Size(46, 20);
            this.MnuClear.Text = "Clear";
            this.MnuClear.Click += new System.EventHandler(this.MnuClear_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // FrmBowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.RTxtDisplay);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmBowing";
            this.Text = "A Better Bowling Team Scores Program";
            this.Load += new System.EventHandler(this.FrmBowing_Load);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.RichTextBox RTxtDisplay;
        private System.Windows.Forms.ToolStripMenuItem MnuInstructions;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ToolStripMenuItem MnuReset;
        private System.Windows.Forms.ToolStripMenuItem MnuClear;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
    }
}

