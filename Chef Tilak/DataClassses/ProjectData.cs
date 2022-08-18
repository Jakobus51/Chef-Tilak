using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;

namespace Chef_Tilak.DataClassses
{
    public class ProjectData
    {

        /// <summary>
        /// List of all the ingredients in your pantry
        /// </summary>
        public List<Ingredient> BuyIngredientList { get; set; }


        /// <summary>
        /// List of all the packagings
        /// </summary>
        public List<Packaging> PackagingList { get; set; }

        /// <summary>
        /// List of all recipes
        /// </summary>
        public List<Recipe> RecipeList { get; set; }

        /// <summary>
        /// The recipe you are currently editing
        /// </summary>
        public Recipe CurrentRecipe { get; set; }

        /// <summary>
        /// List of all recipes
        /// </summary>
        public List<SellProduct> ProductList { get; set; }


        /// <summary>
        /// List of all available units
        /// </summary>
        public List<string> Units { get; set; }

        /// <summary>
        /// Supplier of ingredients
        /// </summary>
        public List<string> IngredientSupplier { get; set; }

        /// <summary>
        /// Categories of recipes
        /// </summary>
        public List<string> RecipesCategories { get; set; }


        /// <summary>
        /// Colors of stickers
        /// </summary>
        public List<string> StickerColors { get; set; }


        /// <summary>
        /// Settings used trhoughout the application
        /// </summary>
        public Settings Settings { get; set; }



        public ProjectData()
        {
            this.BuyIngredientList = new();
            this.PackagingList = new();
            this.RecipeList = new();
            this.ProductList = new();
            this.Settings = new();

            this.IngredientSupplier = new();
            this.RecipesCategories = new();
            this.Units = new();
            this.StickerColors = new();

        }

        public void SetNewProject()
        {
            this.RecipesCategories = new() { "Other" };
            this.IngredientSupplier = new() { "Home made", "Other" };
            this.Units = new() { "Kg", "g", "L", "mL", "piece(s)", "other" };
            this.StickerColors = new() { "Green", "White", "None", "Other" };
        }

        #region Writing from and to XML's

        public static ProjectData FromXmlString(string xmlString)
        {
            if (xmlString.Equals(""))
                return new ProjectData();
            return Deserialize(typeof(ProjectData), xmlString) as ProjectData;
        }


        public static String ToXmlString(ProjectData project)
        {
            return Serialize(typeof(ProjectData), project);
        }


        /// <summary>
        /// Serializes an object to an XML string.
        /// </summary>
        public static string Serialize(Type typeObj, Object obj)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeObj);
                using (StringWriter writer = new StringWriter())
                {
                    serializer.Serialize(writer, obj);
                    return writer.ToString();
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        /// <summary>
        /// Deserializes an XML string to the original object.
        /// </summary>
        public static Object Deserialize(Type typeObj, string xmlString)
        {
            try
            {
                XmlSerializer s = new XmlSerializer(typeObj);
                var result = s.Deserialize(new StringReader(xmlString));
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}
