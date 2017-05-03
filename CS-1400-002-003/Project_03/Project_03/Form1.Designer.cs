namespace Project_03
{
    partial class FrmTravelDistance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTravelDistance));
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.LblWheel = new System.Windows.Forms.Label();
            this.LblTurns = new System.Windows.Forms.Label();
            this.PBxWagon = new System.Windows.Forms.PictureBox();
            this.TxtDiameter = new System.Windows.Forms.TextBox();
            this.TxtTurns = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.MnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxWagon)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout,
            this.MnuInstructions,
            this.MnuClear,
            this.MnuExit});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(224, 24);
            this.MnuStrip.TabIndex = 0;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(52, 20);
            this.MnuAbout.Text = "About";
            this.MnuAbout.Click += new System.EventHandler(this.AboutMnu_Click);
            // 
            // MnuInstructions
            // 
            this.MnuInstructions.Name = "MnuInstructions";
            this.MnuInstructions.Size = new System.Drawing.Size(81, 20);
            this.MnuInstructions.Text = "Instructions";
            this.MnuInstructions.Click += new System.EventHandler(this.InstructionsMnu_Click);
            // 
            // MnuClear
            // 
            this.MnuClear.Name = "MnuClear";
            this.MnuClear.Size = new System.Drawing.Size(46, 20);
            this.MnuClear.Text = "Clear";
            this.MnuClear.Click += new System.EventHandler(this.ClearMnu_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.ExitMnu_Click);
            // 
            // LblWheel
            // 
            this.LblWheel.AutoSize = true;
            this.LblWheel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWheel.Location = new System.Drawing.Point(12, 39);
            this.LblWheel.Name = "LblWheel";
            this.LblWheel.Size = new System.Drawing.Size(338, 25);
            this.LblWheel.TabIndex = 1;
            this.LblWheel.Text = "Please Enter the Wheel Diameter in Inches:";
            // 
            // LblTurns
            // 
            this.LblTurns.AutoSize = true;
            this.LblTurns.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTurns.Location = new System.Drawing.Point(12, 101);
            this.LblTurns.Name = "LblTurns";
            this.LblTurns.Size = new System.Drawing.Size(128, 25);
            this.LblTurns.TabIndex = 2;
            this.LblTurns.Text = "Turns per Mile:";
            // 
            // PBxWagon
            // 
            this.PBxWagon.Image = ((System.Drawing.Image)(resources.GetObject("PBxWagon.Image")));
            this.PBxWagon.Location = new System.Drawing.Point(176, 67);
            this.PBxWagon.Name = "PBxWagon";
            this.PBxWagon.Size = new System.Drawing.Size(384, 266);
            this.PBxWagon.TabIndex = 3;
            this.PBxWagon.TabStop = false;
            // 
            // TxtDiameter
            // 
            this.TxtDiameter.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiameter.Location = new System.Drawing.Point(12, 67);
            this.TxtDiameter.Name = "TxtDiameter";
            this.TxtDiameter.Size = new System.Drawing.Size(153, 31);
            this.TxtDiameter.TabIndex = 4;
            this.TxtDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxDiameter_KeyPress);
            // 
            // TxtTurns
            // 
            this.TxtTurns.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTurns.Location = new System.Drawing.Point(12, 129);
            this.TxtTurns.Name = "TxtTurns";
            this.TxtTurns.ReadOnly = true;
            this.TxtTurns.Size = new System.Drawing.Size(153, 31);
            this.TxtTurns.TabIndex = 5;
            this.TxtTurns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(12, 266);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(153, 33);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(12, 305);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(153, 33);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmTravelDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 350);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtTurns);
            this.Controls.Add(this.TxtDiameter);
            this.Controls.Add(this.PBxWagon);
            this.Controls.Add(this.LblTurns);
            this.Controls.Add(this.LblWheel);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmTravelDistance";
            this.Text = "Wagon Wheel Odometer";
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxWagon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuInstructions;
        private System.Windows.Forms.ToolStripMenuItem MnuClear;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.Label LblWheel;
        private System.Windows.Forms.Label LblTurns;
        private System.Windows.Forms.PictureBox PBxWagon;
        private System.Windows.Forms.TextBox TxtDiameter;
        private System.Windows.Forms.TextBox TxtTurns;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
    }
}

