namespace JunkShopInventoryandTransactionSystem.View.Inventory_Pages
{
    partial class CategoryPage
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryPage));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            CategoryRecordsTable = new DataGridView();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            AddCategoryButton = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            DashboardTitlePage = new Label();
            CategoryID = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            CategoryDescription = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)CategoryRecordsTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            CategoryRecordsTable.Columns.AddRange(new DataGridViewColumn[] { CategoryID, CategoryName, CategoryDescription, Edit, Delete });
            CategoryRecordsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            CategoryRecordsTable.EnableHeadersVisualStyles = false;
            CategoryRecordsTable.GridColor = Color.FromArgb(99, 99, 99);
            CategoryRecordsTable.Location = new Point(14, 78);
            CategoryRecordsTable.Name = "CategoryRecordsTable";
            CategoryRecordsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CategoryRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CategoryRecordsTable.RowHeadersVisible = false;
            CategoryRecordsTable.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 157, 209);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            CategoryRecordsTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            CategoryRecordsTable.RowTemplate.Height = 50;
            CategoryRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryRecordsTable.Size = new Size(1056, 571);
            CategoryRecordsTable.TabIndex = 28;
            CategoryRecordsTable.CellContentClick += CategoryRecordsTable_CellContentClick;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = Properties.Resources.magnifying_glass;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(5, 5);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(0, 0);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.FromArgb(0, 157, 209);
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(0, 5, 5, 0);
            cuiButton1.Size = new Size(43, 39);
            cuiButton1.TabIndex = 24;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.BorderColor = Color.Empty;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.Empty;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Gray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(41, 2);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(18, 8, 18, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.Gray;
            cuiTextBox1.PlaceholderText = "Search...";
            cuiTextBox1.Rounding = new Padding(2);
            cuiTextBox1.Size = new Size(333, 35);
            cuiTextBox1.TabIndex = 23;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // AddCategoryButton
            // 
            AddCategoryButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            AddCategoryButton.CheckButton = false;
            AddCategoryButton.Checked = false;
            AddCategoryButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            AddCategoryButton.CheckedForeColor = Color.White;
            AddCategoryButton.CheckedImageTint = Color.White;
            AddCategoryButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            AddCategoryButton.Content = "Add Category";
            AddCategoryButton.DialogResult = DialogResult.None;
            AddCategoryButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCategoryButton.ForeColor = Color.White;
            AddCategoryButton.HoverBackground = Color.White;
            AddCategoryButton.HoveredImageTint = Color.White;
            AddCategoryButton.HoverForeColor = Color.Black;
            AddCategoryButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            AddCategoryButton.Image = null;
            AddCategoryButton.ImageAutoCenter = true;
            AddCategoryButton.ImageExpand = new Point(0, 0);
            AddCategoryButton.ImageOffset = new Point(0, 0);
            AddCategoryButton.Location = new Point(542, 20);
            AddCategoryButton.Name = "AddCategoryButton";
            AddCategoryButton.NormalBackground = Color.FromArgb(0, 157, 209);
            AddCategoryButton.NormalForeColor = Color.White;
            AddCategoryButton.NormalImageTint = Color.White;
            AddCategoryButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            AddCategoryButton.OutlineThickness = 1F;
            AddCategoryButton.PressedBackground = Color.WhiteSmoke;
            AddCategoryButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            AddCategoryButton.PressedImageTint = Color.White;
            AddCategoryButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            AddCategoryButton.Rounding = new Padding(8);
            AddCategoryButton.Size = new Size(146, 40);
            AddCategoryButton.TabIndex = 30;
            AddCategoryButton.TextAlignment = StringAlignment.Center;
            AddCategoryButton.TextOffset = new Point(0, 0);
            AddCategoryButton.Click += AddCategoryButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 157, 209);
            panel1.Controls.Add(cuiButton1);
            panel1.Controls.Add(cuiTextBox1);
            panel1.Location = new Point(694, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 40);
            panel1.TabIndex = 29;
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(0, 157, 209);
            DashboardTitlePage.Location = new Point(13, 22);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(171, 35);
            DashboardTitlePage.TabIndex = 31;
            DashboardTitlePage.Text = "Categories";
            // 
            // CategoryID
            // 
            CategoryID.FillWeight = 9.83041F;
            CategoryID.HeaderText = "CategoryID";
            CategoryID.MinimumWidth = 6;
            CategoryID.Name = "CategoryID";
            CategoryID.Width = 113;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.FillWeight = 30.5142632F;
            CategoryName.HeaderText = "Category Name";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            // 
            // CategoryDescription
            // 
            CategoryDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryDescription.FillWeight = 32.57976F;
            CategoryDescription.HeaderText = "Description";
            CategoryDescription.MinimumWidth = 6;
            CategoryDescription.Name = "CategoryDescription";
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Edit.Description = "Edit";
            Edit.FillWeight = 9.49495F;
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.green_edit;
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.False;
            Edit.Width = 60;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(10);
            Delete.DefaultCellStyle = dataGridViewCellStyle3;
            Delete.Description = "Delete";
            Delete.FillWeight = 9.49495F;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
            Delete.Width = 60;
            // 
            // CategoryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DashboardTitlePage);
            Controls.Add(CategoryRecordsTable);
            Controls.Add(AddCategoryButton);
            Controls.Add(panel1);
            Name = "CategoryPage";
            Size = new Size(1084, 668);
            ((System.ComponentModel.ISupportInitialize)CategoryRecordsTable).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView CategoryRecordsTable;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButton AddCategoryButton;
        private Panel panel1;
        private Label DashboardTitlePage;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn CategoryDescription;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
