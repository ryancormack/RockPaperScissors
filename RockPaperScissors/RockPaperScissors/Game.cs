using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
    public class Game
    {
        public static void Play(Player playerOne, Player playerTwo)
        {
            List<PlayerChoice> choices = new List<PlayerChoice>();

            foreach (var choice in choices)
            {
                choices.Add(choice);
            }

            Console.WriteLine(playerOne.PlayerName + " please enter your choice" + choices);
            playerOne.PlayerChoice = Console.ReadLine();

            if (playerTwo.IsComputer)
            {
                playerTwo.PlayerChoice = PlayerChoice.Rock.ToString();
                Console.WriteLine(playerTwo.PlayerName + " chose " + playerTwo.PlayerChoice);
            }
            else
            {
                Console.WriteLine(playerTwo.PlayerName + " please enter your choice");   
            }

            var winner = CalculateWinner(playerOne.PlayerChoice, playerTwo.PlayerChoice);
            
            Console.WriteLine(winner);
        }

        private static string CalculateWinner(string playerOneChoice, string playerTwoChoice)
        {
            string winner = "Ryan";
            return winner;
        }
    }
}
