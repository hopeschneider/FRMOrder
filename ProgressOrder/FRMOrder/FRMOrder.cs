using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AUTHORS: Hope Schneider, Krishita Madhekar, Kiet Nguyen, Andrea Perez
//COURSE: ISTM 250.501
//FORM: FRMOrder
//PURPOSE: This program is designed to transition Copperleaf Crafts
// from paper record-keeping to a digital order management system to record
// craft product orders, validate customer and item inputs, and calculate order totals.
//INPUT: Customer contact info from textboxes (TXTCustomerName, TXTStreetAddress,
// TXTCity, CBXState, TXTZipCode, TXTPhoneNumber), delivery option (RDOHandDelivery or RDOMail),
// item selections from CBXProductType and CBXMaterialDesign,
// and a positive integer quantity from TXTQuantity.    
//PROCESS: BTNAddItemOrder_Click, BTNProcessOrder_Click, BTNClearForm_Click, BTNCloseForm_Click
//OUTPUT: 1. Formatted order line items appended to LBXOrderItems
//        2. Product preview image displayed in PBXProductImage
//        3. Order total displayed in summary textboxes (TXTSubtotal, TXTShipping, TXTTax, TXTTotal)
//        4. Validation error dialog messages or order success notification 
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
        /// Stores the running subtotal for the current order.
        /// </summary>
        decimal decOrderSubtotal = 0.0m;

        // Store the material options for each product
        string[][] strMaterialList = new string[][]
        {
            // Wood jewelry box
            new string[] { "Art Deco", "Rustic", "Mid-Century", "Victorian", "Classic" },

            // Ceramic vase
            new string[] { "Modern", "Minimalist", "Ornate", "Stoneware" },

            // Handmade candle
            new string[] { "Votive", "Pillar", "Taper" },

            // Stained glass frame
            new string[] { "Geometric", "Floral", "Abstract", "Mosaic" },

            // Knitted scarf
            new string[] { "Bandana", "Square", "Shawl", "Infinity" },

            // Leather wallet
            new string[] { "Bifold", "Trifold", "Passport" }
         };

        #region Order Processing

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
            // Runs all field and delivery validations (displays one message box if invalid)
            if (!IsValidData())
            {
                return;
            }

            // Displays a message box confirming that the order has been processed successfully
            MessageBox.Show("Your order has been processed successfully!", "Order Confirmation", MessageBoxButtons.OK);

            // Reset the form for the next order
            ClearForm();
        }

        #endregion

        #region Add Item to Order

        /// <summary>
        /// This method is triggered when the "Add Item to Order" button is clicked.
        /// It validates the Quantity field to ensure that it is filled and is a
        /// positive whole number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAddItemToOrder_Click(object sender, EventArgs e)
        {
            // option one
            string strItemError = "";

            // 1. Validate Product Type and Material/Design selections
            strItemError += Validator.ValidateItemEntry(CBXProductType.SelectedIndex, CBXMaterialDesign.SelectedIndex);

            // 2. Validate Quantity (only check IsPositiveInteger if Quantity is not blank)
            string strQtyPresent = Validator.IsPresent(TXTQuantity.Text, "Quantity");
            if (strQtyPresent == "")
            {
                strItemError += Validator.IsPositiveInteger(TXTQuantity.Text, "Quantity");
            }
            else
            {
                strItemError += strQtyPresent;
            }

            // 3. Display combined MessageBox if any errors were collected
            if (strItemError != "")
            {
                MessageBox.Show(strItemError, "Entry Error");
                return; //stop execution so the invalid item is not added
            }

            // Parse the item quantity entered in the textbox into an integer
            int intQuantity = int.Parse(TXTQuantity.Text);

            // Retrieve selected product and material text from the comboboxes
            string strProduct = CBXProductType.Text;
            string strMaterial = CBXMaterialDesign.Text;

            // Initialize the default base price as a decimal literal
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

            // updates the running order subtotal
            decOrderSubtotal += decItemSubtotal;

            // Update order totals after adding an item
            CalculateOrderTotals();
        }

        #endregion

        #region Product Type Selection

        /// <summary>
        /// This method updates the options in the material design dropdown menu
        /// based on the selected product type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBXProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected product
            string strProduct = CBXProductType.Text;

            // clear previous material selections
            CBXMaterialDesign.Items.Clear();
            CBXMaterialDesign.Text = "";
            

            // Stores the current index integer of the selected item from the product type ComboBox.
            int intSelectedIndex = CBXProductType.SelectedIndex;

            //prevents an error when no product is selected
            if (intSelectedIndex == -1)
            {
                return;
            }


            // Loops through the nested string array 'strMaterialList' using the retrieved product
            // index to add each corresponding material option into the material design CBX.
            for (int i = 0; i < strMaterialList[intSelectedIndex].Length; i++)
            {
                CBXMaterialDesign.Items.Add(strMaterialList[intSelectedIndex][i]);
            }
            // checks the current product and updates the PictureBox to display the corresponding image resource.
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

        #endregion

        #region Form Initialization

        /// <summary>
        /// This load event initializes the product list combo box when the form opens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMOrder_Load(object sender, EventArgs e)
        {

            //Creating the array that relates to the combo box for States
            string[] strStateList =
                {
                "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE",
                "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS",
                "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS",
                "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY",
                "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV",
                "WI", "WY"
                };

            // Add all states to the State ComboBox
            for (int i = 0; i < strStateList.Length; i++)
            {
                CBXState.Items.Add(strStateList[i]);
            }



            //Creating the array that relates to the combo box for Product List
            string[] strProductList = { "Wood jewelry box", "Ceramic vase", "Handmade candle", "Stained glass frame", "Knitted scarf", "Leather wallet" };
            //adding the products into the combo box CBXProductType
            for (int i = 0; i < strProductList.Length; i++)
            {
                CBXProductType.Items.Add(strProductList[i]);
            }
        }

        #endregion

        #region Form Reset and Close

        /// <summary>
        /// This button resets the entire order form back to its default, empty state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// This button closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region One Message Box

        /// <summary>
        /// Validates all required customer fields, delivery options, and order items
        /// before processing the order. Displays a combined error message box if any validation rules fail.
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            string strErrorMessage = "";

            // 1. Validate required customer text fields
            strErrorMessage += Validator.IsPresent(TXTCustomerName.Text, TXTCustomerName.Tag?.ToString() ?? "Customer Name");
            strErrorMessage += Validator.IsPresent(TXTStreetAddress.Text, TXTStreetAddress.Tag?.ToString() ?? "Street Address");
            strErrorMessage += Validator.IsPresent(TXTCity.Text, TXTCity.Tag?.ToString() ?? "City");
            strErrorMessage += Validator.IsPresent(TXTZipCode.Text, TXTZipCode.Tag?.ToString() ?? "Zip Code");
            strErrorMessage += Validator.IsPresent(TXTPhoneNumber.Text, TXTPhoneNumber.Tag?.ToString() ?? "Phone Number");


            // Check ZIP code format if entered
            if (TXTZipCode.Text != "")
            {
                strErrorMessage += Validator.IsValidZipCode(TXTZipCode.Text);
            }

            // Check phone number format if entered
            if (TXTPhoneNumber.Text != "")
            {
                strErrorMessage += Validator.IsValidPhoneNumber(TXTPhoneNumber.Text);
            }


            // 2. Validate state, product type, and material/design selection
            if (CBXState.SelectedIndex == -1)
            {
                strErrorMessage += "State is a required field.\n";
            }
            
            // Should this be included for BTNProcessOrder?
            //if (CBXProductType.SelectedIndex == -1)
            //{
            //    strErrorMessage += "Product Type is a required field.\n";
            //}

            //if (CBXMaterialDesign.SelectedIndex == -1)
            //{
            //    strErrorMessage += "Material / Design is a required field.\n";
            //}
            
            // 3. Validate Delivery Option & Hand Delivery Location (Bryan or College Station, TX)
            if (!RDOMail.Checked && !RDOHandDelivery.Checked)
            {
                strErrorMessage += "Please select a delivery option.\n";
            }
            else if (RDOHandDelivery.Checked)
            {
                // Only check delivery area if City and State were actually entered
                if (!string.IsNullOrWhiteSpace(TXTCity.Text) && CBXState.SelectedIndex != -1)
                {
                    strErrorMessage += Validator.IsAllowedDeliveryLocation(TXTCity.Text, CBXState.Text);
                }
            }
            
            // 4. Validate that at least one item has been added to the order
            if (LBXOrderItems.Items.Count == 0)
            {
                strErrorMessage += "Please add at least one item to your order.\n";
            }
            
            // 5. Display one combined MessageBox if any errors were collected
            if (strErrorMessage != "") // if we have one or more errors
            {
                MessageBox.Show(strErrorMessage, "Entry Error");
                return false; // we do not have a valid new product
            }
            return true; // we have no error. we have a valid new product.

        #endregion
        }

        /// <summary>
        /// Clears all fields and resets the order form.
        /// </summary>
        private void ClearForm()
        {
            // Clear customer information
            TXTCustomerName.Clear();
            TXTStreetAddress.Clear();
            TXTCity.Clear();
            CBXState.SelectedIndex = -1;
            CBXState.Text = "";
            TXTZipCode.Clear();
            TXTPhoneNumber.Clear();

            // Reset delivery options
            RDOMail.Checked = false;
            RDOHandDelivery.Checked = false;

            // Clear product selections and quantity
            CBXProductType.SelectedIndex = -1;
            CBXMaterialDesign.Items.Clear();
            CBXMaterialDesign.Text = "";
            TXTQuantity.Clear();

            // Clear product image and order items
            PBXProductImage.Image = null;
            LBXOrderItems.Items.Clear();

            // Reset order subtotal
            decOrderSubtotal = 0.0m;

            // Clear order totals
            TXTOrderSubtotal.Clear();
            TXTShipping.Clear();
            TXTTax.Clear();
            TXTOrderTotal.Clear();

            // Return focus to customer name
            TXTCustomerName.Focus();
        }

        /// <summary>
        /// Calculates and displays the order subtotal, shipping, tax, and total.
        /// </summary>
        private void CalculateOrderTotals()
        {
            // Set the default shipping cost for mail
            decimal decShippingCost = 10.00m;

            // Change shipping cost for hand delivery
            if (RDOHandDelivery.Checked)
            {
                decShippingCost = 15.00m;
            }

            // Calculate tax and order total
            decimal decTax = (decOrderSubtotal + decShippingCost) * 0.0825m;
            decimal decOrderTotal = decOrderSubtotal + decShippingCost + decTax;

            // Display the updated order totals
            TXTOrderSubtotal.Text = decOrderSubtotal.ToString("c");
            TXTShipping.Text = decShippingCost.ToString("c");
            TXTTax.Text = decTax.ToString("c");
            TXTOrderTotal.Text = decOrderTotal.ToString("c");
        }

        private void RDOMail_CheckedChanged(object sender, EventArgs e)
        {
            // Update totals when mail delivery is selected
            if (LBXOrderItems.Items.Count > 0)
            {
                CalculateOrderTotals();
            }
        }

        private void RDOHandDelivery_CheckedChanged(object sender, EventArgs e)
        {
            // Update totals when hand delivery is selected
            if (LBXOrderItems.Items.Count > 0)
            {
                CalculateOrderTotals();
            }
        }
    }
}
