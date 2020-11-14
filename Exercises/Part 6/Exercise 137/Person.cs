namespace exercise_136
{
    using System;

    public class Person
    {
        private string name;

        private int age;

        public Person(string givenName)
        {
            this.name = givenName;
            this.age = 0;
        }

        public bool IsOfAge()
        {
            return (this.age >= 18);
        }

        public int HowManyNames()
        {
            // Do something here
            string personNames = this.ToString();
            var namesCount = personNames.Split(' ').Length;
            int numberOfNames = Convert.ToInt32(namesCount);



            return numberOfNames;
        }

        public void GrowOlder()
        {
            this.age++;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
