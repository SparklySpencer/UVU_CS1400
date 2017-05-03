namespace Project_04
{
    partial class FrmSalesInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesInvoice));
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_ItemName = new System.Windows.Forms.Label();
            this.Lbl_Quantity = new System.Windows.Forms.Label();
            this.Lbl_UnitPrice = new System.Windows.Forms.Label();
            this.TxtBx_ItemDescription = new System.Windows.Forms.TextBox();
            this.TxtBx_Quantity = new System.Windows.Forms.TextBox();
            this.TxtBx_UnitPrice = new System.Windows.Forms.TextBox();
            this.Btn_Buy = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.PBox_StoreGraphic = new System.Windows.Forms.PictureBox();
            this.ErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBox_StoreGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout,
            this.MnuReset,
            this.MnuExit});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(645, 24);
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
            // Lbl_ItemName
            // 
            this.Lbl_ItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ItemName.AutoSize = true;
            this.Lbl_ItemName.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ItemName.Location = new System.Drawing.Point(12, 53);
            this.Lbl_ItemName.Name = "Lbl_ItemName";
            this.Lbl_ItemName.Size = new System.Drawing.Size(143, 25);
            this.Lbl_ItemName.TabIndex = 1;
            this.Lbl_ItemName.Text = "Item Description:";
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Quantity.AutoSize = true;
            this.Lbl_Quantity.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Quantity.Location = new System.Drawing.Point(70, 112);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(86, 25);
            this.Lbl_Quantity.TabIndex = 2;
            this.Lbl_Quantity.Text = "Quantity:";
            // 
            // Lbl_UnitPrice
            // 
            this.Lbl_UnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_UnitPrice.AutoSize = true;
            this.Lbl_UnitPrice.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UnitPrice.Location = new System.Drawing.Point(58, 169);
            this.Lbl_UnitPrice.Name = "Lbl_UnitPrice";
            this.Lbl_UnitPrice.Size = new System.Drawing.Size(97, 25);
            this.Lbl_UnitPrice.TabIndex = 3;
            this.Lbl_UnitPrice.Text = "Unit Price:";
            // 
            // TxtBx_ItemDescription
            // 
            this.TxtBx_ItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBx_ItemDescription.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_ItemDescription.Location = new System.Drawing.Point(161, 50);
            this.TxtBx_ItemDescription.Name = "TxtBx_ItemDescription";
            this.TxtBx_ItemDescription.Size = new System.Drawing.Size(453, 31);
            this.TxtBx_ItemDescription.TabIndex = 4;
            this.TxtBx_ItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBx_ItemDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_ItemDescription_KeyPress);
            // 
            // TxtBx_Quantity
            // 
            this.TxtBx_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBx_Quantity.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Quantity.Location = new System.Drawing.Point(161, 109);
            this.TxtBx_Quantity.Name = "TxtBx_Quantity";
            this.TxtBx_Quantity.Size = new System.Drawing.Size(453, 31);
            this.TxtBx_Quantity.TabIndex = 5;
            this.TxtBx_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBx_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_Quantity_KeyPress);
            // 
            // TxtBx_UnitPrice
            // 
            this.TxtBx_UnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBx_UnitPrice.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_UnitPrice.Location = new System.Drawing.Point(161, 166);
            this.TxtBx_UnitPrice.Name = "TxtBx_UnitPrice";
            this.TxtBx_UnitPrice.Size = new System.Drawing.Size(453, 31);
            this.TxtBx_UnitPrice.TabIndex = 6;
            this.TxtBx_UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBx_UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_UnitPrice_KeyPress);
            // 
            // Btn_Buy
            // 
            this.Btn_Buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Buy.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buy.Location = new System.Drawing.Point(158, 203);
            this.Btn_Buy.Name = "Btn_Buy";
            this.Btn_Buy.Size = new System.Drawing.Size(91, 32);
            this.Btn_Buy.TabIndex = 7;
            this.Btn_Buy.Text = "Buy";
            this.Btn_Buy.UseVisualStyleBackColor = true;
            this.Btn_Buy.Click += new System.EventHandler(this.Btn_Buy_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Reset.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Btn_Reset.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(255, 203);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(91, 32);
            this.Btn_Reset.TabIndex = 8;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Exit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(352, 203);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(91, 32);
            this.Btn_Exit.TabIndex = 9;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // PBox_StoreGraphic
            // 
            this.PBox_StoreGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBox_StoreGraphic.Image = ((System.Drawing.Image)(resources.GetObject("PBox_StoreGraphic.Image")));
            this.PBox_StoreGraphic.Location = new System.Drawing.Point(17, 241);
            this.PBox_StoreGraphic.Name = "PBox_StoreGraphic";
            this.PBox_StoreGraphic.Size = new System.Drawing.Size(597, 181);
            this.PBox_StoreGraphic.TabIndex = 11;
            this.PBox_StoreGraphic.TabStop = false;
            // 
            // ErrProvider
            // 
            this.ErrProvider.ContainerControl = this;
            // 
            // FrmSalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 436);
            this.Controls.Add(this.TxtBx_Quantity);
            this.Controls.Add(this.PBox_StoreGraphic);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_Buy);
            this.Controls.Add(this.TxtBx_UnitPrice);
            this.Controls.Add(this.TxtBx_ItemDescription);
            this.Controls.Add(this.Lbl_UnitPrice);
            this.Controls.Add(this.Lbl_Quantity);
            this.Controls.Add(this.Lbl_ItemName);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmSalesInvoice";
            this.Text = "Sales Invoice Calculator";
            this.Load += new System.EventHandler(this.FrmSalesInvoice_Load);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBox_StoreGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuReset;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.Label Lbl_ItemName;
        private System.Windows.Forms.Label Lbl_Quantity;
        private System.Windows.Forms.Label Lbl_UnitPrice;
        private System.Windows.Forms.TextBox TxtBx_ItemDescription;
        private System.Windows.Forms.TextBox TxtBx_Quantity;
        private System.Windows.Forms.TextBox TxtBx_UnitPrice;
        private System.Windows.Forms.Button Btn_Buy;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.PictureBox PBox_StoreGraphic;
        private System.Windows.Forms.ErrorProvider ErrProvider;
    }
}

