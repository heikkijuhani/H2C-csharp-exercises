namespace exercise_118
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user for the file name and print the content of the file
            Console.WriteLine("Name of the file:");
            string file = Console.ReadLine();

            // DO NOT TOUCH THE CODE ABOVE!
            // implement reading the file here;

            List<String> names = File.ReadAllLines(file).ToList();

            // Oma listan koetulostus
            for (int i = 0; i < names.Count; i++)
            {
                Console.Write(names[i]+"| ");
            }
           

            // DO NOT TOUCH THE CODE BELOW!
            Console.WriteLine("");
            Console.WriteLine("Enter names, an empty line quits.");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                if (names.Contains(name))
                {
                    Console.WriteLine("The name is on the list.");
                }
                else
                {
                    Console.WriteLine("The name is not on the list.");
                }
            }

            Console.WriteLine("Thank you!");
        }
    }
}
