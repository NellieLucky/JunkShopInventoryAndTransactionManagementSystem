namespace JunkShopInventoryandTransactionSystem.View.GenerateTransactionPageFolder
{
    partial class SellerTransaction
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TotalItemsCounterLabel = new Label();
            label3 = new Label();
            RegEmployeeTitlePage = new Label();
            TotalPriceAmntCounterLabel = new Label();
            label1 = new Label();
            SellerItemComboBox = new ComboBox();
            SaveSellerTransaction_Button = new CuoreUI.Controls.cuiButton();
            SellerClearBtn = new CuoreUI.Controls.cuiButton();
            SellerAddTransacBtn = new CuoreUI.Controls.cuiButton();
            BuyerContact = new Label();
            SellerContactTextBox = new CuoreUI.Controls.cuiTextBox();
            CustomerName = new Label();
            SellerNameTextBox = new CuoreUI.Controls.cuiTextBox();
            TransactionQuantity = new Label();
            SellerQtyTextBox = new CuoreUI.Controls.cuiTextBox();
            IdItem = new Label();
            SellerOrdersTable = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            BuyingPrice = new DataGridViewTextBoxColumn();
            TransacQuantity = new DataGridViewTextBoxColumn();
            ExchangeAmount = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Remove = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)SellerOrdersTable).BeginInit();
            SuspendLayout();
            // 
            // TotalItemsCounterLabel
            // 
            TotalItemsCounterLabel.AutoSize = true;
            TotalItemsCounterLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            TotalItemsCounterLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            TotalItemsCounterLabel.ForeColor = Color.FromArgb(0, 157, 209);
            TotalItemsCounterLabel.Location = new Point(872, 539);
            TotalItemsCounterLabel.Name = "TotalItemsCounterLabel";
            TotalItemsCounterLabel.Size = new Size(94, 19);
            TotalItemsCounterLabel.TabIndex = 86;
            TotalItemsCounterLabel.Text = "Total Items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 157, 209);
            label3.Location = new Point(768, 539);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 85;
            label3.Text = "Total Items:";
            // 
            // RegEmployeeTitlePage
            // 
            RegEmployeeTitlePage.AutoSize = true;
            RegEmployeeTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            RegEmployeeTitlePage.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegEmployeeTitlePage.ForeColor = Color.FromArgb(0, 157, 209);
            RegEmployeeTitlePage.Location = new Point(3, 7);
            RegEmployeeTitlePage.Name = "RegEmployeeTitlePage";
            RegEmployeeTitlePage.Size = new Size(273, 35);
            RegEmployeeTitlePage.TabIndex = 84;
            RegEmployeeTitlePage.Text = "Seller Transaction";
            // 
            // TotalPriceAmntCounterLabel
            // 
            TotalPriceAmntCounterLabel.AutoSize = true;
            TotalPriceAmntCounterLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            TotalPriceAmntCounterLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            TotalPriceAmntCounterLabel.ForeColor = Color.FromArgb(0, 157, 209);
            TotalPriceAmntCounterLabel.Location = new Point(872, 564);
            TotalPriceAmntCounterLabel.Name = "TotalPriceAmntCounterLabel";
            TotalPriceAmntCounterLabel.Size = new Size(157, 19);
            TotalPriceAmntCounterLabel.TabIndex = 83;
            TotalPriceAmntCounterLabel.Text = "Total Price Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 157, 209);
            label1.Location = new Point(768, 564);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 82;
            label1.Text = "Total Price:";
            // 
            // SellerItemComboBox
            // 
            SellerItemComboBox.DropDownHeight = 120;
            SellerItemComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SellerItemComboBox.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellerItemComboBox.ForeColor = Color.Gray;
            SellerItemComboBox.FormattingEnabled = true;
            SellerItemComboBox.IntegralHeight = false;
            SellerItemComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            SellerItemComboBox.Location = new Point(3, 80);
            SellerItemComboBox.Name = "SellerItemComboBox";
            SellerItemComboBox.Size = new Size(195, 39);
            SellerItemComboBox.TabIndex = 81;
            // 
            // SaveSellerTransaction_Button
            // 
            SaveSellerTransaction_Button.BackColor = Color.FromArgb(0, 0, 0, 0);
            SaveSellerTransaction_Button.CheckButton = false;
            SaveSellerTransaction_Button.Checked = false;
            SaveSellerTransaction_Button.CheckedBackground = Color.FromArgb(255, 106, 0);
            SaveSellerTransaction_Button.CheckedForeColor = Color.White;
            SaveSellerTransaction_Button.CheckedImageTint = Color.White;
            SaveSellerTransaction_Button.CheckedOutline = Color.FromArgb(255, 106, 0);
            SaveSellerTransaction_Button.Content = "Save Seller Transaction";
            SaveSellerTransaction_Button.DialogResult = DialogResult.None;
            SaveSellerTransaction_Button.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveSellerTransaction_Button.ForeColor = Color.White;
            SaveSellerTransaction_Button.HoverBackground = Color.White;
            SaveSellerTransaction_Button.HoveredImageTint = Color.White;
            SaveSellerTransaction_Button.HoverForeColor = Color.Black;
            SaveSellerTransaction_Button.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SaveSellerTransaction_Button.Image = null;
            SaveSellerTransaction_Button.ImageAutoCenter = true;
            SaveSellerTransaction_Button.ImageExpand = new Point(0, 0);
            SaveSellerTransaction_Button.ImageOffset = new Point(0, 0);
            SaveSellerTransaction_Button.Location = new Point(664, 614);
            SaveSellerTransaction_Button.Name = "SaveSellerTransaction_Button";
            SaveSellerTransaction_Button.NormalBackground = Color.FromArgb(0, 157, 209);
            SaveSellerTransaction_Button.NormalForeColor = Color.White;
            SaveSellerTransaction_Button.NormalImageTint = Color.White;
            SaveSellerTransaction_Button.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SaveSellerTransaction_Button.OutlineThickness = 1F;
            SaveSellerTransaction_Button.PressedBackground = Color.WhiteSmoke;
            SaveSellerTransaction_Button.PressedForeColor = Color.FromArgb(32, 32, 32);
            SaveSellerTransaction_Button.PressedImageTint = Color.White;
            SaveSellerTransaction_Button.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SaveSellerTransaction_Button.Rounding = new Padding(8);
            SaveSellerTransaction_Button.Size = new Size(227, 34);
            SaveSellerTransaction_Button.TabIndex = 80;
            SaveSellerTransaction_Button.TextAlignment = StringAlignment.Center;
            SaveSellerTransaction_Button.TextOffset = new Point(0, 0);
            SaveSellerTransaction_Button.Click += SaveSellerTransaction_Button_Click;
            // 
            // SellerClearBtn
            // 
            SellerClearBtn.BackColor = Color.FromArgb(0, 0, 0, 0);
            SellerClearBtn.CheckButton = false;
            SellerClearBtn.Checked = false;
            SellerClearBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            SellerClearBtn.CheckedForeColor = Color.White;
            SellerClearBtn.CheckedImageTint = Color.White;
            SellerClearBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            SellerClearBtn.Content = "Clear";
            SellerClearBtn.DialogResult = DialogResult.None;
            SellerClearBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerClearBtn.ForeColor = Color.Black;
            SellerClearBtn.HoverBackground = Color.White;
            SellerClearBtn.HoveredImageTint = Color.White;
            SellerClearBtn.HoverForeColor = Color.Black;
            SellerClearBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SellerClearBtn.Image = null;
            SellerClearBtn.ImageAutoCenter = true;
            SellerClearBtn.ImageExpand = new Point(0, 0);
            SellerClearBtn.ImageOffset = new Point(0, 0);
            SellerClearBtn.Location = new Point(902, 614);
            SellerClearBtn.Name = "SellerClearBtn";
            SellerClearBtn.NormalBackground = Color.White;
            SellerClearBtn.NormalForeColor = Color.Black;
            SellerClearBtn.NormalImageTint = Color.White;
            SellerClearBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SellerClearBtn.OutlineThickness = 1F;
            SellerClearBtn.PressedBackground = Color.WhiteSmoke;
            SellerClearBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            SellerClearBtn.PressedImageTint = Color.White;
            SellerClearBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SellerClearBtn.Rounding = new Padding(8);
            SellerClearBtn.Size = new Size(122, 34);
            SellerClearBtn.TabIndex = 79;
            SellerClearBtn.TextAlignment = StringAlignment.Center;
            SellerClearBtn.TextOffset = new Point(0, 0);
            SellerClearBtn.Click += SellerClearBtn_Click;
            // 
            // SellerAddTransacBtn
            // 
            SellerAddTransacBtn.BackColor = Color.FromArgb(0, 0, 0, 0);
            SellerAddTransacBtn.CheckButton = false;
            SellerAddTransacBtn.Checked = false;
            SellerAddTransacBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            SellerAddTransacBtn.CheckedForeColor = Color.White;
            SellerAddTransacBtn.CheckedImageTint = Color.White;
            SellerAddTransacBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            SellerAddTransacBtn.Content = "Add";
            SellerAddTransacBtn.DialogResult = DialogResult.None;
            SellerAddTransacBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerAddTransacBtn.ForeColor = Color.White;
            SellerAddTransacBtn.HoverBackground = Color.White;
            SellerAddTransacBtn.HoveredImageTint = Color.White;
            SellerAddTransacBtn.HoverForeColor = Color.Black;
            SellerAddTransacBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SellerAddTransacBtn.Image = null;
            SellerAddTransacBtn.ImageAutoCenter = true;
            SellerAddTransacBtn.ImageExpand = new Point(0, 0);
            SellerAddTransacBtn.ImageOffset = new Point(0, 0);
            SellerAddTransacBtn.Location = new Point(417, 84);
            SellerAddTransacBtn.Name = "SellerAddTransacBtn";
            SellerAddTransacBtn.NormalBackground = Color.FromArgb(0, 157, 209);
            SellerAddTransacBtn.NormalForeColor = Color.White;
            SellerAddTransacBtn.NormalImageTint = Color.White;
            SellerAddTransacBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SellerAddTransacBtn.OutlineThickness = 1F;
            SellerAddTransacBtn.PressedBackground = Color.WhiteSmoke;
            SellerAddTransacBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            SellerAddTransacBtn.PressedImageTint = Color.White;
            SellerAddTransacBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SellerAddTransacBtn.Rounding = new Padding(8);
            SellerAddTransacBtn.Size = new Size(123, 34);
            SellerAddTransacBtn.TabIndex = 78;
            SellerAddTransacBtn.TextAlignment = StringAlignment.Center;
            SellerAddTransacBtn.TextOffset = new Point(0, 0);
            SellerAddTransacBtn.Click += SellerAddTransacBtn_Click;
            // 
            // BuyerContact
            // 
            BuyerContact.AutoSize = true;
            BuyerContact.BackColor = Color.FromArgb(0, 0, 0, 0);
            BuyerContact.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            BuyerContact.ForeColor = Color.FromArgb(0, 157, 209);
            BuyerContact.Location = new Point(274, 526);
            BuyerContact.Name = "BuyerContact";
            BuyerContact.Size = new Size(103, 19);
            BuyerContact.TabIndex = 77;
            BuyerContact.Text = "Contact No.";
            // 
            // SellerContactTextBox
            // 
            SellerContactTextBox.BackgroundColor = Color.White;
            SellerContactTextBox.BorderColor = Color.FromArgb(0, 157, 209);
            SellerContactTextBox.Content = "";
            SellerContactTextBox.FocusBackgroundColor = Color.White;
            SellerContactTextBox.FocusBorderColor = Color.Empty;
            SellerContactTextBox.FocusImageTint = Color.White;
            SellerContactTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellerContactTextBox.ForeColor = Color.Gray;
            SellerContactTextBox.Image = null;
            SellerContactTextBox.ImageExpand = new Point(0, 0);
            SellerContactTextBox.ImageOffset = new Point(0, 0);
            SellerContactTextBox.Location = new Point(274, 549);
            SellerContactTextBox.Margin = new Padding(4);
            SellerContactTextBox.Multiline = false;
            SellerContactTextBox.Name = "SellerContactTextBox";
            SellerContactTextBox.NormalImageTint = Color.White;
            SellerContactTextBox.Padding = new Padding(20, 9, 20, 0);
            SellerContactTextBox.PasswordChar = false;
            SellerContactTextBox.PlaceholderColor = Color.Gray;
            SellerContactTextBox.PlaceholderText = "Contact No.";
            SellerContactTextBox.Rounding = new Padding(8);
            SellerContactTextBox.Size = new Size(277, 38);
            SellerContactTextBox.TabIndex = 76;
            SellerContactTextBox.TextOffset = new Size(0, 0);
            SellerContactTextBox.UnderlinedStyle = false;
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.BackColor = Color.FromArgb(0, 0, 0, 0);
            CustomerName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            CustomerName.ForeColor = Color.FromArgb(0, 157, 209);
            CustomerName.Location = new Point(7, 526);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(102, 19);
            CustomerName.TabIndex = 75;
            CustomerName.Text = "Seller Name";
            // 
            // SellerNameTextBox
            // 
            SellerNameTextBox.BackgroundColor = Color.White;
            SellerNameTextBox.BorderColor = Color.FromArgb(0, 157, 209);
            SellerNameTextBox.Content = "";
            SellerNameTextBox.FocusBackgroundColor = Color.White;
            SellerNameTextBox.FocusBorderColor = Color.Empty;
            SellerNameTextBox.FocusImageTint = Color.White;
            SellerNameTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellerNameTextBox.ForeColor = Color.Gray;
            SellerNameTextBox.Image = null;
            SellerNameTextBox.ImageExpand = new Point(0, 0);
            SellerNameTextBox.ImageOffset = new Point(0, 0);
            SellerNameTextBox.Location = new Point(7, 549);
            SellerNameTextBox.Margin = new Padding(4);
            SellerNameTextBox.Multiline = false;
            SellerNameTextBox.Name = "SellerNameTextBox";
            SellerNameTextBox.NormalImageTint = Color.White;
            SellerNameTextBox.Padding = new Padding(20, 9, 20, 0);
            SellerNameTextBox.PasswordChar = false;
            SellerNameTextBox.PlaceholderColor = Color.Gray;
            SellerNameTextBox.PlaceholderText = "Seller Name";
            SellerNameTextBox.Rounding = new Padding(8);
            SellerNameTextBox.Size = new Size(254, 38);
            SellerNameTextBox.TabIndex = 74;
            SellerNameTextBox.TextOffset = new Size(0, 0);
            SellerNameTextBox.UnderlinedStyle = false;
            // 
            // TransactionQuantity
            // 
            TransactionQuantity.AutoSize = true;
            TransactionQuantity.BackColor = Color.FromArgb(0, 0, 0, 0);
            TransactionQuantity.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            TransactionQuantity.ForeColor = Color.FromArgb(0, 157, 209);
            TransactionQuantity.Location = new Point(210, 57);
            TransactionQuantity.Name = "TransactionQuantity";
            TransactionQuantity.Size = new Size(76, 19);
            TransactionQuantity.TabIndex = 73;
            TransactionQuantity.Text = "Quantity";
            // 
            // SellerQtyTextBox
            // 
            SellerQtyTextBox.BackgroundColor = Color.White;
            SellerQtyTextBox.BorderColor = Color.FromArgb(0, 157, 209);
            SellerQtyTextBox.Content = "";
            SellerQtyTextBox.FocusBackgroundColor = Color.White;
            SellerQtyTextBox.FocusBorderColor = Color.Empty;
            SellerQtyTextBox.FocusImageTint = Color.White;
            SellerQtyTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellerQtyTextBox.ForeColor = Color.Gray;
            SellerQtyTextBox.Image = null;
            SellerQtyTextBox.ImageExpand = new Point(0, 0);
            SellerQtyTextBox.ImageOffset = new Point(0, 0);
            SellerQtyTextBox.Location = new Point(210, 80);
            SellerQtyTextBox.Margin = new Padding(4);
            SellerQtyTextBox.Multiline = false;
            SellerQtyTextBox.Name = "SellerQtyTextBox";
            SellerQtyTextBox.NormalImageTint = Color.White;
            SellerQtyTextBox.Padding = new Padding(20, 9, 20, 0);
            SellerQtyTextBox.PasswordChar = false;
            SellerQtyTextBox.PlaceholderColor = Color.Gray;
            SellerQtyTextBox.PlaceholderText = "Quantity";
            SellerQtyTextBox.Rounding = new Padding(8);
            SellerQtyTextBox.Size = new Size(195, 38);
            SellerQtyTextBox.TabIndex = 72;
            SellerQtyTextBox.TextOffset = new Size(0, 0);
            SellerQtyTextBox.UnderlinedStyle = false;
            // 
            // IdItem
            // 
            IdItem.AutoSize = true;
            IdItem.BackColor = Color.FromArgb(0, 0, 0, 0);
            IdItem.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            IdItem.ForeColor = Color.FromArgb(0, 157, 209);
            IdItem.Location = new Point(3, 58);
            IdItem.Name = "IdItem";
            IdItem.Size = new Size(63, 19);
            IdItem.TabIndex = 71;
            IdItem.Text = "Item ID";
            // 
            // SellerOrdersTable
            // 
            SellerOrdersTable.AllowUserToAddRows = false;
            SellerOrdersTable.AllowUserToDeleteRows = false;
            SellerOrdersTable.AllowUserToResizeColumns = false;
            SellerOrdersTable.AllowUserToResizeRows = false;
            SellerOrdersTable.BackgroundColor = Color.White;
            SellerOrdersTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            SellerOrdersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SellerOrdersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SellerOrdersTable.ColumnHeadersHeight = 60;
            SellerOrdersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            SellerOrdersTable.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, QtyType, BuyingPrice, TransacQuantity, ExchangeAmount, Edit, Remove });
            SellerOrdersTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            SellerOrdersTable.EnableHeadersVisualStyles = false;
            SellerOrdersTable.GridColor = Color.FromArgb(99, 99, 99);
            SellerOrdersTable.Location = new Point(3, 135);
            SellerOrdersTable.Name = "SellerOrdersTable";
            SellerOrdersTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SellerOrdersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            SellerOrdersTable.RowHeadersVisible = false;
            SellerOrdersTable.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            SellerOrdersTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            SellerOrdersTable.RowTemplate.Height = 50;
            SellerOrdersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SellerOrdersTable.Size = new Size(1048, 376);
            SellerOrdersTable.TabIndex = 87;
            // 
            // ItemID
            // 
            ItemID.HeaderText = "ItemID";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.Width = 125;
            // 
            // ItemName
            // 
            ItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            // 
            // QtyType
            // 
            QtyType.FillWeight = 125F;
            QtyType.HeaderText = "QtyType";
            QtyType.MinimumWidth = 6;
            QtyType.Name = "QtyType";
            QtyType.Width = 125;
            // 
            // BuyingPrice
            // 
            BuyingPrice.FillWeight = 150F;
            BuyingPrice.HeaderText = "Buying Price";
            BuyingPrice.MinimumWidth = 6;
            BuyingPrice.Name = "BuyingPrice";
            BuyingPrice.Width = 150;
            // 
            // TransacQuantity
            // 
            TransacQuantity.FillWeight = 59.177578F;
            TransacQuantity.HeaderText = "Exchange Quantity";
            TransacQuantity.MinimumWidth = 6;
            TransacQuantity.Name = "TransacQuantity";
            TransacQuantity.Width = 150;
            // 
            // ExchangeAmount
            // 
            ExchangeAmount.FillWeight = 59.177578F;
            ExchangeAmount.HeaderText = "Exchange Amount";
            ExchangeAmount.MinimumWidth = 6;
            ExchangeAmount.Name = "ExchangeAmount";
            ExchangeAmount.Width = 150;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.green_edit;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 70;
            // 
            // Remove
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new Padding(10);
            Remove.DefaultCellStyle = dataGridViewCellStyle2;
            Remove.FillWeight = 5.618882F;
            Remove.HeaderText = "Remove";
            Remove.Image = Properties.Resources.delete;
            Remove.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Remove.MinimumWidth = 6;
            Remove.Name = "Remove";
            Remove.Resizable = DataGridViewTriState.False;
            Remove.Width = 70;
            // 
            // SellerTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SellerOrdersTable);
            Controls.Add(TotalItemsCounterLabel);
            Controls.Add(label3);
            Controls.Add(RegEmployeeTitlePage);
            Controls.Add(TotalPriceAmntCounterLabel);
            Controls.Add(label1);
            Controls.Add(SellerItemComboBox);
            Controls.Add(SaveSellerTransaction_Button);
            Controls.Add(SellerClearBtn);
            Controls.Add(SellerAddTransacBtn);
            Controls.Add(BuyerContact);
            Controls.Add(SellerContactTextBox);
            Controls.Add(CustomerName);
            Controls.Add(SellerNameTextBox);
            Controls.Add(TransactionQuantity);
            Controls.Add(SellerQtyTextBox);
            Controls.Add(IdItem);
            Name = "SellerTransaction";
            Size = new Size(1054, 661);
            ((System.ComponentModel.ISupportInitialize)SellerOrdersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TotalItemsCounterLabel;
        private Label label3;
        private Label RegEmployeeTitlePage;
        private Label TotalPriceAmntCounterLabel;
        private Label label1;
        private ComboBox SellerItemComboBox;
        private CuoreUI.Controls.cuiButton SaveSellerTransaction_Button;
        private CuoreUI.Controls.cuiButton SellerClearBtn;
        private CuoreUI.Controls.cuiButton SellerAddTransacBtn;
        private Label BuyerContact;
        private CuoreUI.Controls.cuiTextBox SellerContactTextBox;
        private Label CustomerName;
        private CuoreUI.Controls.cuiTextBox SellerNameTextBox;
        private Label TransactionQuantity;
        private CuoreUI.Controls.cuiTextBox SellerQtyTextBox;
        private Label IdItem;
        private DataGridView SellerOrdersTable;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn QtyType;
        private DataGridViewTextBoxColumn BuyingPrice;
        private DataGridViewTextBoxColumn TransacQuantity;
        private DataGridViewTextBoxColumn ExchangeAmount;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Remove;
    }
}
