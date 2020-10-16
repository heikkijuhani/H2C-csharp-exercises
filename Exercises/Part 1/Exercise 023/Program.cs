using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write your code here:
            int i = 0;
            Console.WriteLine("Give the first number!");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Give the second number!");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
           
            double firstDouble = Convert.ToDouble(firstNumber);
            double secondDouble = Convert.ToDouble(secondNumber);
            
            Console.WriteLine(firstNumber+ " + " + secondNumber + " = "+ firstNumber+secondNumber);
            Console.WriteLine(firstNumber+ " - " + secondNumber + " = "+ (firstNumber-secondNumber));
            Console.WriteLine(firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
            Console.WriteLine(firstDouble + " / " + secondDouble + " = " + (firstDouble / secondDouble));

        }
    }
}
