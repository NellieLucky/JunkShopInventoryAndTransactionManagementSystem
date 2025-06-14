using JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace JunkShopInventoryandTransactionSystem.View.Inventory_Pages
{
    public partial class CategoryPage : UserControl
    {
        private AddEditCategoryDialogBox addEditCategoryDialogBox = null!; // Initialize with null-forgiving operator  

        public CategoryPage()
        {
            InitializeComponent();

            //Pangtest lang to if msgkakalaman  
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);

            // Set header text for Edit and Delete columns to empty  
            dataGridView1.Columns["Edit"].HeaderText = "";
            dataGridView1.Columns["Delete"].HeaderText = "";

            dataGridView1.Paint += DataGridView1_Paint;
        }

        //Para to sa pag-merge ng Edit at Delete header cells kasi walang built-in support sa DataGridView para here  
        private void DataGridView1_Paint(object sender, PaintEventArgs e)
        {
            // Get the rectangles for the Edit and Delete header cells  
            var editRect = dataGridView1.GetCellDisplayRectangle(dataGridView1.Columns["Edit"].Index, -1, true);
            var deleteRect = dataGridView1.GetCellDisplayRectangle(dataGridView1.Columns["Delete"].Index, -1, true);

            // Calculate the merged rectangle  
            Rectangle mergedRect = new Rectangle(
                editRect.Left,
                editRect.Top,
                deleteRect.Right - editRect.Left,
                editRect.Height
            );

            // Draw the merged header background  
            using (SolidBrush backColorBrush = new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.BackColor))
            {
                e.Graphics.FillRectangle(backColorBrush, mergedRect);
            }

            // Draw the header text centered  
            using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (SolidBrush foreColorBrush = new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString("Actions", dataGridView1.ColumnHeadersDefaultCellStyle.Font, foreColorBrush, mergedRect, format);
            }
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (addEditCategoryDialogBox == null || addEditCategoryDialogBox.IsDisposed) // Check if it's already open  
            {
                addEditCategoryDialogBox = new AddEditCategoryDialogBox();
                addEditCategoryDialogBox.Show();
            }
            else
            {
                addEditCategoryDialogBox.Focus(); // Bring existing form to front  
            }
        }
    }
}
