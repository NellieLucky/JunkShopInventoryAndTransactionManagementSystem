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
            guna2RadialGauge1 = new Guna.UI2.WinForms.Guna2RadialGauge();
            SuspendLayout();
            // 
            // DashboardTitlePage
            // 
            DashboardTitlePage.AutoSize = true;
            DashboardTitlePage.BackColor = Color.FromArgb(0, 0, 0, 0);
            DashboardTitlePage.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardTitlePage.ForeColor = Color.FromArgb(16, 107, 23);
            DashboardTitlePage.Location = new Point(30, 28);
            DashboardTitlePage.Name = "DashboardTitlePage";
            DashboardTitlePage.Size = new Size(359, 46);
            DashboardTitlePage.TabIndex = 5;
            DashboardTitlePage.Text = "Financial Records";
            // 
            // guna2RadialGauge1
            // 
            guna2RadialGauge1.Font = new Font("Verdana", 8.2F);
            guna2RadialGauge1.ForeColor = Color.FromArgb(139, 152, 166);
            guna2RadialGauge1.Location = new Point(296, 118);
            guna2RadialGauge1.MinimumSize = new Size(30, 30);
            guna2RadialGauge1.Name = "guna2RadialGauge1";
            guna2RadialGauge1.Size = new Size(300, 300);
            guna2RadialGauge1.TabIndex = 6;
            // 
            // FinancialReportsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2RadialGauge1);
            Controls.Add(DashboardTitlePage);
            Name = "FinancialReportsPage";
            Size = new Size(916, 753);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitlePage;
        private Guna.UI2.WinForms.Guna2RadialGauge guna2RadialGauge1;
    }
}
