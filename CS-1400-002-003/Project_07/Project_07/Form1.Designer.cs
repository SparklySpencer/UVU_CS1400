namespace Project_07
{
    partial class FrmDiceGameGUI
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
            this.Mnu_Strip = new System.Windows.Forms.MenuStrip();
            this.Mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_OneDice = new System.Windows.Forms.Label();
            this.Lbl_TwoDice = new System.Windows.Forms.Label();
            this.Btn_RollDice = new System.Windows.Forms.Button();
            this.Lbl_DisplayResults = new System.Windows.Forms.Label();
            this.Mnu_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Strip
            // 
            this.Mnu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_About,
            this.Mnu_Exit});
            this.Mnu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Strip.Name = "Mnu_Strip";
            this.Mnu_Strip.Size = new System.Drawing.Size(495, 24);
            this.Mnu_Strip.TabIndex = 0;
            this.Mnu_Strip.Text = "MnuStrip";
            // 
            // Mnu_About
            // 
            this.Mnu_About.Name = "Mnu_About";
            this.Mnu_About.Size = new System.Drawing.Size(52, 20);
            this.Mnu_About.Text = "About";
            this.Mnu_About.Click += new System.EventHandler(this.Mnu_About_Click);
            // 
            // Mnu_Exit
            // 
            this.Mnu_Exit.Name = "Mnu_Exit";
            this.Mnu_Exit.Size = new System.Drawing.Size(37, 20);
            this.Mnu_Exit.Text = "Exit";
            this.Mnu_Exit.Click += new System.EventHandler(this.Mnu_Exit_Click);
            // 
            // Lbl_OneDice
            // 
            this.Lbl_OneDice.BackColor = System.Drawing.Color.Black;
            this.Lbl_OneDice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_OneDice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Lbl_OneDice.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OneDice.ForeColor = System.Drawing.Color.White;
            this.Lbl_OneDice.Location = new System.Drawing.Point(109, 23);
            this.Lbl_OneDice.Name = "Lbl_OneDice";
            this.Lbl_OneDice.Size = new System.Drawing.Size(49, 65);
            this.Lbl_OneDice.TabIndex = 1;
            this.Lbl_OneDice.Text = "0";
            this.Lbl_OneDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TwoDice
            // 
            this.Lbl_TwoDice.BackColor = System.Drawing.Color.Black;
            this.Lbl_TwoDice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_TwoDice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Lbl_TwoDice.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TwoDice.ForeColor = System.Drawing.Color.White;
            this.Lbl_TwoDice.Location = new System.Drawing.Point(164, 23);
            this.Lbl_TwoDice.Name = "Lbl_TwoDice";
            this.Lbl_TwoDice.Size = new System.Drawing.Size(49, 65);
            this.Lbl_TwoDice.TabIndex = 2;
            this.Lbl_TwoDice.Text = "0";
            this.Lbl_TwoDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_RollDice
            // 
            this.Btn_RollDice.Location = new System.Drawing.Point(12, 41);
            this.Btn_RollDice.Name = "Btn_RollDice";
            this.Btn_RollDice.Size = new System.Drawing.Size(91, 39);
            this.Btn_RollDice.TabIndex = 3;
            this.Btn_RollDice.Text = "Roll \'Em";
            this.Btn_RollDice.UseVisualStyleBackColor = true;
            this.Btn_RollDice.Click += new System.EventHandler(this.Btn_RollDice_Click);
            // 
            // Lbl_DisplayResults
            // 
            this.Lbl_DisplayResults.AutoSize = true;
            this.Lbl_DisplayResults.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DisplayResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_DisplayResults.Location = new System.Drawing.Point(12, 118);
            this.Lbl_DisplayResults.Name = "Lbl_DisplayResults";
            this.Lbl_DisplayResults.Size = new System.Drawing.Size(0, 29);
            this.Lbl_DisplayResults.TabIndex = 4;
            // 
            // FrmDiceGameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 156);
            this.Controls.Add(this.Lbl_DisplayResults);
            this.Controls.Add(this.Btn_RollDice);
            this.Controls.Add(this.Lbl_TwoDice);
            this.Controls.Add(this.Lbl_OneDice);
            this.Controls.Add(this.Mnu_Strip);
            this.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.Mnu_Strip;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "FrmDiceGameGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dice Game GUI";
            this.Load += new System.EventHandler(this.FrmDiceGameGUI_Load);
            this.Mnu_Strip.ResumeLayout(false);
            this.Mnu_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Strip;
        private System.Windows.Forms.ToolStripMenuItem Mnu_About;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Exit;
        private System.Windows.Forms.Label Lbl_OneDice;
        private System.Windows.Forms.Label Lbl_TwoDice;
        private System.Windows.Forms.Button Btn_RollDice;
        private System.Windows.Forms.Label Lbl_DisplayResults;
    }
}

