using System;
using System.Collections.Generic;
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
            else
            {
                Output.AppendText("------------------" + Environment.NewLine);
                Output.AppendText("Unknown Command" + Environment.NewLine);
            }
        }


    }
}
