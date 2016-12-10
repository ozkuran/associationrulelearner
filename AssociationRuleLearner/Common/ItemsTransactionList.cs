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
            TransactionIds = new HashSet<int>();
        }

        public HashSet<int> TransactionIds { get; set; }
        public ItemList ItemList { get; set; }

        public void AddTransactionsToList(TransactionDatabase transactionDatabase)
        {
            foreach (Transaction transaction in transactionDatabase.Transactions)
            {
                if (transaction.Contains(new Transaction(ItemList)))
                {
                    TransactionIds.Add(transaction.Id);
                }
            }
        }
    }
}
