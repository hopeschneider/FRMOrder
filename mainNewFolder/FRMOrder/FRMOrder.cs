using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AUTHORS: 
//COURSE: 
//FORM: 
//PURPOSE: 
//INPUT: 
//PROCESS: 
//OUTPUT: 
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”


namespace FRMOrder
{
    public partial class FRMOrder : Form
    {
        public FRMOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method is triggered when the "Process Order" button is clicked. 
        /// It validates the input fields to ensure that all required fields are filled, 
        /// the state is selected, the quantity is a positive whole number, and if hand 
        /// delivery is chosen, it checks if the delivery location is allowed 
        /// (Bryan or College Station, TX). If any validation fails, an error message is 
        /// displayed and the process is halted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNProcessOrder_Click(object sender, EventArgs e)
        {
            //Checks if all required fields are filled and valid
            TextBox[] requiredFields = {TXTCustomerName, 
                                        TXTStreetAddress,
                                        TXTCity, 
                                        TXTZipCode, 
                                        TXTQuantity, 
                                        TXTPhoneNumber};

            // Array of field names corresponding to the required fields for error messages
            string[] fieldNames = { "Customer Name",
                                    "Street Address", 
                                    "City", 
                                    "Zip Code",
                                    "Quantity",     
                                    "Phone Number" };

            // Checks if all required fields are filled
            for (int i = 0; i < requiredFields.Length; i++)
            {
                if (!Validator.IsPresent(requiredFields[i].Text, fieldNames[i]))
                {
                    return;
                }
            }

            // Checks if the Quantity field is a positive whole number
            if (!Validator.IsPositiveInteger(TXTQuantity.Text, "Quantity"))
            {
                return;
            }

            // Checks the State combobox selection
            if (!Validator.IsPresent(CBXState.Text, "State"))
            {
                return;
            }

            // Checks if Hand Delivery is selected and if the delivery location is allowed
            if (RDOHandDelivery.Checked && !Validator.IsAllowedDeliveryLocation(TXTCity.Text, CBXState.Text))
            {
                return;
            }

            //THE CODE FOR PROCESSING THE ORDER WILL GO HERE:
        }

        /// <summary>
        /// This method is triggered when the "Add Item to Order" button is clicked.
        /// It validates the Quantity field to ensure that it is filled and is a
        /// positive whole number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAddItemToOrder_Click(object sender, EventArgs e)
        {
            //Checks if the Quantity field is filled
            if(!Validator.IsPresent(TXTQuantity.Text, "Quantity"))
            {
                return;
            }

            //Checks if the Quantity field is a positive whole number
            if (!Validator.IsPositiveInteger(TXTQuantity.Text, "Quantity"))
            {
                return;
            }

            //Checks if CBXProductType and CBXMaterialDesign are selected before adding item to the order
            //and stops addition if an error is detected.
            bool isValid = Validator.ValidateItemEntry(CBXProductType.SelectedIndex,
                                                       CBXMaterialDesign.SelectedIndex);
            if (!isValid) return;

            //THE CODE FOR ADDING THE ITEM TO THE ORDER WILL GO HERE:


            int intQuantity = int.Parse(TXTQuantity.Text);

            string strProduct = CBXProductType.Text;
            string strMaterial = CBXMaterialDesign.Text;

            decimal decPrice = 25.00m;

            // determine the product price
            if (strProduct == "Knitted scarf")
            {
                decPrice = 35.00m;
            }
            else if (strProduct == "Leather wallet")
            {
                if (strMaterial == "Bifold")
                    decPrice = 20.00m;
                else if (strMaterial == "Trifold")
                    decPrice = 30.00m;
                else if (strMaterial == "Passport")
                    decPrice = 35.00m;
            }

            // calculate item subtotal
            decimal decItemSubtotal = intQuantity * decPrice;

            // display the item in the ListBox
            string strOrderItem = $"{strMaterial} {strProduct}, " + $"{intQuantity}@{decPrice:C}, " + $"total: {decItemSubtotal:C}";

            LBXOrderItems.Items.Add(strOrderItem);

            // clear quantity for the next item
            TXTQuantity.Clear();
        }

        private void CBXProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected product
            string strProduct = CBXProductType.Text;

            // clear previous material selections
            CBXMaterialDesign.Items.Clear();
            CBXMaterialDesign.Text = "";

            // add materials for leather wallets
            if (strProduct == "Leather wallet")
            {
                CBXMaterialDesign.Items.Add("Bifold");
                CBXMaterialDesign.Items.Add("Trifold");
                CBXMaterialDesign.Items.Add("Passport");
            }
            // add materials for wood jewelry box
            else if (strProduct == "Wood jewelry box")
            {
                CBXMaterialDesign.Items.Add("Art Deco");
                CBXMaterialDesign.Items.Add("Rustic");
                CBXMaterialDesign.Items.Add("Mid-Century");
                CBXMaterialDesign.Items.Add("Victorian");
                CBXMaterialDesign.Items.Add("Classic");
            }
            // add materials for ceramic vase
            else if (strProduct == "Ceramic vase")
            {
                CBXMaterialDesign.Items.Add("Modern");
                CBXMaterialDesign.Items.Add("Minimalist");
                CBXMaterialDesign.Items.Add("Ornate");
                CBXMaterialDesign.Items.Add("Stoneware");
            }
            // add materials for handmade candle
            else if (strProduct == "Handmade candle")
            {
                CBXMaterialDesign.Items.Add("Votive");
                CBXMaterialDesign.Items.Add("Pillar");
                CBXMaterialDesign.Items.Add("Taper");
            }
            // add materials for stained glass
            else if (strProduct == "Stained glass frame")
            {
                CBXMaterialDesign.Items.Add("Geometric");
                CBXMaterialDesign.Items.Add("Floral");
                CBXMaterialDesign.Items.Add("Abstract");
                CBXMaterialDesign.Items.Add("Mosaic");
            }
            // add materials for knitted scarf
            else if (strProduct == "Knitted scarf")
            {
                CBXMaterialDesign.Items.Add("Bandana");
                CBXMaterialDesign.Items.Add("Square");
                CBXMaterialDesign.Items.Add("Shawl");
                CBXMaterialDesign.Items.Add("Infinity");
            }


            // display the correct image based on the product
            if (strProduct == "Wood jewelry box" ||
                strProduct == "Ceramic vase")
            {
                PBXProductImage.Image = Properties.Resources.craft;
            }
            else if (strProduct == "Handmade candle" ||
                     strProduct == "Stained glass frame")
            {
                PBXProductImage.Image = Properties.Resources.decor;
            }
            else if (strProduct == "Knitted scarf" ||
                     strProduct == "Leather wallet")
            {
                PBXProductImage.Image = Properties.Resources.textile;
            }
        }
    }
}
