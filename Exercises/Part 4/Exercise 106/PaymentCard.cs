using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_106
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;

        }

        public override string ToString()
        {
            // write code here
            return $"The card has a balance of {balance} euros";
        }
    }
}
