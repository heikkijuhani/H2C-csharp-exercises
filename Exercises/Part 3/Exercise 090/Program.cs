using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int bigestAge = 0;
      while (true){
            
            string input = Console.ReadLine();
              if(input != ""){
                string[] nameAndAge = input.Split(',');
               
                int age = Convert.ToInt32(nameAndAge[1]);
                if (bigestAge < age){
                    bigestAge = age;
                            }
                                
              } else {
                Console.WriteLine("Age of the oldest: "+bigestAge);
                break;
                }

            }

    }
  }
}