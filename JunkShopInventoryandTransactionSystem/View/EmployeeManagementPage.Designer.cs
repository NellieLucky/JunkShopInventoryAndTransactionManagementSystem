namespace JunkShopInventoryandTransactionSystem.View
{
    partial class EmployeeManagementPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            vScrollBar1 = new VScrollBar();
            dataGridView2 = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(29, 28);
            DashboardTitlePage.Margin = new Padding(4, 0, 4, 0);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(559, 56);
            DashboardTitlePage.TabIndex = 6;
            DashboardTitlePage.Text = "Employee Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(7, 96, 14);
            label1.Location = new Point(601, 102);
            label1.Name = "label1";
            label1.Size = new Size(285, 29);
            label1.TabIndex = 7;
            label1.Text = "Employee's Information";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(7, 96, 14);
            label2.Location = new Point(139, 191);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(7, 96, 14);
            label3.Location = new Point(426, 191);
            label3.Name = "label3";
            label3.Size = new Size(148, 29);
            label3.TabIndex = 13;
            label3.Text = "Contact No.";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(7, 96, 14);
            label4.Location = new Point(789, 191);
            label4.Name = "label4";
            label4.Size = new Size(113, 29);
            label4.TabIndex = 14;
            label4.Text = "Job Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(7, 96, 14);
            label5.Location = new Point(1107, 191);
            label5.Name = "label5";
            label5.Size = new Size(136, 29);
            label5.TabIndex = 15;
            label5.Text = "Job Status";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ForeColor = Color.FromArgb(48, 212, 119);
            tableLayoutPanel1.Location = new Point(29, 337);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332792F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332792F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333417F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332583F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.Size = new Size(1268, 539);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(163, 244, 215);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(cuiLabel4, 3, 0);
            tableLayoutPanel2.Controls.Add(cuiLabel3, 2, 0);
            tableLayoutPanel2.Controls.Add(cuiLabel2, 1, 0);
            tableLayoutPanel2.Controls.Add(cuiLabel1, 0, 0);
            tableLayoutPanel2.Location = new Point(29, 285);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1268, 46);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Job\\ Status";
            cuiLabel4.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.FromArgb(7, 96, 14);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(956, 6);
            cuiLabel4.Margin = new Padding(5, 6, 5, 6);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(307, 34);
            cuiLabel4.TabIndex = 26;
            cuiLabel4.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Content = "Job\\ Title";
            cuiLabel3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.FromArgb(7, 96, 14);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(639, 6);
            cuiLabel3.Margin = new Padding(5, 6, 5, 6);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(307, 34);
            cuiLabel3.TabIndex = 25;
            cuiLabel3.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Contact\\ \\ No\\.";
            cuiLabel2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.FromArgb(7, 96, 14);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(322, 6);
            cuiLabel2.Margin = new Padding(5, 6, 5, 6);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(307, 34);
            cuiLabel2.TabIndex = 25;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Name";
            cuiLabel1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.FromArgb(7, 96, 14);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(5, 6);
            cuiLabel1.Margin = new Padding(5, 6, 5, 6);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(307, 34);
            cuiLabel1.TabIndex = 24;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            cuiLabel1.Load += cuiLabel1_Load;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(48, 212, 119);
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(790, 223);
            button1.Name = "button1";
            button1.Size = new Size(112, 39);
            button1.TabIndex = 24;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(82, 113, 255);
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(908, 223);
            button2.Name = "button2";
            button2.Size = new Size(112, 39);
            button2.TabIndex = 25;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 74, 173);
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1037, 223);
            button3.Name = "button3";
            button3.Size = new Size(112, 39);
            button3.TabIndex = 26;
            button3.Text = "SAVE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1166, 223);
            button4.Name = "button4";
            button4.Size = new Size(131, 39);
            button4.TabIndex = 27;
            button4.Text = "REMOVE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1300, 349);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(36, 539);
            vScrollBar1.TabIndex = 29;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView2.Location = new Point(28, 268);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1269, 642);
            dataGridView2.TabIndex = 30;
            // 
            // EmployeeManagementPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(vScrollBar1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DashboardTitlePage);
            Controls.Add(dataGridView2);
            Margin = new Padding(4);
            Name = "EmployeeManagementPage";
            Size = new Size(1355, 998);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ActiproSoftware.UI.WinForms.Controls.ScrollBar scrollBar1;
        private VScrollBar vScrollBar1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}
