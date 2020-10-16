using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

           int sum = 0;

           while (true) {

            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0) {
                Console.WriteLine("Total sum of numbers: "+sum);
                break;

                } else {
                sum = sum + number;
                }
          
           }

           Console.ReadKey();
    }
  }
}
