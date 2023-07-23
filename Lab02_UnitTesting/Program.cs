using System;
namespace Lab02_UnitTesting
{
    public static class Program
    {
        public static decimal Balance = 0;

        public static void Main()
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            Console.WriteLine("Welcome to Code Crew Credit Union");
            string? userSelection;
            bool exit = false;

            do
            {
                Console.WriteLine("Please select your desired transaction");
                Console.WriteLine("v. View Balance");
                Console.WriteLine("w. Withdraw");
                Console.WriteLine("d. Deposit");
                Console.WriteLine("e. Exit");

                userSelection = Console.ReadLine();

                if (userSelection == "v")
                {
                    Console.WriteLine($"Current Balance: {ViewBalance()}");
                }
                else if (userSelection == "w")
                {
                    Console.WriteLine("Enter witdrawal amount:");
                    decimal withdrawalAmount;
                    if (decimal.TryParse(Console.ReadLine(), out withdrawalAmount))
                    {
                        decimal withdrawnAmount = Withdraw(withdrawalAmount);
                        if (withdrawnAmount > 0)
                            Console.WriteLine($"Successfully withdrawn: {withdrawnAmount}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawl amount. Please enter a valid decimal value.");
                    }
                }
                else if (userSelection == "d")
                {
                    Console.WriteLine("Enter the deposit amount:");
                    decimal depositAmount;
                    if (decimal.TryParse(Console.ReadLine(), out depositAmount))
                    {
                        decimal depositedAmount = Deposit(depositAmount);
                        if (depositedAmount > 0)
                            Console.WriteLine($"Successfully deposited: {depositedAmount}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount. Please enter a valid decimal value.");
                    }
                }
                else if (userSelection == "e")
                {
                    Console.WriteLine("Thank you for banking with Code Crew Credit Union Exiting application...");
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please select 'v' to viewbalance, 'w' to make a withdrawal, 'd' to make a deposit or 'e' to end transaction.");
                }
            } while (!exit);
        }

        public static decimal ViewBalance()
        {
            return Balance;

        }

        public static decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Please enter amount greater than zero.");
                return 0;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds. Unable to withdraw the requested amount.");
                return 0;
            }

            Balance -= amount;
            return amount;
        }
        public static decimal Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
                return 0;
            }

            Balance += amount;
            return amount;
        }
    }
}