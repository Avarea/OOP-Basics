using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Trainer> trainers = new List<Trainer>();
        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] inputString = input.Split();
            string trainerName = inputString[0];
            string pokemonName = inputString[1];
            string element = inputString[2];
            long health = long.Parse(inputString[3]);

            Pokemon pokemon = new Pokemon(pokemonName, element,health);
            Trainer trainer = new Trainer(trainerName, pokemon);

            if (trainers.Contains(trainer))
            {
                int indexOfTrainer = trainers.FindIndex(t => t.Name == trainerName);
                trainers[indexOfTrainer].AddPokemon(pokemon);
            }
            else
            {
                trainers.Add(trainer);
            }
        }
        string elementInput;
        while ((elementInput = Console.ReadLine().Trim()) != "End")
        {
            trainers.ForEach(t => t.CheckElement(elementInput));
        }

        trainers = trainers.OrderByDescending(t => t.NumberOfBadges).ToList();

        foreach (var trainer in trainers)
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
        }
    }
}

