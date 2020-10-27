using System;
using Exercise_101;

namespace exercise_101
{
  class Program
  {
    public static void Main(string[] args)
    {
      Dalmatian spotty = new Dalmatian("Spot", 306);
      Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur");

    Dalmatian doggo = new Dalmatian("Doggo", 999);
    Console.WriteLine(doggo.name + " is a very good dog. He has " + doggo.spots + " darker spots in his fur");

    }
  }
}



