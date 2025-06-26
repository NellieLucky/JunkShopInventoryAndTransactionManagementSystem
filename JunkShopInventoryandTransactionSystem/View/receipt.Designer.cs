namespace JunkShopInventoryandTransactionSystem.View.InvoiceReceipt
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
            InvoiceReceiptTable = new DataGridView();
            receiptname = new Label();
            receiptInvoice = new Label();
            pictureBox1 = new PictureBox();
            ReceiptContactNo = new Label();
            ReceiptCustName = new Label();
            ReceiptCustNo = new Label();
            ReceiptTotalItem = new Label();
            ReceiptTotalPrice = new Label();
            TotalItemHolder = new Label();
            TotalPriceHolder = new Label();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TransacQuantity = new DataGridViewTextBoxColumn();
            TransacAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)InvoiceReceiptTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            InvoiceReceiptTable.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, QtyType, Price, TransacQuantity, TransacAmount });
            InvoiceReceiptTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            InvoiceReceiptTable.EnableHeadersVisualStyles = false;
            InvoiceReceiptTable.GridColor = Color.FromArgb(99, 99, 99);
            InvoiceReceiptTable.Location = new Point(10, 193);
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
            InvoiceReceiptTable.TabIndex = 52;
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
            // 
            // TotalItemHolder
            // 
            TotalItemHolder.AutoSize = true;
            TotalItemHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            TotalItemHolder.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalItemHolder.ForeColor = SystemColors.ControlDarkDark;
            TotalItemHolder.Location = new Point(640, 416);
            TotalItemHolder.Name = "TotalItemHolder";
            TotalItemHolder.Size = new Size(70, 17);
            TotalItemHolder.TabIndex = 62;
            TotalItemHolder.Text = "Total Item";
            // 
            // TotalPriceHolder
            // 
            TotalPriceHolder.AutoSize = true;
            TotalPriceHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            TotalPriceHolder.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPriceHolder.ForeColor = SystemColors.ControlDarkDark;
            TotalPriceHolder.Location = new Point(640, 448);
            TotalPriceHolder.Name = "TotalPriceHolder";
            TotalPriceHolder.Size = new Size(76, 17);
            TotalPriceHolder.TabIndex = 63;
            TotalPriceHolder.Text = "Total Price";
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
            // receiptlogo
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
            Margin = new Padding(2);
            Name = "receiptlogo";
            Text = "receipt";
            ((System.ComponentModel.ISupportInitialize)InvoiceReceiptTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView InvoiceReceiptTable;
        private Label receiptname;
        private Label receiptInvoice;
        private PictureBox pictureBox1;
        private Label ReceiptContactNo;
        private Label ReceiptCustName;
        private Label ReceiptCustNo;
        private Label ReceiptTotalItem;
        private Label ReceiptTotalPrice;
        private Label TotalItemHolder;
        private Label TotalPriceHolder;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn QtyType;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TransacQuantity;
        private DataGridViewTextBoxColumn TransacAmount;
    }
}