using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef_Tilak.DataClassses;
using System.IO;
using System.Xml.Serialization;

namespace Chef_Tilak.DataClassses
{
    public class ProjectSettings
    {        

        /// <summary>
        /// Where the project files are saved
        /// </summary>
        public string ProjectDirectory { get; set; }             

        /// <summary>
        /// Where teh recipes pdf's are saved
        /// </summary>
        public string RecipesDirectory { get; set; }

        /// <summary>
        /// path of project settings
        /// </summary>
        public string ProjectSaveLocation { get; set; }

        /// <summary>
        /// Is true when new project
        /// </summary>
        public bool  newProject { get; set; }

        /// <summary>
        /// All the good stuff baby
        /// </summary>
        public ProjectData ProjectData{ get; set; }


        /// <summary>
        /// Gets passed throughout the application to open and close forms
        /// </summary>
        public string formType { get; set; }

        public ProjectSettings()
        {
            ProjectData = new();

            string userDataDir = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), "Chef Tilak");

            ProjectDirectory = Path.Combine(userDataDir, "Project");
            ProjectSaveLocation = Path.Combine(ProjectDirectory, "Chef Tilak ProjectFile");
            RecipesDirectory = Path.Combine(userDataDir, "Recipes");


            if (!Directory.Exists(ProjectDirectory))
                Directory.CreateDirectory(ProjectDirectory);

            if (!Directory.Exists(RecipesDirectory))
                Directory.CreateDirectory(RecipesDirectory);

            //If there is already a projectFile present it means you don't have a new project
            if (!File.Exists(ProjectSaveLocation))
            {
                SaveProject();
                newProject = true;
            }                
        }


        public bool SaveProject()
        {
            string content = ProjectData.ToXmlString(ProjectData);
            if (WriteTxtFile(ProjectSaveLocation, content))
            {
                return true;
            }
            return false;
        }

        public bool SaveProject(string fileName)
        {
            string content = ProjectData.ToXmlString(ProjectData);
            if (WriteTxtFile(fileName, content))
            {                
                return true;
            }
            return false;
        }
      

        public Tuple<Boolean, string> LoadProject(string fileName)
        {
            if (File.Exists(fileName))
            {
                string content = ReadTxtFile(fileName);

                ProjectData = ProjectData.FromXmlString(content);
                // Load successful.
                return Tuple.Create(true, "");

            }
            // File location error.
            return Tuple.Create(false, "LocationError");
        }

        #region read and write files to computer

        public static string ReadTxtFile(string fileName)
        {
            string content = string.Empty;
            if (File.Exists(fileName))
            {
                using (StreamReader myFile = new StreamReader(fileName))
                {
                    content = myFile.ReadToEnd();
                    myFile.Close();
                }
            }
            return content;
        }


        public static bool WriteTxtFile(string fileName, string content)
        {
            try
            {
                using (StreamWriter myFile = new StreamWriter(fileName))
                {
                    myFile.Write(content);
                    myFile.Close();
                }
            }
            catch (Exception)
            {
                // log.Error(String.Format("Exception FileIO.WriteFile : {0}", fileName), ex);
                return false;
            }
            return true;
        }
        #endregion
    }
}

