using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class CommandProcessor
    {
        public CommandProcessor()
        {
            
        }

        public TextBox Output { get; set; }
        public ApplicationConfiguration ApplicationConfiguration { get; set; }

        public void Process(string input)
        {
            input = input.Trim();
            if (input == "")
                return;
            else if (input.ToLower() == "listdatasets")
            {
                if (ApplicationConfiguration.DataFiles.Count == 0)
                {
                    Output.AppendText("------------------" + Environment.NewLine);
                    Output.AppendText("List of Currently Availabe Data Files Are:" + Environment.NewLine);
                }
                else
                {
                    Output.AppendText("------------------" + Environment.NewLine);
                    Output.AppendText("List of Currently Availabe Data Files Are:" + Environment.NewLine);
                    for (var i = 1; i <= ApplicationConfiguration.DataFiles.Count ; i++ )
                    {
                        Output.AppendText( i + ". "+ ApplicationConfiguration.DataFiles[i-1] + Environment.NewLine);
                    }
                }
            }
            else if (input.ToLower().Substring(0,8) == "listfile")
            {
                var fileName = input.ToLower().Substring(9, input.Length - 10);
                var fullFileName = Application.StartupPath +"\\" + fileName;
                Output.AppendText("------------------" + Environment.NewLine);
                if (File.Exists(fullFileName))
                {
                    Output.AppendText("The contents of the file " + fileName + " are"  + Environment.NewLine);
                    Output.AppendText(File.ReadAllText(fullFileName)+Environment.NewLine);
                }
                else
                {
                    Output.AppendText("File " + fileName + " cannot be found"+Environment.NewLine);
                }
                Output.AppendText("------------------" + Environment.NewLine);
            }
            else
            {
                Output.AppendText("------------------" + Environment.NewLine);
                Output.AppendText("Unknown Command" + Environment.NewLine);
                Output.AppendText("------------------" + Environment.NewLine);
            }
        }


    }
}
