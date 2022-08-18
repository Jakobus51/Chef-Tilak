using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_Tilak.DataClassses
{



    public class Packaging
    {
        /// <summary>
        /// Name of package
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unique code of Packaging
        /// </summary>
        public Guid Code { get; set; }

        /// <summary>
        /// Amount of tax (is between 0 and 1, 0 to 100%)
        /// </summary>
        public decimal Tax { get; set; }

        /// <summary>
        /// Price of package including tax
        /// </summary>
        public decimal PriceInc { get; set; }       

        /// <summary>
        /// Price of package excluding tax
        /// </summary>
        public decimal PriceExc { get; set; }

        /// Cost such as sticker cost including tax
        /// </summary>
        public decimal AdditionalCostInc { get; set; }

        /// Cost such as sticker cost excluding tax
        /// </summary>
        public decimal AdditionalCostExc { get; set; }

        /// <summary>
        /// Volume of package
        /// </summary>
        public decimal Volume { get; set; }

        /// <summary>
        /// Color of white sticker
        /// </summary>
        public string ColorRoundSticker { get; set; }

        /// <summary>
        /// The number of packages a recipe uses
        /// </summary>
        public decimal NumberOfPackagings { get; set; }

        /// <summary>
        /// The amount that goes into the packaging of a recipe
        /// </summary>
        public decimal RecipeQuantity { get; set; }

        /// <summary>
        /// The cost of producing one filled packaging including tax
        /// </summary>
        public decimal ProductionPriceInc { get; set; }

        /// <summary>
        /// The cost of producing one filled packaging Excluding tax
        /// </summary>
        public decimal ProductionPriceExc { get; set; }




    }
}
