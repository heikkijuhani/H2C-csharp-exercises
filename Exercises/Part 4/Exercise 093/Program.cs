using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
            
            
           Account heikkiKumparesAccount = new Account("Heikki Kumpare's account", 100.00);
           heikkiKumparesAccount.Deposit(20.00);
            Console.WriteLine(heikkiKumparesAccount.balance);

            Console.ReadKey();
    }

  }
}



