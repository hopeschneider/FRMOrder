using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMOrder
{
    public partial class FRMInventory : Form
    {
        private ListBox LBXInventory;
        private Button BTNClose;
        private Label LBLIngredientInventory;

        public FRMInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This clears the listbox before displaying anything.
        /// It also loops through the products and displays them.
        /// </summary>
        private void DisplayInventory()
        {
            // Clears the ListBox before displaying inventory
            LBXInventory.Items.Clear();

            //Loops through all eleven ingredients
            for (int i = 0; i < InventoryData.strIngredientNames.Length; i++)
            {
                //Gets the ingredients name and available quantity
                string strIngredients = InventoryData.strIngredientNames[i];
                decimal decQuantity = InventoryData.decIngredientInventories[i];

                //Displays the ingredient and quantity in the ListBox
                LBXInventory.Items.Add(strIngredients + " - " + decQuantity);
            }
        }
        
        /// <summary>
        /// This displays the inventory when loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMInventory_Load(object sender, EventArgs e)
        {
            DisplayInventory();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            this.LBXInventory = new System.Windows.Forms.ListBox();
            this.BTNClose = new System.Windows.Forms.Button();
            this.LBLIngredientInventory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBXInventory
            // 
            this.LBXInventory.FormattingEnabled = true;
            this.LBXInventory.ItemHeight = 25;
            this.LBXInventory.Location = new System.Drawing.Point(65, 152);
            this.LBXInventory.Name = "LBXInventory";
            this.LBXInventory.Size = new System.Drawing.Size(542, 429);
            this.LBXInventory.TabIndex = 0;
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(245, 628);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(169, 59);
            this.BTNClose.TabIndex = 1;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            // 
            // LBLIngredientInventory
            // 
            this.LBLIngredientInventory.AutoSize = true;
            this.LBLIngredientInventory.Location = new System.Drawing.Point(227, 75);
            this.LBLIngredientInventory.Name = "LBLIngredientInventory";
            this.LBLIngredientInventory.Size = new System.Drawing.Size(201, 25);
            this.LBLIngredientInventory.TabIndex = 2;
            this.LBLIngredientInventory.Text = "Ingredient Inventory";
            // 
            // FRMInventory
            // 
            this.CancelButton = this.BTNClose;
            this.ClientSize = new System.Drawing.Size(700, 732);
            this.Controls.Add(this.LBLIngredientInventory);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.LBXInventory);
            this.Name = "FRMInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
