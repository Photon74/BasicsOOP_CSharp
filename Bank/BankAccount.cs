using System;

namespace Bank
{
    class BankAccount
    {
        private static double Number;

        public BankAccount()
        {
            AccountNumber = ++Number;
            AccountBalance = 0;
            AccountType = AccountType.Deposit;
        }

        public BankAccount(decimal accountBalance) : this() => AccountBalance = accountBalance;

        public BankAccount(AccountType accountType) : this() => AccountType = accountType;

        public BankAccount(decimal accountBalance, AccountType accountType) : this()
        {
            AccountBalance = accountBalance;
            AccountType = accountType;
        }

        public double AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        internal AccountType AccountType { get; set; }

        /// <summary>
        /// Пополнение баланса
        /// </summary>
        /// <param name="amount">Сумма пополнения</param>
        public void Deposit(decimal amount)
        {
            if (amount <= 0) return;

            AccountBalance += amount;
        }

        /// <summary>
        /// Списание с баланса
        /// </summary>
        /// <param name="amount">Сумма списания</param>
        public void Withdraw(decimal amount)
        {
            if (amount > AccountBalance)
            {
                throw new ArgumentException($"Недостаточно средств для снятия!\nБаланс: {AccountBalance:C2}.\n");
            }

            AccountBalance -= amount;
        }

        /// <summary>
        /// Перевод между счетами
        /// </summary>
        /// <param name="other">Счет снятия</param>
        /// <param name="amount">Сумма перевода</param>
        public void Transfer(BankAccount other, decimal amount)
        {
            other.Withdraw(amount);
            Deposit(amount);
        }

        public override string ToString()
        {
            return $"Номер счета: {AccountNumber}\n" +
                $"Баланс счета: {AccountBalance:C}\n" +
                $"Тип счета: {AccountType}\n";
        }
    }
}
