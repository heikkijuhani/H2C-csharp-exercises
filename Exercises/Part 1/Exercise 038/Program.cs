using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

           int i = 0;

           while (true) {

            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0){
                i++;
                }

                if (number == 0) {
                Console.WriteLine("Total amount of negative numbers: "+i);
                break;

                }
          
           }

    }
  }
}
