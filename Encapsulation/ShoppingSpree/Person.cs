using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }
    }

    public List<Product> Products
    {
        get { return products; }
        private set { products = value; }
    }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Products = new List<Product>();

    }

    public string BuyProduct(Product product)
    {
        if (this.Money < product.Cost)
        {
            return $"{this.Name} can't afford {product.Name}";
        }
        this.Money -= product.Cost;
        this.Products.Add(product);
        return $"{this.Name} bought {product.Name}";
    }


    public override string ToString()
    {
        bool isItBought = this.Products.Count > 0;
        string productsOutput;
        if (isItBought)
        {
            productsOutput = string.Join(", ", this.Products);
        }
        else
        {
            productsOutput = "Nothing bought";
        }
        return $"{this.Name} - {productsOutput}";
    }
}

