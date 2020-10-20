using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
     
      Console.WriteLine("Search for?");           
      string name = Console.ReadLine();
      bool found = true;

            for (int i = 0; i < list.Count; i++){
            if (name.Equals(list[i])) {
                found = true;
             } else {
                found = false;
                 }
            }
        if(found == true){
            Console.WriteLine(name+" was found!");
        } else {
            Console.WriteLine(name+" was not found!");
            }
        Console.ReadKey();        
     }   
    }
    }
      


