namespace JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage
{
    partial class CustomerRecordsPage
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
            BuyerButton = new CuoreUI.Controls.cuiButton();
            SupplierButton = new CuoreUI.Controls.cuiButton();
            CustomerPanel = new Panel();
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
            DashboardTitlePage.Size = new Size(375, 46);
            DashboardTitlePage.TabIndex = 4;
            DashboardTitlePage.Text = "Customer Records";
            // 
            // BuyerButton
            // 
            BuyerButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            BuyerButton.CheckButton = false;
            BuyerButton.Checked = false;
            BuyerButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            BuyerButton.CheckedForeColor = Color.White;
            BuyerButton.CheckedImageTint = Color.White;
            BuyerButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            BuyerButton.Content = "Buyer";
            BuyerButton.DialogResult = DialogResult.None;
            BuyerButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuyerButton.ForeColor = Color.White;
            BuyerButton.HoverBackground = Color.White;
            BuyerButton.HoveredImageTint = Color.White;
            BuyerButton.HoverForeColor = Color.Black;
            BuyerButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            BuyerButton.Image = null;
            BuyerButton.ImageAutoCenter = true;
            BuyerButton.ImageExpand = new Point(0, 0);
            BuyerButton.ImageOffset = new Point(0, 0);
            BuyerButton.Location = new Point(39, 95);
            BuyerButton.Name = "BuyerButton";
            BuyerButton.NormalBackground = Color.FromArgb(0, 157, 209);
            BuyerButton.NormalForeColor = Color.White;
            BuyerButton.NormalImageTint = Color.White;
            BuyerButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            BuyerButton.OutlineThickness = 1F;
            BuyerButton.PressedBackground = Color.WhiteSmoke;
            BuyerButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            BuyerButton.PressedImageTint = Color.White;
            BuyerButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            BuyerButton.Rounding = new Padding(8);
            BuyerButton.Size = new Size(146, 40);
            BuyerButton.TabIndex = 12;
            BuyerButton.TextAlignment = StringAlignment.Center;
            BuyerButton.TextOffset = new Point(0, 0);
            BuyerButton.Click += BuyerButton_Click;
            // 
            // SupplierButton
            // 
            SupplierButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            SupplierButton.CheckButton = false;
            SupplierButton.Checked = false;
            SupplierButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            SupplierButton.CheckedForeColor = Color.White;
            SupplierButton.CheckedImageTint = Color.White;
            SupplierButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            SupplierButton.Content = "Seller";
            SupplierButton.DialogResult = DialogResult.None;
            SupplierButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierButton.ForeColor = Color.White;
            SupplierButton.HoverBackground = Color.White;
            SupplierButton.HoveredImageTint = Color.White;
            SupplierButton.HoverForeColor = Color.Black;
            SupplierButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SupplierButton.Image = null;
            SupplierButton.ImageAutoCenter = true;
            SupplierButton.ImageExpand = new Point(0, 0);
            SupplierButton.ImageOffset = new Point(0, 0);
            SupplierButton.Location = new Point(212, 95);
            SupplierButton.Name = "SupplierButton";
            SupplierButton.NormalBackground = Color.FromArgb(0, 157, 209);
            SupplierButton.NormalForeColor = Color.White;
            SupplierButton.NormalImageTint = Color.White;
            SupplierButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SupplierButton.OutlineThickness = 1F;
            SupplierButton.PressedBackground = Color.WhiteSmoke;
            SupplierButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            SupplierButton.PressedImageTint = Color.White;
            SupplierButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SupplierButton.Rounding = new Padding(8);
            SupplierButton.Size = new Size(146, 40);
            SupplierButton.TabIndex = 13;
            SupplierButton.TextAlignment = StringAlignment.Center;
            SupplierButton.TextOffset = new Point(0, 0);
            SupplierButton.Click += SupplierButton_Click;
            // 
            // CustomerPanel
            // 
            CustomerPanel.Location = new Point(25, 153);
            CustomerPanel.Margin = new Padding(2);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(1042, 628);
            CustomerPanel.TabIndex = 14;
            // 
            // CustomerRecordsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(CustomerPanel);
            Controls.Add(SupplierButton);
            Controls.Add(BuyerButton);
            Controls.Add(DashboardTitlePage);
            Name = "CustomerRecordsPage";
            Size = new Size(1084, 798);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private CuoreUI.Controls.cuiButton BuyerButton;
        private CuoreUI.Controls.cuiButton SupplierButton;
        private Panel CustomerPanel;
    }
}
