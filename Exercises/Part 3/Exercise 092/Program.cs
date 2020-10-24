using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      int born;
      int age;
      int bigestAge = 0;
      string longestName = "";
      string name;
      while (true){
            
            string input = Console.ReadLine();
              if(input != ""){
                string[] nameAndBorn = input.Split(',');
                name = nameAndBorn[0];
                born = Convert.ToInt32(nameAndBorn[1]);
                age = 2020 - born;

                if (bigestAge < age){
                    bigestAge = age;
                            }
                if (longestName.Length < name.Length){
                    longestName = name;
                            }

                                
              } else {
                Console.WriteLine("Longest name: "+longestName);
                Console.WriteLine("Highest age: "+bigestAge);
                break;
                }

            }
    }
  }
}