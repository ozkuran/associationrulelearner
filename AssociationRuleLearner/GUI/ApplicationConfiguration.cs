using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class ApplicationConfiguration
    {
        public ApplicationConfiguration()
        {
            DataFiles = new List<string>();
        }

        public List<string> DataFiles { get; set; }

        public void SaveDataFilesInConfig()
        {
            string dataFiles = string.Join(";", DataFiles);
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings.Remove("datafiles");
            config.AppSettings.Settings.Add("datafiles", dataFiles);

            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
