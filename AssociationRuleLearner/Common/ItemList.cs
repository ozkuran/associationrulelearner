using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ItemList
    {
        public ItemList()
        {
            Items = new HashSet<Item>();
        }

        public HashSet<Item> Items { get; set; }

        public void AddItemsOfTransaction(Transaction transaction)
        {
            foreach (var item in transaction.Items)
            {
                Items.Add(item);
            }
        }

        public bool IsItemPresent(Item item)
        {
            var itemPresent = false;
            foreach (var x in Items)
            {
                if (Equals(x, item))
                {
                    itemPresent = true;
                }
            }
            return itemPresent;
        }
    }

    
}
