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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DashboardTitlePage = new Label();
            CategoryRecordsTable = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            CostOfGoodSolds = new DataGridViewTextBoxColumn();
            Revenue = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            codeeloDateTimePicker1 = new CodeeloUI.Controls.CodeeloDateTimePicker();
            FromDate = new CodeeloUI.Controls.CodeeloDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)CategoryRecordsTable).BeginInit();
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
            // CategoryRecordsTable
            // 
            CategoryRecordsTable.AllowUserToAddRows = false;
            CategoryRecordsTable.AllowUserToDeleteRows = false;
            CategoryRecordsTable.AllowUserToResizeColumns = false;
            CategoryRecordsTable.AllowUserToResizeRows = false;
            CategoryRecordsTable.BackgroundColor = Color.White;
            CategoryRecordsTable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            CategoryRecordsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CategoryRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CategoryRecordsTable.ColumnHeadersHeight = 60;
            CategoryRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CategoryRecordsTable.Columns.AddRange(new DataGridViewColumn[] { Date, CostOfGoodSolds, Revenue, Profit });
            CategoryRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            CategoryRecordsTable.EnableHeadersVisualStyles = false;
            CategoryRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            CategoryRecordsTable.Location = new Point(14, 136);
            CategoryRecordsTable.Name = "CategoryRecordsTable";
            CategoryRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CategoryRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CategoryRecordsTable.RowHeadersVisible = false;
            CategoryRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CategoryRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            CategoryRecordsTable.RowTemplate.Height = 50;
            CategoryRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryRecordsTable.Size = new Size(1056, 578);
            CategoryRecordsTable.TabIndex = 31;
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
            // codeeloDateTimePicker1
            // 
            codeeloDateTimePicker1.BorderColor = Color.Black;
            codeeloDateTimePicker1.BorderSize = 1;
            codeeloDateTimePicker1.CalendarFont = null;
            codeeloDateTimePicker1.CalendarForeColor = Color.Empty;
            codeeloDateTimePicker1.CalendarMonthBackground = Color.Empty;
            codeeloDateTimePicker1.CalendarTitleBackColor = Color.Empty;
            codeeloDateTimePicker1.CalendarTitleForeColor = Color.Empty;
            codeeloDateTimePicker1.CalendarTrailingForeColor = Color.Empty;
            codeeloDateTimePicker1.Checked = false;
            codeeloDateTimePicker1.FillColor = Color.White;
            codeeloDateTimePicker1.Font = new Font("Segoe UI", 9.5F);
            codeeloDateTimePicker1.Format = DateTimePickerFormat.Short;
            codeeloDateTimePicker1.Location = new Point(183, 87);
            codeeloDateTimePicker1.MinimumSize = new Size(0, 35);
            codeeloDateTimePicker1.Name = "codeeloDateTimePicker1";
            codeeloDateTimePicker1.Size = new Size(150, 35);
            codeeloDateTimePicker1.TabIndex = 33;
            codeeloDateTimePicker1.TextColor = Color.Black;
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
            FromDate.Location = new Point(14, 87);
            FromDate.MinimumSize = new Size(0, 35);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(150, 35);
            FromDate.TabIndex = 32;
            FromDate.TextColor = Color.Black;
            // 
            // FinancialReportsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(codeeloDateTimePicker1);
            Controls.Add(FromDate);
            Controls.Add(CategoryRecordsTable);
            Controls.Add(DashboardTitlePage);
            Name = "FinancialReportsPage";
            Size = new Size(1084, 798);
            Load += FinancialReportsPage_Load;
            ((System.ComponentModel.ISupportInitialize)CategoryRecordsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private DataGridView CategoryRecordsTable;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CostOfGoodSolds;
        private DataGridViewTextBoxColumn Revenue;
        private DataGridViewTextBoxColumn Profit;
        private CodeeloUI.Controls.CodeeloDateTimePicker codeeloDateTimePicker1;
        private CodeeloUI.Controls.CodeeloDateTimePicker FromDate;
    }
}
