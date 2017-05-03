namespace Project_02
{
    partial class FrmGoodGuys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoodGuys));
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.LbStartTime = new System.Windows.Forms.Label();
            this.LblEndTime = new System.Windows.Forms.Label();
            this.LblPressButton = new System.Windows.Forms.Label();
            this.LblNewStop = new System.Windows.Forms.Label();
            this.textBxStart = new System.Windows.Forms.TextBox();
            this.textBxOrigStop = new System.Windows.Forms.TextBox();
            this.textBxFinalStop = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menuToolStripMenuItem1});
            resources.ApplyResources(this.mnuStrip, "mnuStrip");
            this.mnuStrip.Name = "mnuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            resources.ApplyResources(this.instructionsToolStripMenuItem, "instructionsToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMnu,
            this.instructionsMnu,
            this.exitMnu});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            resources.ApplyResources(this.menuToolStripMenuItem1, "menuToolStripMenuItem1");
            // 
            // aboutMnu
            // 
            this.aboutMnu.Name = "aboutMnu";
            resources.ApplyResources(this.aboutMnu, "aboutMnu");
            // 
            // instructionsMnu
            // 
            this.instructionsMnu.Name = "instructionsMnu";
            resources.ApplyResources(this.instructionsMnu, "instructionsMnu");
            // 
            // exitMnu
            // 
            this.exitMnu.Name = "exitMnu";
            resources.ApplyResources(this.exitMnu, "exitMnu");
            // 
            // LbStartTime
            // 
            resources.ApplyResources(this.LbStartTime, "LbStartTime");
            this.LbStartTime.Name = "LbStartTime";
            // 
            // LblEndTime
            // 
            resources.ApplyResources(this.LblEndTime, "LblEndTime");
            this.LblEndTime.Name = "LblEndTime";
            // 
            // LblPressButton
            // 
            resources.ApplyResources(this.LblPressButton, "LblPressButton");
            this.LblPressButton.Name = "LblPressButton";
            // 
            // LblNewStop
            // 
            resources.ApplyResources(this.LblNewStop, "LblNewStop");
            this.LblNewStop.Name = "LblNewStop";
            // 
            // textBxStart
            // 
            resources.ApplyResources(this.textBxStart, "textBxStart");
            this.textBxStart.Name = "textBxStart";
            // 
            // textBxOrigStop
            // 
            resources.ApplyResources(this.textBxOrigStop, "textBxOrigStop");
            this.textBxOrigStop.Name = "textBxOrigStop";
            // 
            // textBxFinalStop
            // 
            resources.ApplyResources(this.textBxFinalStop, "textBxFinalStop");
            this.textBxFinalStop.Name = "textBxFinalStop";
            this.textBxFinalStop.ReadOnly = true;
            // 
            // BtnExit
            // 
            resources.ApplyResources(this.BtnExit, "BtnExit");
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCalculate
            // 
            resources.ApplyResources(this.BtnCalculate, "BtnCalculate");
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // FrmGoodGuys
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.textBxFinalStop);
            this.Controls.Add(this.textBxOrigStop);
            this.Controls.Add(this.textBxStart);
            this.Controls.Add(this.LblNewStop);
            this.Controls.Add(this.LblPressButton);
            this.Controls.Add(this.LblEndTime);
            this.Controls.Add(this.LbStartTime);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "FrmGoodGuys";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LbStartTime;
        private System.Windows.Forms.Label LblEndTime;
        private System.Windows.Forms.Label LblPressButton;
        private System.Windows.Forms.Label LblNewStop;
        private System.Windows.Forms.TextBox textBxStart;
        private System.Windows.Forms.TextBox textBxOrigStop;
        private System.Windows.Forms.TextBox textBxFinalStop;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutMnu;
        private System.Windows.Forms.ToolStripMenuItem instructionsMnu;
        private System.Windows.Forms.ToolStripMenuItem exitMnu;
    }
}

