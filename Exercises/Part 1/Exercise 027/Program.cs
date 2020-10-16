using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write your code here:
            
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("It is positive");
            } else
            {
                Console.WriteLine("It is not positive");
            }



        }
    }
}
