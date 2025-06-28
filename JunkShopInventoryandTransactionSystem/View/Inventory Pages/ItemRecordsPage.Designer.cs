namespace JunkShopInventoryandTransactionSystem.View.Inventory_Pages
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemRecordsPage));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            SearchTextBox = new CuoreUI.Controls.cuiTextBox();
            SearchButton = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            AddItemButton = new CuoreUI.Controls.cuiButton();
            DashboardTitlePage = new Label();
            ItemRecordsTable = new DataGridView();
            archiveState = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)ItemRecordsTable).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(0, 0, 0, 0);
            SearchTextBox.BackgroundColor = Color.White;
            SearchTextBox.BorderColor = Color.Empty;
            SearchTextBox.Content = "";
            SearchTextBox.FocusBackgroundColor = Color.White;
            SearchTextBox.FocusBorderColor = Color.Empty;
            SearchTextBox.FocusImageTint = Color.White;
            SearchTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.ForeColor = Color.Gray;
            SearchTextBox.Image = null;
            SearchTextBox.ImageExpand = new Point(0, 0);
            SearchTextBox.ImageOffset = new Point(0, 0);
            SearchTextBox.Location = new Point(41, 2);
            SearchTextBox.Margin = new Padding(4);
            SearchTextBox.Multiline = false;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.NormalImageTint = Color.White;
            SearchTextBox.Padding = new Padding(18, 8, 18, 0);
            SearchTextBox.PasswordChar = false;
            SearchTextBox.PlaceholderColor = Color.Gray;
            SearchTextBox.PlaceholderText = "Search...";
            SearchTextBox.Rounding = new Padding(2);
            SearchTextBox.Size = new Size(333, 35);
            SearchTextBox.TabIndex = 23;
            SearchTextBox.TextOffset = new Size(0, 0);
            SearchTextBox.UnderlinedStyle = false;
            // 
            // SearchButton
            // 
            SearchButton.CheckButton = false;
            SearchButton.Checked = false;
            SearchButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            SearchButton.CheckedForeColor = Color.White;
            SearchButton.CheckedImageTint = Color.White;
            SearchButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            SearchButton.Content = "";
            SearchButton.DialogResult = DialogResult.None;
            SearchButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            SearchButton.ForeColor = Color.Black;
            SearchButton.HoverBackground = Color.White;
            SearchButton.HoveredImageTint = Color.White;
            SearchButton.HoverForeColor = Color.Black;
            SearchButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SearchButton.Image = Properties.Resources.magnifying_glass;
            SearchButton.ImageAutoCenter = true;
            SearchButton.ImageExpand = new Point(5, 5);
            SearchButton.ImageOffset = new Point(0, 0);
            SearchButton.Location = new Point(0, 0);
            SearchButton.Name = "SearchButton";
            SearchButton.NormalBackground = Color.FromArgb(0, 157, 209);
            SearchButton.NormalForeColor = Color.Black;
            SearchButton.NormalImageTint = Color.White;
            SearchButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SearchButton.OutlineThickness = 1F;
            SearchButton.PressedBackground = Color.WhiteSmoke;
            SearchButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            SearchButton.PressedImageTint = Color.White;
            SearchButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SearchButton.Rounding = new Padding(0, 5, 5, 0);
            SearchButton.Size = new Size(43, 39);
            SearchButton.TabIndex = 24;
            SearchButton.TextAlignment = StringAlignment.Center;
            SearchButton.TextOffset = new Point(0, 0);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 157, 209);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(SearchTextBox);
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
            DashboardTitlePage.ForeColor = Color.FromArgb(0, 157, 209);
            DashboardTitlePage.Location = new Point(13, 22);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(205, 35);
            DashboardTitlePage.TabIndex = 27;
            DashboardTitlePage.Text = "Item Records";
            // 
            // ItemRecordsTable
            // 
            ItemRecordsTable.AllowUserToAddRows = false;
            ItemRecordsTable.AllowUserToDeleteRows = false;
            ItemRecordsTable.AllowUserToResizeColumns = false;
            ItemRecordsTable.AllowUserToResizeRows = false;
            ItemRecordsTable.BackgroundColor = Color.White;
            ItemRecordsTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            ItemRecordsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ItemRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ItemRecordsTable.ColumnHeadersHeight = 60;
            ItemRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ItemRecordsTable.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, Category, QtyType, Quantity, BuyingPrice, SellingPrice, Edit, Delete });
            ItemRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            ItemRecordsTable.EnableHeadersVisualStyles = false;
            ItemRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            ItemRecordsTable.Location = new Point(14, 82);
            ItemRecordsTable.Name = "ItemRecordsTable";
            ItemRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ItemRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ItemRecordsTable.RowHeadersVisible = false;
            ItemRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ItemRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            ItemRecordsTable.RowTemplate.Height = 50;
            ItemRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemRecordsTable.Size = new Size(1056, 538);
            ItemRecordsTable.TabIndex = 29;
            ItemRecordsTable.CellClick += ItemRecordsTable_CellClick;
            // 
            // archiveState
            // 
            archiveState.DropDownStyle = ComboBoxStyle.DropDownList;
            archiveState.FormattingEnabled = true;
            archiveState.Items.AddRange(new object[] { "Non-archived", "Archived Items" });
            archiveState.Location = new Point(374, 29);
            archiveState.Name = "archiveState";
            archiveState.Size = new Size(151, 28);
            archiveState.TabIndex = 30;
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
            ItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.FillWeight = 150F;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Edit.Description = "Edit";
            Edit.FillWeight = 5.618882F;
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.restore;
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.False;
            Edit.Width = 60;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(10);
            Delete.DefaultCellStyle = dataGridViewCellStyle3;
            Delete.Description = "Delete";
            Delete.FillWeight = 5.618882F;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
            Delete.Width = 60;
            // 
            // ItemRecordsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(archiveState);
            Controls.Add(ItemRecordsTable);
            Controls.Add(DashboardTitlePage);
            Controls.Add(AddItemButton);
            Controls.Add(panel1);
            Name = "ItemRecordsPage";
            Size = new Size(1084, 668);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ItemRecordsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Controls.cuiTextBox SearchTextBox;
        private CuoreUI.Controls.cuiButton SearchButton;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton AddItemButton;
        private Label DashboardTitlePage;
        private DataGridView ItemRecordsTable;
        private ComboBox archiveState;
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
