namespace JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel
{
    partial class AddEditCategoryDialogBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddEditCategoriesLabel = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            CategoryDescriptionLabel = new Label();
            CategoryNameLabel = new Label();
            cancelBtn = new CuoreUI.Controls.cuiButton();
            proceedButton = new CuoreUI.Controls.cuiButton();
            catDescTextBox = new CuoreUI.Controls.cuiTextBox();
            catNameTextBox = new CuoreUI.Controls.cuiTextBox();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddEditCategoriesLabel
            // 
            AddEditCategoriesLabel.AutoSize = true;
            AddEditCategoriesLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            AddEditCategoriesLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddEditCategoriesLabel.ForeColor = Color.FromArgb(0, 157, 209);
            AddEditCategoriesLabel.Location = new Point(26, 26);
            AddEditCategoriesLabel.Name = "AddEditCategoriesLabel";
            AddEditCategoriesLabel.Size = new Size(236, 35);
            AddEditCategoriesLabel.TabIndex = 28;
            AddEditCategoriesLabel.Text = "Add Categories";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(CategoryDescriptionLabel);
            cuiPanel1.Controls.Add(CategoryNameLabel);
            cuiPanel1.Controls.Add(cancelBtn);
            cuiPanel1.Controls.Add(proceedButton);
            cuiPanel1.Controls.Add(catDescTextBox);
            cuiPanel1.Controls.Add(catNameTextBox);
            cuiPanel1.Location = new Point(26, 77);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 3F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(0, 192, 192);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(388, 264);
            cuiPanel1.TabIndex = 29;
            // 
            // CategoryDescriptionLabel
            // 
            CategoryDescriptionLabel.AutoSize = true;
            CategoryDescriptionLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            CategoryDescriptionLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            CategoryDescriptionLabel.ForeColor = Color.FromArgb(0, 157, 209);
            CategoryDescriptionLabel.Location = new Point(24, 98);
            CategoryDescriptionLabel.Name = "CategoryDescriptionLabel";
            CategoryDescriptionLabel.Size = new Size(176, 19);
            CategoryDescriptionLabel.TabIndex = 31;
            CategoryDescriptionLabel.Text = "Category Description";
            // 
            // CategoryNameLabel
            // 
            CategoryNameLabel.AutoSize = true;
            CategoryNameLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            CategoryNameLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            CategoryNameLabel.ForeColor = Color.FromArgb(0, 157, 209);
            CategoryNameLabel.Location = new Point(24, 19);
            CategoryNameLabel.Name = "CategoryNameLabel";
            CategoryNameLabel.Size = new Size(130, 19);
            CategoryNameLabel.TabIndex = 29;
            CategoryNameLabel.Text = "Category Name";
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(0, 0, 0, 0);
            cancelBtn.CheckButton = false;
            cancelBtn.Checked = false;
            cancelBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            cancelBtn.CheckedForeColor = Color.White;
            cancelBtn.CheckedImageTint = Color.White;
            cancelBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            cancelBtn.Content = "Cancel";
            cancelBtn.DialogResult = DialogResult.None;
            cancelBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.HoverBackground = Color.White;
            cancelBtn.HoveredImageTint = Color.White;
            cancelBtn.HoverForeColor = Color.Black;
            cancelBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cancelBtn.Image = null;
            cancelBtn.ImageAutoCenter = true;
            cancelBtn.ImageExpand = new Point(0, 0);
            cancelBtn.ImageOffset = new Point(0, 0);
            cancelBtn.Location = new Point(96, 195);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.NormalBackground = Color.White;
            cancelBtn.NormalForeColor = Color.Black;
            cancelBtn.NormalImageTint = Color.White;
            cancelBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cancelBtn.OutlineThickness = 1F;
            cancelBtn.PressedBackground = Color.WhiteSmoke;
            cancelBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            cancelBtn.PressedImageTint = Color.White;
            cancelBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cancelBtn.Rounding = new Padding(8);
            cancelBtn.Size = new Size(127, 40);
            cancelBtn.TabIndex = 28;
            cancelBtn.TextAlignment = StringAlignment.Center;
            cancelBtn.TextOffset = new Point(0, 0);
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            proceedButton.CheckButton = false;
            proceedButton.Checked = false;
            proceedButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            proceedButton.CheckedForeColor = Color.White;
            proceedButton.CheckedImageTint = Color.White;
            proceedButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            proceedButton.Content = "OK";
            proceedButton.DialogResult = DialogResult.None;
            proceedButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            proceedButton.ForeColor = Color.White;
            proceedButton.HoverBackground = Color.White;
            proceedButton.HoveredImageTint = Color.White;
            proceedButton.HoverForeColor = Color.Black;
            proceedButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            proceedButton.Image = null;
            proceedButton.ImageAutoCenter = true;
            proceedButton.ImageExpand = new Point(0, 0);
            proceedButton.ImageOffset = new Point(0, 0);
            proceedButton.Location = new Point(229, 195);
            proceedButton.Name = "proceedButton";
            proceedButton.NormalBackground = Color.FromArgb(0, 157, 209);
            proceedButton.NormalForeColor = Color.White;
            proceedButton.NormalImageTint = Color.White;
            proceedButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            proceedButton.OutlineThickness = 1F;
            proceedButton.PressedBackground = Color.WhiteSmoke;
            proceedButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            proceedButton.PressedImageTint = Color.White;
            proceedButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            proceedButton.Rounding = new Padding(8);
            proceedButton.Size = new Size(127, 40);
            proceedButton.TabIndex = 27;
            proceedButton.TextAlignment = StringAlignment.Center;
            proceedButton.TextOffset = new Point(0, 0);
            proceedButton.Click += proceedButton_Click;
            // 
            // catDescTextBox
            // 
            catDescTextBox.BackgroundColor = Color.White;
            catDescTextBox.BorderColor = Color.FromArgb(0, 0, 192);
            catDescTextBox.Content = "";
            catDescTextBox.FocusBackgroundColor = Color.White;
            catDescTextBox.FocusBorderColor = Color.Empty;
            catDescTextBox.FocusImageTint = Color.White;
            catDescTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            catDescTextBox.ForeColor = Color.Gray;
            catDescTextBox.Image = null;
            catDescTextBox.ImageExpand = new Point(0, 0);
            catDescTextBox.ImageOffset = new Point(0, 0);
            catDescTextBox.Location = new Point(24, 121);
            catDescTextBox.Margin = new Padding(4);
            catDescTextBox.Multiline = false;
            catDescTextBox.Name = "catDescTextBox";
            catDescTextBox.NormalImageTint = Color.White;
            catDescTextBox.Padding = new Padding(20, 12, 20, 0);
            catDescTextBox.PasswordChar = false;
            catDescTextBox.PlaceholderColor = Color.Gray;
            catDescTextBox.PlaceholderText = "CategoryDescription";
            catDescTextBox.Rounding = new Padding(8);
            catDescTextBox.Size = new Size(332, 44);
            catDescTextBox.TabIndex = 3;
            catDescTextBox.TextOffset = new Size(0, 0);
            catDescTextBox.UnderlinedStyle = false;
            // 
            // catNameTextBox
            // 
            catNameTextBox.BackgroundColor = Color.White;
            catNameTextBox.BorderColor = Color.FromArgb(0, 0, 192);
            catNameTextBox.Content = "";
            catNameTextBox.FocusBackgroundColor = Color.White;
            catNameTextBox.FocusBorderColor = Color.Empty;
            catNameTextBox.FocusImageTint = Color.White;
            catNameTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            catNameTextBox.ForeColor = Color.Gray;
            catNameTextBox.Image = null;
            catNameTextBox.ImageExpand = new Point(0, 0);
            catNameTextBox.ImageOffset = new Point(0, 0);
            catNameTextBox.Location = new Point(24, 42);
            catNameTextBox.Margin = new Padding(4);
            catNameTextBox.Multiline = false;
            catNameTextBox.Name = "catNameTextBox";
            catNameTextBox.NormalImageTint = Color.White;
            catNameTextBox.Padding = new Padding(20, 12, 20, 0);
            catNameTextBox.PasswordChar = false;
            catNameTextBox.PlaceholderColor = Color.Gray;
            catNameTextBox.PlaceholderText = "Category Name";
            catNameTextBox.Rounding = new Padding(8);
            catNameTextBox.Size = new Size(332, 44);
            catNameTextBox.TabIndex = 0;
            catNameTextBox.TextOffset = new Size(0, 0);
            catNameTextBox.UnderlinedStyle = false;
            // 
            // AddEditCategoryDialogBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 356);
            Controls.Add(cuiPanel1);
            Controls.Add(AddEditCategoriesLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "AddEditCategoryDialogBox";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditCategoryDialogBox";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddEditCategoriesLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiTextBox catNameTextBox;
        private CuoreUI.Controls.cuiTextBox catDescTextBox;
        private CuoreUI.Controls.cuiButton cancelBtn;
        private CuoreUI.Controls.cuiButton proceedButton;
        private Label CategoryNameLabel;
        private Label CategoryDescriptionLabel;
    }
}