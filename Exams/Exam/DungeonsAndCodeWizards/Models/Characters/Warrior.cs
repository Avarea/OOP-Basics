using System;
using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Interfaces;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction) : base(name, 100, 50, 40, new Satchel(), faction)
        {
            this.Name = name;
            this.Faction = faction;
            this.Health = 100;
            this.Armor = 50;
            this.AbilityPoints = 40;
        }

        public void Attack(Character character)
        {
            if (!IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException(OutputMessages.MustBeAlive);
            }
            if (character == this)
            {
                throw new InvalidOperationException(OutputMessages.SameChar);
            }

            if (character.Faction == this.Faction)
            {
                throw new ArgumentException(string.Format(OutputMessages.SameFaction, this.Faction));
            }
            character.TakeDamage(this.AbilityPoints);

        }



    }
}
