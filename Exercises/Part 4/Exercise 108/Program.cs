namespace exercise_108
{
    using Exercise_108;
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);

            Console.ReadKey();
        }
    }
}
