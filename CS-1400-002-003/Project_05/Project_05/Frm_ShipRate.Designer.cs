namespace Project_05
{
    partial class Frm_ShipRate
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
            this.components = new System.ComponentModel.Container();
            this.Mnu_Strip = new System.Windows.Forms.MenuStrip();
            this.Mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpBx_How = new System.Windows.Forms.GroupBox();
            this.RBtn_SameDay = new System.Windows.Forms.RadioButton();
            this.RBtn_Express = new System.Windows.Forms.RadioButton();
            this.RBtn_Standard = new System.Windows.Forms.RadioButton();
            this.GrpBx_Where = new System.Windows.Forms.GroupBox();
            this.Lbl_Hawaii = new System.Windows.Forms.Label();
            this.Lbl_Alaska = new System.Windows.Forms.Label();
            this.RBtn_Hawaii = new System.Windows.Forms.RadioButton();
            this.RBtn_Alaska = new System.Windows.Forms.RadioButton();
            this.RBtn_Continental = new System.Windows.Forms.RadioButton();
            this.GrpBx_What = new System.Windows.Forms.GroupBox();
            this.Lbl_PerPound = new System.Windows.Forms.Label();
            this.Lbl_PerItem = new System.Windows.Forms.Label();
            this.TxtBx_PerPound = new System.Windows.Forms.TextBox();
            this.TxtBx_PerItem = new System.Windows.Forms.TextBox();
            this.RBtn_PerPound = new System.Windows.Forms.RadioButton();
            this.RBtn_PerItem = new System.Windows.Forms.RadioButton();
            this.Lbl_PleasePay = new System.Windows.Forms.Label();
            this.Err_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_Process = new System.Windows.Forms.Button();
            this.Mnu_Strip.SuspendLayout();
            this.GrpBx_How.SuspendLayout();
            this.GrpBx_Where.SuspendLayout();
            this.GrpBx_What.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // Mnu_Strip
            // 
            this.Mnu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_About,
            this.Mnu_Exit});
            this.Mnu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Strip.Name = "Mnu_Strip";
            this.Mnu_Strip.Size = new System.Drawing.Size(427, 24);
            this.Mnu_Strip.TabIndex = 0;
            this.Mnu_Strip.Text = "menuStrip1";
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
            // GrpBx_How
            // 
            this.GrpBx_How.Controls.Add(this.RBtn_SameDay);
            this.GrpBx_How.Controls.Add(this.RBtn_Express);
            this.GrpBx_How.Controls.Add(this.RBtn_Standard);
            this.GrpBx_How.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBx_How.Location = new System.Drawing.Point(12, 27);
            this.GrpBx_How.Name = "GrpBx_How";
            this.GrpBx_How.Size = new System.Drawing.Size(361, 113);
            this.GrpBx_How.TabIndex = 1;
            this.GrpBx_How.TabStop = false;
            this.GrpBx_How.Text = "Step 1: Select a shipping method.";
            // 
            // RBtn_SameDay
            // 
            this.RBtn_SameDay.AutoSize = true;
            this.RBtn_SameDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_SameDay.Location = new System.Drawing.Point(6, 79);
            this.RBtn_SameDay.Name = "RBtn_SameDay";
            this.RBtn_SameDay.Size = new System.Drawing.Size(167, 24);
            this.RBtn_SameDay.TabIndex = 2;
            this.RBtn_SameDay.TabStop = true;
            this.RBtn_SameDay.Text = "Same Day Shipping";
            this.RBtn_SameDay.UseVisualStyleBackColor = true;
            this.RBtn_SameDay.CheckedChanged += new System.EventHandler(this.RBtn_SameDay_CheckedChanged);
            // 
            // RBtn_Express
            // 
            this.RBtn_Express.AutoSize = true;
            this.RBtn_Express.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_Express.Location = new System.Drawing.Point(6, 49);
            this.RBtn_Express.Name = "RBtn_Express";
            this.RBtn_Express.Size = new System.Drawing.Size(144, 24);
            this.RBtn_Express.TabIndex = 1;
            this.RBtn_Express.TabStop = true;
            this.RBtn_Express.Text = "Express (2 days)";
            this.RBtn_Express.UseVisualStyleBackColor = true;
            this.RBtn_Express.CheckedChanged += new System.EventHandler(this.RBtn_Express_CheckedChanged);
            // 
            // RBtn_Standard
            // 
            this.RBtn_Standard.AutoSize = true;
            this.RBtn_Standard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_Standard.Location = new System.Drawing.Point(6, 19);
            this.RBtn_Standard.Name = "RBtn_Standard";
            this.RBtn_Standard.Size = new System.Drawing.Size(167, 24);
            this.RBtn_Standard.TabIndex = 0;
            this.RBtn_Standard.TabStop = true;
            this.RBtn_Standard.Text = "Standard (3-5 days)";
            this.RBtn_Standard.UseVisualStyleBackColor = true;
            this.RBtn_Standard.CheckedChanged += new System.EventHandler(this.RBtn_Standard_CheckedChanged);
            // 
            // GrpBx_Where
            // 
            this.GrpBx_Where.Controls.Add(this.Lbl_Hawaii);
            this.GrpBx_Where.Controls.Add(this.Lbl_Alaska);
            this.GrpBx_Where.Controls.Add(this.RBtn_Hawaii);
            this.GrpBx_Where.Controls.Add(this.RBtn_Alaska);
            this.GrpBx_Where.Controls.Add(this.RBtn_Continental);
            this.GrpBx_Where.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBx_Where.Location = new System.Drawing.Point(12, 146);
            this.GrpBx_Where.Name = "GrpBx_Where";
            this.GrpBx_Where.Size = new System.Drawing.Size(361, 113);
            this.GrpBx_Where.TabIndex = 2;
            this.GrpBx_Where.TabStop = false;
            this.GrpBx_Where.Text = "Step 2: Select where your package is going.";
            // 
            // Lbl_Hawaii
            // 
            this.Lbl_Hawaii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Hawaii.AutoSize = true;
            this.Lbl_Hawaii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hawaii.Location = new System.Drawing.Point(90, 81);
            this.Lbl_Hawaii.Name = "Lbl_Hawaii";
            this.Lbl_Hawaii.Size = new System.Drawing.Size(83, 20);
            this.Lbl_Hawaii.TabIndex = 9;
            this.Lbl_Hawaii.Text = "Surcharge";
            // 
            // Lbl_Alaska
            // 
            this.Lbl_Alaska.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Alaska.AutoSize = true;
            this.Lbl_Alaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Alaska.Location = new System.Drawing.Point(91, 51);
            this.Lbl_Alaska.Name = "Lbl_Alaska";
            this.Lbl_Alaska.Size = new System.Drawing.Size(83, 20);
            this.Lbl_Alaska.TabIndex = 8;
            this.Lbl_Alaska.Text = "Surcharge";
            // 
            // RBtn_Hawaii
            // 
            this.RBtn_Hawaii.AutoSize = true;
            this.RBtn_Hawaii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_Hawaii.Location = new System.Drawing.Point(6, 79);
            this.RBtn_Hawaii.Name = "RBtn_Hawaii";
            this.RBtn_Hawaii.Size = new System.Drawing.Size(78, 24);
            this.RBtn_Hawaii.TabIndex = 2;
            this.RBtn_Hawaii.TabStop = true;
            this.RBtn_Hawaii.Text = "Hawaii:";
            this.RBtn_Hawaii.UseVisualStyleBackColor = true;
            this.RBtn_Hawaii.CheckedChanged += new System.EventHandler(this.RBtn_Hawaii_CheckedChanged);
            // 
            // RBtn_Alaska
            // 
            this.RBtn_Alaska.AutoSize = true;
            this.RBtn_Alaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_Alaska.Location = new System.Drawing.Point(6, 49);
            this.RBtn_Alaska.Name = "RBtn_Alaska";
            this.RBtn_Alaska.Size = new System.Drawing.Size(79, 24);
            this.RBtn_Alaska.TabIndex = 1;
            this.RBtn_Alaska.TabStop = true;
            this.RBtn_Alaska.Text = "Alaska:";
            this.RBtn_Alaska.UseVisualStyleBackColor = true;
            this.RBtn_Alaska.CheckedChanged += new System.EventHandler(this.RBtn_Alaska_CheckedChanged);
            // 
            // RBtn_Continental
            // 
            this.RBtn_Continental.AutoSize = true;
            this.RBtn_Continental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_Continental.Location = new System.Drawing.Point(6, 19);
            this.RBtn_Continental.Name = "RBtn_Continental";
            this.RBtn_Continental.Size = new System.Drawing.Size(146, 24);
            this.RBtn_Continental.TabIndex = 0;
            this.RBtn_Continental.TabStop = true;
            this.RBtn_Continental.Text = "Continental USA";
            this.RBtn_Continental.UseVisualStyleBackColor = true;
            this.RBtn_Continental.CheckedChanged += new System.EventHandler(this.RBtn_Continental_CheckedChanged);
            // 
            // GrpBx_What
            // 
            this.GrpBx_What.Controls.Add(this.Lbl_PerPound);
            this.GrpBx_What.Controls.Add(this.Lbl_PerItem);
            this.GrpBx_What.Controls.Add(this.TxtBx_PerPound);
            this.GrpBx_What.Controls.Add(this.TxtBx_PerItem);
            this.GrpBx_What.Controls.Add(this.RBtn_PerPound);
            this.GrpBx_What.Controls.Add(this.RBtn_PerItem);
            this.GrpBx_What.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBx_What.Location = new System.Drawing.Point(12, 265);
            this.GrpBx_What.Name = "GrpBx_What";
            this.GrpBx_What.Size = new System.Drawing.Size(361, 152);
            this.GrpBx_What.TabIndex = 3;
            this.GrpBx_What.TabStop = false;
            this.GrpBx_What.Text = "Step 3: Select the catagory of shipping.";
            // 
            // Lbl_PerPound
            // 
            this.Lbl_PerPound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_PerPound.AutoSize = true;
            this.Lbl_PerPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PerPound.Location = new System.Drawing.Point(122, 83);
            this.Lbl_PerPound.Name = "Lbl_PerPound";
            this.Lbl_PerPound.Size = new System.Drawing.Size(95, 20);
            this.Lbl_PerPound.TabIndex = 10;
            this.Lbl_PerPound.Text = "$ per Pound";
            // 
            // Lbl_PerItem
            // 
            this.Lbl_PerItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_PerItem.AutoSize = true;
            this.Lbl_PerItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PerItem.Location = new System.Drawing.Point(122, 21);
            this.Lbl_PerItem.Name = "Lbl_PerItem";
            this.Lbl_PerItem.Size = new System.Drawing.Size(81, 20);
            this.Lbl_PerItem.TabIndex = 9;
            this.Lbl_PerItem.Text = "$ per Item";
            // 
            // TxtBx_PerPound
            // 
            this.TxtBx_PerPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_PerPound.Location = new System.Drawing.Point(6, 111);
            this.TxtBx_PerPound.Name = "TxtBx_PerPound";
            this.TxtBx_PerPound.Size = new System.Drawing.Size(211, 26);
            this.TxtBx_PerPound.TabIndex = 6;
            this.TxtBx_PerPound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_PerPound_KeyPress);
            // 
            // TxtBx_PerItem
            // 
            this.TxtBx_PerItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_PerItem.Location = new System.Drawing.Point(6, 49);
            this.TxtBx_PerItem.Name = "TxtBx_PerItem";
            this.TxtBx_PerItem.Size = new System.Drawing.Size(211, 26);
            this.TxtBx_PerItem.TabIndex = 5;
            this.TxtBx_PerItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_PerItem_KeyPress);
            // 
            // RBtn_PerPound
            // 
            this.RBtn_PerPound.AutoSize = true;
            this.RBtn_PerPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_PerPound.Location = new System.Drawing.Point(6, 81);
            this.RBtn_PerPound.Name = "RBtn_PerPound";
            this.RBtn_PerPound.Size = new System.Drawing.Size(110, 24);
            this.RBtn_PerPound.TabIndex = 4;
            this.RBtn_PerPound.TabStop = true;
            this.RBtn_PerPound.Text = "Category B:";
            this.RBtn_PerPound.UseVisualStyleBackColor = true;
            this.RBtn_PerPound.CheckedChanged += new System.EventHandler(this.RBtn_PerPound_CheckedChanged);
            // 
            // RBtn_PerItem
            // 
            this.RBtn_PerItem.AutoSize = true;
            this.RBtn_PerItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_PerItem.Location = new System.Drawing.Point(6, 19);
            this.RBtn_PerItem.Name = "RBtn_PerItem";
            this.RBtn_PerItem.Size = new System.Drawing.Size(110, 24);
            this.RBtn_PerItem.TabIndex = 3;
            this.RBtn_PerItem.TabStop = true;
            this.RBtn_PerItem.Text = "Category A:";
            this.RBtn_PerItem.UseVisualStyleBackColor = true;
            this.RBtn_PerItem.CheckedChanged += new System.EventHandler(this.RBtn_PerItem_CheckedChanged);
            // 
            // Lbl_PleasePay
            // 
            this.Lbl_PleasePay.AutoSize = true;
            this.Lbl_PleasePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PleasePay.Location = new System.Drawing.Point(134, 429);
            this.Lbl_PleasePay.Name = "Lbl_PleasePay";
            this.Lbl_PleasePay.Size = new System.Drawing.Size(204, 25);
            this.Lbl_PleasePay.TabIndex = 7;
            this.Lbl_PleasePay.Text = "Please Pay: $0.00";
            // 
            // Err_Provider
            // 
            this.Err_Provider.ContainerControl = this;
            // 
            // Btn_Process
            // 
            this.Btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Process.Location = new System.Drawing.Point(12, 425);
            this.Btn_Process.Name = "Btn_Process";
            this.Btn_Process.Size = new System.Drawing.Size(116, 33);
            this.Btn_Process.TabIndex = 8;
            this.Btn_Process.Text = "Process";
            this.Btn_Process.UseVisualStyleBackColor = true;
            this.Btn_Process.Click += new System.EventHandler(this.Btn_Process_Click);
            // 
            // Frm_ShipRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 463);
            this.Controls.Add(this.Btn_Process);
            this.Controls.Add(this.Lbl_PleasePay);
            this.Controls.Add(this.GrpBx_What);
            this.Controls.Add(this.GrpBx_Where);
            this.Controls.Add(this.GrpBx_How);
            this.Controls.Add(this.Mnu_Strip);
            this.MainMenuStrip = this.Mnu_Strip;
            this.Name = "Frm_ShipRate";
            this.Text = "Red Fern Electronics Shipping Rates ";
            this.Load += new System.EventHandler(this.Frm_ShipRate_Load);
            this.Mnu_Strip.ResumeLayout(false);
            this.Mnu_Strip.PerformLayout();
            this.GrpBx_How.ResumeLayout(false);
            this.GrpBx_How.PerformLayout();
            this.GrpBx_Where.ResumeLayout(false);
            this.GrpBx_Where.PerformLayout();
            this.GrpBx_What.ResumeLayout(false);
            this.GrpBx_What.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Strip;
        private System.Windows.Forms.ToolStripMenuItem Mnu_About;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Exit;
        private System.Windows.Forms.GroupBox GrpBx_How;
        private System.Windows.Forms.RadioButton RBtn_SameDay;
        private System.Windows.Forms.RadioButton RBtn_Express;
        private System.Windows.Forms.RadioButton RBtn_Standard;
        private System.Windows.Forms.GroupBox GrpBx_Where;
        private System.Windows.Forms.Label Lbl_Hawaii;
        private System.Windows.Forms.Label Lbl_Alaska;
        private System.Windows.Forms.RadioButton RBtn_Hawaii;
        private System.Windows.Forms.RadioButton RBtn_Alaska;
        private System.Windows.Forms.RadioButton RBtn_Continental;
        private System.Windows.Forms.GroupBox GrpBx_What;
        private System.Windows.Forms.Label Lbl_PerPound;
        private System.Windows.Forms.Label Lbl_PerItem;
        private System.Windows.Forms.TextBox TxtBx_PerPound;
        private System.Windows.Forms.TextBox TxtBx_PerItem;
        private System.Windows.Forms.RadioButton RBtn_PerPound;
        private System.Windows.Forms.RadioButton RBtn_PerItem;
        private System.Windows.Forms.Label Lbl_PleasePay;
        private System.Windows.Forms.ErrorProvider Err_Provider;
        private System.Windows.Forms.Button Btn_Process;
    }
}

