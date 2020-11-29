using System;
using System.Collections.Generic;
using exercise_131;

namespace exercise_131
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            // Ask for input as shown in the exercise.
            string identifier;
            string name;

            while (true)
            {
                Console.WriteLine("Identifier? (empty will stop):");
                identifier = Console.ReadLine();
                if (identifier == "")
                {
                    break;
                } 
                    
                Console.WriteLine("Name? (empty will stop):");
                name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }
                
                Item item = new Item(identifier, name);

                items.Add(item);

                for (int i = 0; i < items.Count-1; i++)
                {
                    if (item.Equals(items[i]))
                    {
                        Console.WriteLine("oli jo ja poistetaan");
                        items.RemoveAt(items.Count-1);
                    }
                }

                

              

            }

        
            

            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}
  

