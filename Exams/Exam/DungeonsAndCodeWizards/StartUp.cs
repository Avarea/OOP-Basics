using System;
using System.Linq;

namespace DungeonsAndCodeWizards
{
	public class StartUp
	{
		// DO NOT rename this file's namespace or class name.
		// However, you ARE allowed to use your own namespaces (or no namespaces at all if you prefer) in other classes.
		public static void Main()
		{
            DungeonMaster dungeonMaster = new DungeonMaster();

		    var input = Console.ReadLine()?.Split();
		    while (!string.IsNullOrEmpty(input[0]))
		    {
		        var command = input[0];
		        var commandArgs = input.Skip(1).ToArray();

		        try
		        {
		            switch (command)
		            {
		                case "JoinParty":
		                    Console.WriteLine(dungeonMaster.JoinParty(commandArgs));
		                    break;
		                case "AddItemToPool":
		                    Console.WriteLine(dungeonMaster.AddItemToPool(commandArgs));
		                    break;
		                case "PickUpItem":
		                    Console.WriteLine(dungeonMaster.PickUpItem(commandArgs));
		                    break;
		                case "UseItem":
		                    Console.WriteLine(dungeonMaster.UseItem(commandArgs));
		                    break;
		                case "UseItemOn":
		                    Console.WriteLine(dungeonMaster.UseItemOn(commandArgs));
		                    break;
		                case "GiveCharacterItem":
		                    Console.WriteLine(dungeonMaster.GiveCharacterItem(commandArgs));
		                    break;
		                case "GetStats":
		                    Console.WriteLine(dungeonMaster.GetStats());
		                    break;
		                case "Attack":
		                    Console.WriteLine(dungeonMaster.Attack(commandArgs));
		                    break;
		                case "Heal":
		                    Console.WriteLine(dungeonMaster.Heal(commandArgs));
		                    break;
		                case "EndTurn":
		                    Console.WriteLine(dungeonMaster.EndTurn());
		                    break;
		                case "IsGameOver":
		                    Console.WriteLine(dungeonMaster.IsGameOver());
		                    break;
		            }
		        }
		        catch (ArgumentException ae)
		        {
		            Console.WriteLine($"Parameter Error: {ae.Message}");
		        }
		        catch (InvalidOperationException ioe)
		        {
		            Console.WriteLine($"Invalid Operation: {ioe.Message}");
		        }
		        input = input = Console.ReadLine()?.Split();
            }
		    Console.WriteLine("Final stats:");
		    Console.WriteLine(dungeonMaster.GetStats());
		}
	}
}