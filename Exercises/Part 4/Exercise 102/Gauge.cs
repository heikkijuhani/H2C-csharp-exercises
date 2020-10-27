using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_102
{
    class Gauge
    {
        public int value;

        public Gauge()
        {
            this.value = 0;
        }

        public void Increase()
        {
            if(value < 5)
            {
                value++;
            }
        }

        public void Decrease()
        {
            if(value > 0)
            {
                value--;
            }
        }

        public bool Full() {
            bool isFull = false;

            if (value == 5)
            {
                isFull = true;
            }

            return isFull;


        }

    }
}
