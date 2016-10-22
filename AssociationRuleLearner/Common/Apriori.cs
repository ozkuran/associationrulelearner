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

        public Apriori(TransactionDatabase transactionDatabase)
        {
            TransactionDatabase = transactionDatabase;
        }

        public TransactionDatabase TransactionDatabase { get; set; }
    }
}
