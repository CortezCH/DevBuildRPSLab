using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildRPSLab
{
    public enum RPS
    {
        Rock,
        Paper,
        Scissors
    }

    abstract class Player
    {
        public string Name { get; set; }
        public RPS RPSValue {get; set;}
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;

        abstract public RPS GenerateRPS();

        public override string ToString()
        {
            return String.Format("{0,-10} {1,-6} {2,-8}", Name, Wins, Losses);
        }

    }
}
