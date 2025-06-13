namespace JunkShopInventoryandTransactionSystem.View
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cuiColorPicker1 = new CuoreUI.Components.cuiColorPicker(components);
            DashboardTitlePage = new Label();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            QtyType = new DataGridViewTextBoxColumn();
            TransacQuantity = new DataGridViewTextBoxColumn();
            ExchangeAmount = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            DashboardTitlePage.Location = new Point(19, 28);
            DashboardTitlePage.Margin = new Padding(4, 0, 4, 0);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(500, 56);
            DashboardTitlePage.TabIndex = 5;
            DashboardTitlePage.Text = "Transaction Records";
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, ItemName, Category, QtyType, TransacQuantity, ExchangeAmount });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(99, 99, 99);
            dataGridView1.Location = new Point(19, 102);
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
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1320, 830);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Date
            // 
            Date.HeaderText = "Item Name";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 200;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "Category";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.Width = 200;
            // 
            // Category
            // 
            Category.FillWeight = 150F;
            Category.HeaderText = "Qty Type";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 220;
            // 
            // QtyType
            // 
            QtyType.FillWeight = 125F;
            QtyType.HeaderText = "Exchange Quantity";
            QtyType.MinimumWidth = 6;
            QtyType.Name = "QtyType";
            QtyType.Width = 250;
            // 
            // TransacQuantity
            // 
            TransacQuantity.FillWeight = 59.177578F;
            TransacQuantity.HeaderText = "Exchange Amount";
            TransacQuantity.MinimumWidth = 6;
            TransacQuantity.Name = "TransacQuantity";
            TransacQuantity.Width = 250;
            // 
            // ExchangeAmount
            // 
            ExchangeAmount.FillWeight = 59.177578F;
            ExchangeAmount.HeaderText = "Delete";
            ExchangeAmount.Image = Properties.Resources.delete;
            ExchangeAmount.MinimumWidth = 6;
            ExchangeAmount.Name = "ExchangeAmount";
            ExchangeAmount.Resizable = DataGridViewTriState.True;
            ExchangeAmount.SortMode = DataGridViewColumnSortMode.Automatic;
            ExchangeAmount.Width = 210;
            // 
            // TransactionRecordsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(dataGridView1);
            Controls.Add(DashboardTitlePage);
            Margin = new Padding(4);
            Name = "TransactionRecordsPage";
            Size = new Size(1355, 998);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Components.cuiColorPicker cuiColorPicker1;
        private Label DashboardTitlePage;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn QtyType;
        private DataGridViewTextBoxColumn TransacQuantity;
        private DataGridViewImageColumn ExchangeAmount;
    }
}
