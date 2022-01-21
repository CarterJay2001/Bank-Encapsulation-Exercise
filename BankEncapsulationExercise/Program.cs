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
                            if (!check1)
                            {
                                Console.WriteLine("I don't think I understand try again.\n");
                            }
                        }
                        NewAccount.Withdraw(amountWithdraw);
                        Console.WriteLine("\nIf you would like to perform another operator press 1 / To exit press enter.");
                        if (Console.ReadLine() != "1")
                        {
                            check = true;
                        }
                        break;
                    case 2:
                        bool check2 = false;
                        double amountDeposit = 0;
                        while (!check2)
                        {
                            Console.WriteLine("How much would you like to deposit?:");
                            check2 = double.TryParse(Console.ReadLine(), out amountDeposit);
                            if (!check2)
                            {
                                Console.WriteLine("I don't think I understand try again.\n");
                            }
                        }
                        NewAccount.Deposit(amountDeposit);
                        Console.WriteLine("\nIf you would like to perform another operator press 1 / To exit press enter.");
                        if (Console.ReadLine() != "1")
                        {
                            check = true;
                        }
                        break;
                    case 3:
                        Console.WriteLine($"\nYour current balance is: {NewAccount.GetBalance()}\n");
                        Console.WriteLine("\nIf you would like to perform another operator press 1 / To exit press enter.");
                        if (Console.ReadLine() != "1")
                        {
                            check = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nI'm not sure I understand. Taking back to Main Hub\n");
                        break;
                }
            }
        }
    }
}
