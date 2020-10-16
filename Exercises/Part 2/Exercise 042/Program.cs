using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(firstNumber + secondNumber));
   
    }
  }
}
