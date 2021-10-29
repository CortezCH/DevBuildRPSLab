using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildRPSLab
{
    class RPSApp
    {
        private UserPlayer player;
        private Player opponent;


        public RPSApp()
        {
            Console.WriteLine("Welcome to GC RO SHAM BO!");
            opponent = NewOpponent();
            player = NewPlayer();
        }

        public UserPlayer NewPlayer()
        {
            return new UserPlayer(GetUserInput("Please enter your name: "));
        }

        public Player NewOpponent()
        {
            string opponentChoice = GetUserInput("Which opponent would you like:\n" +
                "[1] Rocky\n" +
                "[2] Randa\n" +
                "Selection: ");

            switch (opponentChoice)
            {
                case "1":
                    return new Rocky();
                case "2":
                    return new Randa();
                default:
                    Console.WriteLine("That input was invalid. Please enter 1 or 2.");
                    return NewOpponent();
            }
        }

        public Player Play()
        {

            if ( player.RPSValue == opponent.RPSValue )
            {
                Console.WriteLine("It was a tie!");
                return null;
            }
            else if ((player.RPSValue == RPS.Rock && opponent.RPSValue == RPS.Scissors)
                || (player.RPSValue == RPS.Paper && opponent.RPSValue == RPS.Rock)
                || (player.RPSValue == RPS.Scissors && opponent.RPSValue == RPS.Paper))
            {
                Console.WriteLine($"Player beat Opponents's {opponent.RPSValue} with {player.RPSValue}");
                Console.WriteLine("Player wins!");
                player.Wins++;
                opponent.Losses++;
                return player;
            }
            else
            {
                Console.WriteLine($"Opponent beat Player's {player.RPSValue} with {opponent.RPSValue}");
                Console.WriteLine("Opponent wins!");
                opponent.Wins++;
                player.Losses++;
                return opponent;
            }


            
        }

        public bool PlayAgain()
        {
            string again = GetUserInput("Would you like to play again? (y/n): ");

            switch (again)
            {
                case "y":
                    player.GenerateRPS();
                    opponent.GenerateRPS();
                    return true;
                case "n":
                    PrintScoreboard();
                    return false;
                default:
                    Console.WriteLine("That input was invalid. Please enter only y or n");
                    return PlayAgain();
            }

        }

        public void PrintScoreboard()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("{0,-10} {1,-6} {2,-8}", "Name", "Wins", "Losses");
            Console.WriteLine("------------------------");
            Console.WriteLine(player);
            Console.WriteLine(opponent);
        
        }


        public void NewGame()
        {
            Console.WriteLine("Welcome to GC RO SHAM BO!");
            opponent = NewOpponent();
            player = NewPlayer();
            GC.Collect();
        }

        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine().Trim();


            return output;
        }
    }


}
