using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input;
        Dictionary<int, BankAccount> dictionary = new Dictionary<int, BankAccount>();

        while ((input = Console.ReadLine()) != "End")
        {
            var commandSplit = input.Split();
            switch (commandSplit[0])
            {
                case "Create":
                    CreateAccount(commandSplit, dictionary);
                    break;
                case "Deposit":
                    if (ValidateAccount(int.Parse(commandSplit[1]), dictionary))
                    {
                        dictionary[int.Parse(commandSplit[1])].Deposit(int.Parse(commandSplit[2]));
                    }
                    break;
                case "Withdraw":
                    if (ValidateAccount(int.Parse(commandSplit[1]), dictionary))
                    {
                        dictionary[int.Parse(commandSplit[1])].Withdraw(int.Parse(commandSplit[2]));
                    }
                    break;
                case "Print":
                    if (ValidateAccount(int.Parse(commandSplit[1]), dictionary))
                    {
                        Console.WriteLine(dictionary[int.Parse(commandSplit[1])]);
                    }
                    break;
            }
        }
    }

    public static bool ValidateAccount(int id, Dictionary<int, BankAccount> dictionary)
    {
        if (dictionary.ContainsKey(id))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Account does not exist");
            return false;
        }
    }

    public static void CreateAccount(string[] input, Dictionary<int, BankAccount> dictionary)
    {
        if (dictionary.ContainsKey(int.Parse(input[1])))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.Id = int.Parse(input[1]);
            dictionary.Add(acc.Id, acc);
        }
    }
}

