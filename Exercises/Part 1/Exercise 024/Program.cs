using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write your code here:
            
            Console.WriteLine("Your speed:");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed > 120)
            {
                Console.WriteLine("Seeding!");
            }


        }
    }
}
