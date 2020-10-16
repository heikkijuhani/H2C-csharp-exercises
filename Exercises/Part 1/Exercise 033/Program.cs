using System;
using System.IO.Ports;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
            Console.WriteLine("Give the first string:");
            string firstAnswer = Console.ReadLine();

            Console.WriteLine("Give the second string:");
            string secondAnswer = Console.ReadLine();
           
            if (firstAnswer == secondAnswer) {
            Console.WriteLine("Echo!");
            } else {
            Console.WriteLine("Nope!");
                }

    }
  }
}
