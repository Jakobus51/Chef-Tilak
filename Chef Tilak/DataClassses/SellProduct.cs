using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_Tilak.DataClassses
{
    public class SellProduct
    {
        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of product
        /// </summary>
        public string RecipeName { get; set; }

        /// <summary>
        /// Name of product
        /// </summary>
        public string PackagingName { get; set; }

        /// <summary>
        /// Name of product
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// True if it was made through the recipe maker
        /// </summary>
        public bool IsRecipeProduct { get; set; }

        /// <summary>
        /// Unique code of product
        /// </summary>
        public Guid ProductCode { get; set; }

        /// <summary>
        /// The packaging this product is in
        /// </summary>
        public Guid PackagingCode { get; set; }

        /// <summary>
        /// The recipe this product was made of
        /// </summary>
        public Guid RecipeCode { get; set; }

        /// <summary>
        /// The amount of volume present in the prodcut
        /// </summary>
        public decimal Volume { get; set; }

        /// <summary>
        /// The production price of this product (exc)
        /// </summary>
        public decimal ProductionCostExc { get; set; }

        /// <summary>
        /// The production price of this product (inc)
        /// </summary>
        public decimal ProductionCostInc { get; set; }


        /// <summary>
        /// List of all costs accociated with this product (Cost per each ingredient, packagaing etc)
        /// </summary>
        public List<ProductDataPoint> ProductionCostBreakdown { get; set; }

        /// <summary>
        /// The sale price of this product (exc)
        /// </summary>
        public decimal SellPriceExc { get; set; }

        /// <summary>
        /// The sale price of this product (inc)
        /// </summary>
        public decimal SellPriceInc { get; set; }

        /// <summary>
        /// The production price of this product (inc)
        /// </summary>
        public decimal MarginExc { get; set; }

        /// <summary>
        /// The production price of this product (inc)
        /// </summary>
        public decimal MarginInc { get; set; }

        /// <summary>
        /// The profit of this product (inc)
        /// </summary>
        public decimal ProfitInc { get; set; }

        /// <summary>
        /// The profit of this product (exc)
        /// </summary>
        public decimal ProfitExc { get; set; }

        /// <summary>
        /// Is always set to "Margin" for the graphs stuff
        /// </summary>
        public string DataPointMargin { get; set; }

        /// <summary>
        /// Is always set to "Profit" for the graphs stuff
        /// </summary>
        public string DataPointProfit { get; set; }


        public SellProduct()
        {
            this.ProductionCostBreakdown = new();
        }

        public void UpdateProduct(ProjectData projectData)
        {
            Recipe recipe = projectData.RecipeList.Find(x => x.Code.Equals(this.RecipeCode));

            Packaging packaging = recipe.PackagingList.Find(x => x.Code.Equals(this.PackagingCode));

            this.Name = recipe.RecipeName + "\r\n(" + packaging.Name + ")";
            this.RecipeName = recipe.RecipeName;
            this.PackagingName = packaging.Name;

            this.Category = recipe.Category;
            this.Volume = packaging.RecipeQuantity;
            this.ProductionCostExc = packaging.ProductionPriceExc;
            this.ProductionCostInc = packaging.ProductionPriceInc;

            if (this.SellPriceInc != 0)
            {
                this.MarginInc = (this.SellPriceInc - this.ProductionCostExc) / this.SellPriceInc;
                this.ProfitInc = this.SellPriceInc - this.ProductionCostExc;
            }

            this.CalculateProductionCostBreakdown(projectData, packaging, recipe);
        }


        public void CalculateProductionCostBreakdown(ProjectData projectData, Packaging packaging, Recipe recipe)
        {
            List<ProductDataPoint> costList = new List<ProductDataPoint>();

            //Packaging itself
            if (packaging != null)
            {
                costList.Add(new()
                {
                    Name = packaging.Name,
                    Code = packaging.Code,
                    Category = "Packaging",
                    Cost = packaging.PriceExc,
                });

                //Packaging additional 
                if (packaging.AdditionalCostExc != 0)
                {
                    costList.Add(new()
                    {
                        Name = "Extra Packaging Cost",
                        Code = packaging.Code,
                        Category = "Packaging Extra",
                        Cost = packaging.AdditionalCostExc,
                    });
                }
            }            

            //Ingredient Cost 
            foreach (Ingredient ingredient in recipe.RecipeIngredientList.FindAll(x => x.Code != Guid.Empty))
            {
                decimal percentage = ingredient.RecipePriceExc / recipe.TotalIngredientCostExc;
                //Just the toal cost minus everything that is not an ingredient cost
                decimal productIngredientCost = this.ProductionCostExc - packaging.PriceExc - packaging.AdditionalCostExc;
                costList.Add(new()
                {
                    Name = ingredient.Name,
                    Code = ingredient.Code,
                    Category = "Ingredients",
                    Cost = productIngredientCost * percentage,
                });
            }
            this.ProductionCostBreakdown.Clear();
            this.ProductionCostBreakdown = costList;
           
        }

    }
}
