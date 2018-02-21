using System.Collections.Generic;
using System.Linq;

public class Trainer
{
    public string Name { get; set; }
    public int NumberOfBadges { get; set; }
    public List<Pokemon> Pokemons { get; set; }

    public Trainer()
    {
        this.NumberOfBadges = 0;
        this.Pokemons = new List<Pokemon>();
    }

    public Trainer(string name, Pokemon pokemons):this()
    {
        this.Name = name;
        this.Pokemons.Add(pokemons);
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.Pokemons.Add(pokemon);
    }

    public void CheckElement(string element)
    {
        int count = Pokemons.Count(e => e.Element == element);
        if (count == 0)
        {
            this.Pokemons.ForEach(p => p.Health -= 10);
            this.Pokemons.RemoveAll(p => p.Health <= 0);
        }
        else
        {
            this.NumberOfBadges += 1;
        }
    }

    public bool Equals(Trainer other)
    {
        return this.Name == other.Name;
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Trainer item))
        {
            return false;
        }

        return this.Equals(item);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

