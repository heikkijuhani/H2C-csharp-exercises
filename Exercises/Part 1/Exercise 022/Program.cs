using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace exercise_22
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Write your code here:
            int i = 0;
            Console.WriteLine("Give the first number!");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            i++;
            Console.WriteLine("Give the second number!");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            i++;
            Console.WriteLine("Give the second third!");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            i++;
            double firstDouble = Convert.ToDouble(firstNumber);
            double secondDouble = Convert.ToDouble(secondNumber);
            double thirdDouble = Convert.ToDouble(thirdNumber);
            double sum = firstDouble + secondDouble + thirdDouble;
            double average = (sum / i)*1.0;
            Console.WriteLine("The average is "+average);

        }
    }
}
