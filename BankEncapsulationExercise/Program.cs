using System;
using System.Linq;
using System.Collections.Generic;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var NewAccount = new BankAccount();
            bool check = false;
            int userInput = 0;

            while (!check)
            {
                while (!check)
                {
                    Console.WriteLine("Welcome to Jaylon's Banking Services!" +
                        "\nWould you like to:" +
                        "\nWithdraw (press 1 and enter)" +
                        "\nDeposit (press 2 and enter)" +
                        "\nView Balance (press 3 and enter)");

                    check = int.TryParse(Console.ReadLine(), out userInput);
                    if (!check)
                    {
                        Console.WriteLine("\nI'm not sure I understand. Taking back to Main Hub");
                    }
                }
                check = false;


                switch (userInput)
                {
                    case 1:
                        bool check1 = false;
                        double amountWithdraw = 0;
                        while (!check1)
                        {
                            Console.WriteLine("How much would you like to withdraw?:");
                            check1 = double.TryParse(Console.ReadLine(), out amountWithdraw);
                            if (!check)
                            {
                                Console.WriteLine();
                            }
                        }
                        NewAccount.Withdraw(amountWithdraw);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("How much would you like to deposit?:");
                        var amountDeposit = double.Parse(Console.ReadLine());
                        NewAccount.Deposit(amountDeposit);
                        break;
                    case 3:
                        Console.WriteLine($"\nYour current balance is: {NewAccount.GetBalance()}\n");
                        break;
                    default:
                        Console.WriteLine("\nI'm not sure I understand. Taking back to Main Hub\n");
                        break;
                }
            }
        }
    }
}
