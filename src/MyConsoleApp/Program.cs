using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greetings.Hello("World"));
        }
    }
    public static class Greetings 
    {
        public static string Hello(string name)
        {
            return $"Hello {name}!";
        }
    }
}
