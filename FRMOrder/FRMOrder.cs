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

            //THE CODE FOR ADDING THE ITEM TO THE ORDER WILL GO HERE:
        }
    }
}
