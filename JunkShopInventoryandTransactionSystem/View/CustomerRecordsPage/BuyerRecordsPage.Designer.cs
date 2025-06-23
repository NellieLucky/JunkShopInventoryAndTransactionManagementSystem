namespace JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage
{
    partial class BuyerRecordsPage
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerRecordsPage));
            BuyerRecordsTable = new DataGridView();
            CustID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            ContactNo = new DataGridViewTextBoxColumn();
            TotalNumTransaction = new DataGridViewTextBoxColumn();
            TotalPricePurchases = new DataGridViewTextBoxColumn();
            TotalQuantityPurchases = new DataGridViewTextBoxColumn();
            CustomerDelete = new DataGridViewImageColumn();
            BuyerRec = new Label();
            panel1 = new Panel();
            searchButton = new CuoreUI.Controls.cuiButton();
            searchTextBox = new CuoreUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)BuyerRecordsTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BuyerRecordsTable
            // 
            BuyerRecordsTable.AllowUserToAddRows = false;
            BuyerRecordsTable.AllowUserToDeleteRows = false;
            BuyerRecordsTable.AllowUserToResizeColumns = false;
            BuyerRecordsTable.AllowUserToResizeRows = false;
            BuyerRecordsTable.BackgroundColor = Color.White;
            BuyerRecordsTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            BuyerRecordsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BuyerRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BuyerRecordsTable.ColumnHeadersHeight = 60;
            BuyerRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BuyerRecordsTable.Columns.AddRange(new DataGridViewColumn[] { CustID, CustName, ContactNo, TotalNumTransaction, TotalPricePurchases, TotalQuantityPurchases, CustomerDelete });
            BuyerRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            BuyerRecordsTable.EnableHeadersVisualStyles = false;
            BuyerRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            BuyerRecordsTable.Location = new Point(18, 88);
            BuyerRecordsTable.Name = "BuyerRecordsTable";
            BuyerRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            BuyerRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            BuyerRecordsTable.RowHeadersVisible = false;
            BuyerRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle8.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            BuyerRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            BuyerRecordsTable.RowTemplate.Height = 50;
            BuyerRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BuyerRecordsTable.Size = new Size(1007, 508);
            BuyerRecordsTable.TabIndex = 31;
            BuyerRecordsTable.CellContentClick += BuyerRecordsTable_CellContentClick;
            // 
            // CustID
            // 
            CustID.HeaderText = "Customer ID";
            CustID.MinimumWidth = 6;
            CustID.Name = "CustID";
            CustID.Width = 80;
            // 
            // CustName
            // 
            CustName.HeaderText = "Name";
            CustName.MinimumWidth = 8;
            CustName.Name = "CustName";
            CustName.Width = 200;
            // 
            // ContactNo
            // 
            ContactNo.HeaderText = "Contact Number";
            ContactNo.MinimumWidth = 6;
            ContactNo.Name = "ContactNo";
            ContactNo.Width = 200;
            // 
            // TotalNumTransaction
            // 
            TotalNumTransaction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalNumTransaction.HeaderText = "Total No. Purchases";
            TotalNumTransaction.MinimumWidth = 6;
            TotalNumTransaction.Name = "TotalNumTransaction";
            // 
            // TotalPricePurchases
            // 
            TotalPricePurchases.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPricePurchases.HeaderText = "Total Price of Purchases";
            TotalPricePurchases.MinimumWidth = 6;
            TotalPricePurchases.Name = "TotalPricePurchases";
            // 
            // TotalQuantityPurchases
            // 
            TotalQuantityPurchases.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalQuantityPurchases.HeaderText = "Total Qty. of Purchases";
            TotalQuantityPurchases.MinimumWidth = 6;
            TotalQuantityPurchases.Name = "TotalQuantityPurchases";
            // 
            // CustomerDelete
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = resources.GetObject("dataGridViewCellStyle6.NullValue");
            dataGridViewCellStyle6.Padding = new Padding(10);
            CustomerDelete.DefaultCellStyle = dataGridViewCellStyle6;
            CustomerDelete.HeaderText = "Delete";
            CustomerDelete.Image = Properties.Resources.delete;
            CustomerDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            CustomerDelete.MinimumWidth = 8;
            CustomerDelete.Name = "CustomerDelete";
            CustomerDelete.Resizable = DataGridViewTriState.True;
            CustomerDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            CustomerDelete.Width = 60;
            // 
            // BuyerRec
            // 
            BuyerRec.AutoSize = true;
            BuyerRec.BackColor = Color.FromArgb(0, 0, 0, 0);
            BuyerRec.Font = new Font("Arial", 18F, FontStyle.Bold);
            BuyerRec.ForeColor = Color.FromArgb(0, 157, 209);
            BuyerRec.Location = new Point(22, 14);
            BuyerRec.Name = "BuyerRec";
            BuyerRec.Size = new Size(228, 35);
            BuyerRec.TabIndex = 32;
            BuyerRec.Text = "Buyer Records";
            BuyerRec.Click += DashboardTitlePage_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 157, 209);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(searchTextBox);
            panel1.Location = new Point(649, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 40);
            panel1.TabIndex = 33;
            // 
            // searchButton
            // 
            searchButton.CheckButton = false;
            searchButton.Checked = false;
            searchButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            searchButton.CheckedForeColor = Color.White;
            searchButton.CheckedImageTint = Color.White;
            searchButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            searchButton.Content = "";
            searchButton.DialogResult = DialogResult.None;
            searchButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            searchButton.ForeColor = Color.Black;
            searchButton.HoverBackground = Color.White;
            searchButton.HoveredImageTint = Color.White;
            searchButton.HoverForeColor = Color.Black;
            searchButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            searchButton.Image = Properties.Resources.magnifying_glass;
            searchButton.ImageAutoCenter = true;
            searchButton.ImageExpand = new Point(5, 5);
            searchButton.ImageOffset = new Point(0, 0);
            searchButton.Location = new Point(0, 0);
            searchButton.Name = "searchButton";
            searchButton.NormalBackground = Color.FromArgb(0, 157, 209);
            searchButton.NormalForeColor = Color.Black;
            searchButton.NormalImageTint = Color.White;
            searchButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            searchButton.OutlineThickness = 1F;
            searchButton.PressedBackground = Color.WhiteSmoke;
            searchButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            searchButton.PressedImageTint = Color.White;
            searchButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            searchButton.Rounding = new Padding(0, 5, 5, 0);
            searchButton.Size = new Size(43, 39);
            searchButton.TabIndex = 24;
            searchButton.TextAlignment = StringAlignment.Center;
            searchButton.TextOffset = new Point(0, 0);
            searchTextBox.ContentChanged += SearchTextBox_TextChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.FromArgb(0, 0, 0, 0);
            searchTextBox.BackgroundColor = Color.White;
            searchTextBox.BorderColor = Color.Empty;
            searchTextBox.Content = "";
            searchTextBox.FocusBackgroundColor = Color.White;
            searchTextBox.FocusBorderColor = Color.Empty;
            searchTextBox.FocusImageTint = Color.White;
            searchTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.ForeColor = Color.Gray;
            searchTextBox.Image = null;
            searchTextBox.ImageExpand = new Point(0, 0);
            searchTextBox.ImageOffset = new Point(0, 0);
            searchTextBox.Location = new Point(41, 2);
            searchTextBox.Margin = new Padding(4);
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.NormalImageTint = Color.White;
            searchTextBox.Padding = new Padding(18, 8, 18, 0);
            searchTextBox.PasswordChar = false;
            searchTextBox.PlaceholderColor = Color.Gray;
            searchTextBox.PlaceholderText = "Search...";
            searchTextBox.Rounding = new Padding(2);
            searchTextBox.Size = new Size(333, 35);
            searchTextBox.TabIndex = 23;
            searchTextBox.TextOffset = new Size(0, 0);
            searchTextBox.UnderlinedStyle = false;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // BuyerRecordsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(BuyerRec);
            Controls.Add(BuyerRecordsTable);
            Margin = new Padding(2);
            Name = "BuyerRecordsPage";
            Size = new Size(1042, 628);
            ((System.ComponentModel.ISupportInitialize)BuyerRecordsTable).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BuyerRecordsTable;
        private Label BuyerRec;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton searchButton;
        private CuoreUI.Controls.cuiTextBox searchTextBox;
        private DataGridViewTextBoxColumn CustID;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn ContactNo;
        private DataGridViewTextBoxColumn TotalNumTransaction;
        private DataGridViewTextBoxColumn TotalPricePurchases;
        private DataGridViewTextBoxColumn TotalQuantityPurchases;
        private DataGridViewImageColumn CustomerDelete;
    }
}
