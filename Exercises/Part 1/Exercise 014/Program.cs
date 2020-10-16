using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace exercise_14
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me the truth!");
            // Write your code here:
            string truth = Console.ReadLine();
            bool booleanValue = System.Convert.ToBoolean(truth);
            Console.WriteLine(booleanValue);

        }
    }
}
