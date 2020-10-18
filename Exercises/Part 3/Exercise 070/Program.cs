using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_70
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          Console.WriteLine("The grEatest number: "+list.Max());
          break;
        }
        list.Add(input);
                
      }

    }
  }
}
