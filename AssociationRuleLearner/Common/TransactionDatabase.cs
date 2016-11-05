using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TransactionDatabase
    {
        public TransactionDatabase()
        {
            Transactions = new List<Transaction>();
            UniqueItems = new ItemList();
        }

        public TransactionDatabase(string fileName) : this()
        {
            LoadTransactionsFromCommaSeperatedFile(fileName);
        }

        public List<Transaction> Transactions { get; set; }
        public ItemList UniqueItems { get; set; }

        public override string ToString()
        {
            string outputString = "";
            foreach (Transaction transaction in Transactions)
            {
                outputString += transaction.ToString() + Environment.NewLine;
            }
            return outputString;
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public void LoadTransactionsFromCommaSeperatedFile(string fileName)
        {
            var lines = File.ReadLines(fileName);
            foreach (var line in lines)
            {
                var transaction = new Transaction(line);
                transaction.Id = Transactions.Count;
                AddTransaction(transaction);
            }
        }

        public int GetMaxTransactionLength()
        {
            return Transactions.Select(transaction => transaction.Items.Count).Concat(new[] {0}).Max();
        }

        public double GetSupportOfTransaction(Transaction transaction)
        {
            int containedTransaction = 0;
            foreach (Transaction transaction1 in Transactions)
            {
                if (transaction1.Contains(transaction))
                {
                    containedTransaction++;
                }
            }
            var support = (double)(containedTransaction)/(double)(Transactions.Count);
            return support;
        }

        public double GetConfidenceOfTransactions(Transaction transaction1, Transaction transaction2)
        {
            var support = GetSupportOfTransaction(transaction1 + transaction2) / (GetSupportOfTransaction(transaction1));
            return support;
        }

        public double GetLiftOfTransactions(Transaction transaction1, Transaction transaction2)
        {
            var support = GetSupportOfTransaction(transaction1 + transaction2) / (GetSupportOfTransaction(transaction1) * GetSupportOfTransaction(transaction2));
            return support;
        }

        public double GetConvictionOfTransactions(Transaction transaction1, Transaction transaction2)
        {
            var support = (1 - GetSupportOfTransaction(transaction2)) / (1 - GetConfidenceOfTransactions(transaction1, transaction2));
            return support;
        }

        public void CreateUniqueItemsList()
        {
            foreach (Transaction transaction in Transactions)
            {
                UniqueItems.AddItemsOfTransaction(transaction);
            }
        }

        public void CreateRandomTransactionDatabase(int databaseSize)
        {
            for (var i = 0; i < databaseSize; i++)
            {
                Transactions.Add(GenerateRandomTransaction()); 
            }
        }

        protected virtual Transaction GenerateRandomTransaction()
        {
            var rnd = new Random();
            int itemCount = rnd.Next(9);
            string items = "";
            for (int i = 0; i < itemCount; i++)
            {
                items += GetRandomCharacter("QWERTYUIOPASDFGHJKLZXCVBNM");
            }
            return new Transaction(string.Join(items, ","));
        }

        private static char GetRandomCharacter(string text)
        {
            var rnd = new Random();
            var index = rnd.Next(text.Length);
            return text[index];
        }
    }
}
