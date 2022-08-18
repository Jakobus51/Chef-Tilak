using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chef_Tilak.DataClassses
{
    public class Settings
    {
        /// <summary>
        /// True if you want to open the pdf after creation
        /// </summary>
        public bool ShowPDFAfterCreation { get; set; }

        /// <summary>
        /// True if you want to see the price per unit  in the ingredient overview exc
        /// </summary>
        public bool ShowPricePPIngredientExc { get; set; }

        /// <summary>
        /// True if you want to see the price per unit  in the ingredient overview inc
        /// </summary>
        public bool ShowPricePPIngredientInc { get; set; }

        /// <summary>
        /// Customer logo path
        /// </summary>
        public string CustomerLogoPath { get; set; }

        /// <summary>
        /// Customer Name
        /// </summary>
        public string CustomerName { get; set; }


        /// <summary>
        /// Color in the header of the recipes, the color gets translated into html otherwize it can not get xml seriazlized tus it can not be saved
        /// </summary>
        public string CustomerColorHTML { get; set; }


    }
}
