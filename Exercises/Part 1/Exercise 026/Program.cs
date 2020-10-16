using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write your code here:
            
            Console.WriteLine("Give your age:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 1900)
            {
                Console.WriteLine("You're old");
            }


        }
    }
}
