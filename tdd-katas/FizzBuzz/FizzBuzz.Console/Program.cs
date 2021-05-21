using FizzBuzz.Library;

namespace FizzBuzz.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzService();
            System.Console.WriteLine(fizzBuzzService.ToString());
        }
    }
}