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

        //Stores the product indexes for items added to the order.
        List<int> lstProductIndexes = new List<int>();

        //Stores the quantites for the items added to the order.
        List<int> lstQuantites = new List<int>();
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
            ////Checks if all required fields are filled and valid
            //TextBox[] requiredFields = {TXTCustomerName, 
            //                            TXTStreetAddress,
            //                            TXTCity, 
            //                            TXTZipCode, 
            //                            TXTQuantity, 
            //                            TXTPhoneNumber};

            //// Array of field names corresponding to the required fields for error messages
            //string[] fieldNames = { "Customer Name",
            //                        "Street Address", 
            //                        "City", 
            //                        "Zip Code",
            //                        "Quantity",     
            //                        "Phone Number" };

            //// Checks if all required fields are filled
            //for (int i = 0; i < requiredFields.Length; i++)
            //{
            //    if (!Validator.IsPresent(requiredFields[i].Text, fieldNames[i]))
            //    {
            //        return;
            //    }
            //}

            //// Checks if the Quantity field is a positive whole number
            //if (!Validator.IsPositiveInteger(TXTQuantity.Text, "Quantity"))
            //{
            //    return;
            //}

            //// Checks the State combobox selection
            //if (!Validator.IsPresent(CBXState.Text, "State"))
            //{
            //    return;
            //}

            //// Checks if Hand Delivery is selected and if the delivery location is allowed
            //if (RDOHandDelivery.Checked && !Validator.IsAllowedDeliveryLocation(TXTCity.Text, CBXState.Text))
            //{
            //    return;
            //}

            //// Displays a message box confirming that the order has been processed successfully
            //MessageBox.Show("Your order has been processed successfully!", "Order Confirmation",
            //                MessageBoxButtons.OK);

            // Stores all validation errors in one message
            string strErrorMessage = "";

            // Stores required customer fields
            TextBox[] txtRequiredFields = { TXTCustomerName,
                                            TXTStreetAddress,
                                            TXTCity,
                                            TXTZipCode,
                                            TXTPhoneNumber };

            // Stores field names for error messages
            string[] strFieldNames = { "Customer Name",
                                       "Street Address",
                                       "City",
                                       "Zip Code",
                                       "Phone Number" };


            // Checks all required customer fields
            for (int i = 0; i < txtRequiredFields.Length; i++)
            {
                if (!Validator.IsPresent(txtRequiredFields[i].Text, strFieldNames[i]))
                {
                    strErrorMessage += strFieldNames[i] + " is required.\n";
                }
            }

            // Checks that a state is selected
            if (!Validator.IsPresent(CBXState.Text, "State"))
            {
                strErrorMessage += "State is required.\n";
            }

            // Checks that a delivery option is selected
            if (!RDOMail.Checked && !RDOHandDelivery.Checked)
            {
                strErrorMessage += "Please select a delivery option.\n";
            }

            // Checks if Hand Delivery is allowed
            if (RDOHandDelivery.Checked &&
                !string.IsNullOrWhiteSpace(TXTCity.Text) &&
                !string.IsNullOrWhiteSpace(CBXState.Text) &&
                !Validator.IsAllowedDeliveryLocation(TXTCity.Text, CBXState.Text))
            {
                strErrorMessage +=
                    "Hand Delivery is only available in Bryan or College Station, TX.\n";
            }

            // Checks that ZIP Code contains only numbers
            if (!string.IsNullOrWhiteSpace(TXTZipCode.Text) &&
                !Validator.blnIsNumbersOnly(TXTZipCode.Text))
            {
                strErrorMessage += "Zip Code must contain numbers only.\n";
            }

            // Checks that Phone Number contains only numbers
            if (!string.IsNullOrWhiteSpace(TXTPhoneNumber.Text) &&
                !Validator.blnIsNumbersOnly(TXTPhoneNumber.Text))
            {
                strErrorMessage += "Phone Number must contain numbers only.\n";
            }

            // Checks that at least one item has been added
            if (LBXOrderItems.Items.Count == 0)
            {
                strErrorMessage += "Please add at least one item to the order.\n";
            }

            // Displays all validation errors in one MessageBox
            if (strErrorMessage != "")
            {
                MessageBox.Show(strErrorMessage, "Entry Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Checks if enough inventory is available for the entire order
            if(!InventoryData.HasEnoughInventoryForOrder(lstProductIndexes, lstQuantites))
            {
                MessageBox.Show("Not enough ingredients are available to complete the order.",
                                "Inventory Error", MessageBoxButtons.OK);
                return;
            }

            //Deducts ingredients for each product in the order
            for(int i=0; i< lstProductIndexes.Count; i++)
            {
                InventoryData.DeductIngredients(lstProductIndexes[i], lstQuantites[i]);
            }

            // Confirms successful order processing
            MessageBox.Show("Your order has been processed successfully!",
                            "Order Confirmation", MessageBoxButtons.OK);

            // Resets the form after successful processing
            BTNClearForm_Click(sender, e);



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
            //Checks if the Quantity field is filled
            if(!Validator.IsPresent(TXTQuantity.Text, "Quantity"))
            {
                MessageBox.Show("Quantity is required.", "Entry Error", MessageBoxButtons.OK);
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

            //Saves the selected product and quantity for inventory tracking
            lstProductIndexes.Add(CBXProductType.SelectedIndex);
            lstQuantites.Add(intQuantity);

            // clear quantity for the next item
            TXTQuantity.Clear();

            // updates the running order subtotal
            decOrderSubtotal += decItemSubtotal;

            // Calls the CalculateTotals method to compute and display the order totals
            CalculateTotals();


            //// sets default shipping cost and checks for hand delivery
            //int intShippingCost = 10;
            //if (RDOHandDelivery.Checked)
            //{
            //    intShippingCost = 10;
            //}
            //// calculates tax and final order total
            //decimal decTax =  (decOrderSubtotal + intShippingCost) * .0825m ;
            //decimal decOrderTotal = decOrderSubtotal + intShippingCost + decTax;

            //// displays formatted order totals in text boxes
            //    TXTOrderSubtotal.Text = decOrderSubtotal.ToString("c");
            //    TXTShipping.Text = intShippingCost.ToString("c");
            //    TXTTax.Text = decTax.ToString("c");
            //    TXTOrderTotal.Text = decOrderTotal.ToString("c");
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
            //Creating the material list which relates to the product list
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

            CBXMaterialDesign.Items.Clear();

            // Stores the current index integer of the selected item from the product type ComboBox.
            int intSelectedIndex = CBXProductType.SelectedIndex;

            // Prevents an array error when no product is selected
            if(intSelectedIndex <0)
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
            // Creates an array containing all 50 state abbreviations
            string[] strStates = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE",
                                   "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS",
                                   "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS",
                                   "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY",
                                   "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                                   "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV",
                                   "WI", "WY"
                                 };

            // Adds all state abbreviations to the State ComboBox
            for (int i = 0; i < strStates.Length; i++)
            {
                CBXState.Items.Add(strStates[i]);
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
            // Clear all input fields and selections on the form
            TXTCustomerName.Clear();
            TXTStreetAddress.Clear();
            TXTCity.Clear();
            CBXState.SelectedIndex = -1;
            CBXState.Text = "";
            TXTZipCode.Clear();
            TXTPhoneNumber.Clear();

            // Clear the delivery option radio buttons
            RDOMail.Checked = false;
            RDOHandDelivery.Checked = false;

            // Clear the product selection and related fields
            CBXProductType.SelectedIndex = -1;
            CBXMaterialDesign.Items.Clear();
            CBXMaterialDesign.Text = "";
            TXTQuantity.Clear();

            // Clears the product image 
            PBXProductImage.Image = null;

            // Clear the order items list
            LBXOrderItems.Items.Clear();

            //Clears the saved products and quantities
            lstProductIndexes.Clear();
            lstQuantites.Clear();

            // Reset the order totals
            ClearOrderSummary();

            // Reset the running subtotal
            decOrderSubtotal = 0.0m;

            // Puts the focus back on the Customer Name textbox for user convenience
            TXTCustomerName.Focus();
        }

        /// <summary>
        /// This method allows you to reuse it, clearing all order summary totals.
        /// </summary>
        private void ClearOrderSummary()
        {
            TXTOrderSubtotal.Clear();
            TXTShipping.Clear();
            TXTTax.Clear();
            TXTOrderTotal.Clear();
        }

        /// <summary>
        /// Calcualtes and displays the order subtotal, shipping, tax and order total.
        /// Clears the order summary if no items were added.
        /// </summary>
        private void CalculateTotals()
        {
            // Clears the order summary if no items have been added.
            if (LBXOrderItems.Items.Count == 0)
            {
                ClearOrderSummary();
                return;
            }

            decimal decShippingCost = 10.00m; // Default shipping cost for mail delivery

            if (RDOHandDelivery.Checked)
            {
                // If hand delivery is selected, set shipping cost to $15.00
                decShippingCost = 15.00m;
            }

            // Calculates tax and final order total
            decimal decTax = (decOrderSubtotal + decShippingCost) * 0.0825m;
            decimal decOrderTotal = decOrderSubtotal + decShippingCost + decTax;

            // Displays formatted order totals in text boxes as currency.
            TXTOrderSubtotal.Text = decOrderSubtotal.ToString("C");
            TXTShipping.Text = decShippingCost.ToString("C");
            TXTTax.Text = decTax.ToString("C");
            TXTOrderTotal.Text = decOrderTotal.ToString("C");
        }

        /// <summary>
        /// Checks if the hand delivery option is allowed based on the city and state entered by the user.  
        /// </summary>
        private void UpdateHandDeliveryOption()
        {
            // This trims the spaces and converts the city
            // and state text to lowercase for comparison
            string strCity = TXTCity.Text.Trim().ToLower();
            string strState = CBXState.Text.Trim().ToLower();

            // This checks if the state is Texas and the city is either Bryan or College Station
            bool blnAllowed = strState == "tx" && (strCity == "bryan" || strCity == "college station");

            // This enables or disables the hand delivery radio button based on the allowed condition
            RDOHandDelivery.Enabled = blnAllowed;

            // If hand delivery is not allowed and it is currently selected, switch to mail delivery
            if (!blnAllowed && RDOHandDelivery.Checked)
            {
                RDOHandDelivery.Checked = false; // Uncheck hand delivery
                RDOMail.Checked = true; // Check mail delivery
            }
        }

        /// <summary>
        ///  Updates the hand delivery when the city text changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTCity_TextChanged(object sender, EventArgs e)
        {
            UpdateHandDeliveryOption();
        }

        private void CBXState_SelectedIndexChange(object sender, EventArgs e)
        {
            //Updates the hand delivery option when the state changes
            UpdateHandDeliveryOption();
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

        /// <summary>
        /// This method updates the order totals when the delivery option is changed to mail delivery.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RDOMail_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        /// <summary>
        /// This method updates the order totals when the delivery option is changed to hand delivery.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RDOHandDelivery_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        #endregion

        /// <summary>
        /// This fills in the customer information fields with default data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNDefaultCustomer_Click(object sender, EventArgs e)
        {
            //This fills in default customer information for testing
            TXTCustomerName.Text = "John Doe";
            TXTStreetAddress.Text = "123 Apple Street";
            TXTCity.Text = "College Station";
            CBXState.SelectedItem = "TX";
            TXTZipCode.Text = "77840";
            TXTPhoneNumber.Text = "9791234567";
        }

        private void BTNViewInventory_Click(object sender, EventArgs e)
        {
            //Creates the Inventory form
            FRMInventory frmInventory = new FRMInventory();

            //Opens the Inventory form
            frmInventory.ShowDialog();
        }
    }
}
