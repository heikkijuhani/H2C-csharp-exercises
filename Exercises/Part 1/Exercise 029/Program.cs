using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write your code here:
            
            Console.WriteLine("Give the first number!");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The larger number is " + firstNumber + "!");
            }
            if (secondNumber > firstNumber)
            {
                Console.WriteLine("The larger number is " + secondNumber + "!");
            }
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("They are equal!");
            }

        }
    }
}
