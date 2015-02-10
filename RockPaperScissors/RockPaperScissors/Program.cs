using System;
using System.Security.Policy;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = Players.GetHumanPlayer();
            Console.WriteLine(playerOne.PlayerName + " press 1 to play the computer or 2 to play another human");
            var oppositionChoice = Console.ReadLine();

            if (oppositionChoice == "1")
            {
                Player cpuPlayer = Players.GetComputerPlayer();
                Game.Play(playerOne, cpuPlayer);
                Console.ReadLine();
            }

            if (oppositionChoice == "2")
            {
                Player playerTwo = Players.GetHumanPlayer();
                Game.Play(playerOne, playerTwo);
            }

            else
            {
                Console.WriteLine("Sorry, you did not press 1 or 2");
            }
            Console.ReadLine();

        }
    }
}
