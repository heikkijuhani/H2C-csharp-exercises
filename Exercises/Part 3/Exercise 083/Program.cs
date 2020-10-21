using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_83
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.Write("Give a word: ");
        string wordThreeTimes = String.Concat(Enumerable.Repeat(Console.ReadLine(),3));
        
        Console.WriteLine(wordThreeTimes);
         
            Console.ReadKey();
    }

  }
}

