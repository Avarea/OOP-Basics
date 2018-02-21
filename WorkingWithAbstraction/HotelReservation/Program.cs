using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine()?.Split();
        decimal pricePerDay = decimal.Parse(input[0]);
        int numberOfDays = int.Parse(input[1]);
        var season = (int)Enum.Parse<SeasonEnum>(input[2]);

        var tempTotal = pricePerDay * numberOfDays * season;
        if (input.Length == 4)
        {
            var discount = (decimal) Enum.Parse<DiscountEnum>(input[3])/100;
            tempTotal -= tempTotal * discount;
        }
        PriceCalculator calculator = new PriceCalculator(tempTotal);
        Console.WriteLine(calculator);
    }
}

