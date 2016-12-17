using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm();
            mainForm.applicationConfiguration = new ApplicationConfiguration();
            mainForm.applicationConfiguration.DataFiles = new List<string>(ConfigurationManager.AppSettings["datafiles"].Split(new char[] { ';' }));
            foreach (string dataFile in mainForm.applicationConfiguration.DataFiles)
            {
                mainForm.comboBoxTestDataSet.Items.Add(dataFile);
            }
            Application.Run(mainForm);
        }
    }
}
