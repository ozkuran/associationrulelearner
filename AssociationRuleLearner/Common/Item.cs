using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Item
    {
        public Item()
        {
            Name = "Test Item";
            Guid = Guid.NewGuid();
        }

        public Item(string itemName)
        {
            Name = itemName;
            Guid = Guid.NewGuid();
        }
        public string Name { get; set; }
        public Guid Guid { get; set; }
    }
}
