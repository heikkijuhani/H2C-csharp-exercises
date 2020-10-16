using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      
           int sum = 0;
           int i = 0;

           while (true) {

            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0) {
                Console.WriteLine("Total sum of numbers: "+sum);
                Console.WriteLine("Total amount of numbers: "+i);
                break;

                } else {
                sum = sum + number;
                i++;
                }
          
           }
    }
  }
}
