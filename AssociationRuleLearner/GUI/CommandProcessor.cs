using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

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
            else if (input.ToLower().Substring(0, 8) == "listfile")
            {
                var fileName = input.ToLower().Substring(9, input.Length - 10);
                var fullFileName = Application.StartupPath + "\\" + fileName;
                Output.AppendText("------------------" + Environment.NewLine);
                if (File.Exists(fullFileName))
                {
                    Output.AppendText("The contents of the file " + fileName + " are" + Environment.NewLine);
                    Output.AppendText(File.ReadAllText(fullFileName) + Environment.NewLine);
                }
                else
                {
                    Output.AppendText("File " + fileName + " cannot be found" + Environment.NewLine);
                }
                Output.AppendText("------------------" + Environment.NewLine);
            }
            else if (input.ToLower().Substring(0, 11) == "listdataset")
            {
                var datasetNumber = input.ToLower().Substring(12, input.Length - 13);
                int intDataSetNumber;
                bool isNumeric = int.TryParse(datasetNumber, out intDataSetNumber);

                Output.AppendText("------------------" + Environment.NewLine);
                if (isNumeric)
                {
                    if (intDataSetNumber <= ApplicationConfiguration.DataFiles.Count)
                    {
                        var fullFileName = Application.StartupPath + "\\" + ApplicationConfiguration.DataFiles[intDataSetNumber - 1];
                        if (File.Exists(fullFileName))
                        {
                            Output.AppendText("The contents of the dataset " + ApplicationConfiguration.DataFiles[intDataSetNumber - 1] + " are" + Environment.NewLine);
                            Output.AppendText(File.ReadAllText(fullFileName) + Environment.NewLine);
                        }
                        else
                        {
                            Output.AppendText("The contents of the dataset cannot be found!" + Environment.NewLine);
                        }
                    }
                    else
                    {
                        Output.AppendText("Dataset with " + intDataSetNumber + " cannot be found" + Environment.NewLine);
                    }
                }
                else
                {
                    Output.AppendText(datasetNumber + " is not numeric" + Environment.NewLine);
                    Output.AppendText("------------------" + Environment.NewLine);
                }
            }
            else if (input.ToLower().Substring(0, 7) == "apriori")
            {
                var parameters = Regex.Match(input.ToLower(), @"\(([^)]*)\)").Groups[1].Value;
                var dataSet = parameters.Substring(0, parameters.LastIndexOf(","));
                double support = double.Parse(parameters.Substring(parameters.LastIndexOf(",") + 1 , parameters.Length - parameters.LastIndexOf(",") - 1 ));
                int intDataSetNumber;
                bool isNumeric = int.TryParse(dataSet, out intDataSetNumber);
                string fileName;
                if (isNumeric)
                {
                    fileName = ApplicationConfiguration.DataFiles[intDataSetNumber - 1];
                }
                else
                {
                    fileName = Regex.Match(parameters, @"\""([^)]*)\""").Groups[1].Value;
                }

                Output.AppendText("------------------" + Environment.NewLine);
                if (intDataSetNumber <= ApplicationConfiguration.DataFiles.Count)
                {
                    var fullFileName = Application.StartupPath + "\\" + fileName;
                    if (File.Exists(fullFileName))
                    {
                        Output.AppendText("The result of the dataset " + fileName + " are" + Environment.NewLine);
                        var transactions = new TransactionDatabase(fileName);
                        var apriori = new Apriori(transactions, support);
                        apriori.Run();
                        Output.AppendText(apriori.ToString());
                    }
                    else
                    {
                        Output.AppendText("The contents of the dataset cannot be found!" + Environment.NewLine);
                    }
                }
                else
                {
                    Output.AppendText("Dataset with " + intDataSetNumber + " cannot be found" + Environment.NewLine);
                }
            }
            else if (input.ToLower().Substring(0, 5) == "eclat")
            {
                var parameters = Regex.Match(input.ToLower(), @"\(([^)]*)\)").Groups[1].Value;
                var dataSet = parameters.Substring(0, parameters.LastIndexOf(","));
                double support = double.Parse(parameters.Substring(parameters.LastIndexOf(",") + 1, parameters.Length - parameters.LastIndexOf(",") - 1));
                int intDataSetNumber;
                bool isNumeric = int.TryParse(dataSet, out intDataSetNumber);
                string fileName;
                if (isNumeric)
                {
                    fileName = ApplicationConfiguration.DataFiles[intDataSetNumber - 1];
                }
                else
                {
                    fileName = Regex.Match(parameters, @"\""([^)]*)\""").Groups[1].Value;
                }

                Output.AppendText("------------------" + Environment.NewLine);
                if (intDataSetNumber <= ApplicationConfiguration.DataFiles.Count)
                {
                    var fullFileName = Application.StartupPath + "\\" + fileName;
                    if (File.Exists(fullFileName))
                    {
                        Output.AppendText("The result of the dataset " + fileName + " are" + Environment.NewLine);
                        var transactions = new TransactionDatabase(fileName);
                        var eclat = new Eclat(transactions, support);
                        eclat.Run();
                        Output.AppendText(eclat.ToString());
                    }
                    else
                    {
                        Output.AppendText("The contents of the dataset cannot be found!" + Environment.NewLine);
                    }
                }
                else
                {
                    Output.AppendText("Dataset with " + intDataSetNumber + " cannot be found" + Environment.NewLine);
                }
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
