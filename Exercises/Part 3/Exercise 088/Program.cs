using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {

      while (true){
            string input = Console.ReadLine();
              if(input != ""){
                string[] words = input.Split( );
                Console.WriteLine(words[0]);
                                
              } else {
                break;
                }

            }



    }
  }
}