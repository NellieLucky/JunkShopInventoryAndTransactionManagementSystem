namespace JunkShopInventoryandTransactionSystem.View
{
    partial class InventoryPage
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
            panel1 = new Panel();
            nonoTabControl1 = new NonoUI.Controls.NonoTabControl();
            tabPage1 = new TabPage();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            CategoryID = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            NumOfItems = new DataGridViewTextBoxColumn();
            label3 = new Label();
            cuiTextBox3 = new CuoreUI.Controls.cuiTextBox();
            label2 = new Label();
            label1 = new Label();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            DashboardTitlePage = new Label();
            panel1.SuspendLayout();
            nonoTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(nonoTabControl1);
            panel1.Controls.Add(DashboardTitlePage);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 792);
            panel1.TabIndex = 0;
            // 
            // nonoTabControl1
            // 
            nonoTabControl1.Controls.Add(tabPage1);
            nonoTabControl1.Controls.Add(tabPage2);
            nonoTabControl1.Controls.Add(tabPage3);
            nonoTabControl1.Font = new Font("Microsoft Sans Serif", 11F);
            nonoTabControl1.ItemSize = new Size(180, 25);
            nonoTabControl1.Location = new Point(0, 83);
            nonoTabControl1.Multiline = true;
            nonoTabControl1.Name = "nonoTabControl1";
            nonoTabControl1.RightToLeft = RightToLeft.No;
            nonoTabControl1.SelectedIndex = 0;
            nonoTabControl1.Size = new Size(1081, 691);
            nonoTabControl1.SizeMode = TabSizeMode.FillToRight;
            nonoTabControl1.TabHeight = 25;
            nonoTabControl1.TabIndex = 6;
            nonoTabControl1.TabWidth = 180;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(kryptonDataGridView1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cuiTextBox3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cuiTextBox2);
            tabPage1.Controls.Add(cuiTextBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1073, 658);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categories";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            kryptonDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { CategoryID, CategoryName, Description, NumOfItems });
            kryptonDataGridView1.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            kryptonDataGridView1.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            kryptonDataGridView1.Location = new Point(0, 218);
            kryptonDataGridView1.Margin = new Padding(0);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            kryptonDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            kryptonDataGridView1.RowTemplate.Height = 50;
            kryptonDataGridView1.Size = new Size(1071, 439);
            kryptonDataGridView1.StateCommon.Background.Color1 = Color.Transparent;
            kryptonDataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = Color.Transparent;
            kryptonDataGridView1.StateCommon.DataCell.Back.Color2 = Color.Transparent;
            kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = Color.MediumSpringGreen;
            kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = Color.MediumSpringGreen;
            kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = Color.Black;
            kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color2 = Color.Black;
            kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = Color.Black;
            kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color2 = Color.Black;
            kryptonDataGridView1.StateCommon.HeaderRow.Border.Color1 = Color.Black;
            kryptonDataGridView1.StateCommon.HeaderRow.Border.Color2 = Color.Black;
            kryptonDataGridView1.StateNormal.DataCell.Border.Color1 = Color.Black;
            kryptonDataGridView1.StateNormal.DataCell.Border.Color2 = Color.Black;
            kryptonDataGridView1.TabIndex = 6;
            // 
            // CategoryID
            // 
            CategoryID.HeaderText = "CategoryID";
            CategoryID.MinimumWidth = 6;
            CategoryID.Name = "CategoryID";
            CategoryID.Resizable = DataGridViewTriState.True;
            CategoryID.Width = 120;
            // 
            // CategoryName
            // 
            CategoryName.HeaderText = "Category Name";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.Width = 350;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 350;
            // 
            // NumOfItems
            // 
            NumOfItems.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NumOfItems.HeaderText = "Number of Item Types";
            NumOfItems.MinimumWidth = 6;
            NumOfItems.Name = "NumOfItems";
            NumOfItems.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(16, 107, 23);
            label3.Location = new Point(42, 15);
            label3.Name = "label3";
            label3.Size = new Size(126, 24);
            label3.TabIndex = 5;
            label3.Text = "Category Id:";
            // 
            // cuiTextBox3
            // 
            cuiTextBox3.BackgroundColor = Color.White;
            cuiTextBox3.BorderColor = Color.Green;
            cuiTextBox3.Content = "";
            cuiTextBox3.FocusBackgroundColor = Color.White;
            cuiTextBox3.FocusBorderColor = Color.FromArgb(255, 106, 0);
            cuiTextBox3.FocusImageTint = Color.White;
            cuiTextBox3.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox3.ForeColor = Color.Gray;
            cuiTextBox3.Image = null;
            cuiTextBox3.ImageExpand = new Point(0, 0);
            cuiTextBox3.ImageOffset = new Point(0, 0);
            cuiTextBox3.Location = new Point(39, 40);
            cuiTextBox3.Margin = new Padding(4);
            cuiTextBox3.Multiline = false;
            cuiTextBox3.Name = "cuiTextBox3";
            cuiTextBox3.NormalImageTint = Color.White;
            cuiTextBox3.Padding = new Padding(18, 9, 18, 0);
            cuiTextBox3.PasswordChar = false;
            cuiTextBox3.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox3.PlaceholderText = "";
            cuiTextBox3.Rounding = new Padding(8);
            cuiTextBox3.Size = new Size(442, 37);
            cuiTextBox3.TabIndex = 4;
            cuiTextBox3.TextOffset = new Size(0, 0);
            cuiTextBox3.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(16, 107, 23);
            label2.Location = new Point(581, 86);
            label2.Name = "label2";
            label2.Size = new Size(217, 24);
            label2.TabIndex = 3;
            label2.Text = "Category Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 107, 23);
            label1.Location = new Point(42, 86);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 2;
            label1.Text = "Category Name:";
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.BackgroundColor = Color.White;
            cuiTextBox2.BorderColor = Color.Green;
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusBorderColor = Color.FromArgb(255, 106, 0);
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Gray;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.Location = new Point(578, 111);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.Padding = new Padding(18, 9, 18, 0);
            cuiTextBox2.PasswordChar = false;
            cuiTextBox2.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox2.PlaceholderText = "";
            cuiTextBox2.Rounding = new Padding(8);
            cuiTextBox2.Size = new Size(442, 37);
            cuiTextBox2.TabIndex = 1;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = false;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.BorderColor = Color.Green;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.FromArgb(255, 106, 0);
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Gray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(39, 111);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(18, 9, 18, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox1.PlaceholderText = "";
            cuiTextBox1.Rounding = new Padding(8);
            cuiTextBox1.Size = new Size(442, 37);
            cuiTextBox1.TabIndex = 0;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1073, 658);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Items";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1073, 658);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Inventory Audit";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(4, 23);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(194, 46);
            DashboardTitlePage.TabIndex = 5;
            DashboardTitlePage.Text = "Inventory";
            // 
            // InventoryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "InventoryPage";
            Size = new Size(1084, 798);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            nonoTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NonoUI.Controls.NonoTabControl nonoTabControl1;
        private TabPage tabPage1;
        private Label label3;
        private CuoreUI.Controls.cuiTextBox cuiTextBox3;
        private Label label2;
        private Label label1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label DashboardTitlePage;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn NumOfItems;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
    }
}
