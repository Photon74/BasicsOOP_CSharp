using System;

namespace Bank
{
    public delegate void AccountHandler(string message);
    class BankAccount : IEquatable<BankAccount>
    {
        public static event AccountHandler Notify;
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

        public double AccountNumber { get; }
        public decimal AccountBalance { get; set; }
        internal AccountType AccountType { get; }

        /// <summary>
        /// Пополнение баланса
        /// </summary>
        /// <param name="amount">Сумма пополнения</param>
        public void Deposit(decimal amount)
        {
            Notify?.Invoke($"Попытка пополнить счет № {AccountNumber} на сумму: {amount:C2}.");

            if (amount <= 0)
            {
                throw new ArgumentException("Сумма пополнения должна быть больше нуля!");
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
                throw new ArgumentException($"Недостаточно средств для снятия!\nБаланс: {AccountBalance:C2}.");
            }

            AccountBalance -= amount;
            Notify?.Invoke($"Со счета № {AccountNumber} снято: {amount:C2}\nОстаток: {AccountBalance:C2}.\n");
        }

        /// <summary>
        /// Перевод между счетами
        /// </summary>
        /// <param name="other">Счет снятия</param>
        /// <param name="amount">Сумма перевода</param>
        public void TransferFrom(BankAccount other, decimal amount)
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

        public override bool Equals(object obj)
        {
            return Equals(obj as BankAccount);
        }

        public bool Equals(BankAccount other)
        {
            return other != null &&
                   AccountNumber == other.AccountNumber &&
                   AccountBalance == other.AccountBalance &&
                   AccountType == other.AccountType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AccountNumber, AccountBalance, AccountType);
        }

        public static bool operator ==(BankAccount account1, BankAccount account2) =>
            account1.AccountNumber == account2.AccountNumber &&
            account1.AccountBalance == account2.AccountBalance &&
            account1.AccountType == account2.AccountType;

        public static bool operator !=(BankAccount account1, BankAccount account2) =>
            account1.AccountNumber != account2.AccountNumber ||
            account1.AccountBalance != account2.AccountBalance ||
            account1.AccountType != account2.AccountType;
    }
}
