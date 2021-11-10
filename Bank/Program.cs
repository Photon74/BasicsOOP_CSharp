using System;
using System.Text;

namespace Bank
{
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // Иначе вопросики выводил вместо знака рубля.

            BankAccount bankAccount1 = new();
            BankAccount bankAccount2 = new(accountBalance: 500);
            BankAccount bankAccount3 = new(accountType: AccountType.Credit);
            BankAccount bankAccount4 = new(accountBalance: 358, accountType: AccountType.Deposit);

            Console.WriteLine(bankAccount1);
            Console.WriteLine(bankAccount2);
            Console.WriteLine(bankAccount3);
            Console.WriteLine(bankAccount4);

            bankAccount1.Deposit(250);
            bankAccount2.TransferFrom(bankAccount1, 200);
        }
    }
}
