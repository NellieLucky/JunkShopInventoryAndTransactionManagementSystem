namespace JunkShopInventoryandTransactionSystem.View.FinancialReportsPageFolder
{
    partial class FinancialReportsPage
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
            DashboardTitlePage = new Label();
            FinancialRecordsTable = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            CostOfGoodSolds = new DataGridViewTextBoxColumn();
            Revenue = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            ToDate = new CodeeloUI.Controls.CodeeloDateTimePicker();
            FromDate = new CodeeloUI.Controls.CodeeloDateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)FinancialRecordsTable).BeginInit();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(3, 22);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(359, 46);
            DashboardTitlePage.TabIndex = 5;
            DashboardTitlePage.Text = "Financial Records";
            // 
            // FinancialRecordsTable
            // 
            FinancialRecordsTable.AllowUserToAddRows = false;
            FinancialRecordsTable.AllowUserToDeleteRows = false;
            FinancialRecordsTable.AllowUserToResizeColumns = false;
            FinancialRecordsTable.AllowUserToResizeRows = false;
            FinancialRecordsTable.BackgroundColor = Color.White;
            FinancialRecordsTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            FinancialRecordsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            FinancialRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            FinancialRecordsTable.ColumnHeadersHeight = 60;
            FinancialRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            FinancialRecordsTable.Columns.AddRange(new DataGridViewColumn[] { Date, CostOfGoodSolds, Revenue, Profit });
            FinancialRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            FinancialRecordsTable.EnableHeadersVisualStyles = false;
            FinancialRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            FinancialRecordsTable.Location = new Point(14, 136);
            FinancialRecordsTable.Name = "FinancialRecordsTable";
            FinancialRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            FinancialRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            FinancialRecordsTable.RowHeadersVisible = false;
            FinancialRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            FinancialRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            FinancialRecordsTable.RowTemplate.Height = 50;
            FinancialRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FinancialRecordsTable.Size = new Size(1056, 578);
            FinancialRecordsTable.TabIndex = 31;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.FillWeight = 9.83041F;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // CostOfGoodSolds
            // 
            CostOfGoodSolds.FillWeight = 30.5142632F;
            CostOfGoodSolds.HeaderText = "Cost of Good Solds";
            CostOfGoodSolds.MinimumWidth = 6;
            CostOfGoodSolds.Name = "CostOfGoodSolds";
            CostOfGoodSolds.Width = 300;
            // 
            // Revenue
            // 
            Revenue.FillWeight = 32.57976F;
            Revenue.HeaderText = "Revenue";
            Revenue.MinimumWidth = 6;
            Revenue.Name = "Revenue";
            Revenue.Width = 300;
            // 
            // Profit
            // 
            Profit.HeaderText = "Profit";
            Profit.MinimumWidth = 6;
            Profit.Name = "Profit";
            Profit.Width = 300;
            // 
            // ToDate
            // 
            ToDate.BorderColor = Color.Black;
            ToDate.BorderSize = 1;
            ToDate.CalendarFont = null;
            ToDate.CalendarForeColor = Color.Empty;
            ToDate.CalendarMonthBackground = Color.Empty;
            ToDate.CalendarTitleBackColor = Color.Empty;
            ToDate.CalendarTitleForeColor = Color.Empty;
            ToDate.CalendarTrailingForeColor = Color.Empty;
            ToDate.Checked = false;
            ToDate.FillColor = Color.White;
            ToDate.Font = new Font("Segoe UI", 9.5F);
            ToDate.Format = DateTimePickerFormat.Short;
            ToDate.Location = new Point(316, 87);
            ToDate.MinimumSize = new Size(4, 35);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(150, 35);
            ToDate.TabIndex = 33;
            ToDate.TextColor = Color.Black;
            ToDate.ValueChanged += codeeloDateTimePicker1_ValueChanged;
            // 
            // FromDate
            // 
            FromDate.BorderColor = Color.Black;
            FromDate.BorderSize = 1;
            FromDate.CalendarFont = null;
            FromDate.CalendarForeColor = Color.Empty;
            FromDate.CalendarMonthBackground = Color.Empty;
            FromDate.CalendarTitleBackColor = Color.Empty;
            FromDate.CalendarTitleForeColor = Color.Empty;
            FromDate.CalendarTrailingForeColor = Color.Empty;
            FromDate.Checked = false;
            FromDate.FillColor = Color.White;
            FromDate.Font = new Font("Segoe UI", 9.5F);
            FromDate.Format = DateTimePickerFormat.Short;
            FromDate.Location = new Point(85, 87);
            FromDate.MinimumSize = new Size(4, 35);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(150, 35);
            FromDate.TabIndex = 32;
            FromDate.TextColor = Color.Black;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 157, 209);
            label1.Location = new Point(14, 87);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 34;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 157, 209);
            label2.Location = new Point(271, 90);
            label2.Name = "label2";
            label2.Size = new Size(41, 24);
            label2.TabIndex = 35;
            label2.Text = "To:";
            // 
            // FinancialReportsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ToDate);
            Controls.Add(FromDate);
            Controls.Add(FinancialRecordsTable);
            Controls.Add(DashboardTitlePage);
            Name = "FinancialReportsPage";
            Size = new Size(1084, 798);
            Load += FinancialReportsPage_Load;
            ((System.ComponentModel.ISupportInitialize)FinancialRecordsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private DataGridView FinancialRecordsTable;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CostOfGoodSolds;
        private DataGridViewTextBoxColumn Revenue;
        private DataGridViewTextBoxColumn Profit;
        private CodeeloUI.Controls.CodeeloDateTimePicker ToDate;
        private CodeeloUI.Controls.CodeeloDateTimePicker FromDate;
        private Label label1;
        private Label label2;
    }
}
