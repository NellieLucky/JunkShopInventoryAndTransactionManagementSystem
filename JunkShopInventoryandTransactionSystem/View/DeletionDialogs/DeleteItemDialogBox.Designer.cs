namespace JunkShopInventoryandTransactionSystem.View.DeletionDialogs
{
    partial class DeleteItemDialogBox
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
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            DashboardTitlePage = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ItemIDTextHolder = new Label();
            ItemNameTextHolder = new Label();
            ItemcatTextHolder = new Label();
            AddItemButton = new CuoreUI.Controls.cuiButton();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(AddItemButton);
            cuiPanel1.Controls.Add(ItemcatTextHolder);
            cuiPanel1.Controls.Add(ItemNameTextHolder);
            cuiPanel1.Controls.Add(ItemIDTextHolder);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Controls.Add(DashboardTitlePage);
            cuiPanel1.Controls.Add(cuiPictureBox1);
            cuiPanel1.Location = new Point(0, 1);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.White;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(575, 424);
            cuiPanel1.TabIndex = 0;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiPictureBox1.BackgroundImage = Properties.Resources.bin;
            cuiPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(189, 29);
            cuiPictureBox1.Margin = new Padding(4, 5, 4, 5);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(187, 155);
            cuiPictureBox1.TabIndex = 0;
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(0, 157, 209);
            DashboardTitlePage.Location = new Point(111, 189);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(357, 35);
            DashboardTitlePage.TabIndex = 28;
            DashboardTitlePage.Text = "You are deleting an item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 157, 209);
            label1.Location = new Point(137, 245);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 29;
            label1.Text = "Item ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 157, 209);
            label2.Location = new Point(137, 280);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 30;
            label2.Text = "Item Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 157, 209);
            label3.Location = new Point(137, 317);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 31;
            label3.Text = "Item Category:";
            // 
            // ItemIDTextHolder
            // 
            ItemIDTextHolder.AutoSize = true;
            ItemIDTextHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            ItemIDTextHolder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemIDTextHolder.ForeColor = Color.FromArgb(0, 157, 209);
            ItemIDTextHolder.Location = new Point(350, 245);
            ItemIDTextHolder.Name = "ItemIDTextHolder";
            ItemIDTextHolder.Size = new Size(21, 24);
            ItemIDTextHolder.TabIndex = 32;
            ItemIDTextHolder.Text = "0";
            // 
            // ItemNameTextHolder
            // 
            ItemNameTextHolder.AutoSize = true;
            ItemNameTextHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            ItemNameTextHolder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemNameTextHolder.ForeColor = Color.FromArgb(0, 157, 209);
            ItemNameTextHolder.Location = new Point(350, 280);
            ItemNameTextHolder.Name = "ItemNameTextHolder";
            ItemNameTextHolder.Size = new Size(63, 24);
            ItemNameTextHolder.TabIndex = 33;
            ItemNameTextHolder.Text = "Name";
            // 
            // ItemcatTextHolder
            // 
            ItemcatTextHolder.AutoSize = true;
            ItemcatTextHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            ItemcatTextHolder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemcatTextHolder.ForeColor = Color.FromArgb(0, 157, 209);
            ItemcatTextHolder.Location = new Point(350, 317);
            ItemcatTextHolder.Name = "ItemcatTextHolder";
            ItemcatTextHolder.Size = new Size(96, 24);
            ItemcatTextHolder.TabIndex = 34;
            ItemcatTextHolder.Text = "Category";
            // 
            // AddItemButton
            // 
            AddItemButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            AddItemButton.CheckButton = false;
            AddItemButton.Checked = false;
            AddItemButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            AddItemButton.CheckedForeColor = Color.White;
            AddItemButton.CheckedImageTint = Color.White;
            AddItemButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            AddItemButton.Content = "Continue";
            AddItemButton.DialogResult = DialogResult.None;
            AddItemButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItemButton.ForeColor = Color.White;
            AddItemButton.HoverBackground = Color.White;
            AddItemButton.HoveredImageTint = Color.White;
            AddItemButton.HoverForeColor = Color.Black;
            AddItemButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            AddItemButton.Image = null;
            AddItemButton.ImageAutoCenter = true;
            AddItemButton.ImageExpand = new Point(0, 0);
            AddItemButton.ImageOffset = new Point(0, 0);
            AddItemButton.Location = new Point(300, 370);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.NormalBackground = Color.FromArgb(0, 157, 209);
            AddItemButton.NormalForeColor = Color.White;
            AddItemButton.NormalImageTint = Color.White;
            AddItemButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            AddItemButton.OutlineThickness = 1F;
            AddItemButton.PressedBackground = Color.WhiteSmoke;
            AddItemButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            AddItemButton.PressedImageTint = Color.White;
            AddItemButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            AddItemButton.Rounding = new Padding(8);
            AddItemButton.Size = new Size(146, 40);
            AddItemButton.TabIndex = 35;
            AddItemButton.TextAlignment = StringAlignment.Center;
            AddItemButton.TextOffset = new Point(0, 0);
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Cancel";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.FromArgb(0, 157, 209);
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(126, 370);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.FromArgb(0, 157, 209);
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(146, 40);
            cuiButton1.TabIndex = 36;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // DeleteItemDialogBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 423);
            Controls.Add(cuiPanel1);
            Name = "DeleteItemDialogBox";
            Text = "Delete Item";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private Label DashboardTitlePage;
        private Label ItemcatTextHolder;
        private Label ItemNameTextHolder;
        private Label ItemIDTextHolder;
        private Label label3;
        private Label label2;
        private Label label1;
        private CuoreUI.Controls.cuiButton AddItemButton;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}