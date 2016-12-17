using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ApplicationConfiguration
    {
        public ApplicationConfiguration()
        {
            DataFiles = new List<string>();
        }

        public List<string> DataFiles { get; set; }
    }
}
