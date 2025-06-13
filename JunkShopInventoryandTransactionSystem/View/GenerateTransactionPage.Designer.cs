namespace JunkShopInventoryandTransactionSystem.View
{
    partial class GenerateTransactionPage
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
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateTransactionPage));
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DashboardTitlePage = new Label();
            dataGridView1 = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            TransacQuantity = new DataGridViewTextBoxColumn();
            ExchangeAmount = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            TransactionID = new Label();
            CustomerType = new Label();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            IdItem = new Label();
            cuiTextBox3 = new CuoreUI.Controls.cuiTextBox();
            TransactionQuantity = new Label();
            cuiTextBox4 = new CuoreUI.Controls.cuiTextBox();
            CustomerName = new Label();
            cuiTextBox5 = new CuoreUI.Controls.cuiTextBox();
            CustomerContact = new Label();
            cuiTextBox6 = new CuoreUI.Controls.cuiTextBox();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiButton3 = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 18F, FontStyle.Bold);
            DashboardTitlePage.ForeColor = Color.FromArgb(0, 157, 209);
            DashboardTitlePage.Location = new Point(31, 32);
            DashboardTitlePage.Margin = new Padding(4, 0, 4, 0);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(386, 43);
            DashboardTitlePage.TabIndex = 6;
            DashboardTitlePage.Text = "Generate Transaction";
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
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle21.ForeColor = Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle21.SelectionForeColor = Color.Black;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, Category, QtyType, TransacQuantity, ExchangeAmount, Edit, Delete });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(99, 99, 99);
            dataGridView1.Location = new Point(18, 219);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle25.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle25.ForeColor = Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1320, 526);
            dataGridView1.TabIndex = 30;
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
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.Width = 175;
            // 
            // Category
            // 
            Category.FillWeight = 150F;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 175;
            // 
            // QtyType
            // 
            QtyType.FillWeight = 125F;
            QtyType.HeaderText = "QtyType";
            QtyType.MinimumWidth = 6;
            QtyType.Name = "QtyType";
            QtyType.Width = 125;
            // 
            // TransacQuantity
            // 
            TransacQuantity.FillWeight = 59.177578F;
            TransacQuantity.HeaderText = "Exchange Quantity";
            TransacQuantity.MinimumWidth = 6;
            TransacQuantity.Name = "TransacQuantity";
            TransacQuantity.Width = 130;
            // 
            // ExchangeAmount
            // 
            ExchangeAmount.FillWeight = 59.177578F;
            ExchangeAmount.HeaderText = "Exchange Amount";
            ExchangeAmount.MinimumWidth = 6;
            ExchangeAmount.Name = "ExchangeAmount";
            ExchangeAmount.Width = 130;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.NullValue = resources.GetObject("dataGridViewCellStyle22.NullValue");
            dataGridViewCellStyle22.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle22;
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
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.NullValue = resources.GetObject("dataGridViewCellStyle23.NullValue");
            dataGridViewCellStyle23.Padding = new Padding(10);
            Delete.DefaultCellStyle = dataGridViewCellStyle23;
            Delete.FillWeight = 5.618882F;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.BorderColor = Color.FromArgb(16, 107, 23);
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.Empty;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Gray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(31, 141);
            cuiTextBox1.Margin = new Padding(5, 5, 5, 5);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(24, 15, 24, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.Gray;
            cuiTextBox1.PlaceholderText = "Transaction ID";
            cuiTextBox1.Rounding = new Padding(8);
            cuiTextBox1.Size = new Size(234, 55);
            cuiTextBox1.TabIndex = 31;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // TransactionID
            // 
            TransactionID.AutoSize = true;
            TransactionID.BackColor = Color.FromArgb(0, 0, 0, 0);
            TransactionID.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            TransactionID.ForeColor = Color.FromArgb(16, 107, 23);
            TransactionID.Location = new Point(31, 112);
            TransactionID.Margin = new Padding(4, 0, 4, 0);
            TransactionID.Name = "TransactionID";
            TransactionID.Size = new Size(155, 24);
            TransactionID.TabIndex = 32;
            TransactionID.Text = "Transaction ID";
            // 
            // CustomerType
            // 
            CustomerType.AutoSize = true;
            CustomerType.BackColor = Color.FromArgb(0, 0, 0, 0);
            CustomerType.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            CustomerType.ForeColor = Color.FromArgb(16, 107, 23);
            CustomerType.Location = new Point(22, 778);
            CustomerType.Margin = new Padding(4, 0, 4, 0);
            CustomerType.Name = "CustomerType";
            CustomerType.Size = new Size(162, 24);
            CustomerType.TabIndex = 34;
            CustomerType.Text = "Customer Type";
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.BackgroundColor = Color.White;
            cuiTextBox2.BorderColor = Color.FromArgb(16, 107, 23);
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusBorderColor = Color.Empty;
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Gray;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.Location = new Point(22, 806);
            cuiTextBox2.Margin = new Padding(5, 5, 5, 5);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.Padding = new Padding(25, 15, 25, 0);
            cuiTextBox2.PasswordChar = false;
            cuiTextBox2.PlaceholderColor = Color.Gray;
            cuiTextBox2.PlaceholderText = "Item Name";
            cuiTextBox2.Rounding = new Padding(8);
            cuiTextBox2.Size = new Size(415, 55);
            cuiTextBox2.TabIndex = 33;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = false;
            // 
            // IdItem
            // 
            IdItem.AutoSize = true;
            IdItem.BackColor = Color.FromArgb(0, 0, 0, 0);
            IdItem.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            IdItem.ForeColor = Color.FromArgb(16, 107, 23);
            IdItem.Location = new Point(275, 112);
            IdItem.Margin = new Padding(4, 0, 4, 0);
            IdItem.Name = "IdItem";
            IdItem.Size = new Size(79, 24);
            IdItem.TabIndex = 36;
            IdItem.Text = "Item ID";
            // 
            // cuiTextBox3
            // 
            cuiTextBox3.BackgroundColor = Color.White;
            cuiTextBox3.BorderColor = Color.FromArgb(16, 107, 23);
            cuiTextBox3.Content = "";
            cuiTextBox3.FocusBackgroundColor = Color.White;
            cuiTextBox3.FocusBorderColor = Color.Empty;
            cuiTextBox3.FocusImageTint = Color.White;
            cuiTextBox3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox3.ForeColor = Color.Gray;
            cuiTextBox3.Image = null;
            cuiTextBox3.ImageExpand = new Point(0, 0);
            cuiTextBox3.ImageOffset = new Point(0, 0);
            cuiTextBox3.Location = new Point(275, 141);
            cuiTextBox3.Margin = new Padding(5, 5, 5, 5);
            cuiTextBox3.Multiline = false;
            cuiTextBox3.Name = "cuiTextBox3";
            cuiTextBox3.NormalImageTint = Color.White;
            cuiTextBox3.Padding = new Padding(24, 15, 24, 0);
            cuiTextBox3.PasswordChar = false;
            cuiTextBox3.PlaceholderColor = Color.Gray;
            cuiTextBox3.PlaceholderText = "Item ID";
            cuiTextBox3.Rounding = new Padding(8);
            cuiTextBox3.Size = new Size(234, 55);
            cuiTextBox3.TabIndex = 35;
            cuiTextBox3.TextOffset = new Size(0, 0);
            cuiTextBox3.UnderlinedStyle = false;
            // 
            // TransactionQuantity
            // 
            TransactionQuantity.AutoSize = true;
            TransactionQuantity.BackColor = Color.FromArgb(0, 0, 0, 0);
            TransactionQuantity.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            TransactionQuantity.ForeColor = Color.FromArgb(16, 107, 23);
            TransactionQuantity.Location = new Point(519, 112);
            TransactionQuantity.Margin = new Padding(4, 0, 4, 0);
            TransactionQuantity.Name = "TransactionQuantity";
            TransactionQuantity.Size = new Size(94, 24);
            TransactionQuantity.TabIndex = 38;
            TransactionQuantity.Text = "Quantity";
            // 
            // cuiTextBox4
            // 
            cuiTextBox4.BackgroundColor = Color.White;
            cuiTextBox4.BorderColor = Color.FromArgb(16, 107, 23);
            cuiTextBox4.Content = "";
            cuiTextBox4.FocusBackgroundColor = Color.White;
            cuiTextBox4.FocusBorderColor = Color.Empty;
            cuiTextBox4.FocusImageTint = Color.White;
            cuiTextBox4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox4.ForeColor = Color.Gray;
            cuiTextBox4.Image = null;
            cuiTextBox4.ImageExpand = new Point(0, 0);
            cuiTextBox4.ImageOffset = new Point(0, 0);
            cuiTextBox4.Location = new Point(519, 141);
            cuiTextBox4.Margin = new Padding(5, 5, 5, 5);
            cuiTextBox4.Multiline = false;
            cuiTextBox4.Name = "cuiTextBox4";
            cuiTextBox4.NormalImageTint = Color.White;
            cuiTextBox4.Padding = new Padding(24, 15, 24, 0);
            cuiTextBox4.PasswordChar = false;
            cuiTextBox4.PlaceholderColor = Color.Gray;
            cuiTextBox4.PlaceholderText = "Quantity";
            cuiTextBox4.Rounding = new Padding(8);
            cuiTextBox4.Size = new Size(234, 55);
            cuiTextBox4.TabIndex = 37;
            cuiTextBox4.TextOffset = new Size(0, 0);
            cuiTextBox4.UnderlinedStyle = false;
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.BackColor = Color.FromArgb(0, 0, 0, 0);
            CustomerName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            CustomerName.ForeColor = Color.FromArgb(16, 107, 23);
            CustomerName.Location = new Point(450, 778);
            CustomerName.Margin = new Padding(4, 0, 4, 0);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(172, 24);
            CustomerName.TabIndex = 40;
            CustomerName.Text = "Customer Name";
            // 
            // cuiTextBox5
            // 
            cuiTextBox5.BackgroundColor = Color.White;
            cuiTextBox5.BorderColor = Color.FromArgb(16, 107, 23);
            cuiTextBox5.Content = "";
            cuiTextBox5.FocusBackgroundColor = Color.White;
            cuiTextBox5.FocusBorderColor = Color.Empty;
            cuiTextBox5.FocusImageTint = Color.White;
            cuiTextBox5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox5.ForeColor = Color.Gray;
            cuiTextBox5.Image = null;
            cuiTextBox5.ImageExpand = new Point(0, 0);
            cuiTextBox5.ImageOffset = new Point(0, 0);
            cuiTextBox5.Location = new Point(450, 806);
            cuiTextBox5.Margin = new Padding(5, 5, 5, 5);
            cuiTextBox5.Multiline = false;
            cuiTextBox5.Name = "cuiTextBox5";
            cuiTextBox5.NormalImageTint = Color.White;
            cuiTextBox5.Padding = new Padding(25, 15, 25, 0);
            cuiTextBox5.PasswordChar = false;
            cuiTextBox5.PlaceholderColor = Color.Gray;
            cuiTextBox5.PlaceholderText = "Item Name";
            cuiTextBox5.Rounding = new Padding(8);
            cuiTextBox5.Size = new Size(415, 55);
            cuiTextBox5.TabIndex = 39;
            cuiTextBox5.TextOffset = new Size(0, 0);
            cuiTextBox5.UnderlinedStyle = false;
            // 
            // CustomerContact
            // 
            CustomerContact.AutoSize = true;
            CustomerContact.BackColor = Color.FromArgb(0, 0, 0, 0);
            CustomerContact.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            CustomerContact.ForeColor = Color.FromArgb(16, 107, 23);
            CustomerContact.Location = new Point(880, 778);
            CustomerContact.Margin = new Padding(4, 0, 4, 0);
            CustomerContact.Name = "CustomerContact";
            CustomerContact.Size = new Size(194, 24);
            CustomerContact.TabIndex = 42;
            CustomerContact.Text = "Customer Contact";
            // 
            // cuiTextBox6
            // 
            cuiTextBox6.BackgroundColor = Color.White;
            cuiTextBox6.BorderColor = Color.FromArgb(16, 107, 23);
            cuiTextBox6.Content = "";
            cuiTextBox6.FocusBackgroundColor = Color.White;
            cuiTextBox6.FocusBorderColor = Color.Empty;
            cuiTextBox6.FocusImageTint = Color.White;
            cuiTextBox6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox6.ForeColor = Color.Gray;
            cuiTextBox6.Image = null;
            cuiTextBox6.ImageExpand = new Point(0, 0);
            cuiTextBox6.ImageOffset = new Point(0, 0);
            cuiTextBox6.Location = new Point(880, 806);
            cuiTextBox6.Margin = new Padding(5, 5, 5, 5);
            cuiTextBox6.Multiline = false;
            cuiTextBox6.Name = "cuiTextBox6";
            cuiTextBox6.NormalImageTint = Color.White;
            cuiTextBox6.Padding = new Padding(25, 15, 25, 0);
            cuiTextBox6.PasswordChar = false;
            cuiTextBox6.PlaceholderColor = Color.Gray;
            cuiTextBox6.PlaceholderText = "Item Name";
            cuiTextBox6.Rounding = new Padding(8);
            cuiTextBox6.Size = new Size(415, 55);
            cuiTextBox6.TabIndex = 41;
            cuiTextBox6.TextOffset = new Size(0, 0);
            cuiTextBox6.UnderlinedStyle = false;
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
            cuiButton2.Content = "Add";
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
            cuiButton2.Location = new Point(776, 141);
            cuiButton2.Margin = new Padding(4, 4, 4, 4);
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
            cuiButton2.Size = new Size(159, 50);
            cuiButton2.TabIndex = 43;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Clear";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(1159, 910);
            cuiButton1.Margin = new Padding(4, 4, 4, 4);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(159, 50);
            cuiButton1.TabIndex = 44;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // cuiButton3
            // 
            cuiButton3.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiButton3.CheckButton = false;
            cuiButton3.Checked = false;
            cuiButton3.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton3.CheckedForeColor = Color.White;
            cuiButton3.CheckedImageTint = Color.White;
            cuiButton3.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton3.Content = "Save";
            cuiButton3.DialogResult = DialogResult.None;
            cuiButton3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton3.ForeColor = Color.White;
            cuiButton3.HoverBackground = Color.White;
            cuiButton3.HoveredImageTint = Color.White;
            cuiButton3.HoverForeColor = Color.Black;
            cuiButton3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton3.Image = null;
            cuiButton3.ImageAutoCenter = true;
            cuiButton3.ImageExpand = new Point(0, 0);
            cuiButton3.ImageOffset = new Point(0, 0);
            cuiButton3.Location = new Point(992, 910);
            cuiButton3.Margin = new Padding(4, 4, 4, 4);
            cuiButton3.Name = "cuiButton3";
            cuiButton3.NormalBackground = Color.FromArgb(0, 157, 209);
            cuiButton3.NormalForeColor = Color.White;
            cuiButton3.NormalImageTint = Color.White;
            cuiButton3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.OutlineThickness = 1F;
            cuiButton3.PressedBackground = Color.WhiteSmoke;
            cuiButton3.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton3.PressedImageTint = Color.White;
            cuiButton3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.Rounding = new Padding(8);
            cuiButton3.Size = new Size(159, 50);
            cuiButton3.TabIndex = 45;
            cuiButton3.TextAlignment = StringAlignment.Center;
            cuiButton3.TextOffset = new Point(0, 0);
            // 
            // GenerateTransactionPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(cuiButton3);
            Controls.Add(cuiButton1);
            Controls.Add(cuiButton2);
            Controls.Add(CustomerContact);
            Controls.Add(cuiTextBox6);
            Controls.Add(CustomerName);
            Controls.Add(cuiTextBox5);
            Controls.Add(TransactionQuantity);
            Controls.Add(cuiTextBox4);
            Controls.Add(IdItem);
            Controls.Add(cuiTextBox3);
            Controls.Add(CustomerType);
            Controls.Add(cuiTextBox2);
            Controls.Add(TransactionID);
            Controls.Add(cuiTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(DashboardTitlePage);
            Margin = new Padding(4, 4, 4, 4);
            Name = "GenerateTransactionPage";
            Size = new Size(1355, 998);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private DataGridView dataGridView1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private Label TransactionID;
        private Label CustomerType;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private Label IdItem;
        private CuoreUI.Controls.cuiTextBox cuiTextBox3;
        private Label TransactionQuantity;
        private CuoreUI.Controls.cuiTextBox cuiTextBox4;
        private Label CustomerName;
        private CuoreUI.Controls.cuiTextBox cuiTextBox5;
        private Label CustomerContact;
        private CuoreUI.Controls.cuiTextBox cuiTextBox6;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn QtyType;
        private DataGridViewTextBoxColumn TransacQuantity;
        private DataGridViewTextBoxColumn ExchangeAmount;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton3;
    }
}
