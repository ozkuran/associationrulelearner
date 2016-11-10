using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ItemListTransactions
    {
        public ItemListTransactions()
        {
            ItemList = new ItemList();
            TransactionList = new HashSet<int>();
        }

        public ItemList ItemList;
        public HashSet<int> TransactionList;
    }
}
