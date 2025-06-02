namespace JunkShopInventoryandTransactionSystem
{
    partial class LogInPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            Logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            LogIn_Panel = new JUNKSHOP.Resources.UserDefinedComponents.Gradient_Panel();
            ForgotPasswordPageClick = new Label();
            LogInButton = new Guna.UI2.WinForms.Guna2Button();
            PasswordLabel = new Label();
            PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            EmailLabel = new Label();
            EmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            SigInLabel = new Label();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            LogIn_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(Logo);
            guna2GradientPanel1.Controls.Add(LogIn_Panel);
            guna2GradientPanel1.CustomizableEdges = customizableEdges8;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.FromArgb(13, 158, 169);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(115, 211, 95);
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2GradientPanel1.Size = new Size(1182, 753);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(0, 0, 0, 0);
            Logo.BackgroundImageLayout = ImageLayout.Center;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.ImageRotate = 0F;
            Logo.Location = new Point(76, 277);
            Logo.Name = "Logo";
            Logo.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Logo.Size = new Size(231, 217);
            Logo.SizeMode = PictureBoxSizeMode.CenterImage;
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // LogIn_Panel
            // 
            LogIn_Panel.BackColor = Color.FromArgb(0, 0, 0, 0);
            LogIn_Panel.ColorBottom = Color.White;
            LogIn_Panel.ColorPosition = 0.7F;
            LogIn_Panel.ColorTop = Color.White;
            LogIn_Panel.Controls.Add(ForgotPasswordPageClick);
            LogIn_Panel.Controls.Add(LogInButton);
            LogIn_Panel.Controls.Add(PasswordLabel);
            LogIn_Panel.Controls.Add(PasswordTextBox);
            LogIn_Panel.Controls.Add(EmailLabel);
            LogIn_Panel.Controls.Add(EmailTextBox);
            LogIn_Panel.Controls.Add(SigInLabel);
            LogIn_Panel.CornerRadius = 50;
            LogIn_Panel.GradientAngle = 0F;
            LogIn_Panel.Location = new Point(391, 0);
            LogIn_Panel.Name = "LogIn_Panel";
            LogIn_Panel.RoundBottomLeft = true;
            LogIn_Panel.RoundBottomRight = false;
            LogIn_Panel.RoundTopLeft = true;
            LogIn_Panel.RoundTopRight = false;
            LogIn_Panel.Size = new Size(791, 753);
            LogIn_Panel.TabIndex = 0;
            // 
            // ForgotPasswordPageClick
            // 
            ForgotPasswordPageClick.AutoSize = true;
            ForgotPasswordPageClick.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForgotPasswordPageClick.ForeColor = Color.FromArgb(16, 107, 23);
            ForgotPasswordPageClick.Location = new Point(259, 604);
            ForgotPasswordPageClick.Name = "ForgotPasswordPageClick";
            ForgotPasswordPageClick.Size = new Size(287, 35);
            ForgotPasswordPageClick.TabIndex = 6;
            ForgotPasswordPageClick.Text = "Forgot Password ?";
            ForgotPasswordPageClick.Click += ForgotPasswordPageClick_Click;
            // 
            // LogInButton
            // 
            LogInButton.AutoRoundedCorners = true;
            LogInButton.CustomizableEdges = customizableEdges2;
            LogInButton.DisabledState.BorderColor = Color.DarkGray;
            LogInButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LogInButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogInButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogInButton.FillColor = Color.FromArgb(7, 96, 14);
            LogInButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = SystemColors.Window;
            LogInButton.Location = new Point(95, 510);
            LogInButton.Name = "LogInButton";
            LogInButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            LogInButton.Size = new Size(617, 79);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "LOGIN";
            LogInButton.Click += LogInButton_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.FromArgb(16, 107, 23);
            PasswordLabel.Location = new Point(95, 344);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(169, 35);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderColor = Color.FromArgb(16, 107, 23);
            PasswordTextBox.BorderRadius = 30;
            PasswordTextBox.BorderThickness = 3;
            PasswordTextBox.CustomizableEdges = customizableEdges4;
            PasswordTextBox.DefaultText = "";
            PasswordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Location = new Point(95, 386);
            PasswordTextBox.Margin = new Padding(6);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Enter your password...";
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges5;
            PasswordTextBox.Size = new Size(617, 79);
            PasswordTextBox.TabIndex = 3;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.FromArgb(16, 107, 23);
            EmailLabel.Location = new Point(95, 188);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(104, 35);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BorderColor = Color.FromArgb(16, 107, 23);
            EmailTextBox.BorderRadius = 30;
            EmailTextBox.BorderThickness = 3;
            EmailTextBox.CustomizableEdges = customizableEdges6;
            EmailTextBox.DefaultText = "";
            EmailTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmailTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmailTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmailTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmailTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTextBox.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTextBox.Location = new Point(95, 230);
            EmailTextBox.Margin = new Padding(6);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Enter your email...";
            EmailTextBox.SelectedText = "";
            EmailTextBox.ShadowDecoration.CustomizableEdges = customizableEdges7;
            EmailTextBox.Size = new Size(617, 79);
            EmailTextBox.TabIndex = 1;
            // 
            // SigInLabel
            // 
            SigInLabel.AutoSize = true;
            SigInLabel.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SigInLabel.ForeColor = Color.FromArgb(16, 107, 23);
            SigInLabel.Location = new Point(83, 103);
            SigInLabel.Name = "SigInLabel";
            SigInLabel.Size = new Size(181, 55);
            SigInLabel.TabIndex = 0;
            SigInLabel.Text = "Sign In";
            SigInLabel.Click += SigInLabel_Click;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInPage";
            Text = "Junk Shop Inventory and Transaction Management System";
            guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            LogIn_Panel.ResumeLayout(false);
            LogIn_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private JUNKSHOP.Resources.UserDefinedComponents.Gradient_Panel LogIn_Panel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Logo;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextBox;
        private Label SigInLabel;
        private Guna.UI2.WinForms.Guna2Button LogInButton;
        private Label PasswordLabel;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Label EmailLabel;
        private Label ForgotPasswordPageClick;
    }
}
