using System;

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount
        {
            Id = 1,
            Balance = 15
        };

        Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
    }
}

