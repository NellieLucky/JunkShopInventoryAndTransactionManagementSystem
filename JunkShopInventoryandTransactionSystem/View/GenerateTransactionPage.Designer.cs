namespace JunkShopInventoryandTransactionSystem.View
{
    partial class GenerateTransactionPage
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
            DashboardTitlePage = new Label();
            cuiColorPicker1 = new CuoreUI.Components.cuiColorPicker(components);
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiScrollbar1 = new CuoreUI.Controls.cuiScrollbar();
            cuiPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(20, 24);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(444, 46);
            DashboardTitlePage.TabIndex = 2;
            DashboardTitlePage.Text = "Generate Transactions";
            // 
            // cuiColorPicker1
            // 
            cuiColorPicker1.Color = Color.Empty;
            cuiColorPicker1.EnableThemeChangeButton = true;
            cuiColorPicker1.Theme = CuoreUI.Components.Forms.ColorPickerForm.Themes.Light;
            // 
            // cuiPanel1
            // 
            cuiPanel1.AutoScroll = true;
            cuiPanel1.BackColor = SystemColors.GrayText;
            cuiPanel1.Controls.Add(tableLayoutPanel2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Controls.Add(tableLayoutPanel1);
            cuiPanel1.ForeColor = Color.FromArgb(5, 84, 11);
            cuiPanel1.Location = new Point(22, 117);
            cuiPanel1.Margin = new Padding(2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(227, 244, 238);
            cuiPanel1.PanelOutlineColor = Color.White;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1035, 682);
            cuiPanel1.TabIndex = 3;
            cuiPanel1.Paint += cuiPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(250, 250, 250);
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel2.Location = new Point(19, 129);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4717F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.5283F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel2.Size = new Size(1002, 491);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 208);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(163, 244, 215);
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6233063F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.37669F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 185F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.Controls.Add(cuiLabel6, 5, 0);
            tableLayoutPanel1.Controls.Add(cuiLabel5, 4, 0);
            tableLayoutPanel1.Controls.Add(cuiLabel4, 3, 0);
            tableLayoutPanel1.Controls.Add(cuiLabel3, 2, 0);
            tableLayoutPanel1.Controls.Add(cuiLabel2, 1, 0);
            tableLayoutPanel1.Controls.Add(cuiLabel1, 0, 0);
            tableLayoutPanel1.Location = new Point(19, 12);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.68421F));
            tableLayoutPanel1.Size = new Size(1002, 87);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // cuiLabel6
            // 
            cuiLabel6.BackColor = Color.Transparent;
            cuiLabel6.Content = "Payment\\ Method";
            cuiLabel6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel6.HorizontalAlignment = StringAlignment.Center;
            cuiLabel6.Location = new Point(840, 5);
            cuiLabel6.Margin = new Padding(4, 5, 4, 5);
            cuiLabel6.Name = "cuiLabel6";
            cuiLabel6.Size = new Size(157, 69);
            cuiLabel6.TabIndex = 9;
            cuiLabel6.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel5
            // 
            cuiLabel5.BackColor = Color.Transparent;
            cuiLabel5.Content = "Total\\ Amount";
            cuiLabel5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel5.HorizontalAlignment = StringAlignment.Center;
            cuiLabel5.Location = new Point(655, 5);
            cuiLabel5.Margin = new Padding(4, 5, 4, 5);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(177, 69);
            cuiLabel5.TabIndex = 8;
            cuiLabel5.VerticalAlignment = StringAlignment.Center;
            cuiLabel5.Load += cuiLabel5_Load;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Item\\ Name";
            cuiLabel4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(485, 5);
            cuiLabel4.Margin = new Padding(4, 5, 4, 5);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(162, 69);
            cuiLabel4.TabIndex = 7;
            cuiLabel4.VerticalAlignment = StringAlignment.Center;
            cuiLabel4.Load += cuiLabel4_Load;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Item\\ Type";
            cuiLabel3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(298, 5);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(179, 69);
            cuiLabel3.TabIndex = 6;
            cuiLabel3.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Customer\\ Type:\\ Supplier\\ \\n\\|\\ Buyer";
            cuiLabel2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(94, 5);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(196, 75);
            cuiLabel2.TabIndex = 5;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Date";
            cuiLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(4, 5);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(82, 75);
            cuiLabel1.TabIndex = 4;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            cuiLabel1.Load += cuiLabel1_Load;
            // 
            // cuiScrollbar1
            // 
            cuiScrollbar1.Background = Color.Transparent;
            cuiScrollbar1.HoveredThumbColor = Color.FromArgb(192, 255, 106, 0);
            cuiScrollbar1.Location = new Point(1062, 114);
            cuiScrollbar1.Margin = new Padding(2);
            cuiScrollbar1.MinimumSize = new Size(16, 40);
            cuiScrollbar1.Name = "cuiScrollbar1";
            cuiScrollbar1.PressedThumbColor = Color.FromArgb(192, 255, 106, 0);
            cuiScrollbar1.Rounding = 5;
            cuiScrollbar1.Size = new Size(16, 682);
            cuiScrollbar1.TabIndex = 4;
            cuiScrollbar1.TargetControl = null;
            cuiScrollbar1.ThumbColor = Color.FromArgb(255, 106, 0);
            cuiScrollbar1.ThumbHeight = 50;
            // 
            // GenerateTransactionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(cuiScrollbar1);
            Controls.Add(cuiPanel1);
            Controls.Add(DashboardTitlePage);
            Name = "GenerateTransactionPage";
            Size = new Size(1084, 798);
            Load += GenerateTransactionPage_Load;
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Components.cuiColorPicker cuiColorPicker1;
        private CuoreUI.Controls.cuiScrollbar cuiScrollbar1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
