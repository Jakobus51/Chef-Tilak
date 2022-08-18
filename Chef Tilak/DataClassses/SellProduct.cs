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

    }
}
