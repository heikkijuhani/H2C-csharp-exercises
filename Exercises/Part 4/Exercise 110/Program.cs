using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();
            
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if(name != "")
                {
                    Item item = new Item(name);
                    items.Add(item);
                }
                if(name == "")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        Console.WriteLine(items[i]);
                    }
                    break;
                }
            }

            Console.ReadKey();
    }
  }
}




