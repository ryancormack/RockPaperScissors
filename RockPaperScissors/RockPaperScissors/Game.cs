using System;
using System.Collections.Generic;
using System.Globalization;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
    public class Game
    {
        public static void Play(Player playerOne, Player playerTwo)
        {
            Console.Clear();
            Console.WriteLine(playerOne.PlayerName + " you are playing " + playerTwo.PlayerName);
            Console.WriteLine(playerOne.PlayerName + " please enter your choice");
            playerOne.PlayerChoice = Console.ReadLine();
            Console.Clear();

            if (playerTwo.IsComputer)
            {
                playerTwo.PlayerChoice = GetComputerChoice(playerTwo.PlayerChoice);
                Console.Clear();
                Console.WriteLine("The computer has chosen");
            }
            else
            {
                Console.WriteLine(playerTwo.PlayerName + " please enter your choice");
                playerTwo.PlayerChoice = Console.ReadLine();
                Console.Clear();
            }

            var winner = CalculateWinner(playerOne, playerTwo);
            
            Console.WriteLine("And the winner is " + winner);
        }

        private static string GetComputerChoice(string playerChoice)
        {
            var number = new Random();
            var choice = number.Next(0, 10);

            if (choice < 4)
            {
                playerChoice = "Paper";
            }
            else if (choice > 3 && choice < 8)
            {
                playerChoice = "Rock";
            }
            else
            {
                playerChoice = "Scissors";
            }
            return playerChoice;
        }

        private static string CalculateWinner(Player playerOne, Player playerTwo)
        {
            string winner;

            if (playerOne.PlayerChoice == "Rock" && playerTwo.PlayerChoice == "Scissors")
            {
                winner = playerOne.PlayerName;
            }
            else if (playerOne.PlayerChoice == "Paper" && playerTwo.PlayerChoice == "Rock")
            {
                winner = playerOne.PlayerName;
            }
            else if (playerOne.PlayerChoice == "Scissors" && playerTwo.PlayerChoice == "Paper")
            {
                winner = playerOne.PlayerName;
            }
            else
            {
                winner = playerTwo.PlayerName;
            }

            return winner;
        }
    }
}
