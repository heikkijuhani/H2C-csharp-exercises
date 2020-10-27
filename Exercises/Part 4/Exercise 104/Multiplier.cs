using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_104
{
    class Multiplier
    {
        int number { get; set; }

        public Multiplier(int number)
        {
            this.number = number;
                        
        }

        public int Multiply(int number)
        {
            int instanceValue = this.number * number;
            this.number = instanceValue;
            return instanceValue;
            
                       
            
        }
    }
}
