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
        public static string IsPresent(string strTestValue, string strControlName)
        {
            string strMessage = "";
            if (string.IsNullOrWhiteSpace(strTestValue))
            {
                strMessage += strControlName + " is a required field.\n";
            }
            return strMessage;
        }
        /// <summary>
        /// Checks if a text field is a positive whole number/integer.
        /// </summary>
        /// <param name="strTestValue"></param>
        /// <param name="strControlName"></param>
        /// <returns></returns>
        public static string IsPositiveInteger(string strTestValue, string strControlName)
        {
            string strMessage = "";
            if (!int.TryParse(strTestValue, out int intValue) || intValue <= 0)
            {
                strMessage += strControlName + " must be a valid integer value.\n";
            }
            return strMessage;
        }

        /// <summary>
        /// Checks if the ZIP code contains exactly 5 digits.
        /// </summary>
        public static string IsValidZipCode(string strZipCode)
        {
            // Check that ZIP code has exactly 5 characters
            if (strZipCode.Length != 5)
            {
                return "ZIP Code must contain 5 digits.\n";
            }

            // Check that each character is a number
            for (int i = 0; i < strZipCode.Length; i++)
            {
                if (!char.IsDigit(strZipCode[i]))
                {
                    return "ZIP Code must contain only numbers.\n";
                }
            }

            return "";
        }


        /// <summary>
        /// Checks if the phone number contains 10 digits
        /// with or without hyphens.
        /// </summary>
        public static string IsValidPhoneNumber(string strPhoneNumber)
        {
            // Check phone number without hyphens
            if (strPhoneNumber.Length == 10)
            {
                for (int i = 0; i < strPhoneNumber.Length; i++)
                {
                    if (!char.IsDigit(strPhoneNumber[i]))
                    {
                        return "Phone Number must contain only digits.\n";
                    }
                }

                return "";
            }

            // Check phone number with hyphens
            if (strPhoneNumber.Length == 12)
            {
                if (strPhoneNumber[3] != '-' || strPhoneNumber[7] != '-')
                {
                    return "Phone Number format is invalid.\n";
                }

                for (int i = 0; i < strPhoneNumber.Length; i++)
                {
                    if (i != 3 && i != 7 && !char.IsDigit(strPhoneNumber[i]))
                    {
                        return "Phone Number must contain valid digits.\n";
                    }
                }

                return "";
            }

            return "Phone Number must be 10 digits with or without hyphens.\n";
        }


        /// <summary>
        /// Checks if the delivery location is allowed (Bryan or College Station, TX). 
        /// </summary>
        /// <param name="strCity"></param>
        /// <param name="strState"></param>
        /// <returns></returns>
        public static string IsAllowedDeliveryLocation(string strCity, string strState)
        {
            string city = strCity.Trim().ToLower();
            string state = strState.Trim().ToLower();

            if ((city == "bryan" || city == "college station") && state == "tx")
            {
                return "";
            }
            else
            {
                return "Hand delivery is only available in Bryan and College Station, TX.\n";
            }
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
        public static string ValidateItemEntry(int intProductIndex, int intMaterialIndex)
        {
            string strMessage = "";
            if (intProductIndex < 0)
            {
                strMessage += "Please select a Product Type.\n";
            }

            if (intMaterialIndex < 0)
            {
                strMessage += "Please select a Material or Design option.\n";
            }
            return strMessage;

        }

        #endregion




    }
}
