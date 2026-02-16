using System;

namespace Methods
{
    internal class CharacterModels
    {
        static void Main(string[] args)
        {
            // GlobalTax is automatically initialized when the first instance is created
            Character mage = new Character("Mage", "Arcane Order", "Eldrin", 12, 110);
            Character warrior = new Character("Warrior", "Iron Legion", "Brakus", 18, 130);

            DisplayData(mage);
            DisplayData(warrior);

            mage.CastSpell(mage.Name);
            warrior.CastSpell(warrior.Name);

            Console.WriteLine($"\nMax impact of Eldrin: {mage.GetMaxImpact(mage.Power)}");
            Console.WriteLine($"Max impact of Brakus: {warrior.GetMaxImpact(warrior.Power)}");

            mage.IncreasePower(mage.Power);
            warrior.IncreasePower(warrior.Power);

            Console.WriteLine($"\nEldrin power increased: {mage.Power}");
            Console.WriteLine($"Brakus power increased: {warrior.Power}");

            int currentPower = mage.Power;
            int newPower = mage.IncreasePower(ref currentPower);

            Console.WriteLine($"\nPower after ref method: {currentPower}");
            Console.WriteLine($"Returned value: {newPower}");

            double newImpactMage;
            int updatedPowerMage = mage.IncreasePowerAndImpact(mage.Power, out newImpactMage);

            Console.WriteLine($"\nNew Eldrin power: {updatedPowerMage}");
            Console.WriteLine($"New Eldrin impact: {newImpactMage}");

            double newImpactWarrior;
            int updatedPowerWarrior = warrior.IncreasePowerAndImpact(warrior.Power, out newImpactWarrior);

            Console.WriteLine($"\nNew Brakus power: {updatedPowerWarrior}");
            Console.WriteLine($"New Brakus impact: {newImpactWarrior}");

            // Static value accessed directly from the class
            Console.WriteLine($"\nGlobal tax value (auto initialized): {Character.GlobalTaxValue}%");

            ChooseClass("Eldrin", mage);
            ChooseClass("Brakus", warrior);

            Console.WriteLine($"\nEldrin class: {(Character.Classes)mage.ClassId}");
            Console.WriteLine($"Brakus class: {(Character.Classes)warrior.ClassId}");
        }

        static void DisplayData(Character character)
        {
            Console.WriteLine(
                $"Role: {character.Role}\n" +
                $"Faction: {character.Faction}\n" +
                $"Name: {character.Name}\n" +
                $"Level: {character.Level}\n" +
                $"Power: {character.Power}\n"
            );
        }

        static void ChooseClass(string characterName, Character character)
        {
            Console.WriteLine($"\nChoose the class for {characterName}:");
            Character.ShowClasses();

            int option = Convert.ToInt32(Console.ReadLine());

            if (Enum.IsDefined(typeof(Character.Classes), option))
            {
                character.ClassId = option;
            }
            else
            {
                Console.WriteLine("Invalid class.");
            }
        }
    }

    public partial class Character
    {
        public enum Classes { Novice, Knight, Ranger, Wizard }

        public int ClassId;
        public string? Role;
        public string? Faction;
        public string? Name;
        public int Power;

        private int _level;
        public int Level
        {
            get => _level;
            set
            {
                if (value < 1) _level = 1;
                else if (value > 60) _level = 60;
                else _level = value;
            }
        }

        public static double GlobalTaxValue;

        // Static constructor initializes static fields automatically
        static Character()
        {
            GlobalTaxValue = 4.0;
        }

        public Character() { }

        public Character(string role, string faction, string name, int level, int power)
        {
            Role = role;
            Faction = faction;
            Name = name;
            Level = level;
            Power = power;
        }

        public static void ShowClasses()
        {
            foreach (Classes c in Enum.GetValues(typeof(Classes)))
            {
                Console.WriteLine($"{(int)c} - {c}");
            }
        }

        public void CastSpell(string name)
        {
            Console.WriteLine($"Action performed by {name}!");
        }

        public void IncreasePower(int power)
        {
            Power = power + 3;
        }

        public int IncreasePower(ref int power)
        {
            power += 5;
            return power;
        }

        public int IncreasePowerAndImpact(int power, out double impact)
        {
            int newPower = power + 7;
            impact = newPower * 1.75;
            return newPower;
        }

        public int GetMaxImpact(int power)
        {
            return (int)(power * 1.75);
        }
    }
}
