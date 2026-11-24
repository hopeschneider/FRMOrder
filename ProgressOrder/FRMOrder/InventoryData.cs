using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRMOrder
{
    /// <summary>
    /// Stores ingredient inventory and product recipes.
    /// </summary>
    internal class InventoryData
    {
        // Ingredient names
        public static string[] strIngredientNames =
            {
                "Dye", "Hardware", "Felt Lining", "Pigment",
                "Cotton", "Wood", "Clay", "Wax", "Glass",
                "Yarn", "Leather"
                };

                // Available ingredient inventory
                public static decimal[] decIngredientInventories =
                {
                50m, 150m, 120m, 165m, 220m,
                200m, 500m, 700m, 800m, 2000m, 650m
                };

                // Rows = ingredients, columns = products
                private static decimal[,] decProductRecipes =
                {
                { 0m, 0m, 0.5m, 0m, 3m, 1m },
                { 4m, 0m, 0m, 0m, 0m, 1m },
                { 3m, 0m, 0m, 0m, 0m, 2m },
                { 0m, 4m, 0m, 7m, 0m, 0m },
                { 0m, 0m, 1m, 0m, 10m, 0m },
                { 6m, 0m, 0m, 0m, 0m, 0m },
                { 0m, 8m, 0m, 0m, 0m, 0m },
                { 0m, 0m, 16m, 0m, 0m, 0m },
                { 3m, 0m, 0m, 20m, 0m, 0m },
                { 0m, 0m, 0m, 0m, 60m, 0m },
                { 5m, 0m, 0m, 0m, 0m, 20m }
                };


        /// <summary>
        /// Deducts ingredients from inventory based on the
        /// selected product and quantity ordered.
        /// </summary>
        public static void DeductIngredients(int intProductIndex, int intQuantity)
        {
            // Loops through all 11 ingredients
            for (int i = 0; i < strIngredientNames.Length; i++)
            {
                // Calculates the amount of each ingredient needed
                decimal decAmountNeeded = decProductRecipes[i, intProductIndex] * intQuantity;

                // Subtracts ingredients from available inventory
                decIngredientInventories[i] -= decAmountNeeded;
            }
        }


        /// <summary>
        /// Checks if enough ingredients are available
        /// to make the selected product quantity.
        /// </summary>
        public static bool HasEnoughInventory(int intProductIndex, int intQuantity)
        {
            // Loops through all 11 ingredients
            for (int i = 0; i < strIngredientNames.Length; i++)
            {
                // Calculates how much of each ingredient is needed
                decimal decAmountNeeded = decProductRecipes[i, intProductIndex] * intQuantity;

                // Checks if enough inventory is available
                if (decAmountNeeded > decIngredientInventories[i])
                {
                    return false;
                }
            }

            // Returns true if all ingredients are available
            return true;
        }


        /// <summary>
        /// Checks whether enough ingredients are available
        /// for every item in the order combined.
        /// </summary>
        public static bool HasEnoughInventoryForOrder(
            List<int> lstProductIndexes,
            List<int> lstQuantities)
        {
            // Stores the total amount needed for each ingredient
            decimal[] decTotalNeeded =
                new decimal[strIngredientNames.Length];

            // Loops through every product in the order
            for (int i = 0; i < lstProductIndexes.Count; i++)
            {
                int intProductIndex = lstProductIndexes[i];
                int intQuantity = lstQuantities[i];

                // Calculates the ingredients needed for each product
                for (int j = 0; j < strIngredientNames.Length; j++)
                {
                    decTotalNeeded[j] +=
                        decProductRecipes[j, intProductIndex] * intQuantity;
                }
            }

            // Checks total requirements against available inventory
            for (int i = 0; i < strIngredientNames.Length; i++)
            {
                if (decTotalNeeded[i] > decIngredientInventories[i])
                {
                    return false;
                }
            }

            return true;
        }


    }
}



