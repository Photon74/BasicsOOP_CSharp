using System;
using System.Text;

namespace Bank
{
    class Program
    {
        static void Main()
        {
            BankAccount bankAccount = new();
            BankAccount bankAccount1 = new(accountBalance: 500);
            BankAccount bankAccount2 = new(accountType: AccountType.Credit);
            BankAccount bankAccount3 = new(accountBalance: 358, accountType: AccountType.Deposit);

            Console.OutputEncoding = Encoding.UTF8; // Иначе вопросики выводил вместо знака рубля.
            Console.WriteLine(
                $"Номер счета: {bankAccount.GetAccountNumber()}\n" +
                $"Баланс счета: {bankAccount.GetAccountBalance():C}\n" +
                $"Тип счета: {bankAccount.GetAccountType()}\n"
                );

            Console.WriteLine(
                $"Номер счета: {bankAccount1.GetAccountNumber()}\n" +
                $"Баланс счета: {bankAccount1.GetAccountBalance():C}\n" +
                $"Тип счета: {bankAccount1.GetAccountType()}\n"
                );

            Console.WriteLine(
                $"Номер счета: {bankAccount2.GetAccountNumber()}\n" +
                $"Баланс счета: {bankAccount2.GetAccountBalance():C}\n" +
                $"Тип счета: {bankAccount2.GetAccountType()}\n"
                );

            Console.WriteLine(
                $"Номер счета: {bankAccount3.GetAccountNumber()}\n" +
                $"Баланс счета: {bankAccount3.GetAccountBalance():C}\n" +
                $"Тип счета: {bankAccount3.GetAccountType()}\n"
                );

            //Console.WriteLine(
            //    $"Номер счета: {bankAccount4.GetAccountNumber()}\n" +
            //    $"Баланс счета: {bankAccount4.GetAccountBalance()}\n" +
            //    $"Тип счета: {bankAccount4.GetAccountType()}"
            //    );
        }
    }
}
