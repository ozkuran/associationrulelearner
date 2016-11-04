using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Apriori
    {
        public Apriori()
        {

        }

        public Apriori(TransactionDatabase transactionDatabase, double minimumSupport = 0.1, bool calculateSupport = true, bool calculateConfidence = false, bool calculateLift = false, bool calculateConviction = false)
        {
            TransactionDatabase = transactionDatabase;
            MinimumSupport = minimumSupport;
            CalculateSupport = calculateSupport;
            CalculateConfidence = calculateConfidence;
            CalculateLift = calculateLift;
            CalculateConviction = calculateConviction;
        }

        public TransactionDatabase TransactionDatabase { get; set; }
        public double MinimumSupport { get; set; }
        public bool CalculateSupport { get; set; }
        public bool CalculateConfidence { get; set; }
        public bool CalculateLift { get; set; }
        public bool CalculateConviction { get; set; }
        public List<Transaction> SupportedTransactionsList { get; set; }
        public List<Transaction> UnSupportedTransactionsList { get; set; }

        public override string ToString()
        {
            string outputString = "";
            foreach (Transaction transaction in SupportedTransactionsList)
            {
                outputString += transaction.ToString() + $" Support : {transaction.Support:0.00} " + Environment.NewLine;
            }
            return outputString;
        }

        public int TransactionCountWithSupport()
        {
            return SupportedTransactionsList.Count;
        }

        public void Run()
        {
            TransactionDatabase.CreateUniqueItemsList();
            SupportedTransactionsList = new List<Transaction>();
            UnSupportedTransactionsList = new List<Transaction>();
            var transactionList = TransactionDatabase.UniqueItems.Items.Select(transactionDatabaseUniqueItem => new Transaction(transactionDatabaseUniqueItem.ToString())).ToList();
            var uniqueItems = new HashSet<Item>();
            for (var i = 0; i < TransactionDatabase.GetMaxTransactionLength(); i++)
            {
                UnSupportedTransactionsList = new List<Transaction>();
                uniqueItems.Clear();
                transactionList = CalculateSupportOfTransactionList(transactionList);
                foreach (var transaction in transactionList)
                {
                    if (transaction.Support >= MinimumSupport)
                    {
                        SupportedTransactionsList.Add(transaction);
                        foreach (var item in transaction.Items)
                        {
                            uniqueItems.Add(item);
                        }
                    }
                    else
                    {
                        UnSupportedTransactionsList?.Add(transaction);
                    }
                }
                var itemList = uniqueItems.ToList();
                transactionList = GenerateCandidates(itemList, i + 1);
            }
        }

        private List<Transaction> CalculateSupportOfTransactionList(List<Transaction> transactions)
        {
            if (transactions == null) throw new ArgumentNullException(nameof(transactions));
            foreach (var transaction in transactions)
            {
                transaction.Support = TransactionDatabase.GetSupportOfTransaction(transaction);
            }
            return transactions;
        }
        
        private List<Transaction> GenerateCandidates(List<Item> items, int transactionLength)
        {
            var transactionList = new List<Transaction>();
            var x = GetCombinations(items.AsEnumerable(), transactionLength+1);
            bool unsupported = false;
            foreach (var enumerable in x)
            {
                var transaction = new Transaction();
                unsupported = false;
                foreach (var item in enumerable)
                {
                    transaction.Items.Add(item);
                }
                foreach (Transaction unsupportedTransaction in UnSupportedTransactionsList)
                {
                    if (transaction.Contains(unsupportedTransaction)) unsupported = true;
                }
                if (!unsupported) transactionList.Add(transaction);
            }
            return transactionList;
        }

        private static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> list, int length)
        {
            return length == 0 ? new[] { new T[0] } :
              list.SelectMany((e, i) =>
                GetCombinations(list.Skip(i + 1), length - 1).Select(c => (new[] { e }).Concat(c)));
        }

        public bool IsTransactionSupported(Transaction transaction)
        {
            return SupportedTransactionsList.Any(transaction1 => transaction == transaction1);
        }
    }
}
