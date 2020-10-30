namespace exercise_115
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "end")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Math.Pow((Convert.ToInt32(inputString)), (3.0)));



                }

            }
        }
    }
}
