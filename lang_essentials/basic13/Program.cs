using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {

			public static void PrintNumbers()
			{
				for (int i = 0; i <= 255; i++)
				{
					System.Console.WriteLine(i);
				}
			}

			public static void PrintOdds()
			{
				for (int i = 1; i <= 255; i++)
				{
					if (i % 2 != 0)
					{
						System.Console.WriteLine();
					}
				}
			}

			public static void PrintSum()
			{
				int sum = 0;
				for (int i = 0; i <= 255; i++)
				{
					sum += i;
					System.Console.WriteLine("Number: " + i + ", Sum: " + sum);
				}
			}

			public static void LoopArray(int[] numbers)
			{
				foreach (var idx in numbers)
				{
					System.Console.WriteLine(idx);
				}
			}

			public static int FindMax(int[] numbers)
			{
				int max = numbers[0];
				foreach (int idx in numbers)
				{
					if (idx > max) { max = idx; }
				}
				return max;
			}

			public static void GetAverage(int[] numbers)
			{
				int sum = 0;
				foreach (var num in numbers) { sum += num; }
				double average = sum/numbers.Length;
				System.Console.WriteLine(average);
			}

			public static int[] OddArray()
			{
				List<int> numList = new List<int>();
				for (var i = 1; i <= 255; i++) 
				{
					if (i % 2 != 0) { numList.Add(i); }
				}
				return numList.ToArray();
			}

			public static int GreaterThanY(int[] numbers, int y)
			{
				int count = 0;
				foreach (int num in numbers)
				{
					if (num < y) { count++; }
				}
				return count;
			}

			public static void SquareArrayValues(int[] numbers)
			{
				int i  = 0;
				while ( i < numbers.Length )
				{
					numbers[i] = numbers[i] * numbers[i];
				}
			}

			public static void ElimnateNegatives(int[] numbers)
			{
				for ( int i = 0; i < numbers.Length; i++ )
				{
					if ( numbers[i] < 0 ) { numbers[i] = 0; }
				}
			}

			public static void MinMaxAverage(int[] numbers)
			{
				int max = numbers[0];
				int min = numbers[0];
				int sum = 0;
				foreach (int num in numbers)
				{
					if ( num < min ) { min = num; }
					else if ( num > max ) { max = num; }
					sum += num;
				}
				int avg = sum/numbers.Length;
				System.Console.WriteLine($"Max: {max}, Min: {min}, Average: {avg}");
			}

			public static void ShiftValues(int[] numbers)
			{
				for ( int i = numbers.Length - 1; i > 0; i-- )
				{
					int temp = numbers[i];
					if ( i == numbers.Length - 1 ) { numbers[i] = 0; }
					numbers[i-1] = numbers[i];
				}
			}

			public static object[] NumToString(int[] numbers)
			{
				List<object> newList = new List<object>;
				foreach (var num in numbers) {
					if ( num < 0)
					{
						newList.Add("Dojo");
					}
					else
					{
						newList.Add(num)
					}
				}
				return newList.ToArray();
			}

        static void Main(string[] args)
        {

        }
    }
}
