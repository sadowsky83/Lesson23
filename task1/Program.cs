using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Асинхронное программирование
        static void Main(string[] args)
        {
            Console.WriteLine("\nМетод Main начал работать");
            FactorialAsync();
            Console.WriteLine("\nМетод Main закончил работать");
            Console.ReadKey();
        }
        static void Factorial()
        {
            Console.WriteLine("\nМетод Factorial начал работать");
            int number = 5;
            long result = 1;
            for (long i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine($"\n\tФакториал числа {number}!={result}");
            Console.WriteLine("\nМетод Factorial закончил работать");
        }
        static async Task FactorialAsync()
        {
            Console.WriteLine("\nМетод FactorialAsync начал работать");
            await Task.Run(() => Factorial());
            Console.WriteLine("\nМетод FactorialAsync закончил работать");
            Console.ReadKey();
        }
    }
}
