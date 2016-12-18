using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Eclat
    {
        public Eclat()
        {

        }

        public Eclat(TransactionDatabase transactionDatabase, double minimumSupport = 0.1, bool calculateSupport = true, bool calculateConfidence = false, bool calculateLift = false, bool calculateConviction = false)
        {
            TransactionDatabase = transactionDatabase;
            MinimumSupport = minimumSupport;
            MinimumRequiredTransaction = (int)(Math.Ceiling(transactionDatabase.Transactions.Count * MinimumSupport));
            CalculateSupport = calculateSupport;
            CalculateConfidence = calculateConfidence;
            CalculateLift = calculateLift;
            CalculateConviction = calculateConviction;
            ItemsTransactionLists = new List<ItemsTransactionList>();
        }

        public TransactionDatabase TransactionDatabase { get; set; }
        public double MinimumSupport { get; set; }
        public int MinimumRequiredTransaction { get; set; }
        public bool CalculateSupport { get; set; }
        public bool CalculateConfidence { get; set; }
        public bool CalculateLift { get; set; }
        public bool CalculateConviction { get; set; }
        public HashSet<Transaction> SupportedTransactionsList { get; set; }
        public HashSet<Transaction> UnSupportedTransactionsList { get; set; }

        public List<ItemsTransactionList> ItemsTransactionLists { get; set; }

        public void Run()
        {
            TransactionDatabase.CreateUniqueItemsList();
            SupportedTransactionsList = new HashSet<Transaction>();
            UnSupportedTransactionsList = new HashSet<Transaction>();
            List<ItemsTransactionList> uniqueItemsTransactionLists = new List<ItemsTransactionList>();
            List<ItemsTransactionList> tempUniqueItemsTransactionLists = new List<ItemsTransactionList>();
            foreach (Item uniqueItem in TransactionDatabase.UniqueItems.Items)
            {
                ItemsTransactionList itemsTransactionList = new ItemsTransactionList();
                itemsTransactionList.ItemList = new ItemList();
                itemsTransactionList.ItemList.Items.Add(uniqueItem);
                itemsTransactionList.AddTransactionsToList(GetTransactionsContainsItemList(itemsTransactionList.ItemList));
                if (TransactionDatabase.GetSupportOfTransaction(new Transaction(uniqueItem)) >= MinimumSupport)
                {
                    ItemsTransactionLists.Add(itemsTransactionList);
                    uniqueItemsTransactionLists.Add(itemsTransactionList);
                    var transaction = new Transaction(uniqueItem);
                    if (CalculateSupport)
                    {
                        transaction.Support = TransactionDatabase.GetSupportOfTransaction(transaction);
                    }
                    SupportedTransactionsList.Add(transaction);
                }
            }

            int maxItemCount = 1;
            HashSet<Item> temporaryItems = new HashSet<Item>();
            List<Transaction> temporaryTransactions = new List<Transaction>();
            while (true)
            {
                temporaryItems.Clear();
                temporaryTransactions.Clear();
                tempUniqueItemsTransactionLists.Clear();
                List<ItemsTransactionList> tmpItemsTransactionLists = new List<ItemsTransactionList>();

                foreach (ItemsTransactionList itemsTransactionList in ItemsTransactionLists)
                {
                    if (itemsTransactionList.ItemList.Items.Count == maxItemCount)
                    {
                        tmpItemsTransactionLists.Add(itemsTransactionList);
                    }
                }
                foreach (ItemsTransactionList tmpItemsTransactionList in tmpItemsTransactionLists)
                {
                    foreach (Item item in tmpItemsTransactionList.ItemList.Items)
                    {
                        temporaryItems.Add(item);
                    }
                }

                foreach (ItemsTransactionList itemsTransactionList in uniqueItemsTransactionLists)
                {
                    foreach (Item temporaryItem in temporaryItems)
                    {
                        if (itemsTransactionList.ItemList.Items.First() == temporaryItem)
                        {
                            tempUniqueItemsTransactionLists.Add(itemsTransactionList);                            
                        }
                    }
                }

                List<ItemsTransactionList> candidateTransactions = GenerateCandidates(tempUniqueItemsTransactionLists.ToList(), maxItemCount);
                if (candidateTransactions.Count == 0)
                {
                    break;
                }
                foreach (ItemsTransactionList tmpItemsTransactionList in candidateTransactions)
                {
                    ItemsTransactionLists.Add(tmpItemsTransactionList);
                    var transaction = new Transaction(tmpItemsTransactionList.ItemList);
                    if (CalculateSupport)
                    {
                        transaction.Support = TransactionDatabase.GetSupportOfTransaction(transaction);
                    }
                    SupportedTransactionsList.Add(transaction);
                }
                maxItemCount++;
            }
        }

        private List<Transaction> GetTransactionsContainsTransaction(Transaction transaction)
        {
            List<Transaction> transactionsList = new List<Transaction>();
            foreach (Transaction transactionDatabaseTransaction in TransactionDatabase.Transactions)
            {
                if (transactionDatabaseTransaction.Contains(transaction))
                {
                    transactionsList.Add(transactionDatabaseTransaction);
                }
            }
            return transactionsList;
        }

        private List<Transaction> GetTransactionsContainsItemList(ItemList itemList)
        {
            List<Transaction> transactionsList = new List<Transaction>();
            foreach (Transaction transactionDatabaseTransaction in TransactionDatabase.Transactions)
            {
                if (transactionDatabaseTransaction.Contains(new Transaction(itemList)))
                {
                    transactionsList.Add(transactionDatabaseTransaction);
                }
            }
            return transactionsList;
        }

        private List<ItemsTransactionList> GenerateCandidates(List<ItemsTransactionList> items, int transactionLength)
        {
            var result = new List<ItemsTransactionList>();
            var x = GetCombinations(items.AsEnumerable(), transactionLength + 1);
            foreach (var enumerable in x)
            {
                var itemsTransactionList = new ItemsTransactionList();
                bool first = true;
                foreach (var item in enumerable)
                {
                    foreach (Item itemListItem in item.ItemList.Items)
                    {
                        itemsTransactionList.ItemList.Items.Add(itemListItem);
                    }
                    if (first)
                    {
                        foreach (Transaction transaction in item.Transactions)
                        {
                            itemsTransactionList.Transactions.Add(transaction);
                        }
                    }
                    else
                    {
                        List<Transaction> tmpTransactionList = new List<Transaction>();
                        foreach (Transaction transaction in itemsTransactionList.Transactions)
                        {
                            if (!item.Transactions.Contains(transaction))
                            {
                                tmpTransactionList.Add(transaction);
                            }
                        }
                        foreach (Transaction transaction in tmpTransactionList)
                        {
                            itemsTransactionList.Transactions.Remove(transaction);
                        }
                    }
                    first = false;
                }
                if (((double)itemsTransactionList.Transactions.Count / (double)TransactionDatabase.Transactions.Count)>= MinimumSupport)
                {
                    result.Add(itemsTransactionList);
                }
            }
            return result;
        }

        public ItemsTransactionList CombineItemsTransactionList(ItemsTransactionList itemsTransactionList1,
            ItemsTransactionList itemsTransactionList2)
        {
            itemsTransactionList1.ItemList.AddItemsOfTransaction(new Transaction(
                itemsTransactionList2.ItemList));
            foreach (Transaction transaction in itemsTransactionList1.Transactions)
            {
                if (!itemsTransactionList2.Transactions.Contains(transaction))
                {
                    itemsTransactionList1.Transactions.Remove(transaction);
                }
            }
            return itemsTransactionList1;
        }

        public override string ToString()
        {
            string outputString = "";
            outputString += "Total Transaction Count : " + TransactionDatabase.Transactions.Count + Environment.NewLine;
            outputString += "Unique Item Count : " + TransactionDatabase.UniqueItems.Items.Count + Environment.NewLine;
            outputString += "Supported Transaction Count : " + SupportedTransactionsList.Count + Environment.NewLine;
            if (SupportedTransactionsList.Count > 0)
            {
                outputString += "Maximum Size of a Supported Transaction : " +
                                SupportedTransactionsList.Max(transaction => transaction.Items.Count) +
                                Environment.NewLine;
                outputString += "---------------------------" + Environment.NewLine;
                foreach (
                    Transaction transaction in
                    SupportedTransactionsList.OrderByDescending(x => x.Items.Count).ThenByDescending(x => x.Support))
                {
                    outputString += $" Support : {transaction.Support:0.00} " + "Transaction : " +
                                    transaction.ToString() + Environment.NewLine;
                }
            }
            else
            {
                outputString += "Maximum Size of a Supported Transaction : 0" + Environment.NewLine;
                outputString += "---------------------------" + Environment.NewLine;
                outputString += "No association has been found" + Environment.NewLine;
            }
            outputString += "---------------------------" + Environment.NewLine;
            return outputString;
        }

        public string ToCSV()
        {
            string outputString = "";
            outputString += "Support,Item" +Environment.NewLine;
            foreach (ItemsTransactionList itemsTransactionList in ItemsTransactionLists)
            {
                Transaction transaction = new Transaction();
                foreach (Item item in itemsTransactionList.ItemList.Items)
                {
                    transaction.Items.Add(item);
                }
                outputString += $"{TransactionDatabase.GetSupportOfTransaction(transaction):0.00}," + transaction.ToString() +  Environment.NewLine;
            }
            return outputString;
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

        public int TransactionCountWithSupport()
        {
            return SupportedTransactionsList.Count;
        }

    }
}
