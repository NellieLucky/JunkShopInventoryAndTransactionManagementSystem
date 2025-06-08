namespace JunkShopInventoryandTransactionSystem.View
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
            DashboardTitlePage = new Label();
            codeeloDateTimePicker1 = new CodeeloUI.Controls.CodeeloDateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            hScrollBar1 = new HScrollBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(30, 28);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(359, 46);
            DashboardTitlePage.TabIndex = 5;
            DashboardTitlePage.Text = "Financial Records";
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
            codeeloDateTimePicker1.Location = new Point(39, 75);
            codeeloDateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            codeeloDateTimePicker1.MinimumSize = new Size(4, 35);
            codeeloDateTimePicker1.Name = "codeeloDateTimePicker1";
            codeeloDateTimePicker1.Size = new Size(241, 35);
            codeeloDateTimePicker1.TabIndex = 9;
            codeeloDateTimePicker1.TextColor = Color.Black;
            codeeloDateTimePicker1.ValueChanged += codeeloDateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(91, 117);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(152, 38);
            button1.TabIndex = 25;
            button1.Text = "Yesterday";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(288, 117);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(135, 38);
            button2.TabIndex = 26;
            button2.Text = "Today";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(471, 117);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(135, 38);
            button3.TabIndex = 27;
            button3.Text = "Weekly";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(653, 117);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(135, 38);
            button4.TabIndex = 28;
            button4.Text = "Monthly";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Blue;
            button5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(841, 117);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(135, 38);
            button5.TabIndex = 29;
            button5.Text = "Yearly";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(7, 96, 14);
            button6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(166, 173);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(152, 38);
            button6.TabIndex = 30;
            button6.Text = "Profit";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(196, 2, 26);
            button7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(359, 173);
            button7.Margin = new Padding(2, 2, 2, 2);
            button7.Name = "button7";
            button7.Size = new Size(152, 38);
            button7.TabIndex = 31;
            button7.Text = "Expenses";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(94, 23, 235);
            button8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(555, 173);
            button8.Margin = new Padding(2, 2, 2, 2);
            button8.Name = "button8";
            button8.Size = new Size(152, 38);
            button8.TabIndex = 32;
            button8.Text = "Revenue";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(48, 212, 177);
            button9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(755, 173);
            button9.Margin = new Padding(2, 2, 2, 2);
            button9.Name = "button9";
            button9.Size = new Size(152, 38);
            button9.TabIndex = 33;
            button9.Text = "COGS";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 159);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(885, 62);
            dataGridView1.TabIndex = 34;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(39, 108);
            dataGridView2.Margin = new Padding(2, 2, 2, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1002, 129);
            dataGridView2.TabIndex = 35;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(163, 244, 215);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cuiLabel3, 0, 2);
            tableLayoutPanel1.Controls.Add(cuiLabel2, 0, 1);
            tableLayoutPanel1.Controls.Add(cuiLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(cuiLabel4, 0, 3);
            tableLayoutPanel1.Location = new Point(50, 266);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(170, 398);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cuiLabel3.Content = "Revenue";
            cuiLabel3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.FromArgb(5, 84, 11);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(4, 203);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(162, 89);
            cuiLabel3.TabIndex = 27;
            cuiLabel3.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cuiLabel2.Content = "Expenses";
            cuiLabel2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.FromArgb(5, 84, 11);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(4, 104);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(162, 89);
            cuiLabel2.TabIndex = 26;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            cuiLabel2.Load += cuiLabel2_Load;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cuiLabel1.Content = "Profit";
            cuiLabel1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.FromArgb(5, 84, 11);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(4, 5);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(162, 89);
            cuiLabel1.TabIndex = 25;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cuiLabel4.Content = "Cost\\ of\\ Goods\\ Sold";
            cuiLabel4.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.FromArgb(5, 84, 11);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(4, 302);
            cuiLabel4.Margin = new Padding(4, 5, 4, 5);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(162, 91);
            cuiLabel4.TabIndex = 38;
            cuiLabel4.VerticalAlignment = StringAlignment.Center;
            cuiLabel4.Load += cuiLabel4_Load;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Location = new Point(224, 266);
            tableLayoutPanel2.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(838, 398);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(224, 666);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(838, 39);
            hScrollBar1.TabIndex = 38;
            // 
            // FinancialReportsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(hScrollBar1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(codeeloDateTimePicker1);
            Controls.Add(DashboardTitlePage);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            Name = "FinancialReportsPage";
            Size = new Size(1084, 798);
            Load += FinancialReportsPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private CodeeloUI.Controls.CodeeloDateTimePicker codeeloDateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private HScrollBar hScrollBar1;
    }
}
