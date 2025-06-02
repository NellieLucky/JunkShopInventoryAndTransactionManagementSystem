namespace JunkShopInventoryandTransactionSystem.View
{
    partial class ForgotPasswordPage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            Logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            LogIn_Panel = new JUNKSHOP.Resources.UserDefinedComponents.Gradient_Panel();
            label1 = new Label();
            GoBack = new Label();
            SendLinkButton = new Guna.UI2.WinForms.Guna2Button();
            FEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
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
            guna2GradientPanel1.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.FromArgb(13, 158, 169);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(115, 211, 95);
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2GradientPanel1.Size = new Size(1182, 753);
            guna2GradientPanel1.TabIndex = 1;
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
            LogIn_Panel.Controls.Add(label1);
            LogIn_Panel.Controls.Add(GoBack);
            LogIn_Panel.Controls.Add(SendLinkButton);
            LogIn_Panel.Controls.Add(FEmailTextBox);
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
            // label1
            // 
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 107, 23);
            label1.Location = new Point(82, 181);
            label1.Name = "label1";
            label1.Size = new Size(657, 77);
            label1.TabIndex = 7;
            label1.Text = "Enter the email associated with  your account. We will send you a link to reset your password.\n";
            label1.Click += label1_Click;
            // 
            // GoBack
            // 
            GoBack.AutoSize = true;
            GoBack.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GoBack.ForeColor = Color.FromArgb(16, 107, 23);
            GoBack.Location = new Point(262, 608);
            GoBack.Name = "GoBack";
            GoBack.Size = new Size(330, 33);
            GoBack.TabIndex = 6;
            GoBack.Text = "Go Back to Log In Page";
            GoBack.Click += GoBack_Click;
            GoBack.MouseEnter += GoBack_MouseEnter;
            GoBack.MouseLeave += GoBack_MouseLeave;
            // 
            // SendLinkButton
            // 
            SendLinkButton.AutoRoundedCorners = true;
            SendLinkButton.CustomizableEdges = customizableEdges2;
            SendLinkButton.DisabledState.BorderColor = Color.DarkGray;
            SendLinkButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SendLinkButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SendLinkButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SendLinkButton.FillColor = Color.FromArgb(7, 96, 14);
            SendLinkButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendLinkButton.ForeColor = SystemColors.Window;
            SendLinkButton.Location = new Point(95, 478);
            SendLinkButton.Name = "SendLinkButton";
            SendLinkButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            SendLinkButton.Size = new Size(617, 79);
            SendLinkButton.TabIndex = 5;
            SendLinkButton.Text = "Send Link";
            // 
            // FEmailTextBox
            // 
            FEmailTextBox.BorderColor = Color.FromArgb(16, 107, 23);
            FEmailTextBox.BorderRadius = 30;
            FEmailTextBox.BorderThickness = 3;
            FEmailTextBox.CustomizableEdges = customizableEdges4;
            FEmailTextBox.DefaultText = "";
            FEmailTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            FEmailTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            FEmailTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            FEmailTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            FEmailTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            FEmailTextBox.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FEmailTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            FEmailTextBox.Location = new Point(95, 342);
            FEmailTextBox.Margin = new Padding(6);
            FEmailTextBox.Name = "FEmailTextBox";
            FEmailTextBox.PlaceholderText = "Enter your email...";
            FEmailTextBox.SelectedText = "";
            FEmailTextBox.ShadowDecoration.CustomizableEdges = customizableEdges5;
            FEmailTextBox.Size = new Size(617, 79);
            FEmailTextBox.TabIndex = 1;
            // 
            // SigInLabel
            // 
            SigInLabel.AutoSize = true;
            SigInLabel.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SigInLabel.ForeColor = Color.FromArgb(16, 107, 23);
            SigInLabel.Location = new Point(82, 111);
            SigInLabel.Name = "SigInLabel";
            SigInLabel.Size = new Size(411, 55);
            SigInLabel.TabIndex = 0;
            SigInLabel.Text = "Forgot Password";
            SigInLabel.Click += SigInLabel_Click;
            // 
            // ForgotPasswordPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordPage";
            Text = "ForgotPasswordPage";
            guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            LogIn_Panel.ResumeLayout(false);
            LogIn_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Logo;
        private JUNKSHOP.Resources.UserDefinedComponents.Gradient_Panel LogIn_Panel;
        private Label GoBack;
        private Guna.UI2.WinForms.Guna2Button SendLinkButton;

        public Label FEmailLabel { get; private set; }

        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox FEmailTextBox;
        private Label SigInLabel;
        private Label label1;
    }
}