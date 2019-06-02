using System;
using System.Collections.Generic;

namespace hungryNinja
{

    interface IConsumable
    {
        string Name {get;set;}
        int Calories {get;set;}
        bool IsSpicy {get;set;}
        bool IsSweet {get;set;}
        string GetInfo();
    }

    class Food : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo()
        {
            return $"{Name}: (Food). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }

    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public Drink(string name, int cal)
        {
            Name = name;
            Calories = cal;
            IsSpicy = false;
            IsSweet = true;
        }
        public string GetInfo()
        {
            return $"{Name}: (Drink). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>();
            {
                Menu.Add(new Food("Hamburger", 2000, false, false));
                Menu.Add(new Food("Milkshake", 2500, false, true));
                Menu.Add(new Food("Fried Chicken", 1500, false, false));
                Menu.Add(new Food("Buffalo Wings", 600, true, false));
                Menu.Add(new Food("Rice", 200, false, false));
                Menu.Add(new Food("Club Sandwich", 1200, false, false));
                Menu.Add(new Food("Ice Cream", 1500, false, true));
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0,Menu.Count)];
        }
    }

    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;

        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull {get;}
        public abstract void Consume(IConsumable item);

    }

    class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1500) { return true; }
                else { return false; }
            }
        }
        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                calorieIntake += item.Calories;
                if (item.IsSweet) { calorieIntake += 10; }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
            else
            {
                System.Console.WriteLine("cannot eat any more");
            }
        }
    }
    
    class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200) { return true; }
                else { return false; }
            }
        }
        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                calorieIntake += item.Calories;
                if (item.IsSpicy) { calorieIntake -= 5; }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
            else { System.Console.WriteLine("Cannot eat any more"); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Buffet matsuri = new Buffet();
            SweetTooth bocchi = new SweetTooth();
            SpiceHound satoka = new SpiceHound();
            bocchi.Consume(matsuri.Serve());
            satoka.Consume(matsuri.Serve());
        }
    }
}
