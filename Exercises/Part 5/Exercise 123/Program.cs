using System;
using Exercise_123;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter();

            counter.Increase();
            counter.Increase();
            counter.Increase();
            counter.Increase();
            counter.Increase();
            Console.WriteLine(counter.value); //5
            counter.Increase(10);
            Console.WriteLine(counter.value); //15
            counter.Increase(-10);
            Console.WriteLine(counter.value); //15

            counter.Decrease();
            counter.Decrease();
            counter.Decrease();
            counter.Decrease();
            counter.Decrease();

            Console.WriteLine(counter.value); //10
            counter.Decrease(5);
            Console.WriteLine(counter.value); //5
            counter.Decrease(-5);
            Console.WriteLine(counter.value); //5

            Console.ReadLine();

        }
  }
}
