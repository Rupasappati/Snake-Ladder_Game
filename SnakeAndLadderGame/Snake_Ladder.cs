using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class Snake_Ladder
    {
        
        public const int NOPLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        int PlayerOptions;
        
        Random Dicenum = new Random();
        public void gamestart()
        {
            int StartPosition = 0;
            int Dice = 0;
            int dice=Dicenum.Next(1, 7);
            Console.WriteLine( "Player Starts at a Position {0}", StartPosition);
            Console.WriteLine(dice);

            int Options=Dicenum.Next(1, 4);
            Console.WriteLine("Number present on Dice {0}", Options);
            switch (PlayerOptions)
            {
                case LADDER:

                    StartPosition += Dice;
                    Console.WriteLine("current position of a player is {0}", StartPosition);
                    break;

                case SNAKE:

                    StartPosition -= Dice;
                    Console.WriteLine("current position of a player is {0}", StartPosition);
                    break;
                                    
            }
            Console.WriteLine(StartPosition);


        }

    }
}
