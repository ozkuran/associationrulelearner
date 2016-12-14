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

        private void aprioriAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var transactions = new TransactionDatabase(@"sample.txt");
            //var transactions = new TransactionDatabase(@"groceries.csv");
            var transactions = new TransactionDatabase(comboBoxTestDataSet.Text);
            //var apriori = new Apriori(transactions,0.02);
            var apriori = new Apriori(transactions, double.Parse(textBoxMinimumSupport.Text));
            apriori.Run();
            textBoxTransactions.Text = transactions.ToString();
            textBoxAssociations.Text = apriori.ToString();
            csvString = apriori.ToCSV();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxGUI about = new AboutBoxGUI();
            about.Show();
        }

        private void eCLATAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var transactions = new TransactionDatabase(@"sample.txt");
            //var transactions = new TransactionDatabase(@"groceries.csv");
            var transactions = new TransactionDatabase(comboBoxTestDataSet.Text);
            //var eclat = new Eclat(transactions, 0.02);
            var eclat = new Eclat(transactions, double.Parse(textBoxMinimumSupport.Text));
            eclat.Run();
            textBoxTransactions.Text = transactions.ToString();
            textBoxAssociations.Text = eclat.ToString();
            csvString = eclat.ToCSV();
        }

        private void buttonExportToCsv_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"result.csv", csvString);
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
    }
}
