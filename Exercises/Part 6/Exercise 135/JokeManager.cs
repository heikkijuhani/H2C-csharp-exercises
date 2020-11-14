using System;
using System.Collections.Generic;

namespace exercise_135
{
    class JokeManager
    {
        List<String> jokes = new List<string>();
        public JokeManager()
        {

        }

        public void AddJoke(string joke)
        {
            jokes.Add(joke);

        }

        public string DrawJoke()
        {
            Random random = new Random();
            int i = random.Next(0, jokes.Count);

            return jokes[i];
        }

        public void PrintJokes()
        {
            for (int i = 0; i < jokes.Count; i++)
            {
                Console.WriteLine(jokes[i]);
            }
        }





    }
}