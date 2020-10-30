using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
            // IMPLEMENT YOUR CODE IN HERE!
            List<TelevisionProgram> televisionPrograms = new List<TelevisionProgram>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if(name == "")
                {
                    Console.WriteLine("Program's maximum duration? ");
                    int maxDuration = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i < televisionPrograms.Count; i++)
                    {
                        if(televisionPrograms[i].duration <= maxDuration)
                        {
                            Console.WriteLine(televisionPrograms[i]);
                        }
                    }
                    break;
                }
                Console.Write("Duration: ");
                int duaration = Convert.ToInt32(Console.ReadLine());

                TelevisionProgram program = new TelevisionProgram(name, duaration);
                televisionPrograms.Add(program);


            }

            Console.ReadKey();

    }
  }
}




