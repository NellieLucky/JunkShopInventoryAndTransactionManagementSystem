namespace JunkShopInventoryandTransactionSystem.View
{
    partial class FinancialReportsPage
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
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(38, 35);
            DashboardTitlePage.Margin = new Padding(4, 0, 4, 0);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(437, 56);
            DashboardTitlePage.TabIndex = 5;
            DashboardTitlePage.Text = "Financial Records";
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.Location = new Point(595, 164);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(174, 29);
            guna2CheckBox1.TabIndex = 6;
            guna2CheckBox1.Text = "guna2CheckBox1";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // FinancialReportsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CheckBox1);
            Controls.Add(DashboardTitlePage);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FinancialReportsPage";
            Size = new Size(1145, 941);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
    }
}
