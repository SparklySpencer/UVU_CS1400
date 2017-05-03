namespace Lab_05
{
    partial class FrmInOut
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
            this.MnuStrTop = new System.Windows.Forms.MenuStrip();
            this.MnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtBxIn = new System.Windows.Forms.TextBox();
            this.TxtBxOut = new System.Windows.Forms.TextBox();
            this.LblIn = new System.Windows.Forms.Label();
            this.LblOut = new System.Windows.Forms.Label();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.MnuStrTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStrTop
            // 
            this.MnuStrTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMenu});
            this.MnuStrTop.Location = new System.Drawing.Point(0, 0);
            this.MnuStrTop.Name = "MnuStrTop";
            this.MnuStrTop.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.MnuStrTop.Size = new System.Drawing.Size(826, 27);
            this.MnuStrTop.TabIndex = 0;
            this.MnuStrTop.Text = "menuStrip1";
            // 
            // MnuMenu
            // 
            this.MnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout,
            this.MnuClear,
            this.MnuExit});
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Size = new System.Drawing.Size(50, 19);
            this.MnuMenu.Text = "Menu";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(107, 22);
            this.MnuAbout.Text = "About";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // MnuClear
            // 
            this.MnuClear.Name = "MnuClear";
            this.MnuClear.Size = new System.Drawing.Size(107, 22);
            this.MnuClear.Text = "Clear";
            this.MnuClear.Click += new System.EventHandler(this.MnuClear_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(107, 22);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // TxtBxIn
            // 
            this.TxtBxIn.Location = new System.Drawing.Point(187, 88);
            this.TxtBxIn.Margin = new System.Windows.Forms.Padding(6);
            this.TxtBxIn.Name = "TxtBxIn";
            this.TxtBxIn.Size = new System.Drawing.Size(596, 34);
            this.TxtBxIn.TabIndex = 1;
            // 
            // TxtBxOut
            // 
            this.TxtBxOut.Location = new System.Drawing.Point(187, 186);
            this.TxtBxOut.Margin = new System.Windows.Forms.Padding(6);
            this.TxtBxOut.Name = "TxtBxOut";
            this.TxtBxOut.Size = new System.Drawing.Size(596, 34);
            this.TxtBxOut.TabIndex = 2;
            // 
            // LblIn
            // 
            this.LblIn.AutoSize = true;
            this.LblIn.Location = new System.Drawing.Point(35, 88);
            this.LblIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblIn.Name = "LblIn";
            this.LblIn.Size = new System.Drawing.Size(62, 28);
            this.LblIn.TabIndex = 3;
            this.LblIn.Text = "Input";
            // 
            // LblOut
            // 
            this.LblOut.AutoSize = true;
            this.LblOut.Location = new System.Drawing.Point(35, 186);
            this.LblOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(75, 28);
            this.LblOut.TabIndex = 4;
            this.LblOut.Text = "Output";
            // 
            // BtnProcess
            // 
            this.BtnProcess.Location = new System.Drawing.Point(187, 275);
            this.BtnProcess.Margin = new System.Windows.Forms.Padding(6);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(600, 110);
            this.BtnProcess.TabIndex = 5;
            this.BtnProcess.Text = "Process";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // FrmInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 441);
            this.Controls.Add(this.BtnProcess);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.LblIn);
            this.Controls.Add(this.TxtBxOut);
            this.Controls.Add(this.TxtBxIn);
            this.Controls.Add(this.MnuStrTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MnuStrTop;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmInOut";
            this.Text = "Lab 05 SC V1.0";
            this.MnuStrTop.ResumeLayout(false);
            this.MnuStrTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrTop;
        private System.Windows.Forms.ToolStripMenuItem MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuClear;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.TextBox TxtBxIn;
        private System.Windows.Forms.TextBox TxtBxOut;
        private System.Windows.Forms.Label LblIn;
        private System.Windows.Forms.Label LblOut;
        private System.Windows.Forms.Button BtnProcess;
    }
}

