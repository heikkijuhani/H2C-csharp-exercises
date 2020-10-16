using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace exercise_18
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Write your code here:
            Console.WriteLine("Give the first number!");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the third number!");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("The sum is "+sum);
        }
    }
}
