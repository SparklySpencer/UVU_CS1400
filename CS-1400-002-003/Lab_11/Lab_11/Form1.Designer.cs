namespace Lab_11
{
    partial class Frm_TokenGiver
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
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Quarters = new System.Windows.Forms.Label();
            this.Lbl_Dispensed = new System.Windows.Forms.Label();
            this.Lbl_Remaining = new System.Windows.Forms.Label();
            this.TxtBx_Bills = new System.Windows.Forms.TextBox();
            this.TxtBx_Quarters = new System.Windows.Forms.TextBox();
            this.TxtBx_Dispense = new System.Windows.Forms.TextBox();
            this.TxtBx_Remainder = new System.Windows.Forms.TextBox();
            this.Btn_GetTokens = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Lbl_MoneyStored = new System.Windows.Forms.Label();
            this.TxtBx_MoneyStored = new System.Windows.Forms.TextBox();
            this.Lbl_Bills = new System.Windows.Forms.Label();
            this.Lbl_ChangeDispense = new System.Windows.Forms.Label();
            this.TxtBx_Change = new System.Windows.Forms.TextBox();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout,
            this.MnuInstructions,
            this.MnuReset,
            this.MnuExit});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(644, 24);
            this.MnuStrip.TabIndex = 0;
            this.MnuStrip.Text = "MnuStrip";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(52, 20);
            this.MnuAbout.Text = "About";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // MnuInstructions
            // 
            this.MnuInstructions.Name = "MnuInstructions";
            this.MnuInstructions.Size = new System.Drawing.Size(81, 20);
            this.MnuInstructions.Text = "Instructions";
            this.MnuInstructions.Click += new System.EventHandler(this.MnuInstructions_Click);
            // 
            // MnuReset
            // 
            this.MnuReset.Name = "MnuReset";
            this.MnuReset.Size = new System.Drawing.Size(47, 20);
            this.MnuReset.Text = "Reset";
            this.MnuReset.Click += new System.EventHandler(this.MnuReset_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // Lbl_Quarters
            // 
            this.Lbl_Quarters.AutoSize = true;
            this.Lbl_Quarters.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Quarters.Location = new System.Drawing.Point(63, 109);
            this.Lbl_Quarters.Name = "Lbl_Quarters";
            this.Lbl_Quarters.Size = new System.Drawing.Size(153, 32);
            this.Lbl_Quarters.TabIndex = 2;
            this.Lbl_Quarters.Text = "Quarter Slot:";
            // 
            // Lbl_Dispensed
            // 
            this.Lbl_Dispensed.AutoSize = true;
            this.Lbl_Dispensed.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dispensed.Location = new System.Drawing.Point(15, 197);
            this.Lbl_Dispensed.Name = "Lbl_Dispensed";
            this.Lbl_Dispensed.Size = new System.Drawing.Size(212, 32);
            this.Lbl_Dispensed.TabIndex = 3;
            this.Lbl_Dispensed.Text = "Tokens Dispensed:";
            // 
            // Lbl_Remaining
            // 
            this.Lbl_Remaining.AutoSize = true;
            this.Lbl_Remaining.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Remaining.Location = new System.Drawing.Point(12, 325);
            this.Lbl_Remaining.Name = "Lbl_Remaining";
            this.Lbl_Remaining.Size = new System.Drawing.Size(215, 32);
            this.Lbl_Remaining.TabIndex = 4;
            this.Lbl_Remaining.Text = "Tokens Remaining:";
            // 
            // TxtBx_Bills
            // 
            this.TxtBx_Bills.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBx_Bills.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Bills.Location = new System.Drawing.Point(233, 63);
            this.TxtBx_Bills.Name = "TxtBx_Bills";
            this.TxtBx_Bills.ReadOnly = true;
            this.TxtBx_Bills.Size = new System.Drawing.Size(399, 36);
            this.TxtBx_Bills.TabIndex = 5;
            this.TxtBx_Bills.Text = "Not Yet Available, Sorry";
            this.TxtBx_Bills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBx_Quarters
            // 
            this.TxtBx_Quarters.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Quarters.Location = new System.Drawing.Point(233, 105);
            this.TxtBx_Quarters.Name = "TxtBx_Quarters";
            this.TxtBx_Quarters.ReadOnly = true;
            this.TxtBx_Quarters.Size = new System.Drawing.Size(399, 36);
            this.TxtBx_Quarters.TabIndex = 6;
            this.TxtBx_Quarters.Text = "Not Yet Available, Sorry";
            this.TxtBx_Quarters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBx_Dispense
            // 
            this.TxtBx_Dispense.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Dispense.Location = new System.Drawing.Point(233, 193);
            this.TxtBx_Dispense.Name = "TxtBx_Dispense";
            this.TxtBx_Dispense.ReadOnly = true;
            this.TxtBx_Dispense.Size = new System.Drawing.Size(399, 36);
            this.TxtBx_Dispense.TabIndex = 7;
            this.TxtBx_Dispense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBx_Remainder
            // 
            this.TxtBx_Remainder.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Remainder.Location = new System.Drawing.Point(236, 321);
            this.TxtBx_Remainder.Name = "TxtBx_Remainder";
            this.TxtBx_Remainder.ReadOnly = true;
            this.TxtBx_Remainder.Size = new System.Drawing.Size(399, 36);
            this.TxtBx_Remainder.TabIndex = 8;
            this.TxtBx_Remainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_GetTokens
            // 
            this.Btn_GetTokens.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetTokens.Location = new System.Drawing.Point(233, 147);
            this.Btn_GetTokens.Name = "Btn_GetTokens";
            this.Btn_GetTokens.Size = new System.Drawing.Size(145, 38);
            this.Btn_GetTokens.TabIndex = 9;
            this.Btn_GetTokens.Text = "Get Tokens";
            this.Btn_GetTokens.UseVisualStyleBackColor = true;
            this.Btn_GetTokens.Click += new System.EventHandler(this.Btn_GetTokens_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(233, 277);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(145, 38);
            this.Btn_Reset.TabIndex = 10;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click_1);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(236, 405);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(145, 38);
            this.Btn_Exit.TabIndex = 11;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lbl_MoneyStored
            // 
            this.Lbl_MoneyStored.AutoSize = true;
            this.Lbl_MoneyStored.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MoneyStored.Location = new System.Drawing.Point(10, 367);
            this.Lbl_MoneyStored.Name = "Lbl_MoneyStored";
            this.Lbl_MoneyStored.Size = new System.Drawing.Size(217, 32);
            this.Lbl_MoneyStored.TabIndex = 12;
            this.Lbl_MoneyStored.Text = "Money in Machine:";
            // 
            // TxtBx_MoneyStored
            // 
            this.TxtBx_MoneyStored.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_MoneyStored.Location = new System.Drawing.Point(236, 363);
            this.TxtBx_MoneyStored.Name = "TxtBx_MoneyStored";
            this.TxtBx_MoneyStored.ReadOnly = true;
            this.TxtBx_MoneyStored.Size = new System.Drawing.Size(399, 36);
            this.TxtBx_MoneyStored.TabIndex = 13;
            this.TxtBx_MoneyStored.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Bills
            // 
            this.Lbl_Bills.AutoSize = true;
            this.Lbl_Bills.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bills.Location = new System.Drawing.Point(15, 67);
            this.Lbl_Bills.Name = "Lbl_Bills";
            this.Lbl_Bills.Size = new System.Drawing.Size(212, 32);
            this.Lbl_Bills.TabIndex = 1;
            this.Lbl_Bills.Text = "Dollar Bill Reader:";
            // 
            // Lbl_ChangeDispense
            // 
            this.Lbl_ChangeDispense.AutoSize = true;
            this.Lbl_ChangeDispense.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ChangeDispense.Location = new System.Drawing.Point(13, 239);
            this.Lbl_ChangeDispense.Name = "Lbl_ChangeDispense";
            this.Lbl_ChangeDispense.Size = new System.Drawing.Size(214, 32);
            this.Lbl_ChangeDispense.TabIndex = 14;
            this.Lbl_ChangeDispense.Text = "Change Dispensed:";
            // 
            // TxtBx_Change
            // 
            this.TxtBx_Change.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Change.Location = new System.Drawing.Point(233, 235);
            this.TxtBx_Change.Name = "TxtBx_Change";
            this.TxtBx_Change.ReadOnly = true;
            this.TxtBx_Change.Size = new System.Drawing.Size(399, 36);
            this.TxtBx_Change.TabIndex = 15;
            this.TxtBx_Change.Text = "Not Yet Available, Sorry";
            this.TxtBx_Change.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_TokenGiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 462);
            this.Controls.Add(this.TxtBx_Change);
            this.Controls.Add(this.Lbl_ChangeDispense);
            this.Controls.Add(this.TxtBx_MoneyStored);
            this.Controls.Add(this.Lbl_MoneyStored);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_GetTokens);
            this.Controls.Add(this.TxtBx_Remainder);
            this.Controls.Add(this.TxtBx_Dispense);
            this.Controls.Add(this.TxtBx_Quarters);
            this.Controls.Add(this.TxtBx_Bills);
            this.Controls.Add(this.Lbl_Remaining);
            this.Controls.Add(this.Lbl_Dispensed);
            this.Controls.Add(this.Lbl_Quarters);
            this.Controls.Add(this.Lbl_Bills);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "Frm_TokenGiver";
            this.Text = "Token Giver";
            this.Load += new System.EventHandler(this.Frm_TokenGiver_Load);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuInstructions;
        private System.Windows.Forms.ToolStripMenuItem MnuReset;
        private System.Windows.Forms.Label Lbl_Quarters;
        private System.Windows.Forms.Label Lbl_Dispensed;
        private System.Windows.Forms.Label Lbl_Remaining;
        private System.Windows.Forms.TextBox TxtBx_Bills;
        private System.Windows.Forms.TextBox TxtBx_Quarters;
        private System.Windows.Forms.TextBox TxtBx_Dispense;
        private System.Windows.Forms.TextBox TxtBx_Remainder;
        private System.Windows.Forms.Button Btn_GetTokens;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lbl_MoneyStored;
        private System.Windows.Forms.TextBox TxtBx_MoneyStored;
        private System.Windows.Forms.Label Lbl_Bills;
        private System.Windows.Forms.Label Lbl_ChangeDispense;
        private System.Windows.Forms.TextBox TxtBx_Change;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
    }
}

