using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_30
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write your code here:
            
            Console.WriteLine("Give your percent [0 - 100]:");
            int percent = Convert.ToInt32(Console.ReadLine());

            if (percent < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if (percent <= 49)
            {
                Console.WriteLine("Fail");
            }
            else if (percent <= 59)
            {
                Console.WriteLine("1");
            }
            else if (percent <= 69)
            {
                Console.WriteLine("2");
            }
            else if (percent <= 79)
            {
                Console.WriteLine("3");
            }
            else if (percent <= 89)
            {
                Console.WriteLine("4");
            }
            else if (percent <= 100)
            {
                Console.WriteLine("5");
            }
            else if (percent > 100)
            {
                Console.WriteLine("Outstanding!");
            }
        }
    }
}
