using System;
using System.Diagnostics.Tracing;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
        Console.WriteLine("Give numbers:");
        int sum = 0;
        int i = 0;
        int even = 0;
        int odd = 0;

      while (true) {

        int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1){
                Console.WriteLine("Thx! Bye! \n"+
                    "Sum: "+sum+"\n"+
                    "Numbers: "+i+"\n"+
                    "Average: "+Convert.ToDouble((sum*1.0)/i)+"\n"+
                    "Even: "+even+"\n"+
                    "Odd: "+odd);
                break;
                } else {
                    if (number%2 == 0) {
                    even++;
                    } else {
                    odd++;
                    }
                sum = sum + number;
                i++;

                }

                    

            }
        Console.ReadKey();
    }
  }
}
