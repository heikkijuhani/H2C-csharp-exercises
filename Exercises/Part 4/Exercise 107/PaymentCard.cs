using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_107
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;

        }
        public void EatLunch()
        {
            balance = balance - 10.60;
        }

        public void DrinkCoffee()
        {
            balance = balance - 2.00;
        }


        public override string ToString()
        {
            // write code here
            return $"The card has a balance of {balance} euros";
        }
    }
}