using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace exercise_13
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("Give a number!");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You gave "+number);
            
        }
    }
}
