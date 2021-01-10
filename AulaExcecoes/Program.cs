using System;
using AulaExcecoes.Entities;
using AulaExcecoes.Exceptions;

namespace AulaExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account(123,"Joao",200.00,300.00);
                account.WithDraw(250.00);
                Console.WriteLine($"New balance: {account.Balance}");
            }
            catch (AccountExceptions e)
            {
                Console.WriteLine($"Exception handled: {e.Message}");       
            }
            
        }
    }
}
