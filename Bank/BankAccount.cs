namespace Bank
{
    public delegate void AccountHandler(string message);
    class BankAccount
    {
        public event AccountHandler Notify;
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

        public BankAccount(decimal accountBalance) : this()
        {
            AccountBalance = accountBalance;
        }

        public BankAccount(AccountType accountType) : this()
        {
            AccountType = accountType;
        }

        public BankAccount(decimal accountBalance, AccountType accountType) : this()
        {
            AccountBalance = accountBalance;
            AccountType = accountType;
        }

        public double AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public decimal AccountBalance { get => _accountBalance; set => _accountBalance = value; }
        internal AccountType AccountType { get => _accountType; set => _accountType = value; }

        /// <summary>
        /// Пополнение баланса
        /// </summary>
        /// <param name="amount">Сумма пополнения</param>
        public void Deposit(decimal amount)
        {
            Notify?.Invoke($"Попытка пополнить счет № {AccountNumber} на сумму: {amount:C2}.");

            if (amount <= 0)
            {
                Notify?.Invoke($"Сумма пополнения должна быть больше нуля!\n");
                return;
            }

            AccountBalance += amount;
            Notify?.Invoke($"На счет № {AccountNumber} поступило: {amount:C2}\nБаланс: {AccountBalance:C2}.\n");
        }

        /// <summary>
        /// Списание с баланса
        /// </summary>
        /// <param name="amount">Сумма списания</param>
        public void Withdraw(decimal amount)
        {
            Notify?.Invoke($"Попытка снять со счета № {AccountNumber} сумму: {amount:C2}.");

            if (amount > AccountBalance)
            {
                Notify?.Invoke($"Недостаточно средств для снятия!\nБаланс: {AccountBalance:C2}.\n");
                return;
            }

            AccountBalance -= amount;
            Notify?.Invoke($"Со счета № {AccountNumber} снято: {amount:C2}\nОстаток: {AccountBalance:C2}.\n");
        }
    }
}
