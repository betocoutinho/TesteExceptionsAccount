using System;
using System.Globalization;
using TesteExceptionsAccount.Entities;
using TesteExceptionsAccount.Entities.Exceptions;

namespace TesteExceptionsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.WriteLine("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Holder: ");
                string holder = Console.ReadLine();
                Console.WriteLine("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account c1 = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1.Withdraw(amount);

                Console.WriteLine("New balance: " + c1.Balance);
            }
            catch (ExceptionAccount e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
