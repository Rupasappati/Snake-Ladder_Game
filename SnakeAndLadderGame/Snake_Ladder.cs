using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class Snake_Ladder
    {
        int StartPosition = 0;
        public const int NOPLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;    
        
        Random Dicenum = new Random();
        public void gamestart()
        {
            int dice=Dicenum.Next(1,7);
            Console.WriteLine( "Player Starts at a Position {0}", StartPosition);

        }
    }
}
