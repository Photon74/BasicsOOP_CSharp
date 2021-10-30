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

            Console.WriteLine(bankAccount);
            Console.WriteLine(bankAccount1);
            Console.WriteLine(bankAccount2);
            Console.WriteLine(bankAccount3);

            bankAccount.Deposit(500);
            bankAccount1.Transfer(bankAccount, 200);
        }
    }
}
