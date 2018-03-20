using System;
using DungeonsAndCodeWizards.Models;
using DungeonsAndCodeWizards.Models.Characters;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string name, string characterType, string faction)
        {
            Faction factionn = (Faction)Enum.Parse(typeof(Faction), faction);
            Character character = null;
            switch (characterType)
            {
                case "Warrior":
                    return character = new Warrior(name, factionn);
                case "Cleric":
                    return character = new Cleric(name, factionn);
                default:
                    throw new ArgumentException(string.Format(OutputMessages.InvalidCharacterType), characterType);
            }
        }
    }
}
