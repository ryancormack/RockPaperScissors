using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
    public class Players
    {
        public static Player GetHumanPlayer()
        {
            var humanPlayer = new Player();

            Console.WriteLine("Hello, what is your name?");

            humanPlayer.PlayerName = Console.ReadLine();

            Console.WriteLine("Welcome back " + humanPlayer.PlayerName);

            return humanPlayer;
        }

        public static Player GetComputerPlayer()
        {
            return new Player {PlayerName = "Joe the Destroyer", IsComputer = true};
        }
 
    }
}
