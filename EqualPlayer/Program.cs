using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    public class Program
    {
        private static readonly IEnumerable<Player> setOfPlayers;

        private static void Main(string[] args)
        {
            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"Player Name: {p.Name}, Player Class: {p.PClass}");
            }
        }
    }
}
