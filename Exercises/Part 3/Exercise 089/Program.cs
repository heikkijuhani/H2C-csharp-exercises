using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true){
            string input = Console.ReadLine();
              if(input != ""){
                string[] words = input.Split( );
                Console.WriteLine(words[words.Length-1]);
                                
              } else {
                break;
                }

            }



    }
  }
}