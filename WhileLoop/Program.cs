using System;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a command: ");
            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
            Console.WriteLine(command);
            Console.Write("Enter a command:");                
            }
        }
    }
}
