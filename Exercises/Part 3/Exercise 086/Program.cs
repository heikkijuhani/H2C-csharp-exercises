using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true){
            string input = Console.ReadLine();
              if(input != ""){
                string[] words = input.Split( );
                        for(int i = 0; i < words.Length; i++){
                            Console.WriteLine(words[i]);
                    }
              } else {
                break;
                }

            }



    }
  }
}

