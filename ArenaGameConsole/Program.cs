using ArenaGameEngine;

namespace ArenaGameConsole
{
    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight1 = new Knight("Sir John");
            Rogue rogue1 = new Rogue("Slim Shady");
            Mage mage1 = new Mage("Gandalf");
            Barbarian barbarian1 = new Barbarian("Conan");
            Knight knight2 = new Knight("Sir Lancelot");
            Rogue rogue2 = new Rogue("Black Widow");
            Mage mage2 = new Mage("Merlin");
            Barbarian barbarian2 = new Barbarian("Grog");
            // Form teams
            List<Hero> teamA = new List<Hero> { knight1, rogue1, mage1, barbarian1 };
            List<Hero> teamB = new List<Hero> { knight2, rogue2, mage2, barbarian2 };
            Arena arena = new Arena(teamA, teamB);
            arena.EventListener = new ConsoleGameEventListener();
            Console.WriteLine("Battle begins.");
            Hero winner = arena.Battle();
            Console.WriteLine($"Battle ended. Winner is: {winner.Name}");
            Console.ReadLine();
        }
    }
}
