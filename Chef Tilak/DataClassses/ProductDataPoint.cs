using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_Tilak.DataClassses
{
    public class ProductDataPoint
    {    

        public string Name { get; set; }

        /// <summary>
        /// Can be Ingredient, Packaging or Additional
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Can be either for a packaging or ingredient or empty for aditional packaging cost
        /// </summary>
        public Guid Code { get; set; }

        /// <summary>
        /// The money cost of this specific datapoint
        /// </summary>
        public decimal Cost { get; set; }
    }
}
