using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Person> persons = new Dictionary<string, Person>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = inputArgs[0];
            Person person = null;

            if (persons.ContainsKey(name))
            {
                person = persons[name];
            }
            else
            {
                person = new Person(name);
            }

            switch (inputArgs[1])
            {
                case "company":
                    string companyName = inputArgs[2];
                    string department = inputArgs[3];
                    decimal salary = decimal.Parse(inputArgs[4]);
                    person.AddCompany(new Company(companyName,department,salary));
                    break;
                case "pokemon":
                    string pokemonName = inputArgs[2];
                    string pokemonTypoe = inputArgs[3];
                    person.AddPokemon(new Pokemon(pokemonName, pokemonTypoe));
                    break;
                case "parents":
                    string parentName = inputArgs[2];
                    string birthday = inputArgs[3];
                    person.AddParent(new Parent(parentName, birthday));
                    break;
                case "children":
                    string childName = inputArgs[2];
                    string childBirthday = inputArgs[3];
                    person.AddChildren(new Children(childName,childBirthday));
                    break;
                case "car":
                    string model = inputArgs[2];
                    int speed = int.Parse(inputArgs[3]);
                    person.AddCar(new Car(model, speed));
                    break;
            }

            if (!persons.ContainsKey(person.Name))
            {
                persons.Add(person.Name,new Person());
            }

            persons[person.Name] = person;
        }

        string nameToPrint = Console.ReadLine();
        Console.WriteLine(persons[nameToPrint].ToString());
    }
}

