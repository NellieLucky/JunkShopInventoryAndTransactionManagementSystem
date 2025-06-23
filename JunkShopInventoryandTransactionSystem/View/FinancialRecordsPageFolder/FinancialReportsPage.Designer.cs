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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DashboardTitlePage = new Label();
            CategoryRecordsTable = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            CostOfGoodSolds = new DataGridViewTextBoxColumn();
            Revenue = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            codeeloDateTimePicker1 = new CodeeloUI.Controls.CodeeloDateTimePicker();
            FromDate = new CodeeloUI.Controls.CodeeloDateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoryRecordsTable).BeginInit();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(4, 28);
            DashboardTitlePage.Margin = new Padding(4, 0, 4, 0);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(437, 56);
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            CategoryRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            CategoryRecordsTable.ColumnHeadersHeight = 60;
            CategoryRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CategoryRecordsTable.Columns.AddRange(new DataGridViewColumn[] { Date, CostOfGoodSolds, Revenue, Profit });
            CategoryRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            CategoryRecordsTable.EnableHeadersVisualStyles = false;
            CategoryRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            CategoryRecordsTable.Location = new Point(18, 170);
            CategoryRecordsTable.Margin = new Padding(4, 4, 4, 4);
            CategoryRecordsTable.Name = "CategoryRecordsTable";
            CategoryRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            CategoryRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            CategoryRecordsTable.RowHeadersVisible = false;
            CategoryRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            CategoryRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            CategoryRecordsTable.RowTemplate.Height = 50;
            CategoryRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryRecordsTable.Size = new Size(1320, 722);
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
            codeeloDateTimePicker1.Location = new Point(395, 109);
            codeeloDateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            codeeloDateTimePicker1.MinimumSize = new Size(4, 35);
            codeeloDateTimePicker1.Name = "codeeloDateTimePicker1";
            codeeloDateTimePicker1.Size = new Size(186, 35);
            codeeloDateTimePicker1.TabIndex = 33;
            codeeloDateTimePicker1.TextColor = Color.Black;
            codeeloDateTimePicker1.ValueChanged += codeeloDateTimePicker1_ValueChanged;
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
            FromDate.Location = new Point(106, 109);
            FromDate.Margin = new Padding(4, 4, 4, 4);
            FromDate.MinimumSize = new Size(4, 35);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(186, 35);
            FromDate.TabIndex = 32;
            FromDate.TextColor = Color.Black;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 157, 209);
            label1.Location = new Point(18, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 29);
            label1.TabIndex = 34;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 157, 209);
            label2.Location = new Point(339, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 29);
            label2.TabIndex = 35;
            label2.Text = "To:";
            // 
            // FinancialReportsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(codeeloDateTimePicker1);
            Controls.Add(FromDate);
            Controls.Add(CategoryRecordsTable);
            Controls.Add(DashboardTitlePage);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FinancialReportsPage";
            Size = new Size(1355, 998);
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
        private Label label1;
        private Label label2;
    }
}
