using System;
namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double balance = 0;

        public BankAccount()
        {
        }

        public void Deposit(double deposit)
        {
            balance += deposit;
        }

        public void Withdraw(double withdraw)
        {
            balance -= withdraw;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
