namespace JunkShopInventoryandTransactionSystem.View
{
    partial class DashboardPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPage));
            DashboardTitlePage = new Label();
            cuiGroupBox1 = new CuoreUI.Controls.cuiGroupBox();
            label2 = new Label();
            cuiGroupBox2 = new CuoreUI.Controls.cuiGroupBox();
            label1 = new Label();
            cuiGroupBox3 = new CuoreUI.Controls.cuiGroupBox();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            pictureBox1 = new PictureBox();
            cuiGroupBox1.SuspendLayout();
            cuiGroupBox2.SuspendLayout();
            cuiGroupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(29, 32);
            DashboardTitlePage.Margin = new Padding(4, 0, 4, 0);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(450, 56);
            DashboardTitlePage.TabIndex = 0;
            DashboardTitlePage.Text = "WELCOME, USER!";
            // 
            // cuiGroupBox1
            // 
            cuiGroupBox1.BorderColor = Color.FromArgb(16, 107, 23);
            cuiGroupBox1.Content = "Total Sales Today";
            cuiGroupBox1.Controls.Add(label2);
            cuiGroupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiGroupBox1.ForeColor = Color.FromArgb(16, 107, 23);
            cuiGroupBox1.Location = new Point(81, 108);
            cuiGroupBox1.Name = "cuiGroupBox1";
            cuiGroupBox1.Padding = new Padding(4, 30, 4, 4);
            cuiGroupBox1.Rounding = new Padding(4);
            cuiGroupBox1.Size = new Size(272, 113);
            cuiGroupBox1.TabIndex = 1;
            cuiGroupBox1.Paint += cuiGroupBox1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 30F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 43);
            label2.Name = "label2";
            label2.Size = new Size(63, 70);
            label2.TabIndex = 1;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // cuiGroupBox2
            // 
            cuiGroupBox2.BorderColor = Color.FromArgb(16, 107, 23);
            cuiGroupBox2.Content = "Total Purchases Today";
            cuiGroupBox2.Controls.Add(label1);
            cuiGroupBox2.Font = new Font("Arial", 12F, FontStyle.Bold);
            cuiGroupBox2.ForeColor = Color.FromArgb(16, 107, 23);
            cuiGroupBox2.Location = new Point(495, 108);
            cuiGroupBox2.Name = "cuiGroupBox2";
            cuiGroupBox2.Padding = new Padding(4, 30, 4, 4);
            cuiGroupBox2.Rounding = new Padding(4);
            cuiGroupBox2.Size = new Size(319, 113);
            cuiGroupBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 30F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 30);
            label1.Name = "label1";
            label1.Size = new Size(63, 70);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // cuiGroupBox3
            // 
            cuiGroupBox3.BorderColor = Color.FromArgb(16, 107, 23);
            cuiGroupBox3.Content = "Total Inventory Items";
            cuiGroupBox3.Controls.Add(label3);
            cuiGroupBox3.Font = new Font("Arial", 12F, FontStyle.Bold);
            cuiGroupBox3.ForeColor = Color.FromArgb(16, 107, 23);
            cuiGroupBox3.Location = new Point(970, 108);
            cuiGroupBox3.Name = "cuiGroupBox3";
            cuiGroupBox3.Padding = new Padding(4, 30, 4, 4);
            cuiGroupBox3.Rounding = new Padding(4);
            cuiGroupBox3.Size = new Size(300, 113);
            cuiGroupBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 30F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 30);
            label3.Name = "label3";
            label3.Size = new Size(63, 70);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 49, 49);
            label4.Location = new Point(81, 238);
            label4.Name = "label4";
            label4.Size = new Size(194, 29);
            label4.TabIndex = 4;
            label4.Text = "Low Stock Alert";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(163, 244, 215);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8909721F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.109024F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Location = new Point(102, 307);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1149, 59);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(16, 107, 23);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(780, 0);
            label6.Name = "label6";
            label6.Size = new Size(161, 59);
            label6.TabIndex = 2;
            label6.Text = "Quantity Left";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(16, 107, 23);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(220, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 59);
            label5.TabIndex = 1;
            label5.Text = "Item Name";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8909721F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.109024F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Location = new Point(102, 372);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1149, 86);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // materialScrollBar1
            // 
            materialScrollBar1.Depth = 0;
            materialScrollBar1.Location = new Point(1257, 372);
            materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialScrollBar1.Name = "materialScrollBar1";
            materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            materialScrollBar1.ScrollbarSize = 15;
            materialScrollBar1.Size = new Size(15, 300);
            materialScrollBar1.TabIndex = 8;
            materialScrollBar1.Text = "materialScrollBar1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1193, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(materialScrollBar1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(cuiGroupBox3);
            Controls.Add(cuiGroupBox2);
            Controls.Add(cuiGroupBox1);
            Controls.Add(DashboardTitlePage);
            Margin = new Padding(4);
            Name = "DashboardPage";
            Size = new Size(1355, 998);
            Load += DashboardPage_Load;
            cuiGroupBox1.ResumeLayout(false);
            cuiGroupBox1.PerformLayout();
            cuiGroupBox2.ResumeLayout(false);
            cuiGroupBox2.PerformLayout();
            cuiGroupBox3.ResumeLayout(false);
            cuiGroupBox3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox2;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private PictureBox pictureBox1;
    }
}
