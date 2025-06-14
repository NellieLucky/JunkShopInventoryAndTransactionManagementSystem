namespace JunkShopInventoryandTransactionSystem.View
{
    partial class MainInventoryPage
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
            panel1 = new Panel();
            ItemNavButton = new CuoreUI.Controls.cuiButton();
            AuditNavButton = new CuoreUI.Controls.cuiButton();
            CategoryNavButton = new CuoreUI.Controls.cuiButton();
            InventoryPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(21, 21);
            DashboardTitlePage.Margin = new Padding(4, 0, 4, 0);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(240, 56);
            DashboardTitlePage.TabIndex = 1;
            DashboardTitlePage.Text = "Inventory";
            // 
            // panel1
            // 
            panel1.Controls.Add(ItemNavButton);
            panel1.Controls.Add(AuditNavButton);
            panel1.Controls.Add(CategoryNavButton);
            panel1.Controls.Add(DashboardTitlePage);
            panel1.Location = new Point(4, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1351, 160);
            panel1.TabIndex = 2;
            // 
            // ItemNavButton
            // 
            ItemNavButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            ItemNavButton.CheckButton = false;
            ItemNavButton.Checked = false;
            ItemNavButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            ItemNavButton.CheckedForeColor = Color.White;
            ItemNavButton.CheckedImageTint = Color.White;
            ItemNavButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            ItemNavButton.Content = "Items";
            ItemNavButton.DialogResult = DialogResult.None;
            ItemNavButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemNavButton.ForeColor = Color.White;
            ItemNavButton.HoverBackground = Color.White;
            ItemNavButton.HoveredImageTint = Color.White;
            ItemNavButton.HoverForeColor = Color.Black;
            ItemNavButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            ItemNavButton.Image = null;
            ItemNavButton.ImageAutoCenter = true;
            ItemNavButton.ImageExpand = new Point(0, 0);
            ItemNavButton.ImageOffset = new Point(0, 0);
            ItemNavButton.Location = new Point(21, 101);
            ItemNavButton.Margin = new Padding(4, 4, 4, 4);
            ItemNavButton.Name = "ItemNavButton";
            ItemNavButton.NormalBackground = Color.FromArgb(0, 157, 209);
            ItemNavButton.NormalForeColor = Color.White;
            ItemNavButton.NormalImageTint = Color.White;
            ItemNavButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            ItemNavButton.OutlineThickness = 1F;
            ItemNavButton.PressedBackground = Color.WhiteSmoke;
            ItemNavButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            ItemNavButton.PressedImageTint = Color.White;
            ItemNavButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            ItemNavButton.Rounding = new Padding(8);
            ItemNavButton.Size = new Size(182, 50);
            ItemNavButton.TabIndex = 4;
            ItemNavButton.TextAlignment = StringAlignment.Center;
            ItemNavButton.TextOffset = new Point(0, 0);
            ItemNavButton.Click += ItemNavButton_Click;
            // 
            // AuditNavButton
            // 
            AuditNavButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            AuditNavButton.CheckButton = false;
            AuditNavButton.Checked = false;
            AuditNavButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            AuditNavButton.CheckedForeColor = Color.White;
            AuditNavButton.CheckedImageTint = Color.White;
            AuditNavButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            AuditNavButton.Content = "Inventory Audit";
            AuditNavButton.DialogResult = DialogResult.None;
            AuditNavButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuditNavButton.ForeColor = Color.White;
            AuditNavButton.HoverBackground = Color.White;
            AuditNavButton.HoveredImageTint = Color.White;
            AuditNavButton.HoverForeColor = Color.Black;
            AuditNavButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            AuditNavButton.Image = null;
            AuditNavButton.ImageAutoCenter = true;
            AuditNavButton.ImageExpand = new Point(0, 0);
            AuditNavButton.ImageOffset = new Point(0, 0);
            AuditNavButton.Location = new Point(401, 101);
            AuditNavButton.Margin = new Padding(4, 4, 4, 4);
            AuditNavButton.Name = "AuditNavButton";
            AuditNavButton.NormalBackground = Color.FromArgb(0, 157, 209);
            AuditNavButton.NormalForeColor = Color.White;
            AuditNavButton.NormalImageTint = Color.White;
            AuditNavButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            AuditNavButton.OutlineThickness = 1F;
            AuditNavButton.PressedBackground = Color.WhiteSmoke;
            AuditNavButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            AuditNavButton.PressedImageTint = Color.White;
            AuditNavButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            AuditNavButton.Rounding = new Padding(8);
            AuditNavButton.Size = new Size(182, 50);
            AuditNavButton.TabIndex = 3;
            AuditNavButton.TextAlignment = StringAlignment.Center;
            AuditNavButton.TextOffset = new Point(0, 0);
            // 
            // CategoryNavButton
            // 
            CategoryNavButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            CategoryNavButton.CheckButton = false;
            CategoryNavButton.Checked = false;
            CategoryNavButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            CategoryNavButton.CheckedForeColor = Color.White;
            CategoryNavButton.CheckedImageTint = Color.White;
            CategoryNavButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            CategoryNavButton.Content = "Categories";
            CategoryNavButton.DialogResult = DialogResult.None;
            CategoryNavButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryNavButton.ForeColor = Color.White;
            CategoryNavButton.HoverBackground = Color.White;
            CategoryNavButton.HoveredImageTint = Color.White;
            CategoryNavButton.HoverForeColor = Color.Black;
            CategoryNavButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            CategoryNavButton.Image = null;
            CategoryNavButton.ImageAutoCenter = true;
            CategoryNavButton.ImageExpand = new Point(0, 0);
            CategoryNavButton.ImageOffset = new Point(0, 0);
            CategoryNavButton.Location = new Point(211, 101);
            CategoryNavButton.Margin = new Padding(4, 4, 4, 4);
            CategoryNavButton.Name = "CategoryNavButton";
            CategoryNavButton.NormalBackground = Color.FromArgb(0, 157, 209);
            CategoryNavButton.NormalForeColor = Color.White;
            CategoryNavButton.NormalImageTint = Color.White;
            CategoryNavButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            CategoryNavButton.OutlineThickness = 1F;
            CategoryNavButton.PressedBackground = Color.WhiteSmoke;
            CategoryNavButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            CategoryNavButton.PressedImageTint = Color.White;
            CategoryNavButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            CategoryNavButton.Rounding = new Padding(8);
            CategoryNavButton.Size = new Size(182, 50);
            CategoryNavButton.TabIndex = 2;
            CategoryNavButton.TextAlignment = StringAlignment.Center;
            CategoryNavButton.TextOffset = new Point(0, 0);
            // 
            // InventoryPanel
            // 
            InventoryPanel.Location = new Point(0, 159);
            InventoryPanel.Margin = new Padding(4, 4, 4, 4);
            InventoryPanel.Name = "InventoryPanel";
            InventoryPanel.Size = new Size(1355, 835);
            InventoryPanel.TabIndex = 3;
            InventoryPanel.Paint += InventoryPanel_Paint;
            // 
            // MainInventoryPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 238);
            Controls.Add(InventoryPanel);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainInventoryPage";
            Size = new Size(1355, 998);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label DashboardTitlePage;
        private Panel panel1;
        private Panel InventoryPanel;
        private CuoreUI.Controls.cuiButton CategoryNavButton;
        private CuoreUI.Controls.cuiButton AuditNavButton;
        private CuoreUI.Controls.cuiButton ItemNavButton;
    }
}
