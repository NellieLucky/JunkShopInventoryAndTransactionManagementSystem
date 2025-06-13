using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using JunkShopInventoryandTransactionSystem.View;

namespace JunkShopInventoryandTransactionSystem
{
    public partial class MainForm : Form
    {
        // Connection string to connect to the local SQL Server database
        //private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\source\repos\JunkShopInventoryandTransactionSystem\Users.mdf;Integrated Security=True";

        //arnel's connstring
        //private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShop.mdf;Integrated Security=True";

        //remo string
        private readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public static Panel MainPanel;
        public MainForm()
        {
            InitializeComponent();
            MainPanel = panel1; // Assign the panel to a static variable for easy access
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool isManagementTableEmpty = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Management";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int count = (int)command.ExecuteScalar();
                        isManagementTableEmpty = count == 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            panel1.Controls.Clear();

            if (isManagementTableEmpty)
            {
                AdminSignUpPage adminSignUpPage = new AdminSignUpPage();
                adminSignUpPage.Dock = DockStyle.Fill;
                adminSignUpPage.TopLevel = false;
                panel1.Controls.Add(adminSignUpPage);
                adminSignUpPage.Show();
            }
            else
            {
                LogInPage loginPage = new LogInPage();
                loginPage.Dock = DockStyle.Fill;
                loginPage.TopLevel = false;
                panel1.Controls.Add(loginPage);
                loginPage.Show();
            }
        }
    }
}
