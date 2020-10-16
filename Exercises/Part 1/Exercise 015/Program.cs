using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace exercise_15
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("Give a string:");
            string word = Console.ReadLine();
            
            Console.WriteLine("Give a integer:");
            string answer = Console.ReadLine();
            int intNumber = System.Convert.ToInt32(answer);

            Console.WriteLine("Give a double:");
            answer = Console.ReadLine();
            double doubleNumber = System.Convert.ToDouble(answer);

            Console.WriteLine("Give a boolean:");
            answer = Console.ReadLine();
            bool booleanValue = System.Convert.ToBoolean(answer);
            
            Console.WriteLine("Your string: " + word);
            Console.WriteLine("Your integer: " + intNumber);
            Console.WriteLine("Your double: " + doubleNumber);
            Console.WriteLine("Your string: " + booleanValue);


        }
    }
}
