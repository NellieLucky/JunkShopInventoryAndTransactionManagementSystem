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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            CustID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            ContactNo = new DataGridViewTextBoxColumn();
            TotalNumTransaction = new DataGridViewTextBoxColumn();
            TotalPricePurchases = new DataGridViewTextBoxColumn();
            TotalQuantityPurchases = new DataGridViewTextBoxColumn();
            CustomerDelete = new DataGridViewImageColumn();
            BuyerRec = new Label();
            panel1 = new Panel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustID, CustName, ContactNo, TotalNumTransaction, TotalPricePurchases, TotalQuantityPurchases, CustomerDelete });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(99, 99, 99);
            dataGridView1.Location = new Point(18, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1007, 508);
            dataGridView1.TabIndex = 31;
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
            CustomerDelete.HeaderText = "Delete";
            CustomerDelete.Image = Properties.Resources.delete;
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
            panel1.Controls.Add(cuiButton1);
            panel1.Controls.Add(cuiTextBox1);
            panel1.Location = new Point(649, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 40);
            panel1.TabIndex = 33;
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
            // BuyerRecordsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(BuyerRec);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "BuyerRecordsPage";
            Size = new Size(1042, 628);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label BuyerRec;
        private DataGridViewTextBoxColumn CustID;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn ContactNo;
        private DataGridViewTextBoxColumn TotalNumTransaction;
        private DataGridViewTextBoxColumn TotalPricePurchases;
        private DataGridViewTextBoxColumn TotalQuantityPurchases;
        private DataGridViewImageColumn CustomerDelete;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
    }
}
