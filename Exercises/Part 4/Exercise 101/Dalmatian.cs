using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_101;

namespace Exercise_101
{
    public class Dalmatian
    {
        public string name { get; set; }
        public int spots { get; set; }

        public Dalmatian(string name, int spots)
        {
            this.name = name;
            this.spots = spots;
        }
    }
}
