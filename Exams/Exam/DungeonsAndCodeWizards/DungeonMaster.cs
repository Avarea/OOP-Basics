using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonsAndCodeWizards.Factories;
using DungeonsAndCodeWizards.Models;

namespace DungeonsAndCodeWizards
{
    public class DungeonMaster
    {
        private CharacterFactory characterFactory;
        private ItemFactory itemFactory;
        private List<Character> party;
        private List<Item> items;
        private int lastSurvivorRounds = 0;

        public DungeonMaster()
        {
            this.party = new List<Character>();
            this.items = new List<Item>();
            characterFactory = new CharacterFactory();
            itemFactory = new ItemFactory();
        }

        public string JoinParty(string[] args)
        {
            string faction = args[0];
            string characterType = args[1];
            string name = args[2];

            Character character = characterFactory.CreateCharacter(name, characterType, faction);
            party.Add(character);
            return $"{args[2]} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemType = args[0];

            Item item = itemFactory.CreateItem(itemType);
            items.Add(item);
            return $"{args[0]} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];
            var itemName = items[items.Count - 1];
            bool characterExist = party.Any(e => e.Name == characterName);
            Character character = party.FirstOrDefault(e => e.Name == characterName);
            if (items.Count == 0)
            {
                throw new InvalidOperationException(OutputMessages.NoItemsInThePool);
            }
            if (!characterExist)
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, characterName));
            }
            character.ReceiveItem(itemName);


            return $"{characterName} picked up {itemName}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];
            bool characterExist = party.Any(e => e.Name == characterName);
            if (!characterExist)
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound), characterName);
            }
            Character character = party.FirstOrDefault(e => e.Name == characterName);
            Item item = character.Bag.GetItem(itemName);
            character.UseItem(item);
            return $"{characterName} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            Character giver = party.FirstOrDefault(e => e.Name == giverName);
            Character receiver = party.FirstOrDefault(e => e.Name == receiverName);
            Item item = giver.Bag.Items.FirstOrDefault(i => i.GetType().Name == itemName);
            if (!party.Contains(giver))
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, giverName));
            }
            if (!party.Contains(receiver))
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, receiverName));
            }
            if (item == null)
            {
                throw new ArgumentException(string.Format(OutputMessages.ItemNotExisting, itemName));
            }
            giver.UseItemOn(item, receiver);
            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            Character giver = party.FirstOrDefault(e => e.Name == giverName);
            Character receiver = party.FirstOrDefault(e => e.Name == receiverName);
            Item item = giver.Bag.Items.FirstOrDefault(i => i.GetType().Name == itemName);
            if (!party.Contains(giver))
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, giverName));
            }
            if (!party.Contains(receiver))
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, receiverName));
            }
            if (item == null)
            {
                throw new ArgumentException(string.Format(OutputMessages.ItemNotExisting, itemName));
            }

            giver.GiveCharacterItem(item, receiver);
            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var character in party.OrderByDescending(a => a.IsAlive).ThenByDescending(h => h.Health))
            {
                bool isAlive = character.IsAlive;
                string status = string.Empty;
                if (isAlive)
                    status = "Alive";
                else
                    status = "Dead";
                sb.AppendLine(
                    $"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {status}");
            }
            return sb.ToString();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string defendantName = args[1];
            Character attacker = party.FirstOrDefault(e => e.Name == attackerName);
            Character defendant = party.FirstOrDefault(e => e.Name == defendantName);
            if (!party.Contains(attacker))
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, attackerName));
            }
            if (!party.Contains(defendant))
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, defendantName));
            }
            if (attacker.GetType().Name == "Cleric")
            {
                throw new ArgumentException(string.Format(OutputMessages.SameChar, attackerName));
            }

            defendant.TakeDamage(attacker.AbilityPoints);
            if (defendant.Health <= 0)
            {
                defendant.IsAlive = false;
                return $"{attackerName} attacks {defendantName} for {attacker.AbilityPoints} hit points!" +
                       $"{defendantName} has {defendant.Health}/{defendant.BaseHealth} HP and" +
                       $"{defendant.Armor}/{defendant.BaseArmor} AP left!" + Environment.NewLine +
                       $"{defendant.Name} is dead!";
            }
            return $"{attackerName} attacks {defendantName} for {attacker.AbilityPoints} hit points!" +
                   $"{defendantName} has {defendant.Health}/{defendant.BaseHealth} HP and" +
                   $"{defendant.Armor}/{defendant.BaseArmor} AP left!";
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string receiverName = args[1];
            Character healer = party.FirstOrDefault(e => e.Name == healerName);
            Character receiver = party.FirstOrDefault(e => e.Name == receiverName);
            if (!party.Contains(healer))
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, healerName));
            }
            if (!party.Contains(receiver))
            {
                throw new ArgumentException(string.Format(OutputMessages.CharacterNotFound, receiverName));
            }
            if (healer.GetType().Name != "Cleric")
            {
                throw new ArgumentException(string.Format(OutputMessages.CannotHeal, healerName));
            }
            if (healerName == receiverName)
            {
                throw new ArgumentException(string.Format(OutputMessages.CannotHeal, healerName));
            }

            return
                $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
        }

        public string EndTurn()
        {
            var aliveMembers = party.Where(c => c.IsAlive).ToList();
            if (aliveMembers.Count <= 1)
            {
                lastSurvivorRounds++;
            }
            foreach (var partyMember in aliveMembers)
            {
                var currentHealth = partyMember.Health;
                partyMember.Rest();
                return $"{partyMember.Name} rests ({currentHealth} => {partyMember.Health})";
            }
            return null;
        }

        public bool IsGameOver()
        {
            throw new NotImplementedException();
        }
    }
}
