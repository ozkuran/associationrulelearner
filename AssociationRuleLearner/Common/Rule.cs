using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Rule
    {
        public Rule()
        {
            
        }

        public Rule(List<Item> items, double support, double confidence)
        {
            Items = items;
            Support = support;
            Confidence = confidence;
        }

        public List<Item> Items { get; set; }
        public double Support { get; set; }
        public double Confidence { get; set; }

    }
}
