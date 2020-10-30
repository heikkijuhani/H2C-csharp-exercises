namespace exercise_117
{
    using System;
    using System.IO;

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user for the file name and print the content of the file

            Console.WriteLine("Which file should have its contents printed?");
            string file = Console.ReadLine();
            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }


            Console.ReadKey();
        }
    }
}
