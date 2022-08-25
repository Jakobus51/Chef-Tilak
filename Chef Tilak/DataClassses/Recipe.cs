using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_Tilak.DataClassses
{
    public class Recipe
    {
        /// <summary>
        /// Name of recipe
        /// </summary>
        public string RecipeName { get; set; }

        /// <summary>
        /// Unique code of Recipe
        /// </summary>
        public Guid Code { get; set; }

        /// <summary>
        /// Category of recipe
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Category of recipe
        /// </summary>
        public string LastEdited { get; set; }

        /// <summary>
        /// List of ingredients that are present in the recipe
        /// </summary>
        public List<Ingredient> RecipeIngredientList { get; set; }

        /// <summary>
        /// Packaging()s of the recipe
        /// </summary>
        public List<Packaging> PackagingList { get; set; }

        /// <summary>
        /// Packaging()s of the recipe
        /// </summary>
        public List<Packaging> packagingList { get; set; }

        /// <summary>
        /// Description how it is made
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Amount produced
        /// </summary>
        public decimal TotalVolume { get; set; }

        /// <summary>
        /// Total Cost of recipe including the packaging and tax
        /// </summary>
        public decimal TotalCostwPackagingsInc { get; set; }

        /// <summary>
        /// Total Cost of recipe including the packaging and tax
        /// </summary>
        public decimal TotalCostwPackagingsExc { get; set; }

        /// <summary>
        /// Cost of all ingredients includin Tax
        /// </summary>
        public decimal TotalIngredientCostInc { get; set; }

        /// <summary>
        /// Cost of all ingredients excluding Tax
        /// </summary>
        public decimal TotalIngredientCostExc { get; set; }

        /// <summary>
        /// The unit in which this recipe is produced (can be either g or mL)
        /// </summary>
        public string RecipeUnit { get; set; }


        /// <summary>
        /// True if this recipe is also added to the ingredient list
        /// </summary>
        public bool IsAlsoIngredient { get; set; }


        public Recipe()
        {
            this.RecipeIngredientList = new();
            this.PackagingList = new();
        }


        public void calculateRecipeIngredientCostExc()
        {
            decimal cost = 0M;
            foreach (Ingredient ingredient in this.RecipeIngredientList)
            {
                if (ingredient.Code != Guid.Empty)
                {
                    cost += ingredient.RecipePriceExc;
                }
            }

            this.TotalIngredientCostExc = cost;
        }

        public void calculateTotalCostExc()
        {
            decimal totalCost = 0M;
            this.calculateRecipeIngredientCostExc();
            totalCost += this.TotalIngredientCostExc;

            foreach (Packaging packaging in this.PackagingList)
            {
                totalCost += packaging.NumberOfPackagings * (packaging.PriceExc + packaging.AdditionalCostExc);
            }
            this.TotalCostwPackagingsExc = totalCost;
        }

        public void calculateRecipeIngredientCostInc()
        {
            decimal cost = 0M;
            foreach (Ingredient ingredient in this.RecipeIngredientList)
            {
                if (ingredient.Code != Guid.Empty)
                {
                    cost += ingredient.RecipePriceInc;
                }
            }

            this.TotalIngredientCostInc = cost;
        }

        public void calculateTotalCostInc()
        {
            decimal totalCost = 0M;
            this.calculateRecipeIngredientCostInc();
            totalCost += this.TotalIngredientCostInc;

            foreach (Packaging packaging in this.PackagingList)
            {
                totalCost += packaging.NumberOfPackagings * (packaging.PriceInc + packaging.AdditionalCostInc);
            }
            this.TotalCostwPackagingsInc = totalCost;
        }



        public void updatePricePerPackage(int packagings)
        {
            this.calculateRecipeIngredientCostExc();
            this.calculateRecipeIngredientCostInc();

            if (this.PackagingList.Count() == 1)
            {

                decimal pricePP1Exc = 0M;
                decimal pricePP1Inc = 0M;
                Packaging package1 = this.PackagingList[0];
                if (package1 != null)
                {
                    pricePP1Exc = package1.PriceExc + package1.AdditionalCostExc + (this.TotalIngredientCostExc / package1.NumberOfPackagings);
                    package1.ProductionPriceExc = pricePP1Exc;

                    pricePP1Inc = package1.PriceInc + package1.AdditionalCostInc + (this.TotalIngredientCostInc / package1.NumberOfPackagings);
                    package1.ProductionPriceInc = pricePP1Inc;
                }


            }

            if (this.PackagingList.Count() == 2)
            {
                decimal pricePP1Exc = 0M;
                decimal pricePP2Exc = 0M;
                decimal pricePP1Inc = 0M;
                decimal pricePP2Inc = 0M;

                Packaging package1 = this.PackagingList[0];
                Packaging package2 = this.PackagingList[1];

                if (package1 != null && package2 != null)
                {
                    pricePP1Exc = package1.PriceExc + package1.AdditionalCostExc + (this.TotalIngredientCostExc * ((package1.NumberOfPackagings * package1.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity))) / package1.NumberOfPackagings);
                    pricePP2Exc = package2.PriceExc + package2.AdditionalCostExc + (this.TotalIngredientCostExc * ((package2.NumberOfPackagings * package2.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity))) / package2.NumberOfPackagings);
                    package1.ProductionPriceExc = pricePP1Exc;
                    package2.ProductionPriceExc = pricePP2Exc;

                    pricePP1Inc = package1.PriceInc + package1.AdditionalCostInc + (this.TotalIngredientCostInc * ((package1.NumberOfPackagings * package1.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity))) / package1.NumberOfPackagings);
                    pricePP2Inc = package2.PriceInc + package2.AdditionalCostInc + (this.TotalIngredientCostInc * ((package2.NumberOfPackagings * package2.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity))) / package2.NumberOfPackagings);
                    package1.ProductionPriceInc = pricePP1Inc;
                    package2.ProductionPriceInc = pricePP2Inc;
                }

            }

            if (this.PackagingList.Count() == 3)
            {
                decimal pricePP1Exc = 0M;
                decimal pricePP2Exc = 0M;
                decimal pricePP3Exc = 0M;

                decimal pricePP1Inc = 0M;
                decimal pricePP2Inc = 0M;
                decimal pricePP3Inc = 0M;

                Packaging package1 = this.PackagingList[0];
                Packaging package2 = this.PackagingList[1];
                Packaging package3 = this.PackagingList[2];

                if (package1 != null && package2 != null && package3 != null)
                {
                    pricePP1Exc = package1.PriceExc + package1.AdditionalCostExc + (this.TotalIngredientCostExc * ((package1.NumberOfPackagings * package1.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity) + (package3.NumberOfPackagings * package3.RecipeQuantity))) / package1.NumberOfPackagings);
                    pricePP2Exc = package2.PriceExc + package2.AdditionalCostExc + (this.TotalIngredientCostExc * ((package2.NumberOfPackagings * package2.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity) + (package3.NumberOfPackagings * package3.RecipeQuantity))) / package2.NumberOfPackagings);
                    pricePP3Exc = package3.PriceExc + package3.AdditionalCostExc + (this.TotalIngredientCostExc * ((package3.NumberOfPackagings * package3.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity) + (package3.NumberOfPackagings * package3.RecipeQuantity))) / package3.NumberOfPackagings);

                    package1.ProductionPriceExc = pricePP1Exc;
                    package2.ProductionPriceExc = pricePP2Exc;
                    package3.ProductionPriceExc = pricePP3Exc;

                    pricePP1Inc = package1.PriceInc + package1.AdditionalCostInc + (this.TotalIngredientCostInc * ((package1.NumberOfPackagings * package1.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity) + (package3.NumberOfPackagings * package3.RecipeQuantity))) / package1.NumberOfPackagings);
                    pricePP2Inc = package2.PriceInc + package2.AdditionalCostInc + (this.TotalIngredientCostInc * ((package2.NumberOfPackagings * package2.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity) + (package3.NumberOfPackagings * package3.RecipeQuantity))) / package2.NumberOfPackagings);
                    pricePP3Inc = package3.PriceInc + package3.AdditionalCostInc + (this.TotalIngredientCostInc * ((package3.NumberOfPackagings * package3.RecipeQuantity) / ((package1.NumberOfPackagings * package1.RecipeQuantity) + (package2.NumberOfPackagings * package2.RecipeQuantity) + (package3.NumberOfPackagings * package3.RecipeQuantity))) / package3.NumberOfPackagings);

                    package1.ProductionPriceInc = pricePP1Inc;
                    package2.ProductionPriceInc = pricePP2Inc;
                    package3.ProductionPriceInc = pricePP3Inc;
                }
            }

        }





    }
}
