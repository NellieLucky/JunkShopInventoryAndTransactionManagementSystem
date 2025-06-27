namespace JunkShopInventoryandTransactionSystem.View.TransactionRecordsPageFolder
{
    partial class TransactionRecordsPage
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionRecordsPage));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cuiColorPicker1 = new CuoreUI.Components.cuiColorPicker(components);
            DashboardTitlePage = new Label();
            TransactionRecordsTable = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            ExchangeDate = new DataGridViewTextBoxColumn();
            CustomerType = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            EmployeeAssigned = new DataGridViewTextBoxColumn();
            Num_Items = new DataGridViewTextBoxColumn();
            TotalQuantity = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Receipt = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            SearchButton = new CuoreUI.Controls.cuiButton();
            SearchTextBox = new CuoreUI.Controls.cuiTextBox();
            archiveState = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TransactionRecordsTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiColorPicker1
            // 
            cuiColorPicker1.Color = Color.Empty;
            cuiColorPicker1.EnableThemeChangeButton = true;
            cuiColorPicker1.Theme = CuoreUI.Components.Forms.ColorPickerForm.Themes.Light;
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(3, 21);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(410, 46);
            DashboardTitlePage.TabIndex = 5;
            DashboardTitlePage.Text = "Transaction Records";
            // 
            // TransactionRecordsTable
            // 
            TransactionRecordsTable.AllowUserToAddRows = false;
            TransactionRecordsTable.AllowUserToDeleteRows = false;
            TransactionRecordsTable.AllowUserToResizeColumns = false;
            TransactionRecordsTable.AllowUserToResizeRows = false;
            TransactionRecordsTable.BackgroundColor = Color.White;
            TransactionRecordsTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            TransactionRecordsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TransactionRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TransactionRecordsTable.ColumnHeadersHeight = 80;
            TransactionRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TransactionRecordsTable.Columns.AddRange(new DataGridViewColumn[] { TransactionID, ExchangeDate, CustomerType, CustomerName, EmployeeAssigned, Num_Items, TotalQuantity, TotalAmount, Receipt, Delete });
            TransactionRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            TransactionRecordsTable.EnableHeadersVisualStyles = false;
            TransactionRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            TransactionRecordsTable.Location = new Point(13, 139);
            TransactionRecordsTable.Name = "TransactionRecordsTable";
            TransactionRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TransactionRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            TransactionRecordsTable.RowHeadersVisible = false;
            TransactionRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            TransactionRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            TransactionRecordsTable.RowTemplate.Height = 50;
            TransactionRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionRecordsTable.Size = new Size(1056, 640);
            TransactionRecordsTable.TabIndex = 31;
            TransactionRecordsTable.CellContentClick += TransactionRecordsTable_CellContentClick;
            // 
            // TransactionID
            // 
            TransactionID.HeaderText = "Transaction ID";
            TransactionID.MinimumWidth = 6;
            TransactionID.Name = "TransactionID";
            TransactionID.Width = 105;
            // 
            // ExchangeDate
            // 
            ExchangeDate.FillWeight = 150F;
            ExchangeDate.HeaderText = "Date";
            ExchangeDate.MinimumWidth = 6;
            ExchangeDate.Name = "ExchangeDate";
            ExchangeDate.Width = 135;
            // 
            // CustomerType
            // 
            CustomerType.HeaderText = "Customer Type";
            CustomerType.MinimumWidth = 6;
            CustomerType.Name = "CustomerType";
            CustomerType.Width = 105;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerName.HeaderText = "Customer Name";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            // 
            // EmployeeAssigned
            // 
            EmployeeAssigned.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeAssigned.HeaderText = "Employee in-charge";
            EmployeeAssigned.MinimumWidth = 6;
            EmployeeAssigned.Name = "EmployeeAssigned";
            // 
            // Num_Items
            // 
            Num_Items.HeaderText = "No. of items";
            Num_Items.MinimumWidth = 6;
            Num_Items.Name = "Num_Items";
            Num_Items.Width = 60;
            // 
            // TotalQuantity
            // 
            TotalQuantity.HeaderText = "Total Quantity";
            TotalQuantity.MinimumWidth = 6;
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.Width = 110;
            // 
            // TotalAmount
            // 
            TotalAmount.FillWeight = 59.177578F;
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 120;
            // 
            // Receipt
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(10);
            Receipt.DefaultCellStyle = dataGridViewCellStyle2;
            Receipt.FillWeight = 59.177578F;
            Receipt.HeaderText = "Receipt";
            Receipt.Image = Properties.Resources.receipt;
            Receipt.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Receipt.MinimumWidth = 6;
            Receipt.Name = "Receipt";
            Receipt.SortMode = DataGridViewColumnSortMode.Automatic;
            Receipt.Width = 60;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(10);
            Delete.DefaultCellStyle = dataGridViewCellStyle3;
            Delete.FillWeight = 59.177578F;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 60;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 157, 209);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(SearchTextBox);
            panel1.Location = new Point(695, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 40);
            panel1.TabIndex = 32;
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
            SearchButton.Click += SearchButton_Click_1;
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
            SearchTextBox.Location = new Point(41, 3);
            SearchTextBox.Margin = new Padding(5, 4, 5, 4);
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
            SearchTextBox.TextChanged += SearchTextBox_TextChange;
            // 
            // archiveState
            // 
            archiveState.DropDownStyle = ComboBoxStyle.DropDownList;
            archiveState.FormattingEnabled = true;
            archiveState.Items.AddRange(new object[] { "Non-archived", "Archived Items" });
            archiveState.Location = new Point(514, 86);
            archiveState.Name = "archiveState";
            archiveState.Size = new Size(151, 28);
            archiveState.TabIndex = 33;
            // 
            // TransactionRecordsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(archiveState);
            Controls.Add(panel1);
            Controls.Add(TransactionRecordsTable);
            Controls.Add(DashboardTitlePage);
            Name = "TransactionRecordsPage";
            Size = new Size(1083, 797);
            ((System.ComponentModel.ISupportInitialize)TransactionRecordsTable).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Components.cuiColorPicker cuiColorPicker1;
        private Label DashboardTitlePage;
        private DataGridView TransactionRecordsTable;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton SearchButton;
        private CuoreUI.Controls.cuiTextBox SearchTextBox;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn ExchangeDate;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn EmployeeAssigned;
        private DataGridViewTextBoxColumn Num_Items;
        private DataGridViewTextBoxColumn TotalQuantity;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewImageColumn Receipt;
        private DataGridViewImageColumn Delete;
        private ComboBox archiveState;
    }
}
