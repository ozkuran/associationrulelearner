using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ItemsTransactionList
    {
        public ItemsTransactionList()
        {
            Transactions = new HashSet<Transaction>();
            ItemList = new ItemList();
        }

        public ItemsTransactionList(ItemList itemList)
        {
            foreach (Item item in itemList.Items)
            {
                ItemList.Items.Add(item);
            }
        }

        public HashSet<Transaction> Transactions { get; set; }
        public ItemList ItemList { get; set; }

        public void AddTransactionsToList(List<Transaction> transactions)
        {
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Contains(new Transaction(ItemList)))
                {
                    Transactions.Add(transaction);
                }
            }
        }

        public void AddTransactionsInTransactionDatabaseToList(TransactionDatabase transactionDatabase)
        {
            foreach (Transaction transaction in transactionDatabase.Transactions)
            {
                if (transaction.Contains(new Transaction(ItemList)))
                {
                    Transactions.Add(transaction);
                }
            }
        }
    }
}
