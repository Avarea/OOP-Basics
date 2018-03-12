public abstract class Animal : IAnimal
{
    protected Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = 0;
    }

    public string Name { get; protected set; }
    public double Weight { get; protected set; }
    public double FoodEaten { get; protected set; }

    public abstract string ProduceSound();
    public abstract void IncreaseWeight(Food food);

}

