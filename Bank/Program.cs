using System;

namespace Bank
{
    class Program
    {
        static void Main()
        {
            BankAccount bankAccount = new();

            bankAccount.SetAccountBalance(500);
            bankAccount.SetAccountType(AccountType.Deposit);

            Console.WriteLine(
                $"Номер счета: {bankAccount.GetAccountNumber()}\n" +
                $"Баланс счета: {bankAccount.GetAccountBalance()}\n" +
                $"Тип счета: {bankAccount.GetAccountType()}"
                );
        }
    }
}
