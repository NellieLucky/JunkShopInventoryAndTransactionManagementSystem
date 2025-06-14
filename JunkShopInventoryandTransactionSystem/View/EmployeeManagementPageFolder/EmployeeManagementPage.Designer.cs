namespace JunkShopInventoryandTransactionSystem.View.EmployeeManagementPageFolder
{
    partial class EmployeeManagementPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementPage));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DashboardTitlePage = new Label();
            vScrollBar1 = new VScrollBar();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BuyingPrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            dataGridView1 = new DataGridView();
            RegisterEmployeeButton = new CuoreUI.Controls.cuiButton();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            DateRegisteredColumn = new DataGridViewTextBoxColumn();
            EmailColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            PasswordColumn = new DataGridViewTextBoxColumn();
            ContactColumn = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            EditColumn = new DataGridViewImageColumn();
            RemoveColumn = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(23, 22);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(459, 46);
            DashboardTitlePage.TabIndex = 6;
            DashboardTitlePage.Text = "Employee Management";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1029, 335);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(36, 431);
            vScrollBar1.TabIndex = 29;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = resources.GetObject("dataGridViewCellStyle1.NullValue");
            dataGridViewCellStyle1.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(10);
            Delete.DefaultCellStyle = dataGridViewCellStyle2;
            Delete.FillWeight = 5.618882F;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DateRegisteredColumn, EmailColumn, NameColumn, PasswordColumn, ContactColumn, Address, EditColumn, RemoveColumn });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(99, 99, 99);
            dataGridView1.Location = new Point(14, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1056, 614);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RegisterEmployeeButton
            // 
            RegisterEmployeeButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            RegisterEmployeeButton.CheckButton = false;
            RegisterEmployeeButton.Checked = false;
            RegisterEmployeeButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            RegisterEmployeeButton.CheckedForeColor = Color.White;
            RegisterEmployeeButton.CheckedImageTint = Color.White;
            RegisterEmployeeButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            RegisterEmployeeButton.Content = "Register Employee";
            RegisterEmployeeButton.DialogResult = DialogResult.None;
            RegisterEmployeeButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterEmployeeButton.ForeColor = Color.White;
            RegisterEmployeeButton.HoverBackground = Color.White;
            RegisterEmployeeButton.HoveredImageTint = Color.White;
            RegisterEmployeeButton.HoverForeColor = Color.Black;
            RegisterEmployeeButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            RegisterEmployeeButton.Image = null;
            RegisterEmployeeButton.ImageAutoCenter = true;
            RegisterEmployeeButton.ImageExpand = new Point(0, 0);
            RegisterEmployeeButton.ImageOffset = new Point(0, 0);
            RegisterEmployeeButton.Location = new Point(489, 80);
            RegisterEmployeeButton.Name = "RegisterEmployeeButton";
            RegisterEmployeeButton.NormalBackground = Color.FromArgb(0, 157, 209);
            RegisterEmployeeButton.NormalForeColor = Color.White;
            RegisterEmployeeButton.NormalImageTint = Color.White;
            RegisterEmployeeButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            RegisterEmployeeButton.OutlineThickness = 1F;
            RegisterEmployeeButton.PressedBackground = Color.WhiteSmoke;
            RegisterEmployeeButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            RegisterEmployeeButton.PressedImageTint = Color.White;
            RegisterEmployeeButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            RegisterEmployeeButton.Rounding = new Padding(8);
            RegisterEmployeeButton.Size = new Size(193, 40);
            RegisterEmployeeButton.TabIndex = 40;
            RegisterEmployeeButton.TextAlignment = StringAlignment.Center;
            RegisterEmployeeButton.TextOffset = new Point(0, 0);
            RegisterEmployeeButton.Click += RegisterEmployeeButton_Click;
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
            cuiTextBox1.Location = new Point(737, 85);
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
            cuiTextBox1.TabIndex = 41;
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
            cuiButton1.Location = new Point(698, 85);
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
            cuiButton1.Size = new Size(43, 35);
            cuiButton1.TabIndex = 42;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // DateRegisteredColumn
            // 
            DateRegisteredColumn.HeaderText = "Date Registered";
            DateRegisteredColumn.MinimumWidth = 6;
            DateRegisteredColumn.Name = "DateRegisteredColumn";
            DateRegisteredColumn.Width = 105;
            // 
            // EmailColumn
            // 
            EmailColumn.FillWeight = 120F;
            EmailColumn.HeaderText = "Email Account";
            EmailColumn.MinimumWidth = 6;
            EmailColumn.Name = "EmailColumn";
            EmailColumn.Width = 170;
            // 
            // NameColumn
            // 
            NameColumn.FillWeight = 120F;
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 170;
            // 
            // PasswordColumn
            // 
            PasswordColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PasswordColumn.FillWeight = 130F;
            PasswordColumn.HeaderText = "Password";
            PasswordColumn.MinimumWidth = 6;
            PasswordColumn.Name = "PasswordColumn";
            // 
            // ContactColumn
            // 
            ContactColumn.HeaderText = "Contact Number";
            ContactColumn.MinimumWidth = 6;
            ContactColumn.Name = "ContactColumn";
            ContactColumn.Width = 140;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 200;
            // 
            // EditColumn
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = resources.GetObject("dataGridViewCellStyle4.NullValue");
            dataGridViewCellStyle4.Padding = new Padding(10);
            EditColumn.DefaultCellStyle = dataGridViewCellStyle4;
            EditColumn.FillWeight = 5.618882F;
            EditColumn.HeaderText = "Edit";
            EditColumn.Image = Properties.Resources.pen;
            EditColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EditColumn.MinimumWidth = 6;
            EditColumn.Name = "EditColumn";
            EditColumn.Resizable = DataGridViewTriState.False;
            EditColumn.Width = 80;
            // 
            // RemoveColumn
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = resources.GetObject("dataGridViewCellStyle5.NullValue");
            dataGridViewCellStyle5.Padding = new Padding(10);
            RemoveColumn.DefaultCellStyle = dataGridViewCellStyle5;
            RemoveColumn.FillWeight = 5.618882F;
            RemoveColumn.HeaderText = "Remove";
            RemoveColumn.Image = Properties.Resources.delete;
            RemoveColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            RemoveColumn.MinimumWidth = 6;
            RemoveColumn.Name = "RemoveColumn";
            RemoveColumn.Resizable = DataGridViewTriState.False;
            RemoveColumn.Width = 80;
            // 
            // EmployeeManagementPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(cuiButton1);
            Controls.Add(cuiTextBox1);
            Controls.Add(RegisterEmployeeButton);
            Controls.Add(dataGridView1);
            Controls.Add(vScrollBar1);
            Controls.Add(DashboardTitlePage);
            Name = "EmployeeManagementPage";
            Size = new Size(1084, 798);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private ActiproSoftware.UI.WinForms.Controls.ScrollBar scrollBar1;
        private VScrollBar vScrollBar1;
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
        private CuoreUI.Controls.cuiButton RegisterEmployeeButton;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private DataGridViewTextBoxColumn DateRegisteredColumn;
        private DataGridViewTextBoxColumn EmailColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PasswordColumn;
        private DataGridViewTextBoxColumn ContactColumn;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewImageColumn EditColumn;
        private DataGridViewImageColumn RemoveColumn;
    }
}
