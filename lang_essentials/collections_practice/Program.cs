using System;
using System.Collections.Generic;

namespace collections_practice
{
		class Program
		{
				static void Main(string[] args)
				{
					
					// Three Basic Arrays
					int[] array1 = { 0,1,2,3,4,5,6,7,8,9 };
					string[] array2 = {"Tim", "Martin", "Nikki", "Sara"};
					bool[] array3 = {true, false, true, false, true, false, true, false, true, false};

					// List of Flavors
					List<string> flavors = new List<string>();
					flavors.Add("vanilla bean");
					flavors.Add("french vanilla");
					flavors.Add("rocky road");
					flavors.Add("salted caramel");
					flavors.Add("cookie dough");
					Console.WriteLine(flavors.Count);
					Console.WriteLine(flavors[2]);
					flavors.RemoveAt(2);
					Console.WriteLine(flavors.Count);

					// User Info Dictionary
					Dictionary<string,string> users = new Dictionary<string,string>();
					Random r = new Random();
					for (int i = 0; i < array2.Length; i++)
					{
					users.Add(array2[i], flavors[r.Next(0,3)]);
					}
					foreach (var user in users)
					{
						Console.WriteLine(user.Key + " " + user.Value);
					}
				}
		}
}
