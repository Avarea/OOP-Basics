using System;
using DungeonsAndCodeWizards;
using DungeonsAndCodeWizards.Models;

public abstract class Item
{
    protected Item(int weight)
    {
        this.Weight = weight;
    }

    public int Weight { get; protected set; }

    public virtual void AffectCharacter(Character character)
    {
        if (!character.IsAlive)
        {
            throw new InvalidOperationException(OutputMessages.MustBeAlive);
        }
    }

    public override string ToString()
    {
        return GetType().Name;
    }
}

