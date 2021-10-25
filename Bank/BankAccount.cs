using System;

namespace Bank
{
    class BankAccount
    {
        private static double Number;
        private double _accountNumber;
        private decimal _accountBalance;
        private AccountType _accountType;

        public BankAccount()
        {
            AccountNumber = ++Number;
            AccountBalance = 0;
            AccountType = AccountType.Deposit;
        }

        public BankAccount(decimal accountBalance)
        {
            AccountNumber = ++Number;
            AccountBalance = accountBalance;
        }

        public BankAccount(AccountType accountType)
        {
            AccountNumber = ++Number;
            AccountType = accountType;
        }

        public BankAccount(decimal accountBalance, AccountType accountType)
        {
            AccountNumber = ++Number;
            AccountBalance = accountBalance;
            AccountType = accountType;
        }

        public double AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public decimal AccountBalance { get => _accountBalance; set => _accountBalance = value; }
        internal AccountType AccountType { get => _accountType; set => _accountType = value; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) return;
            AccountBalance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > AccountBalance) return;
            AccountBalance -= amount;
        }
    }
}
