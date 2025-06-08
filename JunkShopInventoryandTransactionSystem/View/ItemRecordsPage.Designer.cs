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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemRecordsPage));
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            AddItemButton = new CuoreUI.Controls.cuiButton();
            DashboardTitlePage = new Label();
            dataGridView1 = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BuyingPrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.BorderColor = Color.Empty;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.Empty;
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
            // AddItemButton
            // 
            AddItemButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            AddItemButton.CheckButton = false;
            AddItemButton.Checked = false;
            AddItemButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            AddItemButton.CheckedForeColor = Color.White;
            AddItemButton.CheckedImageTint = Color.White;
            AddItemButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            AddItemButton.Content = "Add Item";
            AddItemButton.DialogResult = DialogResult.None;
            AddItemButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItemButton.ForeColor = Color.White;
            AddItemButton.HoverBackground = Color.White;
            AddItemButton.HoveredImageTint = Color.White;
            AddItemButton.HoverForeColor = Color.Black;
            AddItemButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            AddItemButton.Image = null;
            AddItemButton.ImageAutoCenter = true;
            AddItemButton.ImageExpand = new Point(0, 0);
            AddItemButton.ImageOffset = new Point(0, 0);
            AddItemButton.Location = new Point(541, 22);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.NormalBackground = Color.FromArgb(0, 157, 209);
            AddItemButton.NormalForeColor = Color.White;
            AddItemButton.NormalImageTint = Color.White;
            AddItemButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            AddItemButton.OutlineThickness = 1F;
            AddItemButton.PressedBackground = Color.WhiteSmoke;
            AddItemButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            AddItemButton.PressedImageTint = Color.White;
            AddItemButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            AddItemButton.Rounding = new Padding(8);
            AddItemButton.Size = new Size(146, 40);
            AddItemButton.TabIndex = 26;
            AddItemButton.TextAlignment = StringAlignment.Center;
            AddItemButton.TextOffset = new Point(0, 0);
            AddItemButton.Click += AddItemButton_Click;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, Category, QtyType, Quantity, BuyingPrice, SellingPrice, Edit, Delete });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(99, 99, 99);
            dataGridView1.Location = new Point(14, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle10.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1056, 538);
            dataGridView1.TabIndex = 29;
            // 
            // ItemID
            // 
            ItemID.HeaderText = "ItemID";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.Width = 70;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.Width = 150;
            // 
            // Category
            // 
            Category.FillWeight = 150F;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 150;
            // 
            // QtyType
            // 
            QtyType.FillWeight = 125F;
            QtyType.HeaderText = "QtyType";
            QtyType.MinimumWidth = 6;
            QtyType.Name = "QtyType";
            QtyType.Width = 125;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 59.177578F;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 130;
            // 
            // BuyingPrice
            // 
            BuyingPrice.FillWeight = 59.177578F;
            BuyingPrice.HeaderText = "BuyingPrice";
            BuyingPrice.MinimumWidth = 6;
            BuyingPrice.Name = "BuyingPrice";
            BuyingPrice.Width = 130;
            // 
            // SellingPrice
            // 
            SellingPrice.FillWeight = 59.177578F;
            SellingPrice.HeaderText = "SellingPrice";
            SellingPrice.MinimumWidth = 6;
            SellingPrice.Name = "SellingPrice";
            SellingPrice.Width = 130;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = resources.GetObject("dataGridViewCellStyle7.NullValue");
            dataGridViewCellStyle7.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle7;
            Edit.FillWeight = 5.618882F;
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.pen;
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.False;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = resources.GetObject("dataGridViewCellStyle8.NullValue");
            dataGridViewCellStyle8.Padding = new Padding(10);
            Delete.DefaultCellStyle = dataGridViewCellStyle8;
            Delete.FillWeight = 5.618882F;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
            // 
            // ItemRecordsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(DashboardTitlePage);
            Controls.Add(AddItemButton);
            Controls.Add(panel1);
            Name = "ItemRecordsPage";
            Size = new Size(1084, 668);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton AddItemButton;
        private Label DashboardTitlePage;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn QtyType;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn BuyingPrice;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
