using System;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models
{
    public class Character
    {
        private string name;
        private uint health;
        private uint armor;

        public Character(string name, uint health, uint armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.RestHealMultiplier = 0.2;
            this.IsAlive = true;
        }

        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(OutputMessages.InvalidName);
                }
                name = value;
            }
        }

        public uint Health
        {
            get => health;
            set
            {
                if (value <= 0)
                {
                    this.IsAlive = false;
                }
                health = value;
            }
        }

        public uint Armor
        {
            get { return armor; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                armor = value;
                if (value > BaseArmor)
                {
                    armor = (uint)BaseArmor;
                }
            }
        }

        public virtual double RestHealMultiplier { get; set; }
        public Bag Bag { get; set; }
        public double AbilityPoints { get; set; }
        public bool IsAlive { get; set; }
        public double BaseHealth { get; set; }
        public double BaseArmor { get; set; }
        public Faction Faction { get; set; }

        public void TakeDamage(double hitPoints)
        {

            if (!this.IsAlive)
            {
                throw new InvalidOperationException(OutputMessages.MustBeAlive);
            }
            var diff = Math.Abs(this.Armor - hitPoints);
            this.Armor -= (uint)hitPoints;

            this.Health -= (uint) diff;


            if (this.Health <= 0)
            {
                this.IsAlive = false;
            }
        }

        public void Rest()
        {
            if (!IsAlive)
            {
                throw new InvalidOperationException(OutputMessages.MustBeAlive);
            }
            this.Health += (uint)this.BaseHealth * (uint)this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            if (!IsAlive)
            {
                throw new InvalidOperationException(OutputMessages.MustBeAlive);
            }
            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException(OutputMessages.MustBeAlive);
            }
            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            if (!IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException(OutputMessages.MustBeAlive);
            }
            this.Bag.Items.Remove(item);
            character.Bag.Items.Add(item);
        }

        public void ReceiveItem(Item item)
        {
            if (!IsAlive)
            {
                throw new InvalidOperationException(OutputMessages.MustBeAlive);
            }
            this.Bag.Items.Add(item);
        }
    }
}
