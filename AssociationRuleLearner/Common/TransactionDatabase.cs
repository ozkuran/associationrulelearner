using System;
using System.Collections.Generic;
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
        }

        public List<Transaction> Transactions { get; set; }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}
