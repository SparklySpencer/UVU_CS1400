namespace Lab_14
{
    partial class Frm_ShippingRates
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
            this.GrpBx_RadBtn_ShipMethods = new System.Windows.Forms.GroupBox();
            this.RadBtn_Standard = new System.Windows.Forms.RadioButton();
            this.RadBtn_Express = new System.Windows.Forms.RadioButton();
            this.RadBtn_SameDay = new System.Windows.Forms.RadioButton();
            this.Mnu_Strip = new System.Windows.Forms.MenuStrip();
            this.Mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ComBx_Rates = new System.Windows.Forms.ComboBox();
            this.GrpBx_RadBtn_ShipMethods.SuspendLayout();
            this.Mnu_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBx_RadBtn_ShipMethods
            // 
            this.GrpBx_RadBtn_ShipMethods.Controls.Add(this.RadBtn_Standard);
            this.GrpBx_RadBtn_ShipMethods.Controls.Add(this.RadBtn_Express);
            this.GrpBx_RadBtn_ShipMethods.Controls.Add(this.RadBtn_SameDay);
            this.GrpBx_RadBtn_ShipMethods.Location = new System.Drawing.Point(290, 27);
            this.GrpBx_RadBtn_ShipMethods.Name = "GrpBx_RadBtn_ShipMethods";
            this.GrpBx_RadBtn_ShipMethods.Size = new System.Drawing.Size(200, 135);
            this.GrpBx_RadBtn_ShipMethods.TabIndex = 0;
            this.GrpBx_RadBtn_ShipMethods.TabStop = false;
            this.GrpBx_RadBtn_ShipMethods.Text = "Shipping Methods";
            // 
            // RadBtn_Standard
            // 
            this.RadBtn_Standard.AutoSize = true;
            this.RadBtn_Standard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtn_Standard.Location = new System.Drawing.Point(6, 101);
            this.RadBtn_Standard.Name = "RadBtn_Standard";
            this.RadBtn_Standard.Size = new System.Drawing.Size(103, 28);
            this.RadBtn_Standard.TabIndex = 2;
            this.RadBtn_Standard.TabStop = true;
            this.RadBtn_Standard.Text = "Standard";
            this.RadBtn_Standard.UseVisualStyleBackColor = true;
            this.RadBtn_Standard.CheckedChanged += new System.EventHandler(this.RadBtn_Standard_CheckedChanged);
            // 
            // RadBtn_Express
            // 
            this.RadBtn_Express.AutoSize = true;
            this.RadBtn_Express.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtn_Express.Location = new System.Drawing.Point(6, 67);
            this.RadBtn_Express.Name = "RadBtn_Express";
            this.RadBtn_Express.Size = new System.Drawing.Size(97, 28);
            this.RadBtn_Express.TabIndex = 1;
            this.RadBtn_Express.TabStop = true;
            this.RadBtn_Express.Text = "Express";
            this.RadBtn_Express.UseVisualStyleBackColor = true;
            this.RadBtn_Express.CheckedChanged += new System.EventHandler(this.RadBtn_Express_CheckedChanged);
            // 
            // RadBtn_SameDay
            // 
            this.RadBtn_SameDay.AutoSize = true;
            this.RadBtn_SameDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtn_SameDay.Location = new System.Drawing.Point(6, 33);
            this.RadBtn_SameDay.Name = "RadBtn_SameDay";
            this.RadBtn_SameDay.Size = new System.Drawing.Size(114, 28);
            this.RadBtn_SameDay.TabIndex = 0;
            this.RadBtn_SameDay.TabStop = true;
            this.RadBtn_SameDay.Text = "Same Day";
            this.RadBtn_SameDay.UseVisualStyleBackColor = true;
            this.RadBtn_SameDay.CheckedChanged += new System.EventHandler(this.RadBtn_SameDay_CheckedChanged);
            // 
            // Mnu_Strip
            // 
            this.Mnu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_About,
            this.Mnu_Exit});
            this.Mnu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Strip.Name = "Mnu_Strip";
            this.Mnu_Strip.Size = new System.Drawing.Size(502, 24);
            this.Mnu_Strip.TabIndex = 1;
            this.Mnu_Strip.Text = "Mnu_Strip";
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
            // ComBx_Rates
            // 
            this.ComBx_Rates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBx_Rates.FormattingEnabled = true;
            this.ComBx_Rates.Items.AddRange(new object[] {
            "Same Day Shipping - $12.50",
            "Express Shipping - $10.25",
            "Standard Shipping -$05.15"});
            this.ComBx_Rates.Location = new System.Drawing.Point(12, 39);
            this.ComBx_Rates.Name = "ComBx_Rates";
            this.ComBx_Rates.Size = new System.Drawing.Size(272, 32);
            this.ComBx_Rates.TabIndex = 0;
            this.ComBx_Rates.Text = "Click to Select";
            this.ComBx_Rates.SelectedIndexChanged += new System.EventHandler(this.ComBx_Rates_SelectedIndexChanged);
            // 
            // Frm_ShippingRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 195);
            this.Controls.Add(this.ComBx_Rates);
            this.Controls.Add(this.GrpBx_RadBtn_ShipMethods);
            this.Controls.Add(this.Mnu_Strip);
            this.MainMenuStrip = this.Mnu_Strip;
            this.Name = "Frm_ShippingRates";
            this.Text = "Shipping Rates";
            this.GrpBx_RadBtn_ShipMethods.ResumeLayout(false);
            this.GrpBx_RadBtn_ShipMethods.PerformLayout();
            this.Mnu_Strip.ResumeLayout(false);
            this.Mnu_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBx_RadBtn_ShipMethods;
        private System.Windows.Forms.RadioButton RadBtn_Standard;
        private System.Windows.Forms.RadioButton RadBtn_Express;
        private System.Windows.Forms.RadioButton RadBtn_SameDay;
        private System.Windows.Forms.MenuStrip Mnu_Strip;
        private System.Windows.Forms.ToolStripMenuItem Mnu_About;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Exit;
        private System.Windows.Forms.ComboBox ComBx_Rates;
    }
}

