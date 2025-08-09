using System;

namespace lecture3task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double balance = 0;
            bool active = true;

            // Welcome message
            Console.WriteLine("=== Welcome to the ATM! ===");

            // While the ATM is active
            while (active)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1- Show Balance");
                Console.WriteLine("2- Deposit");
                Console.WriteLine("3- Withdraw");
                Console.WriteLine("4- Exit");
                Console.Write("Your choice as a Number: ");

                // Read user input
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Show balance
                        Console.WriteLine($"Your current balance is: {balance:C}");
                        break;
                    case "2":
                        // Deposit
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        if (depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"You have successfully deposited {depositAmount:C}. New balance: {balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Deposit amount must be positive.");
                        }
                        break;
                    case "3":
                        // Withdraw
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        if (withdrawAmount > 0 && withdrawAmount <= balance)
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"You have successfully withdrawn {withdrawAmount:C}. New balance: {balance:C}");
                        }
                        else if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Insufficient funds for this withdrawal.");
                        }
                        else
                        {
                            Console.WriteLine("Withdrawal amount must be positive.");
                        }
                        break;
                    case "4":
                        // Exit
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        active = false;
                        break;
                    default:
                        // Invalid choice
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
