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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            ForgotPasswordButton = new Label();
            LogInButton = new CuoreUI.Controls.cuiButton();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            PasswordTextBox = new CuoreUI.Controls.cuiTextBox();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            EmailTextBox = new CuoreUI.Controls.cuiTextBox();
            SignInLabel = new Label();
            codeeloGradientPanel1.SuspendLayout();
            cuiPanel1.SuspendLayout();
            cuiPanel3.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // codeeloGradientPanel1
            // 
            codeeloGradientPanel1.AccessibleRole = null;
            codeeloGradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            codeeloGradientPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            codeeloGradientPanel1.BorderRadius = 0;
            codeeloGradientPanel1.BorderThickness = 0;
            codeeloGradientPanel1.CausesValidation = false;
            codeeloGradientPanel1.ColorBorderFirst = Color.Empty;
            codeeloGradientPanel1.ColorBorderSecond = Color.Empty;
            codeeloGradientPanel1.ColorFillFirst = Color.FromArgb(13, 158, 169);
            codeeloGradientPanel1.ColorFillSecond = Color.FromArgb(115, 211, 95);
            codeeloGradientPanel1.Controls.Add(cuiPictureBox1);
            codeeloGradientPanel1.Controls.Add(cuiPanel1);
            codeeloGradientPanel1.DrawBorderGradient = true;
            codeeloGradientPanel1.DrawGradient = true;
            codeeloGradientPanel1.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            codeeloGradientPanel1.Location = new Point(0, 0);
            codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            codeeloGradientPanel1.Size = new Size(1400, 801);
            codeeloGradientPanel1.TabIndex = 0;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiPictureBox1.Content = (Image)resources.GetObject("cuiPictureBox1.Content");
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(89, 261);
            cuiPictureBox1.Margin = new Padding(4, 5, 4, 5);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(125);
            cuiPictureBox1.Size = new Size(250, 250);
            cuiPictureBox1.TabIndex = 1;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiPanel1.Controls.Add(ForgotPasswordButton);
            cuiPanel1.Controls.Add(LogInButton);
            cuiPanel1.Controls.Add(PasswordLabel);
            cuiPanel1.Controls.Add(EmailLabel);
            cuiPanel1.Controls.Add(cuiPanel3);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Controls.Add(SignInLabel);
            cuiPanel1.Location = new Point(420, 0);
            cuiPanel1.Margin = new Padding(0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Empty;
            cuiPanel1.Rounding = new Padding(0, 50, 50, 0);
            cuiPanel1.Size = new Size(980, 800);
            cuiPanel1.TabIndex = 0;
            // 
            // ForgotPasswordButton
            // 
            ForgotPasswordButton.AutoSize = true;
            ForgotPasswordButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForgotPasswordButton.ForeColor = Color.FromArgb(16, 107, 23);
            ForgotPasswordButton.Location = new Point(380, 629);
            ForgotPasswordButton.Name = "ForgotPasswordButton";
            ForgotPasswordButton.Size = new Size(287, 35);
            ForgotPasswordButton.TabIndex = 8;
            ForgotPasswordButton.Text = "Forgot Password ?";
            ForgotPasswordButton.Click += ForgotPasswordButton_Click;
            ForgotPasswordButton.MouseEnter += ForgotPasswordButton_MouseEnter;
            ForgotPasswordButton.MouseLeave += ForgotPasswordButton_MouseLeave;
            // 
            // LogInButton
            // 
            LogInButton.CheckButton = false;
            LogInButton.Checked = false;
            LogInButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            LogInButton.CheckedForeColor = Color.White;
            LogInButton.CheckedImageTint = Color.White;
            LogInButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            LogInButton.Content = "LOGIN";
            LogInButton.DialogResult = DialogResult.None;
            LogInButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.White;
            LogInButton.HoverBackground = Color.FromArgb(0, 192, 0);
            LogInButton.HoveredImageTint = Color.White;
            LogInButton.HoverForeColor = Color.Green;
            LogInButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            LogInButton.Image = null;
            LogInButton.ImageAutoCenter = true;
            LogInButton.ImageExpand = new Point(0, 0);
            LogInButton.ImageOffset = new Point(0, 0);
            LogInButton.Location = new Point(184, 522);
            LogInButton.Name = "LogInButton";
            LogInButton.NormalBackground = Color.FromArgb(7, 96, 14);
            LogInButton.NormalForeColor = Color.White;
            LogInButton.NormalImageTint = Color.White;
            LogInButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            LogInButton.OutlineThickness = 1F;
            LogInButton.PressedBackground = Color.FromArgb(128, 255, 128);
            LogInButton.PressedForeColor = Color.Green;
            LogInButton.PressedImageTint = Color.White;
            LogInButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            LogInButton.Rounding = new Padding(24);
            LogInButton.Size = new Size(641, 79);
            LogInButton.TabIndex = 7;
            LogInButton.TextAlignment = StringAlignment.Center;
            LogInButton.TextOffset = new Point(0, 0);
            LogInButton.Click += LogInButton_Click_1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.FromArgb(16, 107, 23);
            PasswordLabel.Location = new Point(184, 364);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(169, 35);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.FromArgb(16, 107, 23);
            EmailLabel.Location = new Point(182, 220);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(104, 35);
            EmailLabel.TabIndex = 5;
            EmailLabel.Text = "Email:";
            // 
            // cuiPanel3
            // 
            cuiPanel3.Controls.Add(PasswordTextBox);
            cuiPanel3.Location = new Point(182, 402);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.Green;
            cuiPanel3.PanelOutlineColor = Color.Green;
            cuiPanel3.Rounding = new Padding(24);
            cuiPanel3.Size = new Size(643, 75);
            cuiPanel3.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.AutoScroll = true;
            PasswordTextBox.AutoValidate = AutoValidate.EnablePreventFocusChange;
            PasswordTextBox.BackgroundColor = Color.White;
            PasswordTextBox.BorderColor = Color.Green;
            PasswordTextBox.Content = "";
            PasswordTextBox.FocusBackgroundColor = Color.White;
            PasswordTextBox.FocusBorderColor = Color.Green;
            PasswordTextBox.FocusImageTint = Color.Empty;
            PasswordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.Image = null;
            PasswordTextBox.ImageExpand = new Point(0, 0);
            PasswordTextBox.ImageOffset = new Point(0, 0);
            PasswordTextBox.ImeMode = ImeMode.Off;
            PasswordTextBox.Location = new Point(2, 3);
            PasswordTextBox.Margin = new Padding(0);
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.NormalImageTint = Color.White;
            PasswordTextBox.Padding = new Padding(23, 23, 23, 0);
            PasswordTextBox.PasswordChar = true;
            PasswordTextBox.PlaceholderColor = Color.Gray;
            PasswordTextBox.PlaceholderText = "Enter your password...";
            PasswordTextBox.Rounding = new Padding(24);
            PasswordTextBox.Size = new Size(638, 68);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.TextOffset = new Size(0, 0);
            PasswordTextBox.UnderlinedStyle = false;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(EmailTextBox);
            cuiPanel2.Location = new Point(182, 258);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.Green;
            cuiPanel2.PanelOutlineColor = Color.Green;
            cuiPanel2.Rounding = new Padding(24);
            cuiPanel2.Size = new Size(643, 75);
            cuiPanel2.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            EmailTextBox.AutoScroll = true;
            EmailTextBox.AutoValidate = AutoValidate.EnablePreventFocusChange;
            EmailTextBox.BackgroundColor = Color.White;
            EmailTextBox.BorderColor = Color.Green;
            EmailTextBox.Content = "";
            EmailTextBox.FocusBackgroundColor = Color.White;
            EmailTextBox.FocusBorderColor = Color.Green;
            EmailTextBox.FocusImageTint = Color.Empty;
            EmailTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextBox.ForeColor = Color.Black;
            EmailTextBox.Image = null;
            EmailTextBox.ImageExpand = new Point(0, 0);
            EmailTextBox.ImageOffset = new Point(0, 0);
            EmailTextBox.ImeMode = ImeMode.Off;
            EmailTextBox.Location = new Point(2, 3);
            EmailTextBox.Margin = new Padding(0);
            EmailTextBox.Multiline = false;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.NormalImageTint = Color.White;
            EmailTextBox.Padding = new Padding(23, 23, 23, 0);
            EmailTextBox.PasswordChar = false;
            EmailTextBox.PlaceholderColor = Color.Gray;
            EmailTextBox.PlaceholderText = "Enter your email...";
            EmailTextBox.Rounding = new Padding(24);
            EmailTextBox.Size = new Size(638, 68);
            EmailTextBox.TabIndex = 2;
            EmailTextBox.TextOffset = new Size(0, 0);
            EmailTextBox.UnderlinedStyle = false;
            EmailTextBox.UseWaitCursor = true;
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInLabel.ForeColor = Color.FromArgb(16, 107, 23);
            SignInLabel.Location = new Point(172, 132);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(181, 55);
            SignInLabel.TabIndex = 0;
            SignInLabel.Text = "Sign In";
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(codeeloGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInPage";
            Text = "Junk Shop Inventory and Transaction Management System";
            codeeloGradientPanel1.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            cuiPanel3.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private Label SignInLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiTextBox EmailTextBox;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiTextBox PasswordTextBox;
        private Label PasswordLabel;
        private Label EmailLabel;
        private CuoreUI.Controls.cuiButton LogInButton;
        private Label ForgotPasswordButton;
    }
}
