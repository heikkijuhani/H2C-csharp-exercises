using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write your code here:
            
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You're under age!");
            } else
            {
                Console.WriteLine("You're an adult!");
            }


        }
    }
}
