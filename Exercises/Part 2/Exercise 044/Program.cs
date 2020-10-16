using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

        int firsNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firsNumber > secondNumber){
            Console.WriteLine(firsNumber+" is grEater than "+secondNumber+".");
            }
        if (firsNumber < secondNumber){
        Console.WriteLine(firsNumber+" is less than "+secondNumber+".");
        }

        if (firsNumber == secondNumber){
        Console.WriteLine(firsNumber+" is equal to "+secondNumber+".");
        }

        
      Console.ReadKey();      


    }
  }
}
