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
                if (item.Trim() == "") continue;
                var transactionItem = new Item(item);
                Items.Add(transactionItem);
            }
        }

        public Transaction(List<Item> itemList) : this()
        {
            Items.AddRange(itemList);
        }

        public List<Item> Items { get; set; }
        public double Support { get; set; }

        public bool ContainsItem(Item item)
        {
            bool contains = false;
            foreach (Item item1 in Items)
            {
                if (Equals(item, item1))
                {
                    contains = true;
                }
            }
            return contains;

        }

        public bool Contains(Transaction transaction)
        {
            bool contains = true;
            foreach (Item item in transaction.Items)
            {
                contains = contains && ContainsItem(item);
            }
            return contains;
        }

        public static Transaction operator +(Transaction transaction1, Transaction transaction2)
        {
            Transaction t1 = new Transaction(transaction1.Items);
            t1.Items.AddRange(transaction2.Items);
            return t1;
        }

        public override string ToString()
        {
            return string.Join(",",Items);
        }
    }
}
