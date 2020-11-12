namespace ShoppingList
{
    partial class ShoppingListForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingListForm));
            this.shoppingCheckedList = new System.Windows.Forms.CheckedListBox();
            this.shoppingProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnEndShoppingList = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shoppingCheckedList
            // 
            resources.ApplyResources(this.shoppingCheckedList, "shoppingCheckedList");
            this.shoppingCheckedList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.shoppingCheckedList.FormattingEnabled = true;
            this.shoppingCheckedList.Name = "shoppingCheckedList";
            // 
            // shoppingProgressBar
            // 
            resources.ApplyResources(this.shoppingProgressBar, "shoppingProgressBar");
            this.shoppingProgressBar.Name = "shoppingProgressBar";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnAddProduct, "btnAddProduct");
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnDeleteProduct, "btnDeleteProduct");
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnClearAll, "btnClearAll");
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnEndShoppingList
            // 
            this.btnEndShoppingList.BackColor = System.Drawing.Color.Khaki;
            resources.ApplyResources(this.btnEndShoppingList, "btnEndShoppingList");
            this.btnEndShoppingList.Name = "btnEndShoppingList";
            this.btnEndShoppingList.UseVisualStyleBackColor = false;
            // 
            // txtItem
            // 
            resources.ApplyResources(this.txtItem, "txtItem");
            this.txtItem.Name = "txtItem";
            // 
            // ShoppingListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnEndShoppingList);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.shoppingProgressBar);
            this.Controls.Add(this.shoppingCheckedList);
            this.Name = "ShoppingListForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox shoppingCheckedList;
        private System.Windows.Forms.ProgressBar shoppingProgressBar;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnEndShoppingList;
        private System.Windows.Forms.TextBox txtItem;
    }
}

