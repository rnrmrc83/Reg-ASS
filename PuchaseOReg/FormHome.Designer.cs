namespace ShopReg
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculatePurchasePrice = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewListCalculatedPrice = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBottom = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVAL = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCalculatedPrice)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBottom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVAL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CalculatePurchasePrice);
            this.panel1.Controls.Add(this.cmbFilter);
            this.panel1.Controls.Add(this.txtOrderQty);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 116);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // CalculatePurchasePrice
            // 
            this.CalculatePurchasePrice.BackColor = System.Drawing.Color.Transparent;
            this.CalculatePurchasePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CalculatePurchasePrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculatePurchasePrice.Location = new System.Drawing.Point(619, 27);
            this.CalculatePurchasePrice.Name = "CalculatePurchasePrice";
            this.CalculatePurchasePrice.Size = new System.Drawing.Size(197, 47);
            this.CalculatePurchasePrice.TabIndex = 2;
            this.CalculatePurchasePrice.Text = "Calculate purchase price";
            this.CalculatePurchasePrice.UseVisualStyleBackColor = false;
            this.CalculatePurchasePrice.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DisplayMember = "(nessuno)";
            this.cmbFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(191, 20);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(355, 24);
            this.cmbFilter.Sorted = true;
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.Text = "-- Select a product --";
            this.cmbFilter.SelectionChangeCommitted += new System.EventHandler(this.cmbFilter_SelectionChangeCommitted);
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Location = new System.Drawing.Point(191, 51);
            this.txtOrderQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Size = new System.Drawing.Size(121, 23);
            this.txtOrderQty.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(89, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Checked = true;
            this.homeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(31, 979);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 750);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1140, 31);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(961, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ConnectionState";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToOrderColumns = true;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 121);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 62;
            this.dataGridViewProduct.RowTemplate.Height = 25;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1091, 207);
            this.dataGridViewProduct.TabIndex = 7;
            // 
            // dataGridViewListCalculatedPrice
            // 
            this.dataGridViewListCalculatedPrice.AllowUserToAddRows = false;
            this.dataGridViewListCalculatedPrice.AllowUserToDeleteRows = false;
            this.dataGridViewListCalculatedPrice.AllowUserToOrderColumns = true;
            this.dataGridViewListCalculatedPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListCalculatedPrice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListCalculatedPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewListCalculatedPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCalculatedPrice.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewListCalculatedPrice.Name = "dataGridViewListCalculatedPrice";
            this.dataGridViewListCalculatedPrice.RowHeadersWidth = 62;
            this.dataGridViewListCalculatedPrice.RowTemplate.Height = 25;
            this.dataGridViewListCalculatedPrice.Size = new System.Drawing.Size(1073, 111);
            this.dataGridViewListCalculatedPrice.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.dataGridViewProduct);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(37, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1091, 718);
            this.panel5.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewBottom);
            this.groupBox2.Location = new System.Drawing.Point(9, 586);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1080, 129);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price conditions (ALL)";
            // 
            // dataGridViewBottom
            // 
            this.dataGridViewBottom.AllowUserToAddRows = false;
            this.dataGridViewBottom.AllowUserToDeleteRows = false;
            this.dataGridViewBottom.AllowUserToOrderColumns = true;
            this.dataGridViewBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBottom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBottom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBottom.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBottom.Location = new System.Drawing.Point(-1, 21);
            this.dataGridViewBottom.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBottom.Name = "dataGridViewBottom";
            this.dataGridViewBottom.ReadOnly = true;
            this.dataGridViewBottom.RowHeadersWidth = 62;
            this.dataGridViewBottom.RowTemplate.Height = 33;
            this.dataGridViewBottom.Size = new System.Drawing.Size(1074, 108);
            this.dataGridViewBottom.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewListCalculatedPrice);
            this.groupBox1.Controls.Add(this.dataGridViewVAL);
            this.groupBox1.Location = new System.Drawing.Point(3, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 238);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price Conditions (APPLIED)";
            // 
            // dataGridViewVAL
            // 
            this.dataGridViewVAL.AllowUserToAddRows = false;
            this.dataGridViewVAL.AllowUserToDeleteRows = false;
            this.dataGridViewVAL.AllowUserToOrderColumns = true;
            this.dataGridViewVAL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVAL.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewVAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVAL.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVAL.Location = new System.Drawing.Point(5, 138);
            this.dataGridViewVAL.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewVAL.Name = "dataGridViewVAL";
            this.dataGridViewVAL.ReadOnly = true;
            this.dataGridViewVAL.RowHeadersWidth = 62;
            this.dataGridViewVAL.RowTemplate.Height = 33;
            this.dataGridViewVAL.Size = new System.Drawing.Size(1074, 95);
            this.dataGridViewVAL.TabIndex = 9;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1140, 781);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopReg 1.0 - Purchase Order CMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCalculatedPrice)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBottom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVAL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cmbFilter;
        private TextBox txtOrderQty;
        private Panel panel2;
        private Button CalculatePurchasePrice;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridViewProduct;
        private Label label3;
        private DataGridView dataGridViewListCalculatedPrice;
        private Panel panel5;
        private DataGridView dataGridViewVAL;
        private GroupBox groupBox1;
        private DataGridView dataGridViewBottom;
        private GroupBox groupBox2;
    }
}