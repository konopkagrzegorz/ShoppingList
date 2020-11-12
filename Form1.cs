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
    }
}
