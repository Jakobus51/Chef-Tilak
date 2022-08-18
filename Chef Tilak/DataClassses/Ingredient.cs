using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_Tilak.DataClassses
{
    public class Ingredient
    {
        /// <summary>
        /// Name of Ingredient
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unique code of Ingredient
        /// </summary>
        public Guid Code { get; set; }

        /// <summary>
        /// Is used for supplier
        /// </summary>
        public string Store { get; set; }

        /// <summary>
        /// Old setting but stays in ti convert old data
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Amount of tax (is between 0 and 1, 0 to 100%)
        /// </summary>
        public decimal Tax { get; set; }

        /// <summary>
        /// The amount of the ingredient (in kg/g/L or Ml)
        /// </summary>
        public decimal BuyQuantity { get; set; }

        /// <summary>
        /// Kg, g, L or Ml, piece or other
        /// </summary>
        public string BuyUnit { get; set; }

        /// <summary>
        /// the price for the ingredient including tax
        /// </summary>
        public decimal BuyPriceInc { get; set; }

        /// <summary>
        /// the price for the ingredient excluding tax
        /// </summary>
        public decimal BuyPriceExc { get; set; }

        /// <summary>
        /// the price for the ingredient per its unit including tax
        /// </summary>
        public decimal PricePerUnitInc { get; set; }

        /// <summary>
        /// the price for the ingredient per its unit excluding tax
        /// </summary>
        public decimal PricePerUnitExc { get; set; }


        /// <summary>
        /// the quantity for the ingredient needed in the recipe
        /// </summary>
        public decimal RecipeQuantity { get; set; }

        /// <summary>
        /// the unit for the ingredient needed in the recipe
        /// </summary>
        public string RecipeUnit { get; set; }       

        /// <summary>
        /// PriceInc of the ingredient in the recipe
        /// </summary>
        public decimal RecipePriceInc { get; set; }

        /// <summary>
        /// PriceInc of the ingredient in the recipe
        /// </summary>
        public decimal RecipePriceExc { get; set; }

        /// <summary>
        /// Additional information on the ingredient in the recipe
        /// </summary>
        public string RecipeComment { get; set; }

        /// <summary>
        /// Is created from an own recipe
        /// </summary>
        public bool MadeFromOwnRecipe { get; set; }

        /// <summary>
        /// The code of the recipe if it was made from one
        /// </summary>
        public Guid RecipeCode { get; set; }

        /// <summary>
        /// updates the price per unit for an ingredient
        /// </summary>
        public void updateBuyPPU()
        {

            if (this.BuyQuantity == 0)
            {
                PricePerUnitInc = 0;
                PricePerUnitExc = 0;
            }
            else
            {
                PricePerUnitInc = Math.Round(this.BuyPriceInc / this.BuyQuantity, 2);
                PricePerUnitExc = Math.Round(this.BuyPriceExc / this.BuyQuantity, 2);
            }
        }

        public void UpdateStore()
        {
            this.Store = this.Category;          
        }


        /// <summary>
        /// Sets the correct Ingredient price for an ingredient in a recipe
        /// </summary>
        public void updatePriceRecipe()
        {
            this.RecipePriceInc = Math.Round(this.PricePerUnitInc * this.RecipeQuantity, 2);
            this.RecipePriceExc = Math.Round(this.PricePerUnitExc * this.RecipeQuantity, 2);

            //If unit in ingredientlist is mL but in your recipe it is L
            if (this.BuyUnit.Equals("mL") || this.BuyUnit.Equals("g"))
            {
                if (this.RecipeUnit.Equals("L") || this.RecipeUnit.Equals("Kg"))
                {
                    this.RecipePriceInc = Math.Round(((this.PricePerUnitInc * this.RecipeQuantity) * 1000),2);
                    this.RecipePriceExc = Math.Round(((this.PricePerUnitExc * this.RecipeQuantity) * 1000),2);
                }
            }
            //If unit in ingredientlist is Kg but in your recipe it is g
            else if (this.BuyUnit.Equals("L") || this.BuyUnit.Equals("Kg"))
            {
                if (this.RecipeUnit.Equals("mL") || this.RecipeUnit.Equals("g") || this.RecipeUnit.Equals("Snufje"))
                {
                    this.RecipePriceInc = Math.Round(((this.PricePerUnitInc * this.RecipeQuantity) / 1000),2);
                    this.RecipePriceExc = Math.Round(((this.PricePerUnitExc * this.RecipeQuantity) / 1000),2);
                }
            } 

        }
    }
}
