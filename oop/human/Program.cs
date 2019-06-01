using System;

namespace human
{

    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get
            {
                return health;
            }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Dexterity = 3;
            Intelligence = 3;
            health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int setHealth)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = setHealth;
        }

        public int Attack(Human target)
        {
            target.health -= (this.Strength) * 5;
            return target.health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
