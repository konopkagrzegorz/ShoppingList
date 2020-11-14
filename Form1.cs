using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class ShoppingListForm : Form
    {

        private Boolean btnEndShoppingListStatus = false;

        public ShoppingListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            txtItem.Text = txtItem.Text.ToUpper();
            if (txtItem.TextLength == 0 || txtItem.Text.Equals(" "))
            {
                MessageBox.Show("You cannot add empty element!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (shoppingCheckedList.Items.Contains(txtItem.Text))
            {
                MessageBox.Show("You cannot add the same product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                shoppingCheckedList.Items.Add(txtItem.Text);
            }
            txtItem.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Do You want delete all items?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                shoppingCheckedList.Items.Clear();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (shoppingCheckedList.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                shoppingCheckedList.Items.RemoveAt(shoppingCheckedList.SelectedIndex);
            }
        }

        private void btnEndShoppingList_Click(object sender, EventArgs e)
        {
            btnAddProduct.Enabled = false;
            btnClearAll.Enabled = false;
            btnDeleteProduct.Enabled = false;

            btnEndShoppingListStatus = true;
        }

        private void shoppingCheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int checkedItems = shoppingCheckedList.CheckedItems.Count + 1;
            int items = shoppingCheckedList.Items.Count;
            if (btnEndShoppingListStatus == false)
            {
                MessageBox.Show("You need to close Shopping list first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                shoppingProgressBar.Value = (checkedItems * 100) / items;
                if (shoppingProgressBar.Value == 100)
                {
                    DialogResult dialog = MessageBox.Show("You collected all items! I am going to close", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }
    }
}
