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
                decimal decQuanity = InventoryData.decIngredientInventories[i];

                //Displays the ingredient and quantity in the ListBox
                LBXInventory.Items.Add(strIngredients + " - " + decQuanity);
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
    }
}
