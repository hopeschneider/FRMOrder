using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMOrder
{
    public static class Validator
    {
        /// <summary>
        /// Checks if a requirred text field is filled.
        /// </summary>
        /// <param name="strTestValue"></param>
        /// <param name="strControlName"></param>
        /// <returns></returns>
        public static bool IsPresent(string strTestValue, string strControlName)
        {
            if (string.IsNullOrWhiteSpace(strTestValue))
            {
                MessageBox.Show($"{strControlName} is a required field.", "Entry Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
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

           if((city == "bryan" || city == "college station") && state == "tx")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hand delivery is only available in Bryan and College Station, TX.", "Delivery Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
