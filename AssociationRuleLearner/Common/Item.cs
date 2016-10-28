using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Item : IComparable
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

        public override string ToString()
        {
            return Name.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Item otherItem = obj as Item;
            if (otherItem != null)
                return string.Compare(this.Name, otherItem.Name, StringComparison.Ordinal);
            else
                throw new ArgumentException("Object is not an Item");
        }

        public string Name { get; set; }
        public Guid Guid { get; set; }
    }

}
