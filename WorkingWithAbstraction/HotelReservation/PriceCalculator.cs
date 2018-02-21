public class PriceCalculator
{
    public decimal TotalPrice { get; set; }

    public PriceCalculator(decimal totalPrice)
    {
        this.TotalPrice = totalPrice;
    }

    public override string ToString()
    {
        return $"{TotalPrice:F2}";
    }
}

