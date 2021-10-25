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

        //private void SetAccountNumber()
        //{
        //    Number++;
        //    _accountNumber = Number;
        //}

        //public double GetAccountNumber()
        //{
        //    return _accountNumber;
        //}

        //public decimal GetAccountBalance()
        //{
        //    return _accountBalance;
        //}

        //public AccountType GetAccountType()
        //{
        //    return _accountType;
        //}
    }
}
