namespace JunkShopInventoryandTransactionSystem.View
{
    partial class receiptlogo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BuyersOrderTable = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            TransacQuantity = new DataGridViewTextBoxColumn();
            ExchangeAmount = new DataGridViewTextBoxColumn();
            receiptname = new Label();
            receiptInvoice = new Label();
            pictureBox1 = new PictureBox();
            ReceiptContactNo = new Label();
            ReceiptCustName = new Label();
            ReceiptCustNo = new Label();
            ReceiptTotalItem = new Label();
            ReceiptTotalPrice = new Label();
            label1 = new Label();
            label2 = new Label();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)BuyersOrderTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BuyersOrderTable
            // 
            BuyersOrderTable.AllowUserToAddRows = false;
            BuyersOrderTable.AllowUserToDeleteRows = false;
            BuyersOrderTable.AllowUserToResizeColumns = false;
            BuyersOrderTable.AllowUserToResizeRows = false;
            BuyersOrderTable.BackgroundColor = Color.White;
            BuyersOrderTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            BuyersOrderTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BuyersOrderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BuyersOrderTable.ColumnHeadersHeight = 60;
            BuyersOrderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BuyersOrderTable.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, QtyType, SellingPrice, TransacQuantity, ExchangeAmount });
            BuyersOrderTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            BuyersOrderTable.EnableHeadersVisualStyles = false;
            BuyersOrderTable.GridColor = Color.FromArgb(99, 99, 99);
            BuyersOrderTable.Location = new Point(10, 193);
            BuyersOrderTable.Name = "BuyersOrderTable";
            BuyersOrderTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BuyersOrderTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BuyersOrderTable.RowHeadersVisible = false;
            BuyersOrderTable.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BuyersOrderTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            BuyersOrderTable.RowTemplate.Height = 50;
            BuyersOrderTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BuyersOrderTable.Size = new Size(746, 203);
            BuyersOrderTable.TabIndex = 52;
            BuyersOrderTable.CellContentClick += BuyersOrderTable_CellContentClick;
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
            // SellingPrice
            // 
            SellingPrice.FillWeight = 150F;
            SellingPrice.HeaderText = "Selling Price";
            SellingPrice.MinimumWidth = 6;
            SellingPrice.Name = "SellingPrice";
            SellingPrice.Width = 150;
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
            // receiptname
            // 
            receiptname.AutoSize = true;
            receiptname.BackColor = Color.FromArgb(0, 0, 0, 0);
            receiptname.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            receiptname.ForeColor = Color.Black;
            receiptname.Location = new Point(19, 126);
            receiptname.Name = "receiptname";
            receiptname.Size = new Size(125, 18);
            receiptname.TabIndex = 54;
            receiptname.Text = "Customer Name:";
            receiptname.Click += IdItem_Click;
            // 
            // receiptInvoice
            // 
            receiptInvoice.AutoSize = true;
            receiptInvoice.BackColor = Color.FromArgb(0, 0, 0, 0);
            receiptInvoice.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiptInvoice.ForeColor = Color.FromArgb(0, 157, 209);
            receiptInvoice.Location = new Point(575, 18);
            receiptInvoice.Name = "receiptInvoice";
            receiptInvoice.Size = new Size(191, 34);
            receiptInvoice.TabIndex = 55;
            receiptInvoice.Text = "I N V O I C E";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.JUNKSHOP__9___1_;
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // ReceiptContactNo
            // 
            ReceiptContactNo.AutoSize = true;
            ReceiptContactNo.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptContactNo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptContactNo.ForeColor = Color.Black;
            ReceiptContactNo.Location = new Point(19, 154);
            ReceiptContactNo.Name = "ReceiptContactNo";
            ReceiptContactNo.Size = new Size(127, 18);
            ReceiptContactNo.TabIndex = 57;
            ReceiptContactNo.Text = "Contact Number:";
            // 
            // ReceiptCustName
            // 
            ReceiptCustName.AutoSize = true;
            ReceiptCustName.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptCustName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceiptCustName.ForeColor = SystemColors.ControlDarkDark;
            ReceiptCustName.Location = new Point(154, 126);
            ReceiptCustName.Name = "ReceiptCustName";
            ReceiptCustName.Size = new Size(116, 17);
            ReceiptCustName.TabIndex = 58;
            ReceiptCustName.Text = "Customer Name";
            // 
            // ReceiptCustNo
            // 
            ReceiptCustNo.AutoSize = true;
            ReceiptCustNo.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptCustNo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceiptCustNo.ForeColor = SystemColors.ControlDarkDark;
            ReceiptCustNo.Location = new Point(154, 154);
            ReceiptCustNo.Name = "ReceiptCustNo";
            ReceiptCustNo.Size = new Size(115, 17);
            ReceiptCustNo.TabIndex = 59;
            ReceiptCustNo.Text = "Contact Number";
            // 
            // ReceiptTotalItem
            // 
            ReceiptTotalItem.AutoSize = true;
            ReceiptTotalItem.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptTotalItem.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptTotalItem.ForeColor = Color.Black;
            ReceiptTotalItem.Location = new Point(471, 416);
            ReceiptTotalItem.Name = "ReceiptTotalItem";
            ReceiptTotalItem.Size = new Size(81, 18);
            ReceiptTotalItem.TabIndex = 60;
            ReceiptTotalItem.Text = "Total Item ";
            ReceiptTotalItem.Click += ReceiptTotalItem_Click;
            // 
            // ReceiptTotalPrice
            // 
            ReceiptTotalPrice.AutoSize = true;
            ReceiptTotalPrice.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptTotalPrice.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptTotalPrice.ForeColor = Color.Black;
            ReceiptTotalPrice.Location = new Point(471, 448);
            ReceiptTotalPrice.Name = "ReceiptTotalPrice";
            ReceiptTotalPrice.Size = new Size(84, 18);
            ReceiptTotalPrice.TabIndex = 61;
            ReceiptTotalPrice.Text = "Total Price";
            ReceiptTotalPrice.Click += ReceiptTotalPrice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(640, 416);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 62;
            label1.Text = "Total Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(640, 448);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 63;
            label2.Text = "Total Price";
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = SystemColors.ControlLight;
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
            cuiButton1.NormalBackground = SystemColors.ControlLight;
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
            cuiTextBox1.Location = new Point(38, 1);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cuiButton1);
            panel1.Controls.Add(cuiTextBox1);
            panel1.Location = new Point(378, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 40);
            panel1.TabIndex = 64;
            // 
            // receiptlogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 489);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReceiptTotalPrice);
            Controls.Add(ReceiptTotalItem);
            Controls.Add(ReceiptCustNo);
            Controls.Add(ReceiptCustName);
            Controls.Add(ReceiptContactNo);
            Controls.Add(pictureBox1);
            Controls.Add(receiptInvoice);
            Controls.Add(receiptname);
            Controls.Add(BuyersOrderTable);
            Margin = new Padding(2);
            Name = "receiptlogo";
            Text = "receipt";
            ((System.ComponentModel.ISupportInitialize)BuyersOrderTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BuyersOrderTable;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn QtyType;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn TransacQuantity;
        private DataGridViewTextBoxColumn ExchangeAmount;
        private Label receiptname;
        private Label receiptInvoice;
        private PictureBox pictureBox1;
        private Label ReceiptContactNo;
        private Label ReceiptCustName;
        private Label ReceiptCustNo;
        private Label ReceiptTotalItem;
        private Label ReceiptTotalPrice;
        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private Panel panel1;
    }
}