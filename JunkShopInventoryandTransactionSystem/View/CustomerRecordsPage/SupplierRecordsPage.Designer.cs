namespace JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage
{
    partial class SupplierRecordsPage
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
            BuyerRec = new Label();
            dataGridView1 = new DataGridView();
            CustID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            ContactNo = new DataGridViewTextBoxColumn();
            CustomerDelete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BuyerRec
            // 
            BuyerRec.AutoSize = true;
            BuyerRec.BackColor = Color.FromArgb(0, 0, 0, 0);
            BuyerRec.Font = new Font("Arial", 18F, FontStyle.Bold);
            BuyerRec.ForeColor = Color.FromArgb(0, 157, 209);
            BuyerRec.Location = new Point(29, 17);
            BuyerRec.Margin = new Padding(4, 0, 4, 0);
            BuyerRec.Name = "BuyerRec";
            BuyerRec.Size = new Size(313, 43);
            BuyerRec.TabIndex = 34;
            BuyerRec.Text = "Supplier Records";
            BuyerRec.Click += BuyerRec_Click;
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
            dataGridView1.Location = new Point(29, 64);
            dataGridView1.Margin = new Padding(4);
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
            dataGridView1.Size = new Size(1233, 450);
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
            // SupplierRecordsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BuyerRec);
            Controls.Add(dataGridView1);
            Name = "SupplierRecordsPage";
            Size = new Size(1302, 530);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
