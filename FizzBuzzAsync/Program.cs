using System;
using System.Threading.Tasks;

namespace FizzBuzzAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFizzBuzzAsync();
            Console.Read();
        }

        public static async void RunFizzBuzzAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 50; i++)
                {
                    Console.Write(i + ".");

                    if (i%3 == 0)
                        Console.Write("Fizz");

                    if (i%5 == 0)
                        Console.Write("Buzz");

                    Console.WriteLine();
                }
            });
        }
    }
}
