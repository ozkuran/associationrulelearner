using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
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
    }
}
