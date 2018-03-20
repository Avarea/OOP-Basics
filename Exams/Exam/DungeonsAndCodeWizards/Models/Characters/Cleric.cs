using System;
using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Interfaces;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction) 
            : base(name, 50, 25, 40, new Backpack(), faction)
        {
            this.Name = name;
            this.Faction = faction;
        }

        public override double RestHealMultiplier  => 0.5;

        public void Heal(Character character)
        {
            if (!IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException(OutputMessages.MustBeAlive);
            }
            if (character.Faction != this.Faction)
            {
                throw new InvalidOperationException(OutputMessages.CantHealOtherFaction);
            }
            character.Health += (uint)this.AbilityPoints;
        }
    }
}
