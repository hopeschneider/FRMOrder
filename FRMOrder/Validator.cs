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
    }
}
