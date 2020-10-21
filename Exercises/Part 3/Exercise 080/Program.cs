using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_80
{
  class Program
  {
    public static void Main(string[] args)
    {
      int[] numbers = { 5, 1, 3, 4, 2 };
      int sum = SumOfNumbersInArray(numbers);
      Console.WriteLine(sum);

    }

    public static int SumOfNumbersInArray(int[] numbers) {

      return numbers.Sum();
    }

  }
}


