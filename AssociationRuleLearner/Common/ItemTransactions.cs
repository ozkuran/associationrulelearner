using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ItemTransactions
    {
        public ItemTransactions()
        {
            Item = new Item();
            TransactionList = new HashSet<Transaction>();
        }

        public ItemTransactions(Item item)
        {
            Item = item;
            TransactionList = new HashSet<Transaction>();
        }

        public void GetTransactionsFromDatabase(TransactionDatabase transactionDatabase)
        {
            foreach (var transactionDatabaseTransaction in transactionDatabase.Transactions)
            {
                TransactionList.Add(transactionDatabaseTransaction);
            }  
        }

        public Item Item;
        public HashSet<Transaction> TransactionList;


    }
}
