using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static public int[] RandomArray()
        {
            List<int> randList = new List<int>();
            Random rand = new Random();
            for ( int i = 0; i < 10; i++ ) { randList.Add(rand.Next()); }
            int[] randArray = randList.ToArray();
            int max = randArray[0];
            int min = randArray[0];
            int sum = 0;
            foreach (int j in randArray)
            {
                if ( j > max ) { max = j; }
                else if ( j < min ) { min = j; }
                sum += j;
                System.Console.WriteLine(j);
            }
            double avg = sum/randArray.Length;
            System.Console.WriteLine($"Max: {max}, Min: {min}");
            return randArray;
        }

        static public string TossCoin()
        {
            System.Console.WriteLine("Tossing a Coin");
            Random rand = new Random();
            String result;
            if (rand.Next(0,9) < 5) { result = "Heads"; }
            else { result = "Tails"; }
            System.Console.WriteLine(result);
            return result;
        }

        static public double TossMultipleCoins(int num)
        {
            int headsCount = 0;
            for (int i = 0; i <= num; i++)
            {
                if (TossCoin() == "Heads") { headsCount++; }
            }
            double ratio = headsCount / num;
            return ratio;
        }

        public static List<string> Names()
        {
            List<string> nameList = new List<string>();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");
            Random rand = new Random();
            for (int i = 0; i <= rand.Next(5,25); i++)
            {
                int from = rand.Next(0,4);
                int to = rand.Next(0,4);
                string temp = nameList[to];
                nameList[to] = nameList[from];
                nameList[from] = temp;
            }
            System.Console.WriteLine(nameList);
            foreach (string name in nameList)
            {
                if (name.Length <= 5) { nameList.Remove(name); }
            }
            return nameList;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
