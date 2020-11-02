using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise_119;
using Exercise_119;

namespace Exercise_119
{
    

    class Timer
    {
        public int value;

        ClockHand hunreds = new ClockHand(100);
        ClockHand seconds = new ClockHand(60);


        public Timer()
        {

        }

        public void Advance()
        {
            this.hunreds.value++;
            if (this.hunreds.value > 99)
            {
                this.hunreds.value = 0;
                this.seconds.value++;
            }

        }

        public override string ToString()
        {
            return seconds + ":" + hunreds;

        }
    }
}

