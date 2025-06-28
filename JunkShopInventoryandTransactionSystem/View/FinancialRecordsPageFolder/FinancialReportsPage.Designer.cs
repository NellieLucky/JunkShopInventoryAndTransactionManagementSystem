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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialReportsPage));
            DashboardTitlePage = new Label();
            FinancialRecordsTable = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            CostOfGoodSolds = new DataGridViewTextBoxColumn();
            Revenue = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Periodicity = new CodeeloUI.Controls.CodeeloComboBox();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(163, 244, 215);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            FinancialRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            FinancialRecordsTable.ColumnHeadersHeight = 60;
            FinancialRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            FinancialRecordsTable.Columns.AddRange(new DataGridViewColumn[] { Date, CostOfGoodSolds, Revenue, Profit });
            FinancialRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            FinancialRecordsTable.EnableHeadersVisualStyles = false;
            FinancialRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            FinancialRecordsTable.Location = new Point(14, 168);
            FinancialRecordsTable.Name = "FinancialRecordsTable";
            FinancialRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            FinancialRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            FinancialRecordsTable.RowHeadersVisible = false;
            FinancialRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            FinancialRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 157, 209);
            label1.Location = new Point(14, 91);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 34;
            label1.Text = "Periodicity";
            // 
            // Periodicity
            // 
            Periodicity.ArrowColor = Color.MediumSlateBlue;
            Periodicity.BackColor = Color.MediumSlateBlue;
            Periodicity.BorderColor = Color.MediumSlateBlue;
            Periodicity.BorderSize = 1;
            Periodicity.DropDownStyle = ComboBoxStyle.DropDown;
            Periodicity.DropDownWidth = 136;
            Periodicity.DroppedDown = false;
            Periodicity.FillColor = Color.White;
            Periodicity.Font = new Font("Segoe UI", 10F);
            Periodicity.ForeColor = Color.DimGray;
            Periodicity.Items.AddRange(new object[] { resources.GetObject("Periodicity.Items"), resources.GetObject("Periodicity.Items1"), resources.GetObject("Periodicity.Items2") });
            Periodicity.ListBackColor = Color.FromArgb(230, 228, 245);
            Periodicity.ListTextColor = Color.WhiteSmoke;
            Periodicity.Location = new Point(14, 118);
            Periodicity.Name = "Periodicity";
            Periodicity.Padding = new Padding(1);
            Periodicity.SelectedIndex = -1;
            Periodicity.SelectedItem = null;
            Periodicity.SelectedText = "";
            Periodicity.SelectedValue = null;
            Periodicity.Size = new Size(246, 35);
            Periodicity.TabIndex = 35;
            Periodicity.Text = "Periodicity";
            // 
            // FinancialReportsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(Periodicity);
            Controls.Add(label1);
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
        private Label label1;
        private CodeeloUI.Controls.CodeeloComboBox Periodicity;
    }
}
