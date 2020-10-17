using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
        Console.WriteLine("How many times?");
        int times = Convert.ToInt32(Console.ReadLine());
        PrintPhrase(times);

    }

    // Write your method here:
    public static void PrintPhrase(int times) {
            for (int i = 0; i < times; i++){
                Console.WriteLine("In a hole in the ground there lived a method");
            }
            


    }
  }
}
