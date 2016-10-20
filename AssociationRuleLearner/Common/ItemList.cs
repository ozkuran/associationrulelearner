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
    }

    
}
