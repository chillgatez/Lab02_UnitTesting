using System;
namespace Lab02_UnitTesting
{
    internal class Program
    {
        static public decimal Balance = 0;

        static void Main(string[] args)
        {
            UserInterface();
        }
        static public decimal ViewBalance()
        {
            return Balance;
        }

    }
}