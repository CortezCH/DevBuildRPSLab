using System;

namespace DevBuildRPSLab
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSApp game = new RPSApp();

            do
            {
                game.Play();

                
            } while (game.PlayAgain());
        }
    }
}
