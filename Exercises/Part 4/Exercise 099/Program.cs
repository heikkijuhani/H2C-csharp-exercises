﻿using System;

namespace exercise_99
{
  class Program
  {
    public static void Main(string[] args)
    {

      DecreasingCounter counter = new DecreasingCounter(2);
      counter.PrintValue();
            counter.Decrement();
            counter.PrintValue();

            counter.Decrement();
            counter.PrintValue();
            counter.Decrement();
            counter.PrintValue();
            counter.Decrement();
            counter.PrintValue();

            counter.Reset();
      counter.PrintValue();

            Console.ReadKey();
    }
  }
}



