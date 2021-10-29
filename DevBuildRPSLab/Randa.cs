using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildRPSLab
{
    class Randa : Player
    {

        public Randa()
        {
            Name = "Randa";
            RPSValue = GenerateRPS();
        }

        public override RPS GenerateRPS()
        {
            Random rand = new Random();
            RPSValue = (RPS)rand.Next(0, Enum.GetNames(typeof(RPS)).Length);
            return RPSValue;
        }
    }
}
