using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildRPSLab
{
    class Rocky : Player
    {

        public Rocky()
        {
            Name = "Rocky";
            RPSValue = GenerateRPS();
        }

        public override RPS GenerateRPS()
        {
            return RPS.Rock;
        }
    }
}
