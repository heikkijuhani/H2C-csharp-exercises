using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!

             Account heikkiKumparesAccount = new Account("Heikki Kumpare's account", 1000.00);
             Account personalAccount = new Account("Personal account", 00.00);

            heikkiKumparesAccount.Withdrawal(100.0);
            personalAccount.Deposit(100.0);

            Console.WriteLine(heikkiKumparesAccount);
            Console.WriteLine(personalAccount);


        }
  }
}



