using System;

namespace Trial
{
   public  class AD
    {
        public void Deposit(int amount)
        {

            if (amount <= 0)
            {
                Console.WriteLine("Cannot deposit as amount is less than 0");
            }
            else
            {
                int totalBalance = Balance + amount;
                A1.Balance = totalBalance;
                Console.WriteLine("deposit done  " + totalBalance);
            }
        }

        public void Withdrawl(Account A1, int amount)
        {
            if (amount <= 0)
                Console.WriteLine("Cannnot withdraw as amount is less than 0");
            else if (A1.Balance <= 0)
            {
                Console.WriteLine("Cannnot withdraw as Balance is less than 0");

            }
            else if (A1.Balance - amount < 0)
            {
                Console.WriteLine("Cannnot withdraw as amount withdrawing is more than balance avaialble");
            }
            else
            {
                int totalBalance = A1.Balance - amount;

                A1.Balance = totalBalance;
                Console.WriteLine("withdraw complete   " + totalBalance);
            }

        }

        public void Retireval()
        {
            int totalBalance = A1.Balance;

            Console.WriteLine("Available Balance is " + A1.Balance);

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
