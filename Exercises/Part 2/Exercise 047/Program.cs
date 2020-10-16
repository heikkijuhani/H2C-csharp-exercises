using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int toNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int fromNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = fromNumber; i <= toNumber; i++){
            Console.WriteLine(i);
             }
      
    }
  }
}
