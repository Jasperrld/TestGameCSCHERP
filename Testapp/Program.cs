using Testapp.Characters.Classes;

namespace Testapp;
using Testapp.Characters;
using Testapp.Match;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wat is je naam?");
        string username = Console.ReadLine();

        Console.WriteLine("Welke hero wil je kiezen?");
        Console.WriteLine("1. Katarina");

        string choice = Console.ReadLine()?.ToLower();

        Player player;

        switch (choice)
        {
            case "1":
            case "katarina":
                player = new Katarina(username);
                break;

            default:
                Console.WriteLine("Default Katarina gekozen");
                player = new Katarina(username);
                break;
        }

        Console.WriteLine($"Hero {player.Name} | hp {player.CurrentHealth}");
        
        MatchSystem match = new MatchSystem();
        match.Start(player);
    }
}
