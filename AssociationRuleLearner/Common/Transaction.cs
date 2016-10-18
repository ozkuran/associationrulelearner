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

        public List<Item> Items { get; set; }
    }
}
