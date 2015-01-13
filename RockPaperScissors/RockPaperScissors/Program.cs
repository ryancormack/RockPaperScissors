using System;
using System.Security.Policy;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = Players.GetPlayerOne();
            Console.WriteLine(playerOne.PlayerName + " would you like to play another person or the computer?");
            var oppositionChoice = Console.ReadLine();

            if (oppositionChoice == "1")
            {
                Player cpuPlayer = Players.GetComputerPlayer();
                Console.WriteLine("You're playing " + cpuPlayer.PlayerName);
                Console.WriteLine("Lets start");

                Game.Play(playerOne, cpuPlayer);
                

                Console.ReadLine();
            }

            
        }
    }
}
