using System;
using System.Collections.Generic;

namespace exercise_69
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
          Console.WriteLine("From where?");
          int from = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Where to?");
          int to = Convert.ToInt32(Console.ReadLine());

          for (int i = 0; i < list.Count; i++){
                    if (list[i] >= from && list[i] <= to){
                        Console.WriteLine(list[i]);
                                }

                    }

          break;
        }
        list.Add(input);
      }

    }
  }
}
