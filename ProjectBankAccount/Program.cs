using System;
using ProjectBankAccount.Entities;
using ProjectBankAccount.Entities.Exceptions;
using System.Globalization;

namespace ProjectBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.WriteLine();
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, initialBalance, withdrawLimit);
                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(withdraw);
                Console.WriteLine();
                Console.Write("Nem balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (AccountException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
