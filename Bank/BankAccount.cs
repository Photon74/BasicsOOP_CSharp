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
            SetAccountNumber();
            _accountBalance = 0;
            _accountType = AccountType.Deposit;
        }

        public BankAccount(decimal accountBalance)
        {
            SetAccountNumber();
            _accountBalance = accountBalance;
        }

        public BankAccount(AccountType accountType)
        {
            SetAccountNumber();
            _accountType = accountType;
        }

        public BankAccount(decimal accountBalance, AccountType accountType)
        {
            SetAccountNumber();
            _accountBalance = accountBalance;
            _accountType = accountType;
        }

        private void SetAccountNumber()
        {
            Number++;
            _accountNumber = Number;
        }

        public double GetAccountNumber()
        {
            return _accountNumber;
        }

        public decimal GetAccountBalance()
        {
            return _accountBalance;
        }

        public AccountType GetAccountType()
        {
            return _accountType;
        }
    }
}
