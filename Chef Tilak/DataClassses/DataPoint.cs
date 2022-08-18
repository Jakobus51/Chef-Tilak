using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_Tilak.DataClassses
{
    internal class DataPoint
    {
        /// <summary>
        /// Is always set to "Margin" for the graphs stuff
        /// </summary>
        public string DataPointMargin { get; set; }

        /// <summary>
        /// Is always set to "Profit" for the graphs stuff
        /// </summary>
        public string DataPointProfit { get; set; }

        public string Name { get; set; }

        public string RecipeName { get; set; }

        public string PackagingName { get; set; }

        public decimal Margin { get; set; }
        public decimal Profit { get; set; }





    }
}
