using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Transaction
    {
        public Transaction()
        {
            Items = new List<Item>();
        }

        public Transaction(string line) : this()
        {
            var items = line.Split(',');
            foreach (var item in items)
            {
                var transactionItem = new Item(item); 
                Items.Add(transactionItem);
            }
        }

        public List<Item> Items { get; set; }
    }
}
