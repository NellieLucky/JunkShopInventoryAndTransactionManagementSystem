namespace JunkShopInventoryandTransactionSystem.View.TransactionRecordsPageFolder
{
    partial class HistoricalReceipt
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
            TotalPriceHolder = new Label();
            TotalItemHolder = new Label();
            ReceiptTotalPrice = new Label();
            ReceiptTotalItem = new Label();
            ReceiptCustNo = new Label();
            ReceiptCustName = new Label();
            ReceiptContactNo = new Label();
            pictureBox1 = new PictureBox();
            receiptInvoice = new Label();
            receiptname = new Label();
            InvoiceReceiptTable = new DataGridView();
            TransacID = new DataGridViewTextBoxColumn();
            TransacDate = new DataGridViewTextBoxColumn();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TransacQuantity = new DataGridViewTextBoxColumn();
            TransacAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceReceiptTable).BeginInit();
            SuspendLayout();
            // 
            // TotalPriceHolder
            // 
            TotalPriceHolder.AutoSize = true;
            TotalPriceHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            TotalPriceHolder.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPriceHolder.ForeColor = SystemColors.ControlDarkDark;
            TotalPriceHolder.Location = new Point(643, 460);
            TotalPriceHolder.Name = "TotalPriceHolder";
            TotalPriceHolder.Size = new Size(64, 15);
            TotalPriceHolder.TabIndex = 74;
            TotalPriceHolder.Text = "Total Price";
            // 
            // TotalItemHolder
            // 
            TotalItemHolder.AutoSize = true;
            TotalItemHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            TotalItemHolder.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalItemHolder.ForeColor = SystemColors.ControlDarkDark;
            TotalItemHolder.Location = new Point(643, 428);
            TotalItemHolder.Name = "TotalItemHolder";
            TotalItemHolder.Size = new Size(60, 15);
            TotalItemHolder.TabIndex = 73;
            TotalItemHolder.Text = "Total Item";
            // 
            // ReceiptTotalPrice
            // 
            ReceiptTotalPrice.AutoSize = true;
            ReceiptTotalPrice.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptTotalPrice.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptTotalPrice.ForeColor = Color.Black;
            ReceiptTotalPrice.Location = new Point(474, 460);
            ReceiptTotalPrice.Name = "ReceiptTotalPrice";
            ReceiptTotalPrice.Size = new Size(67, 15);
            ReceiptTotalPrice.TabIndex = 72;
            ReceiptTotalPrice.Text = "Total Price";
            // 
            // ReceiptTotalItem
            // 
            ReceiptTotalItem.AutoSize = true;
            ReceiptTotalItem.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptTotalItem.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptTotalItem.ForeColor = Color.Black;
            ReceiptTotalItem.Location = new Point(474, 428);
            ReceiptTotalItem.Name = "ReceiptTotalItem";
            ReceiptTotalItem.Size = new Size(65, 15);
            ReceiptTotalItem.TabIndex = 71;
            ReceiptTotalItem.Text = "Total Item ";
            // 
            // ReceiptCustNo
            // 
            ReceiptCustNo.AutoSize = true;
            ReceiptCustNo.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptCustNo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceiptCustNo.ForeColor = SystemColors.ControlDarkDark;
            ReceiptCustNo.Location = new Point(157, 166);
            ReceiptCustNo.Name = "ReceiptCustNo";
            ReceiptCustNo.Size = new Size(97, 15);
            ReceiptCustNo.TabIndex = 70;
            ReceiptCustNo.Text = "Contact Number";
            // 
            // ReceiptCustName
            // 
            ReceiptCustName.AutoSize = true;
            ReceiptCustName.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptCustName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceiptCustName.ForeColor = SystemColors.ControlDarkDark;
            ReceiptCustName.Location = new Point(157, 138);
            ReceiptCustName.Name = "ReceiptCustName";
            ReceiptCustName.Size = new Size(99, 15);
            ReceiptCustName.TabIndex = 69;
            ReceiptCustName.Text = "Customer Name";
            // 
            // ReceiptContactNo
            // 
            ReceiptContactNo.AutoSize = true;
            ReceiptContactNo.BackColor = Color.FromArgb(0, 0, 0, 0);
            ReceiptContactNo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptContactNo.ForeColor = Color.Black;
            ReceiptContactNo.Location = new Point(22, 166);
            ReceiptContactNo.Name = "ReceiptContactNo";
            ReceiptContactNo.Size = new Size(102, 15);
            ReceiptContactNo.TabIndex = 68;
            ReceiptContactNo.Text = "Contact Number:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.JUNKSHOP__9___1_;
            pictureBox1.Location = new Point(7, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // receiptInvoice
            // 
            receiptInvoice.AutoSize = true;
            receiptInvoice.BackColor = Color.FromArgb(0, 0, 0, 0);
            receiptInvoice.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiptInvoice.ForeColor = Color.FromArgb(0, 157, 209);
            receiptInvoice.Location = new Point(578, 30);
            receiptInvoice.Name = "receiptInvoice";
            receiptInvoice.Size = new Size(152, 28);
            receiptInvoice.TabIndex = 66;
            receiptInvoice.Text = "I N V O I C E";
            // 
            // receiptname
            // 
            receiptname.AutoSize = true;
            receiptname.BackColor = Color.FromArgb(0, 0, 0, 0);
            receiptname.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            receiptname.ForeColor = Color.Black;
            receiptname.Location = new Point(22, 138);
            receiptname.Name = "receiptname";
            receiptname.Size = new Size(102, 15);
            receiptname.TabIndex = 65;
            receiptname.Text = "Customer Name:";
            // 
            // InvoiceReceiptTable
            // 
            InvoiceReceiptTable.AllowUserToAddRows = false;
            InvoiceReceiptTable.AllowUserToDeleteRows = false;
            InvoiceReceiptTable.AllowUserToResizeColumns = false;
            InvoiceReceiptTable.AllowUserToResizeRows = false;
            InvoiceReceiptTable.BackgroundColor = Color.White;
            InvoiceReceiptTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            InvoiceReceiptTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            InvoiceReceiptTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            InvoiceReceiptTable.ColumnHeadersHeight = 60;
            InvoiceReceiptTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            InvoiceReceiptTable.Columns.AddRange(new DataGridViewColumn[] { TransacID, TransacDate, ItemID, ItemName, QtyType, Price, TransacQuantity, TransacAmount });
            InvoiceReceiptTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            InvoiceReceiptTable.EnableHeadersVisualStyles = false;
            InvoiceReceiptTable.GridColor = Color.FromArgb(99, 99, 99);
            InvoiceReceiptTable.Location = new Point(13, 205);
            InvoiceReceiptTable.Name = "InvoiceReceiptTable";
            InvoiceReceiptTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            InvoiceReceiptTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            InvoiceReceiptTable.RowHeadersVisible = false;
            InvoiceReceiptTable.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            InvoiceReceiptTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            InvoiceReceiptTable.RowTemplate.Height = 50;
            InvoiceReceiptTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InvoiceReceiptTable.Size = new Size(746, 203);
            InvoiceReceiptTable.TabIndex = 64;
            // 
            // TransacID
            // 
            TransacID.HeaderText = "TransacID";
            TransacID.MinimumWidth = 6;
            TransacID.Name = "TransacID";
            // 
            // TransacDate
            // 
            TransacDate.HeaderText = "Transaction Date";
            TransacDate.MinimumWidth = 6;
            TransacDate.Name = "TransacDate";
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
            // Price
            // 
            Price.FillWeight = 150F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // TransacQuantity
            // 
            TransacQuantity.FillWeight = 59.177578F;
            TransacQuantity.HeaderText = "Exchange Quantity";
            TransacQuantity.MinimumWidth = 6;
            TransacQuantity.Name = "TransacQuantity";
            TransacQuantity.Width = 150;
            // 
            // TransacAmount
            // 
            TransacAmount.FillWeight = 59.177578F;
            TransacAmount.HeaderText = "Exchange Amount";
            TransacAmount.MinimumWidth = 6;
            TransacAmount.Name = "TransacAmount";
            TransacAmount.Width = 150;
            // 
            // HistoricalReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 489);
            Controls.Add(TotalPriceHolder);
            Controls.Add(TotalItemHolder);
            Controls.Add(ReceiptTotalPrice);
            Controls.Add(ReceiptTotalItem);
            Controls.Add(ReceiptCustNo);
            Controls.Add(ReceiptCustName);
            Controls.Add(ReceiptContactNo);
            Controls.Add(pictureBox1);
            Controls.Add(receiptInvoice);
            Controls.Add(receiptname);
            Controls.Add(InvoiceReceiptTable);
            Name = "HistoricalReceipt";
            Text = "HistoricalReceipt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceReceiptTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TotalPriceHolder;
        private Label TotalItemHolder;
        private Label ReceiptTotalPrice;
        private Label ReceiptTotalItem;
        private Label ReceiptCustNo;
        private Label ReceiptCustName;
        private Label ReceiptContactNo;
        private PictureBox pictureBox1;
        private Label receiptInvoice;
        private Label receiptname;
        private DataGridView InvoiceReceiptTable;
        private DataGridViewTextBoxColumn TransacID;
        private DataGridViewTextBoxColumn TransacDate;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn QtyType;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TransacQuantity;
        private DataGridViewTextBoxColumn TransacAmount;
    }
}