namespace exercise_136
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Person ada = new Person("Ada Lovelace");
            Person jack = new Person("Jack The Ripper");
            Person mike = new Person("Mike The Incredible Magic Mouse");

            HowManyNames(ada);
            HowManyNames(jack);
            HowManyNames(mike);
            Console.ReadKey();
        }

        public static void HowManyNames(Person person)
        {

            string personNames = person.ToString();
            var namesCount = personNames.Split(' ').Length;

            Console.WriteLine(personNames + " has " + namesCount + " names.");
        }
    }
}
