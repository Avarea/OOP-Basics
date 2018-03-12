using System;
using System.Collections.Generic;


class Startup
{
    static void Main()
    {
        var animals = new List<IAnimal>();
        string firstLine;
        while ((firstLine = Console.ReadLine()) != "End")
        {
            var animalParams = firstLine.Split();
            var foodParams = Console.ReadLine()?.Split();

            try
            {
                Animal currentAnimal = ProduceAnimal(animalParams);
                animals.Add(currentAnimal);

                Food currentFood = ProduceFood(foodParams);

                Console.WriteLine(currentAnimal.ProduceSound());
                currentAnimal.IncreaseWeight(currentFood);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }

    public static Animal ProduceAnimal(string[] animalParams)
    {
        Animal animal = null;

        var typeOfAnimal = animalParams[0];
        var animalName = animalParams[1];
        var animalWeight = double.Parse(animalParams[2]);
        double wingSize;
        string livingRegion;
        string breed;

        switch (typeOfAnimal)
        {
            case "Hen":
                wingSize = double.Parse(animalParams[3]);
                animal = new Hen(animalName, animalWeight, wingSize);
                break;
            case "Owl":
                wingSize = double.Parse(animalParams[3]);
                animal = new Owl(animalName, animalWeight, wingSize);
                break;
            case "Dog":
                livingRegion = animalParams[3];
                animal = new Dog(animalName, animalWeight, livingRegion);
                break;
            case "Mouse":
                livingRegion = animalParams[3];
                animal = new Mouse(animalName, animalWeight, livingRegion);
                break;
            case "Cat":
                livingRegion = animalParams[3];
                breed = animalParams[4];
                animal = new Cat(animalName, animalWeight, livingRegion, breed);
                break;
            case "Tiger":
                livingRegion = animalParams[3];
                breed = animalParams[4];
                animal = new Tiger(animalName, animalWeight, livingRegion, breed);
                break;
            default:
                break;
        }
        return animal;
    }

    public static Food ProduceFood(string[] foodParams)
    {
        Food food = null;

        var typeOfFood = foodParams[0];
        var foodQuantity = double.Parse(foodParams[1]);

        switch (typeOfFood)
        {
            case "Vegetable":
                food = new Vegetable(foodQuantity);
                break;
            case "Seeds":
                food = new Seeds(foodQuantity);
                break;
            case "Fruit":
                food = new Fruit(foodQuantity);
                break;
            case "Meat":
                food = new Meat(foodQuantity);
                break;
            default:
                break;
        }
        return food;
    }
}

