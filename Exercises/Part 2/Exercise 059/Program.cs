using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = GrEatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
            Console.ReadKey();

    }

    // Write your method here:
    public static int GrEatest(int number1, int number2, int number3) 
      {
  // write your code here
  // do not print anything inside the method
                    if (number1 > number2 && number1 > number3)  {
                return number1;
            } else if (number2 > number1 && number2 > number3) {
                return number2;
            } else {
                return number3;
            }
     

  // there must be a return command at the end
    }

        

  }
}
