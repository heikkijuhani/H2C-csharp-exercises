namespace Exercise_108
{
    internal class PaymentCard
    {
        internal double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        public void EatLunch()
        {
            if (balance >= 10.60) { 
            balance = balance - 10.60;
            }
        }

        public void DrinkCoffee()
        {
            if(balance >= 2.00) { 
            balance = balance - 2.00;
            }
        }

        public override string ToString()
        {
            // write code here
            return $"The card has a balance of {balance} euros";
        }
    }
}
