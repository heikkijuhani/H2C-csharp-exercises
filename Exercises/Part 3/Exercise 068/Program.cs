using System;
using System.Collections.Generic;

namespace exercise_68
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
            for(int i = 0; i < list.Count; i++){
                    Console.WriteLine(list[i]);
                            }
          
         break;
        }
        list.Add(input);
      }

    }
  }
}
