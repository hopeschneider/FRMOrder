using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PURPOSE: This class provides centralized validation methods for the order form.
// It ensures all user inputs, meet business rules before processing order
// placement.
//INPUT: string values and control names passed from form textboxes/comboboxes
// (TXTCustomerName, TXTQuantity, CBXProductType).
//PROCESS: Validates data presence, numeric parsing, positive values, and valid selections.  
//OUTPUT: Returns true if validation passed; displays custom message box error
// dialogs and returns false if an entry error is caught. 
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”

namespace FRMOrder
{

    /// <summary>
    /// Centrailized validation class for Coding Project 1.
    /// Handles text presence, numeric checks, range testing, and single error dialogs.
    /// </summary>
    public static class Validator
    {

        #region Generic Utility Validation Methods

        /// <summary>
        /// Checks if a required text field is filled.
        /// </summary>
        /// <param name="strTestValue"></param>
        /// <param name="strControlName"></param>
        /// <returns></returns>
        public static bool IsPresent(string strTestValue, string strControlName)
        {
            if (string.IsNullOrWhiteSpace(strTestValue))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Checks if a text field is a positive whole number/integer.
        /// </summary>
        /// <param name="strTestValue"></param>
        /// <param name="strControlName"></param>
        /// <returns></returns>
        public static bool IsPositiveInteger(string strTestValue, string strControlName)
        {
            if (!int.TryParse(strTestValue, out int intValue) || intValue <= 0)
            {
                MessageBox.Show($"{strControlName} must be a positive whole number.", "Entry Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Checks if the delivery location is allowed (Bryan or College Station, TX). 
        /// </summary>
        /// <param name="strCity"></param>
        /// <param name="strState"></param>
        /// <returns></returns>
        public static bool IsAllowedDeliveryLocation(string strCity, string strState)
        {
            string city = strCity.Trim().ToLower();
            string state = strState.Trim().ToLower();

            // Checks if the city is either "bryan" or "college station" and the state is "tx"
            // allowing hand delivery.
            if ((city == "bryan" || city == "college station") && state == "tx")
            {
                return true;
            }
           
            return false;
            
        }

        /// <summary>
        /// This method checks if a string contains only numeric characters (digits).
        /// Primarily used for validating fields like Zip Code and Phone Number.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static bool blnIsNumbersOnly(string strValue)
        {
            for (int i = 0; i < strValue.Length; i++)
            {
                if (!char.IsDigit(strValue[i]))
                { 
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region High-Level Form Validation Routines

        /// <summary>
        /// Validates product selection prior to adding an item to the order ListBox.
        /// Stops on the first invalid field so only ONE message box pops up.
        /// </summary>
        /// <param name="intProductIndex"></param>
        /// <param name="intMaterialIndex"></param>
        /// <returns></returns>
        public static bool ValidateItemEntry(int intProductIndex, int intMaterialIndex)
        {
            if(intProductIndex < 0)
            {
                MessageBox.Show("Please select a Product Type.", "Selection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(intMaterialIndex < 0)
            {
                MessageBox.Show("Please select a Material or Design option.", "Selection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

    }
}
