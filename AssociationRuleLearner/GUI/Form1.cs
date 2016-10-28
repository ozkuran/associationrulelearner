using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            var transactions = new TransactionDatabase(@"sample.txt");
            var apriori = new Apriori(transactions);
            apriori.Run();
            textBoxTransactions.Text = transactions.ToString();
            textBoxAssociations.Text = apriori.ToString();
        }
    }
}
