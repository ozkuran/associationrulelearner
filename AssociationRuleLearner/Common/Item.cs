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

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Name.Equals(((Item)obj)?.Name);
        }

        public string Name { get; set; }
        public Guid Guid { get; set; }
    }

}
