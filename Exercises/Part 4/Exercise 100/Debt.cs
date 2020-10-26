using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_100;

namespace Exercise_100
{
    public class Debt

    {
        double balance;
        double interestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine(balance);
        }

        public void WaitOneYear()
        {
            balance = balance * interestRate;
        }

    }
}
