using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>();

            while (true)
            {
                Console.WriteLine("First name:");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    for (int i = 0; i < list.Count; i++)
                        Console.WriteLine(list[i].firstName + " " + list[i].lastName);
                        break;
                    }
                Console.WriteLine("Last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Identification number:");
                string id = Console.ReadLine();

                PersonalInformation person = new PersonalInformation(firstName, lastName, id);
                list.Add(person);

            }

            Console.ReadKey();
    }
  }
}




