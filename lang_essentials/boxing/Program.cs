using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {

					List<object> newList = new List<object>();
					newList.Add(7);
					newList.Add(28);
					newList.Add(-1);
					newList.Add(true);
					newList.Add("chair");

					int sum = 0;
					foreach (var item in newList)
					{
						System.Console.WriteLine(item);
						if (item is int)
						{
							int itemInt = (int)item;
							sum += itemInt;
						}
					}
					System.Console.WriteLine(sum);
        }
    }
}
