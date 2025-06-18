namespace JunkShopInventoryandTransactionSystem.View.DeletionDialogs
{
    partial class DeleteCategoryDialogBox
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
            label4 = new Label();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            ContinueDelButton = new CuoreUI.Controls.cuiButton();
            CatNameTextHolder = new Label();
            CatIDTextHolder = new Label();
            label2 = new Label();
            label1 = new Label();
            DashboardTitlePage = new Label();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(ContinueDelButton);
            cuiPanel1.Controls.Add(CatNameTextHolder);
            cuiPanel1.Controls.Add(CatIDTextHolder);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Controls.Add(DashboardTitlePage);
            cuiPanel1.Controls.Add(cuiPictureBox1);
            cuiPanel1.Location = new Point(0, -1);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.White;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(575, 424);
            cuiPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 157, 209);
            label4.Location = new Point(126, 224);
            label4.Name = "label4";
            label4.Size = new Size(316, 19);
            label4.TabIndex = 37;
            label4.Text = "This action will also remove all linked items";
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
            cuiButton1.Click += cuiButton1_Click;
            // 
            // ContinueDelButton
            // 
            ContinueDelButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            ContinueDelButton.CheckButton = false;
            ContinueDelButton.Checked = false;
            ContinueDelButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            ContinueDelButton.CheckedForeColor = Color.White;
            ContinueDelButton.CheckedImageTint = Color.White;
            ContinueDelButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            ContinueDelButton.Content = "Continue";
            ContinueDelButton.DialogResult = DialogResult.None;
            ContinueDelButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinueDelButton.ForeColor = Color.White;
            ContinueDelButton.HoverBackground = Color.White;
            ContinueDelButton.HoveredImageTint = Color.White;
            ContinueDelButton.HoverForeColor = Color.Black;
            ContinueDelButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            ContinueDelButton.Image = null;
            ContinueDelButton.ImageAutoCenter = true;
            ContinueDelButton.ImageExpand = new Point(0, 0);
            ContinueDelButton.ImageOffset = new Point(0, 0);
            ContinueDelButton.Location = new Point(300, 370);
            ContinueDelButton.Name = "ContinueDelButton";
            ContinueDelButton.NormalBackground = Color.FromArgb(0, 157, 209);
            ContinueDelButton.NormalForeColor = Color.White;
            ContinueDelButton.NormalImageTint = Color.White;
            ContinueDelButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            ContinueDelButton.OutlineThickness = 1F;
            ContinueDelButton.PressedBackground = Color.WhiteSmoke;
            ContinueDelButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            ContinueDelButton.PressedImageTint = Color.White;
            ContinueDelButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            ContinueDelButton.Rounding = new Padding(8);
            ContinueDelButton.Size = new Size(146, 40);
            ContinueDelButton.TabIndex = 35;
            ContinueDelButton.TextAlignment = StringAlignment.Center;
            ContinueDelButton.TextOffset = new Point(0, 0);
            ContinueDelButton.Click += ContinueDelButton_Click;
            // 
            // CatNameTextHolder
            // 
            CatNameTextHolder.AutoSize = true;
            CatNameTextHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            CatNameTextHolder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CatNameTextHolder.ForeColor = Color.FromArgb(0, 157, 209);
            CatNameTextHolder.Location = new Point(346, 303);
            CatNameTextHolder.Name = "CatNameTextHolder";
            CatNameTextHolder.Size = new Size(63, 24);
            CatNameTextHolder.TabIndex = 33;
            CatNameTextHolder.Text = "Name";
            // 
            // CatIDTextHolder
            // 
            CatIDTextHolder.AutoSize = true;
            CatIDTextHolder.BackColor = Color.FromArgb(0, 0, 0, 0);
            CatIDTextHolder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CatIDTextHolder.ForeColor = Color.FromArgb(0, 157, 209);
            CatIDTextHolder.Location = new Point(346, 268);
            CatIDTextHolder.Name = "CatIDTextHolder";
            CatIDTextHolder.Size = new Size(21, 24);
            CatIDTextHolder.TabIndex = 32;
            CatIDTextHolder.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 157, 209);
            label2.Location = new Point(133, 303);
            label2.Name = "label2";
            label2.Size = new Size(162, 24);
            label2.TabIndex = 30;
            label2.Text = "Category Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 157, 209);
            label1.Location = new Point(133, 268);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 29;
            label1.Text = "Category ID:";
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(0, 157, 209);
            DashboardTitlePage.Location = new Point(88, 189);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(403, 35);
            DashboardTitlePage.TabIndex = 28;
            DashboardTitlePage.Text = "You are deleting a category";
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
            // DeleteCategoryDialogBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 423);
            Controls.Add(cuiPanel1);
            Name = "DeleteCategoryDialogBox";
            Text = "DeleteCategoryDialogBox";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton ContinueDelButton;
        private Label CatNameTextHolder;
        private Label CatIDTextHolder;
        private Label label2;
        private Label label1;
        private Label DashboardTitlePage;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label4;
    }
}