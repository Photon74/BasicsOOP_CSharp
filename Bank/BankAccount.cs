namespace Bank
{
    class BankAccount
    {
        private double _accountNumber;
        private decimal _accountBalance;
        private AccountType _accountType;

        public void SetAccountNumber(double number)
        {
            _accountNumber = number;
        }

        public double GetAccountNumber()
        {
            return _accountNumber;
        }

        public void SetAccountBalance(decimal balance)
        {
            _accountBalance = balance;
        }

        public decimal GetAccountBalance()
        {
            return _accountBalance;
        }

        public void SetAccountType(AccountType accountType)
        {
            _accountType = accountType;
        }

        public AccountType GetAccountType()
        {
            return _accountType;
        }
    }
}
