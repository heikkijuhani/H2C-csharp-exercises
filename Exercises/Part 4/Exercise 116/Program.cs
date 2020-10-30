using System;
using System.IO;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
            // Read the file data.txt and print the text from it as it is
            // You can use either File.ReadAllText or File.ReadAllLines

            string file = "data.txt";
            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }

            Console.ReadKey();
    }
  }
}
