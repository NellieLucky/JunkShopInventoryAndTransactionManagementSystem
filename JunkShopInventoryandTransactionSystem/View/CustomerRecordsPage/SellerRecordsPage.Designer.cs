namespace JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage
{
    partial class SellerRecordsPage
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerRecordsPage));
            BuyerRec = new Label();
            dataGridView1 = new DataGridView();
            CustID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            ContactNo = new DataGridViewTextBoxColumn();
            CustomerDelete = new DataGridViewImageColumn();
            panel1 = new Panel();
            searchButton = new CuoreUI.Controls.cuiButton();
            searchTextBox = new CuoreUI.Controls.cuiTextBox();
            sellerRecordsTable = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            SupplierTotalSold = new DataGridViewTextBoxColumn();
            TotalQuantityPurchases = new DataGridViewTextBoxColumn();
            TotalPriceSold = new DataGridViewTextBoxColumn();
            DeleteColumn = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sellerRecordsTable).BeginInit();
            SuspendLayout();
            // 
            // BuyerRec
            // 
            BuyerRec.AutoSize = true;
            BuyerRec.BackColor = Color.FromArgb(0, 0, 0, 0);
            BuyerRec.Font = new Font("Arial", 18F, FontStyle.Bold);
            BuyerRec.ForeColor = Color.FromArgb(0, 157, 209);
            BuyerRec.Location = new Point(23, 13);
            BuyerRec.Name = "BuyerRec";
            BuyerRec.Size = new Size(226, 35);
            BuyerRec.TabIndex = 34;
            BuyerRec.Text = "Seller Records";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustID, CustName, ContactNo, CustomerDelete });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(99, 99, 99);
            dataGridView1.Location = new Point(23, 51);
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
            dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(0, 0);
            dataGridView1.TabIndex = 33;
            // 
            // CustID
            // 
            CustID.HeaderText = "CustomerID";
            CustID.MinimumWidth = 6;
            CustID.Name = "CustID";
            CustID.Width = 300;
            // 
            // CustName
            // 
            CustName.HeaderText = "Name";
            CustName.MinimumWidth = 8;
            CustName.Name = "CustName";
            CustName.Width = 400;
            // 
            // ContactNo
            // 
            ContactNo.HeaderText = "Contact Number";
            ContactNo.MinimumWidth = 6;
            ContactNo.Name = "ContactNo";
            ContactNo.Width = 380;
            // 
            // CustomerDelete
            // 
            CustomerDelete.HeaderText = "Delete";
            CustomerDelete.Image = Properties.Resources.delete;
            CustomerDelete.MinimumWidth = 8;
            CustomerDelete.Name = "CustomerDelete";
            CustomerDelete.Resizable = DataGridViewTriState.True;
            CustomerDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            CustomerDelete.Width = 150;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 157, 209);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(searchTextBox);
            panel1.Location = new Point(649, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 40);
            panel1.TabIndex = 36;
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
            searchButton.Margin = new Padding(3, 4, 3, 4);
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
            searchButton.Size = new Size(50, 40);
            searchButton.TabIndex = 24;
            searchButton.TextAlignment = StringAlignment.Center;
            searchButton.TextOffset = new Point(0, 0);
            searchButton.Click += searchButton_Click;
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
            searchTextBox.Margin = new Padding(5);
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
            // 
            // sellerRecordsTable
            // 
            sellerRecordsTable.AllowUserToAddRows = false;
            sellerRecordsTable.AllowUserToDeleteRows = false;
            sellerRecordsTable.AllowUserToResizeColumns = false;
            sellerRecordsTable.AllowUserToResizeRows = false;
            sellerRecordsTable.BackgroundColor = Color.White;
            sellerRecordsTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            sellerRecordsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            sellerRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            sellerRecordsTable.ColumnHeadersHeight = 60;
            sellerRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            sellerRecordsTable.Columns.AddRange(new DataGridViewColumn[] { CustomerID, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, SupplierTotalSold, TotalQuantityPurchases, TotalPriceSold, DeleteColumn });
            sellerRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            sellerRecordsTable.EnableHeadersVisualStyles = false;
            sellerRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            sellerRecordsTable.Location = new Point(18, 88);
            sellerRecordsTable.Margin = new Padding(3, 4, 3, 4);
            sellerRecordsTable.Name = "sellerRecordsTable";
            sellerRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            sellerRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            sellerRecordsTable.RowHeadersVisible = false;
            sellerRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle7.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            sellerRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle7;
            sellerRecordsTable.RowTemplate.Height = 50;
            sellerRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sellerRecordsTable.Size = new Size(1007, 508);
            sellerRecordsTable.TabIndex = 35;
            sellerRecordsTable.CellContentClick += sellerRecordsTable_CellContentClick;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Customer ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Contact Number";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // SupplierTotalSold
            // 
            SupplierTotalSold.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierTotalSold.HeaderText = "Total Sales Transaction";
            SupplierTotalSold.MinimumWidth = 6;
            SupplierTotalSold.Name = "SupplierTotalSold";
            // 
            // TotalQuantityPurchases
            // 
            TotalQuantityPurchases.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalQuantityPurchases.HeaderText = "Total Quantity of Sold";
            TotalQuantityPurchases.MinimumWidth = 6;
            TotalQuantityPurchases.Name = "TotalQuantityPurchases";
            // 
            // TotalPriceSold
            // 
            TotalPriceSold.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPriceSold.HeaderText = "Total Price Sold";
            TotalPriceSold.MinimumWidth = 6;
            TotalPriceSold.Name = "TotalPriceSold";
            // 
            // DeleteColumn
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = resources.GetObject("dataGridViewCellStyle5.NullValue");
            dataGridViewCellStyle5.Padding = new Padding(10);
            DeleteColumn.DefaultCellStyle = dataGridViewCellStyle5;
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.Image = Properties.Resources.delete;
            DeleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DeleteColumn.MinimumWidth = 8;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Resizable = DataGridViewTriState.True;
            DeleteColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteColumn.Width = 60;
            // 
            // SellerRecordsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(sellerRecordsTable);
            Controls.Add(BuyerRec);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "SellerRecordsPage";
            Size = new Size(1042, 628);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sellerRecordsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BuyerRec;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustID;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn ContactNo;
        private DataGridViewImageColumn CustomerDelete;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton searchButton;
        private CuoreUI.Controls.cuiTextBox searchTextBox;
        private DataGridView sellerRecordsTable;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn SupplierTotalSold;
        private DataGridViewTextBoxColumn TotalQuantityPurchases;
        private DataGridViewTextBoxColumn TotalPriceSold;
        private DataGridViewImageColumn DeleteColumn;
    }
}
