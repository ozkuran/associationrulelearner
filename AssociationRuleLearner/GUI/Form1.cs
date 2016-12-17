using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private CommandProcessor CommandProcessor;

        private void aprioriAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var transactions = new TransactionDatabase(comboBoxTestDataSet.Text);
            var apriori = new Apriori(transactions, double.Parse(textBoxMinimumSupport.Text));
            apriori.Run();
            textBoxOutput.Text = apriori.ToString();
            csvString = apriori.ToCSV();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxGUI about = new AboutBoxGUI();
            about.Show();
        }

        private void eCLATAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var transactions = new TransactionDatabase(comboBoxTestDataSet.Text);
            var eclat = new Eclat(transactions, double.Parse(textBoxMinimumSupport.Text));
            eclat.Run();
            textBoxOutput.Text = eclat.ToString();
            csvString = eclat.ToCSV();
        }

        private void buttonExportToCsv_Click(object sender, EventArgs e)
        {

        }

        private void performanceTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process proc = Process.GetCurrentProcess();
            List<double> supports = new List<double>(new double[] { 0.01, 0.02, 0.03, 0.04, 0.05, 0.1, 0.2, 0.3, 0.4, 0.5});
            string stringResult = "";
            string readfile = File.ReadAllText(comboBoxTestDataSet.Text);
            foreach (double support in supports)
            {
                var start = DateTime.Now;
                //var startMem = GC.GetTotalMemory(true);
                var transactions = new TransactionDatabase(comboBoxTestDataSet.Text);
                var apriori = new Apriori(transactions, support);
                apriori.Run();
                var end = DateTime.Now;
                var result = end - start;
                //var endMem = GC.GetTotalMemory(true);
                var resultMem = GC.GetTotalMemory(true);
                stringResult += $"APRIORI Support:{support} Total Time (ms): {result.TotalMilliseconds} Memory Usage (bytes): {resultMem}" + Environment.NewLine;
            }
            foreach (double support in supports)
            {
                var start = DateTime.Now;
                //var startMem = GC.GetTotalMemory(true);
                var transactions = new TransactionDatabase(comboBoxTestDataSet.Text);
                var eclat = new Eclat(transactions, support);
                eclat.Run();
                var end = DateTime.Now;
                var result = end - start;
                //var endMem = GC.GetTotalMemory(true);
                var resultMem = GC.GetTotalMemory(true);
                stringResult += $"ECLAT Support:{support} Total Time (ms): {result.TotalMilliseconds} Memory Usage (bytes): {resultMem}" + Environment.NewLine;
                System.IO.File.WriteAllText(@"PerformanceResults.txt", stringResult);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxCommandTerminal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                CommandProcessor.Process(textBoxCommandTerminal.Text);
                e.Handled = true;
            }

        }

        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"result.csv", csvString);
        }

        private void textBoxCommandTerminal_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CommandProcessor = new CommandProcessor();
            CommandProcessor.ApplicationConfiguration = applicationConfiguration;
            CommandProcessor.Output = textBoxOutput;
        }

        private void textBoxOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        private void toolStripMenuItemImportTransactionData_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = @"Select Transaction File..";

            string fullFileName = "";
            string fileName = "";

            if (file.ShowDialog() == DialogResult.OK)
            {
                fullFileName = file.FileName;
                fileName = file.SafeFileName;
            }
            File.Copy(fullFileName, AppDomain.CurrentDomain.BaseDirectory + "\\" + fileName,true);
            applicationConfiguration.DataFiles.Add(fileName);
            comboBoxTestDataSet.Items.Clear();
            foreach (var applicationConfigurationDataFile in applicationConfiguration.DataFiles)
            {
                comboBoxTestDataSet.Items.Add(applicationConfigurationDataFile);
            }
            applicationConfiguration.SaveDataFilesInConfig();
        }
    }
}
