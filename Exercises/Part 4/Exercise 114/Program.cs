using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "end")
                {
                    Console.WriteLine(i);
                    break;
                } else
                {
                    i++;
                }

            }

            Console.ReadKey();
        }
    }
}
