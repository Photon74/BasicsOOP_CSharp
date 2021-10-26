using System;
using System.Text;

namespace Bank
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // Иначе вопросики выводил вместо знака рубля.

            BankAccount bankAccount = new();
            bankAccount.Notify += message => Console.WriteLine(message);

            BankAccount bankAccount1 = new(accountBalance: 500);
            BankAccount bankAccount2 = new(accountType: AccountType.Credit);
            BankAccount bankAccount3 = new(accountBalance: 358, accountType: AccountType.Deposit);


            Console.WriteLine(
                $"Номер счета: {bankAccount.AccountNumber}\n" +
                $"Баланс счета: {bankAccount.AccountBalance:C}\n" +
                $"Тип счета: {bankAccount.AccountType}\n"
                );

            Console.WriteLine(
                $"Номер счета: {bankAccount1.AccountNumber}\n" +
                $"Баланс счета: {bankAccount1.AccountBalance:C}\n" +
                $"Тип счета: {bankAccount1.AccountType}\n"
                );

            Console.WriteLine(
                $"Номер счета: {bankAccount2.AccountNumber}\n" +
                $"Баланс счета: {bankAccount2.AccountBalance:C}\n" +
                $"Тип счета: {bankAccount2.AccountType}\n"
                );

            Console.WriteLine(
                $"Номер счета: {bankAccount3.AccountNumber}\n" +
                $"Баланс счета: {bankAccount3.AccountBalance:C}\n" +
                $"Тип счета: {bankAccount3.AccountType}\n"
                );

            bankAccount.Deposit(0);
            bankAccount.Deposit(100);
            bankAccount.Withdraw(200);
            bankAccount.Withdraw(50);
        }
    }
}
