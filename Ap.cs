using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Trial
{


    public class Ap
    {
        static void Main(string[] args)
        {
            Ap A1 = new Ap();
            A1.Deposit(5000);
          //  P1.Withdrawl(A1, 7000);
            //P1.Retireval(A1);
            //Console.ReadKey();
        }
        public int accN { get; set; }
        public int accB { get; set; }
        public string accH { get; set; }
        public Ap()

        {
            accB = 0;
            accH = "Soumya";
            accN = 1236547890;
        }
        public void Deposit(int amount)
        {

            if (amount <= 0)
            {
                Console.WriteLine("Cannot deposit as amount is less than 0");
            }
            else
            {
                int totalBalance = accB + amount;
                accB = totalBalance;
                Console.WriteLine("deposit done  " + totalBalance);
            }
        }

        public void Withdrawl(int amount)
        {
            if (amount <= 0)
                Console.WriteLine("Cannnot withdraw as amount is less than 0");
            else if (accB <= 0)
            {
                Console.WriteLine("Cannnot withdraw as Balance is less than 0");

            }
            else if (accB - amount < 0)
            {
                Console.WriteLine("Cannnot withdraw as amount withdrawing is more than balance avaialble");
            }
            else
            {
                int totalBalance = accB - amount;

                accB = totalBalance;
                Console.WriteLine("withdraw complete   " + totalBalance);
            }

        }

        public void Retireval()
        {
            int totalBalance = accB;

            Console.WriteLine("Available Balance is " + accB);

        }


       
        
          //  P1.Withdrawl(A1, 7000);
           // P1.Retireval(A1);
 
    }


   

}
