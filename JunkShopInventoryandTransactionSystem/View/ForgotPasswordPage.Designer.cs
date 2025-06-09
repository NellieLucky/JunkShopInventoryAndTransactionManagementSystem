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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            SigInLabel = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            EmailTextBox = new CuoreUI.Controls.cuiTextBox();
            SendLinkButton = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            GoBack = new Label();
            codeeloGradientPanel1.SuspendLayout();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // codeeloGradientPanel1
            // 
            codeeloGradientPanel1.AccessibleRole = null;
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
            codeeloGradientPanel1.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            codeeloGradientPanel1.Location = new Point(-1, 0);
            codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            codeeloGradientPanel1.Size = new Size(1401, 800);
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
            cuiPictureBox1.TabIndex = 10;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            cuiPanel1.Controls.Add(SigInLabel);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Controls.Add(SendLinkButton);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Controls.Add(GoBack);
            cuiPanel1.Location = new Point(420, 0);
            cuiPanel1.Margin = new Padding(0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Empty;
            cuiPanel1.Rounding = new Padding(0, 50, 50, 0);
            cuiPanel1.Size = new Size(980, 800);
            cuiPanel1.TabIndex = 9;
            // 
            // SigInLabel
            // 
            SigInLabel.AutoSize = true;
            SigInLabel.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SigInLabel.ForeColor = Color.FromArgb(16, 107, 23);
            SigInLabel.Location = new Point(172, 132);
            SigInLabel.Name = "SigInLabel";
            SigInLabel.Size = new Size(411, 55);
            SigInLabel.TabIndex = 0;
            SigInLabel.Text = "Forgot Password";
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(EmailTextBox);
            cuiPanel2.Location = new Point(200, 355);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.Green;
            cuiPanel2.PanelOutlineColor = Color.Green;
            cuiPanel2.Rounding = new Padding(24);
            cuiPanel2.Size = new Size(643, 75);
            cuiPanel2.TabIndex = 8;
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
            // SendLinkButton
            // 
            SendLinkButton.AutoRoundedCorners = true;
            SendLinkButton.CustomizableEdges = customizableEdges3;
            SendLinkButton.DisabledState.BorderColor = Color.DarkGray;
            SendLinkButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SendLinkButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SendLinkButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SendLinkButton.FillColor = Color.FromArgb(7, 96, 14);
            SendLinkButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendLinkButton.ForeColor = SystemColors.Window;
            SendLinkButton.Location = new Point(203, 504);
            SendLinkButton.Name = "SendLinkButton";
            SendLinkButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SendLinkButton.Size = new Size(640, 79);
            SendLinkButton.TabIndex = 5;
            SendLinkButton.Text = "Send Link";
            SendLinkButton.Click += SendLinkButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 107, 23);
            label1.Location = new Point(182, 219);
            label1.Name = "label1";
            label1.Size = new Size(643, 77);
            label1.TabIndex = 7;
            label1.Text = "Enter the email associated with  your account. We will send you a link to reset your password.\n";
            // 
            // GoBack
            // 
            GoBack.AutoSize = true;
            GoBack.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GoBack.ForeColor = Color.FromArgb(16, 107, 23);
            GoBack.Location = new Point(380, 629);
            GoBack.Name = "GoBack";
            GoBack.Size = new Size(330, 33);
            GoBack.TabIndex = 6;
            GoBack.Text = "Go Back to Log In Page";
            GoBack.Click += GoBack_Click_1;
            GoBack.MouseEnter += GoBack_MouseEnter_1;
            GoBack.MouseLeave += GoBack_MouseLeave_1;
            // 
            // ForgotPasswordPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(codeeloGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordPage";
            Text = "ForgotPasswordPage";
            codeeloGradientPanel1.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private Label label1;
        private Label GoBack;
        private Guna.UI2.WinForms.Guna2Button SendLinkButton;
        private Label SigInLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiTextBox EmailTextBox;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;

        public Label FEmailLabel { get; private set; }
    }
}