using System;
using MyFirstEfCoreProject.Model;

namespace MyFirstEfCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Commands.WipeCreateSeed(true) ? "Created database and seeded it" : "Database exists");
            Commands.ListAll();
            Console.ReadLine();
        }
    }
}
