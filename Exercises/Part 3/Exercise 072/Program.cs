using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          Console.WriteLine("Smallest number: "+list.Min());
                  for (int i = 0; i < list.Count; i++){
                    if (list[i] == list.Min()){
                        Console.WriteLine("Found at index: "+i);
                                }}

          break;
        }
        list.Add(input);
      }


    }
  }
}