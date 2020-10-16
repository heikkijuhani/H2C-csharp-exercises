using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
         while (true) {

            Console.WriteLine("Do you want to continue?");
            int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 42) {
                break;
                }

          
            }

    }
  }
}
