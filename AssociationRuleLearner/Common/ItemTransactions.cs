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
            TransactionList = new HashSet<int>();
        }

        public ItemTransactions(Item item)
        {
            Item = item;
            TransactionList = new HashSet<int>();
        }

        public void GetTransactionsFromDatabase(TransactionDatabase transactionDatabase)
        {
            foreach (var transactionDatabaseTransaction in transactionDatabase.Transactions)
            {
                if (transactionDatabaseTransaction.Items.Contains(Item))
                {
                    TransactionList.Add(transactionDatabaseTransaction.Id);
                }
            }  
        }

        public Item Item;
        public HashSet<int> TransactionList;


    }
}
