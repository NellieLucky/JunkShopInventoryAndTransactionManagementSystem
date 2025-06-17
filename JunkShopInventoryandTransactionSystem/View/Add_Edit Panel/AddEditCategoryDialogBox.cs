
// imports cat add, edit, crud
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Add;
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Edit;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel
{
    public partial class AddEditCategoryDialogBox : Form
    {

        // will hold the value passed to the constructor
        private string value;
        private DataGridView _targetDataGridView;
        private int? categoryId;

        // constructor for Add function only
        // Modified constructor to accept the DataGridView

        public AddEditCategoryDialogBox(string value, DataGridView dgv)
        {
            InitializeComponent();

            this.value = value;
            _targetDataGridView = dgv;

            // checks the value
            if (this.value == "Add")
            {
                //replaces the dashboard title and button with "Add Item"
                AddEditCategoriesLabel.Text = "Add Category";
                // btn2 = OK button = add category
                proceedButton.Content = "Add Category";

                // idk what these are yet
                //this.Text = "Add Item";
                //this.Icon = Icon.FromHandle(Properties.Resources.add.GetHicon());
            }
            else
            {
                // for checking
                AddEditCategoriesLabel.Text = "ADD CAT ERROR DO NOT PROCEED";
                proceedButton.Content = "ERROR DO NOT CLICK-INFORM BACK-ENDERS IMMEDIATELY";
            }


        }

        // constructor for Edit function only
        // Modified constructor to accept the DataGridView

        public AddEditCategoryDialogBox(string value, DataGridView dgv, int categoryId)
        {
            InitializeComponent();

            this.value = value;
            _targetDataGridView = dgv;
            this.categoryId = categoryId;

            // checks the value
            if (this.value == "Edit")
            {
                //replaces the dashboard title and button with "Add Item"
                AddEditCategoriesLabel.Text = "Edit Category";
                // btn2 = OK button = add category
                proceedButton.Content = "Edit Category";

                // idk what these are yet
                //this.Text = "Add Item";
                //this.Icon = Icon.FromHandle(Properties.Resources.add.GetHicon());
            }
            else
            {
                // for checking
                AddEditCategoriesLabel.Text = "EDIT CAT ERROR DO NOT PROCEED";
                proceedButton.Content = "ERROR DO NOT CLICK-INFORM BACK-ENDERS IMMEDIATELY";
            }

            LoadCategoryDetails();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (proceedButton.Content == "Add Category")
            {
                //moved them here to ensure they are only executed when adding an item
                //stores the values of the widgets in variables
                string categoryName = catNameTextBox.Content as string ?? string.Empty;
                string categoryDescription  = catDescTextBox.Content as string ?? string.Empty;

                // passes the values of the widgets to the AddToInventoryHandler 
                bool addSuccess = AddToCategory.HandleAddCategory(
                    categoryName,
                    categoryDescription,
                    _targetDataGridView // Pass the stored DataGridView
                );

                //clear the input fields after adding and close the window
                if (addSuccess) // Only clear and close if the item was added successfully
                {
                    catNameTextBox.Content = string.Empty;
                    catDescTextBox.Content = string.Empty;

                    //Closes the form
                    this.Close();
                }
                else
                {
                    // added this for checking incase of error
                    MessageBox.Show("Cannot add category: Unknown Error.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (proceedButton.Content == "Edit Category")
            {
                //moved them here to ensure they are only executed when adding an item
                //stores the values of the widgets in variables
                int categoryId = this.categoryId ?? 0;
                string categoryName = catNameTextBox.Content as string ?? string.Empty;
                string categoryDescription = catDescTextBox.Content as string ?? string.Empty;

                // passes the values of the widgets to the AddToInventoryHandler 
                bool editSuccess = EditCategory.HandleEditCategory(
                    categoryId,
                    categoryName,
                    categoryDescription,
                    _targetDataGridView // Pass the stored DataGridView
                );

                //clear the input fields after adding and close the window
                if (editSuccess) // Only clear and close if the item was added successfully
                {
                    catNameTextBox.Content = string.Empty;
                    catDescTextBox.Content = string.Empty;

                    //Closes the form
                    this.Close();
                }
                else
                {
                    // added this for checking incase of error
                    MessageBox.Show("Cannot edit category: Unknown Error.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCategoryDetails()
        {
            // cat as in category but ight 

            if (!categoryId.HasValue) return;
            CategoryItem? category = new CategoryRead().GetOneCategory(categoryId.Value);

            if (category == null)
            {
                MessageBox.Show("Category not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Populate widgets using .Text, not .Content
            catNameTextBox.Content = category.categoryName.ToString();
            catDescTextBox.Content = category.categoryDescription ?? string.Empty;
        }
    }
}
