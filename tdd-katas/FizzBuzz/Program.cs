using System;
using FizzBuzz.Library;

namespace FizzBuzz.Cli
{
    static class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzService();
            Console.WriteLine(fizzBuzzService.ToString());
        }
    }
}