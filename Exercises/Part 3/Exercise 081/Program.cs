using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = {5, 1, 3, 4, 2};
      PrintNEatly(array);
            
    }

    public static void PrintNEatly(int[] array)
    {
            Console.Write(String.Join(", ", array));
            }

    }
  }


