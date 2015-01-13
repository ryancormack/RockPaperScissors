using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
    public class Players
    {
        public static Player GetPlayerOne()
        {
            var playerOne = new Player();

            Console.WriteLine("Hello, what is your name?");

            playerOne.PlayerName = Console.ReadLine();

            Console.WriteLine("Welcome back " + playerOne.PlayerName);

            return playerOne;
        }

        public static Player GetComputerPlayer()
        {
            return new Player {PlayerName = "Joe the Destroyer", IsComputer = true};
        }
 
    }
}
