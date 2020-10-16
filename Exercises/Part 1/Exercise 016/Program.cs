using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace exercise_16
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Write your code here:
            Console.WriteLine("How many days?");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(days * 86400);

        }
    }
}
