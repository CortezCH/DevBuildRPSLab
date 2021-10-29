using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildRPSLab
{
    class UserPlayer :Player
    {

        public UserPlayer(string incomingName) : base()
        {
            Name = incomingName;
            RPSValue = GenerateRPS();
        }

        public override RPS GenerateRPS()
        {

            string userRPSChoice = RPSApp.GetUserInput("Enter Rock, Paper, or Scissors: ");

            switch (userRPSChoice.ToLower())
            {
                case "rock":
                    RPSValue = RPS.Rock;
                    return RPSValue;

                case "paper":
                    RPSValue = RPS.Paper;
                    return RPSValue;

                case "scissors":
                    RPSValue = RPS.Scissors;
                    return RPSValue;

                default:
                    Console.WriteLine("That answer was invalid.\nPlease only enter Rock, Paper, or Scissors.");
                    return GenerateRPS();
            }
        }
    }
}
