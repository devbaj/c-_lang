using System;

namespace fundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {

					int i = 1;
					while (i <= 255) {
						Console.WriteLine(i);
						i++;
					}

					int j = 1;

					while (j <= 100) {
						if ( j % 5 == 0 && j % 3 == 0 ) {
							Console.WriteLine("FizzBuzz");
						} else if (j % 3 == 0) {
							Console.WriteLine("Fizz");
						} else if (j % 5 == 0) {
							Console.WriteLine("Buzz");
						}
						j++;
					}


        }
    }
}
