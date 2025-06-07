namespace JunkShopInventoryandTransactionSystem.View
{
    partial class ItemRecordsPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BuyingPrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            DashboardTitlePage = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(99, 99, 99);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, Category, QtyType, Quantity, BuyingPrice, SellingPrice, Edit, Delete });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(99, 99, 99);
            dataGridView1.Location = new Point(13, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1056, 571);
            dataGridView1.TabIndex = 22;
            // 
            // ItemID
            // 
            ItemID.FillWeight = 60.1758423F;
            ItemID.HeaderText = "ItemId";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            ItemName.FillWeight = 67.99225F;
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            // 
            // Category
            // 
            Category.FillWeight = 72.59462F;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // QtyType
            // 
            QtyType.FillWeight = 76.74243F;
            QtyType.HeaderText = "Qty. Type";
            QtyType.MinimumWidth = 6;
            QtyType.Name = "QtyType";
            // 
            // Quantity
            // 
            Quantity.FillWeight = 81.254425F;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // BuyingPrice
            // 
            BuyingPrice.FillWeight = 83.77312F;
            BuyingPrice.HeaderText = "Buying Price";
            BuyingPrice.MinimumWidth = 6;
            BuyingPrice.Name = "BuyingPrice";
            // 
            // SellingPrice
            // 
            SellingPrice.FillWeight = 86.81687F;
            SellingPrice.HeaderText = "Selling Price";
            SellingPrice.MinimumWidth = 6;
            SellingPrice.Name = "SellingPrice";
            // 
            // Edit
            // 
            Edit.FillWeight = 51.6692467F;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.FillWeight = 51.6692467F;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.BorderColor = Color.Empty;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.FromArgb(255, 106, 0);
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Gray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(41, 2);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(18, 8, 18, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.Gray;
            cuiTextBox1.PlaceholderText = "Search...";
            cuiTextBox1.Rounding = new Padding(2);
            cuiTextBox1.Size = new Size(333, 35);
            cuiTextBox1.TabIndex = 23;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = Properties.Resources.magnifying_glass;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(5, 5);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(0, 0);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.FromArgb(0, 157, 209);
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(0, 5, 5, 0);
            cuiButton1.Size = new Size(43, 39);
            cuiButton1.TabIndex = 24;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 157, 209);
            panel1.Controls.Add(cuiButton1);
            panel1.Controls.Add(cuiTextBox1);
            panel1.Location = new Point(693, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 40);
            panel1.TabIndex = 25;
            // 
            // cuiButton2
            // 
            cuiButton2.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Add Item";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(541, 22);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(0, 157, 209);
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(146, 40);
            cuiButton2.TabIndex = 26;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(13, 22);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(205, 35);
            DashboardTitlePage.TabIndex = 27;
            DashboardTitlePage.Text = "Item Records";
            // 
            // ItemRecordsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DashboardTitlePage);
            Controls.Add(cuiButton2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "ItemRecordsPage";
            Size = new Size(1084, 668);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private Label DashboardTitlePage;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn QtyType;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn BuyingPrice;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
