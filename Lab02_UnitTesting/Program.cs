using System;
namespace Lab02_UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface();
        }

        static public decimal Balance = 0;



        static public decimal ViewBalance()
        {
            return Balance;
        }
        static public decimal Withdraw(decimal amount)
        {
            return amount;
        }
        static public decimal Deposit(decimal amount)
        {
            return amount;
        }
    }
}