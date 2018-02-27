using System;

class Program
{
    static void Main()
    {
        try
        {
            string pizzaName = Console.ReadLine()?.Split()[1];
            Pizza pizza = new Pizza(pizzaName);
            CreateDough(pizza);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                CreateTopping(pizza, command);
            }
            Console.WriteLine(pizza);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void CreateDough(Pizza pizza)
    {
        string[] doughInput = Console.ReadLine()?.Split();
        string flourType = doughInput[1];
        string bakingTechnique = doughInput[2];
        double doughWeight = double.Parse(doughInput[3]);
        Dough dough = new Dough(flourType, bakingTechnique, doughWeight);
        pizza.SetDough(dough);
    }

    private static void CreateTopping(Pizza pizza, string command)
    {
        string[] commandInput = command.Split();
        string toppingName = commandInput[1];
        double toppingWeight = double.Parse(commandInput[2]);

        Topping topping = new Topping(toppingName, toppingWeight);
        pizza.AddTopping(topping);
    }
}

