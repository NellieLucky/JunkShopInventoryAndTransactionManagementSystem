namespace JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel
{
    partial class AddEditInventoryItem
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            QtyTypeComboBox = new ComboBox();
            CategoryComboBox = new ComboBox();
            LabelRow3_SellingPriceLabel = new Label();
            LabelRow3_BuyingPriceLabel = new Label();
            LabelRow2_QtyLabel = new Label();
            LabelRow2_CategoryLabel = new Label();
            LabelRow1_QtyTypeLabel = new Label();
            LabelRow1_ItemNameLabel = new Label();
            CancelButton = new CuoreUI.Controls.cuiButton();
            AddEditButton = new CuoreUI.Controls.cuiButton();
            TextBox_ofSellingPriceLabel = new CuoreUI.Controls.cuiTextBox();
            TextBox_ofBuyingPriceLabel = new CuoreUI.Controls.cuiTextBox();
            TextBox_ofQtyLabel = new CuoreUI.Controls.cuiTextBox();
            TextBox_ofItemNameLabel = new CuoreUI.Controls.cuiTextBox();
            DashboardTitlePage = new Label();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(QtyTypeComboBox);
            cuiPanel1.Controls.Add(CategoryComboBox);
            cuiPanel1.Controls.Add(LabelRow3_SellingPriceLabel);
            cuiPanel1.Controls.Add(LabelRow3_BuyingPriceLabel);
            cuiPanel1.Controls.Add(LabelRow2_QtyLabel);
            cuiPanel1.Controls.Add(LabelRow2_CategoryLabel);
            cuiPanel1.Controls.Add(LabelRow1_QtyTypeLabel);
            cuiPanel1.Controls.Add(LabelRow1_ItemNameLabel);
            cuiPanel1.Controls.Add(CancelButton);
            cuiPanel1.Controls.Add(AddEditButton);
            cuiPanel1.Controls.Add(TextBox_ofSellingPriceLabel);
            cuiPanel1.Controls.Add(TextBox_ofBuyingPriceLabel);
            cuiPanel1.Controls.Add(TextBox_ofQtyLabel);
            cuiPanel1.Controls.Add(TextBox_ofItemNameLabel);
            cuiPanel1.Location = new Point(27, 83);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 3F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(0, 192, 192);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(750, 347);
            cuiPanel1.TabIndex = 31;
            // 
            // QtyTypeComboBox
            // 
            QtyTypeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QtyTypeComboBox.BackColor = Color.White;
            QtyTypeComboBox.DropDownHeight = 120;
            QtyTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            QtyTypeComboBox.DropDownWidth = 324;
            QtyTypeComboBox.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QtyTypeComboBox.ForeColor = Color.Gray;
            QtyTypeComboBox.FormattingEnabled = true;
            QtyTypeComboBox.IntegralHeight = false;
            QtyTypeComboBox.Items.AddRange(new object[] { "Per Kilo", "Per Piece" });
            QtyTypeComboBox.Location = new Point(382, 40);
            QtyTypeComboBox.Margin = new Padding(0);
            QtyTypeComboBox.Name = "QtyTypeComboBox";
            QtyTypeComboBox.Size = new Size(332, 46);
            QtyTypeComboBox.TabIndex = 36;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownHeight = 120;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryComboBox.ForeColor = Color.Gray;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.IntegralHeight = false;
            CategoryComboBox.Items.AddRange(new object[] { "Category 1", "Category 2" });
            CategoryComboBox.Location = new Point(24, 121);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(332, 46);
            CategoryComboBox.TabIndex = 37;
            // 
            // LabelRow3_SellingPriceLabel
            // 
            LabelRow3_SellingPriceLabel.AutoSize = true;
            LabelRow3_SellingPriceLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            LabelRow3_SellingPriceLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            LabelRow3_SellingPriceLabel.ForeColor = Color.FromArgb(0, 157, 209);
            LabelRow3_SellingPriceLabel.Location = new Point(382, 183);
            LabelRow3_SellingPriceLabel.Name = "LabelRow3_SellingPriceLabel";
            LabelRow3_SellingPriceLabel.Size = new Size(106, 19);
            LabelRow3_SellingPriceLabel.TabIndex = 34;
            LabelRow3_SellingPriceLabel.Text = "Selling Price";
            // 
            // LabelRow3_BuyingPriceLabel
            // 
            LabelRow3_BuyingPriceLabel.AutoSize = true;
            LabelRow3_BuyingPriceLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            LabelRow3_BuyingPriceLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            LabelRow3_BuyingPriceLabel.ForeColor = Color.FromArgb(0, 157, 209);
            LabelRow3_BuyingPriceLabel.Location = new Point(24, 183);
            LabelRow3_BuyingPriceLabel.Name = "LabelRow3_BuyingPriceLabel";
            LabelRow3_BuyingPriceLabel.Size = new Size(109, 19);
            LabelRow3_BuyingPriceLabel.TabIndex = 33;
            LabelRow3_BuyingPriceLabel.Text = "Buying Price";
            // 
            // LabelRow2_QtyLabel
            // 
            LabelRow2_QtyLabel.AutoSize = true;
            LabelRow2_QtyLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            LabelRow2_QtyLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            LabelRow2_QtyLabel.ForeColor = Color.FromArgb(0, 157, 209);
            LabelRow2_QtyLabel.Location = new Point(382, 98);
            LabelRow2_QtyLabel.Name = "LabelRow2_QtyLabel";
            LabelRow2_QtyLabel.Size = new Size(76, 19);
            LabelRow2_QtyLabel.TabIndex = 32;
            LabelRow2_QtyLabel.Text = "Quantity";
            // 
            // LabelRow2_CategoryLabel
            // 
            LabelRow2_CategoryLabel.AutoSize = true;
            LabelRow2_CategoryLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            LabelRow2_CategoryLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            LabelRow2_CategoryLabel.ForeColor = Color.FromArgb(0, 157, 209);
            LabelRow2_CategoryLabel.Location = new Point(24, 98);
            LabelRow2_CategoryLabel.Name = "LabelRow2_CategoryLabel";
            LabelRow2_CategoryLabel.Size = new Size(81, 19);
            LabelRow2_CategoryLabel.TabIndex = 31;
            LabelRow2_CategoryLabel.Text = "Category";
            // 
            // LabelRow1_QtyTypeLabel
            // 
            LabelRow1_QtyTypeLabel.AutoSize = true;
            LabelRow1_QtyTypeLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            LabelRow1_QtyTypeLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            LabelRow1_QtyTypeLabel.ForeColor = Color.FromArgb(0, 157, 209);
            LabelRow1_QtyTypeLabel.Location = new Point(382, 19);
            LabelRow1_QtyTypeLabel.Name = "LabelRow1_QtyTypeLabel";
            LabelRow1_QtyTypeLabel.Size = new Size(118, 19);
            LabelRow1_QtyTypeLabel.TabIndex = 30;
            LabelRow1_QtyTypeLabel.Text = "Quantity Type";
            // 
            // LabelRow1_ItemNameLabel
            // 
            LabelRow1_ItemNameLabel.AutoSize = true;
            LabelRow1_ItemNameLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            LabelRow1_ItemNameLabel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            LabelRow1_ItemNameLabel.ForeColor = Color.FromArgb(0, 157, 209);
            LabelRow1_ItemNameLabel.Location = new Point(24, 19);
            LabelRow1_ItemNameLabel.Name = "LabelRow1_ItemNameLabel";
            LabelRow1_ItemNameLabel.Size = new Size(91, 19);
            LabelRow1_ItemNameLabel.TabIndex = 29;
            LabelRow1_ItemNameLabel.Text = "Item Name";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            CancelButton.CheckButton = false;
            CancelButton.Checked = false;
            CancelButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            CancelButton.CheckedForeColor = Color.White;
            CancelButton.CheckedImageTint = Color.White;
            CancelButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            CancelButton.Content = "Cancel";
            CancelButton.DialogResult = DialogResult.None;
            CancelButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.HoverBackground = Color.White;
            CancelButton.HoveredImageTint = Color.White;
            CancelButton.HoverForeColor = Color.Black;
            CancelButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            CancelButton.Image = null;
            CancelButton.ImageAutoCenter = true;
            CancelButton.ImageExpand = new Point(0, 0);
            CancelButton.ImageOffset = new Point(0, 0);
            CancelButton.Location = new Point(454, 274);
            CancelButton.Name = "CancelButton";
            CancelButton.NormalBackground = Color.White;
            CancelButton.NormalForeColor = Color.Black;
            CancelButton.NormalImageTint = Color.White;
            CancelButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            CancelButton.OutlineThickness = 1F;
            CancelButton.PressedBackground = Color.WhiteSmoke;
            CancelButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            CancelButton.PressedImageTint = Color.White;
            CancelButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            CancelButton.Rounding = new Padding(8);
            CancelButton.Size = new Size(127, 40);
            CancelButton.TabIndex = 28;
            CancelButton.TextAlignment = StringAlignment.Center;
            CancelButton.TextOffset = new Point(0, 0);
            CancelButton.Click += CancelButton_Click;
            // 
            // AddEditButton
            // 
            AddEditButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            AddEditButton.CheckButton = false;
            AddEditButton.Checked = false;
            AddEditButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            AddEditButton.CheckedForeColor = Color.White;
            AddEditButton.CheckedImageTint = Color.White;
            AddEditButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            AddEditButton.Content = "OK";
            AddEditButton.DialogResult = DialogResult.None;
            AddEditButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddEditButton.ForeColor = Color.White;
            AddEditButton.HoverBackground = Color.White;
            AddEditButton.HoveredImageTint = Color.White;
            AddEditButton.HoverForeColor = Color.Black;
            AddEditButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            AddEditButton.Image = null;
            AddEditButton.ImageAutoCenter = true;
            AddEditButton.ImageExpand = new Point(0, 0);
            AddEditButton.ImageOffset = new Point(0, 0);
            AddEditButton.Location = new Point(587, 274);
            AddEditButton.Name = "AddEditButton";
            AddEditButton.NormalBackground = Color.FromArgb(0, 157, 209);
            AddEditButton.NormalForeColor = Color.White;
            AddEditButton.NormalImageTint = Color.White;
            AddEditButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            AddEditButton.OutlineThickness = 1F;
            AddEditButton.PressedBackground = Color.WhiteSmoke;
            AddEditButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            AddEditButton.PressedImageTint = Color.White;
            AddEditButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            AddEditButton.Rounding = new Padding(8);
            AddEditButton.Size = new Size(127, 40);
            AddEditButton.TabIndex = 27;
            AddEditButton.TextAlignment = StringAlignment.Center;
            AddEditButton.TextOffset = new Point(0, 0);
            AddEditButton.Click += AddEditButton_Click;
            // 
            // TextBox_ofSellingPriceLabel
            // 
            TextBox_ofSellingPriceLabel.BackgroundColor = Color.White;
            TextBox_ofSellingPriceLabel.BorderColor = Color.FromArgb(0, 0, 192);
            TextBox_ofSellingPriceLabel.Content = "";
            TextBox_ofSellingPriceLabel.FocusBackgroundColor = Color.White;
            TextBox_ofSellingPriceLabel.FocusBorderColor = Color.Empty;
            TextBox_ofSellingPriceLabel.FocusImageTint = Color.White;
            TextBox_ofSellingPriceLabel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_ofSellingPriceLabel.ForeColor = Color.Gray;
            TextBox_ofSellingPriceLabel.Image = null;
            TextBox_ofSellingPriceLabel.ImageExpand = new Point(0, 0);
            TextBox_ofSellingPriceLabel.ImageOffset = new Point(0, 0);
            TextBox_ofSellingPriceLabel.Location = new Point(382, 206);
            TextBox_ofSellingPriceLabel.Margin = new Padding(4);
            TextBox_ofSellingPriceLabel.Multiline = false;
            TextBox_ofSellingPriceLabel.Name = "TextBox_ofSellingPriceLabel";
            TextBox_ofSellingPriceLabel.NormalImageTint = Color.White;
            TextBox_ofSellingPriceLabel.Padding = new Padding(20, 12, 20, 0);
            TextBox_ofSellingPriceLabel.PasswordChar = false;
            TextBox_ofSellingPriceLabel.PlaceholderColor = Color.Gray;
            TextBox_ofSellingPriceLabel.PlaceholderText = "Selling Price";
            TextBox_ofSellingPriceLabel.Rounding = new Padding(8);
            TextBox_ofSellingPriceLabel.Size = new Size(332, 44);
            TextBox_ofSellingPriceLabel.TabIndex = 6;
            TextBox_ofSellingPriceLabel.TextOffset = new Size(0, 0);
            TextBox_ofSellingPriceLabel.UnderlinedStyle = false;
            // 
            // TextBox_ofBuyingPriceLabel
            // 
            TextBox_ofBuyingPriceLabel.BackgroundColor = Color.White;
            TextBox_ofBuyingPriceLabel.BorderColor = Color.FromArgb(0, 0, 192);
            TextBox_ofBuyingPriceLabel.Content = "";
            TextBox_ofBuyingPriceLabel.FocusBackgroundColor = Color.White;
            TextBox_ofBuyingPriceLabel.FocusBorderColor = Color.Empty;
            TextBox_ofBuyingPriceLabel.FocusImageTint = Color.White;
            TextBox_ofBuyingPriceLabel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_ofBuyingPriceLabel.ForeColor = Color.Gray;
            TextBox_ofBuyingPriceLabel.Image = null;
            TextBox_ofBuyingPriceLabel.ImageExpand = new Point(0, 0);
            TextBox_ofBuyingPriceLabel.ImageOffset = new Point(0, 0);
            TextBox_ofBuyingPriceLabel.Location = new Point(24, 206);
            TextBox_ofBuyingPriceLabel.Margin = new Padding(4);
            TextBox_ofBuyingPriceLabel.Multiline = false;
            TextBox_ofBuyingPriceLabel.Name = "TextBox_ofBuyingPriceLabel";
            TextBox_ofBuyingPriceLabel.NormalImageTint = Color.White;
            TextBox_ofBuyingPriceLabel.Padding = new Padding(20, 12, 20, 0);
            TextBox_ofBuyingPriceLabel.PasswordChar = false;
            TextBox_ofBuyingPriceLabel.PlaceholderColor = Color.Gray;
            TextBox_ofBuyingPriceLabel.PlaceholderText = "Buying Price";
            TextBox_ofBuyingPriceLabel.Rounding = new Padding(8);
            TextBox_ofBuyingPriceLabel.Size = new Size(332, 44);
            TextBox_ofBuyingPriceLabel.TabIndex = 5;
            TextBox_ofBuyingPriceLabel.TextOffset = new Size(0, 0);
            TextBox_ofBuyingPriceLabel.UnderlinedStyle = false;
            // 
            // TextBox_ofQtyLabel
            // 
            TextBox_ofQtyLabel.BackgroundColor = Color.White;
            TextBox_ofQtyLabel.BorderColor = Color.FromArgb(0, 0, 192);
            TextBox_ofQtyLabel.Content = "";
            TextBox_ofQtyLabel.FocusBackgroundColor = Color.White;
            TextBox_ofQtyLabel.FocusBorderColor = Color.Empty;
            TextBox_ofQtyLabel.FocusImageTint = Color.White;
            TextBox_ofQtyLabel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_ofQtyLabel.ForeColor = Color.Gray;
            TextBox_ofQtyLabel.Image = null;
            TextBox_ofQtyLabel.ImageExpand = new Point(0, 0);
            TextBox_ofQtyLabel.ImageOffset = new Point(0, 0);
            TextBox_ofQtyLabel.Location = new Point(382, 121);
            TextBox_ofQtyLabel.Margin = new Padding(4);
            TextBox_ofQtyLabel.Multiline = false;
            TextBox_ofQtyLabel.Name = "TextBox_ofQtyLabel";
            TextBox_ofQtyLabel.NormalImageTint = Color.White;
            TextBox_ofQtyLabel.Padding = new Padding(20, 12, 20, 0);
            TextBox_ofQtyLabel.PasswordChar = false;
            TextBox_ofQtyLabel.PlaceholderColor = Color.Gray;
            TextBox_ofQtyLabel.PlaceholderText = "Quantity";
            TextBox_ofQtyLabel.Rounding = new Padding(8);
            TextBox_ofQtyLabel.Size = new Size(332, 44);
            TextBox_ofQtyLabel.TabIndex = 4;
            TextBox_ofQtyLabel.TextOffset = new Size(0, 0);
            TextBox_ofQtyLabel.UnderlinedStyle = false;
            // 
            // TextBox_ofItemNameLabel
            // 
            TextBox_ofItemNameLabel.BackgroundColor = Color.White;
            TextBox_ofItemNameLabel.BorderColor = Color.FromArgb(0, 0, 192);
            TextBox_ofItemNameLabel.Content = "";
            TextBox_ofItemNameLabel.FocusBackgroundColor = Color.White;
            TextBox_ofItemNameLabel.FocusBorderColor = Color.Empty;
            TextBox_ofItemNameLabel.FocusImageTint = Color.White;
            TextBox_ofItemNameLabel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_ofItemNameLabel.ForeColor = Color.Gray;
            TextBox_ofItemNameLabel.Image = null;
            TextBox_ofItemNameLabel.ImageExpand = new Point(0, 0);
            TextBox_ofItemNameLabel.ImageOffset = new Point(0, 0);
            TextBox_ofItemNameLabel.Location = new Point(24, 42);
            TextBox_ofItemNameLabel.Margin = new Padding(4);
            TextBox_ofItemNameLabel.Multiline = false;
            TextBox_ofItemNameLabel.Name = "TextBox_ofItemNameLabel";
            TextBox_ofItemNameLabel.NormalImageTint = Color.White;
            TextBox_ofItemNameLabel.Padding = new Padding(20, 12, 20, 0);
            TextBox_ofItemNameLabel.PasswordChar = false;
            TextBox_ofItemNameLabel.PlaceholderColor = Color.Gray;
            TextBox_ofItemNameLabel.PlaceholderText = "Item Name";
            TextBox_ofItemNameLabel.Rounding = new Padding(8);
            TextBox_ofItemNameLabel.Size = new Size(332, 44);
            TextBox_ofItemNameLabel.TabIndex = 0;
            TextBox_ofItemNameLabel.TextOffset = new Size(0, 0);
            TextBox_ofItemNameLabel.UnderlinedStyle = false;
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(0, 157, 209);
            DashboardTitlePage.Location = new Point(27, 32);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(158, 35);
            DashboardTitlePage.TabIndex = 30;
            DashboardTitlePage.Text = "Add Items";
            // 
            // AddEditInventoryItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 463);
            Controls.Add(cuiPanel1);
            Controls.Add(DashboardTitlePage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "AddEditInventoryItem";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditInventoryItem";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Label LabelRow3_SellingPriceLabel;
        private Label LabelRow3_BuyingPriceLabel;
        private Label LabelRow1_QtyTypeLabel;
        private Label LabelRow1_ItemNameLabel;
        private CuoreUI.Controls.cuiButton CancelButton;
        private CuoreUI.Controls.cuiButton AddEditButton;
        private CuoreUI.Controls.cuiTextBox TextBox_ofSellingPriceLabel;
        private CuoreUI.Controls.cuiTextBox TextBox_ofBuyingPriceLabel;
        private CuoreUI.Controls.cuiTextBox TextBox_ofItemNameLabel;
        private Label DashboardTitlePage;
        private Label LabelRow2_QtyLabel;
        private Label LabelRow2_CategoryLabel;
        private CuoreUI.Controls.cuiTextBox TextBox_ofQtyLabel;
        private ComboBox QtyTypeComboBox;
        private ComboBox CategoryComboBox;
    }
}