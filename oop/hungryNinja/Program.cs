using System;
using System.Collections.Generic;

namespace hungryNinja
{

    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
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

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    System.Console.WriteLine("Can't eat anymore!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Eat(Food item)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            string entry = $"Ate {item.Name}";
            if (item.IsSpicy && item.IsSweet) { entry += "; it is sweet and spicy!"; }
            else if (item.IsSpicy) { entry += "; it is spicy!"; }
            else if (item.IsSweet) { entry += "; it is sweet!"; }
            else { entry += "."; }
            System.Console.WriteLine(entry);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Buffet tucanos = new Buffet();
            Ninja satoka = new Ninja();
            while (!satoka.IsFull)
            {
                satoka.Eat(tucanos.Serve());
            }
        }
    }
}
